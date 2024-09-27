using System;
using System.IO;
using System.Reflection.PortableExecutable;
using DevSecOps.Utilities.Infra.Model.DefectDojo;
using DevSecOps.Utilities.Infra;
using Newtonsoft.Json;
using DevSecOps.Utilities.Infra.Service;
using Microsoft.AspNetCore.Http;
using System.Diagnostics;
using System.Text;
using DevSecOps.Utilities.Infra.Services.DefectDojo;
using DevSecOps.Utilities.Infra.Util;
using DevSecOps.Utilities.Infra.Model.Trufflehog;


namespace DevSecOps.Utilities.Infra.Services.Trufflehog
{


    public class TrufflehogService
    {
        string GitUrl { get; set; }
        string GitUser { get; set; }
        string GitPass { get; set; }

        public TrufflehogService(string gitUrl, string gitUser, string gitPass)
        {
            this.GitUrl = gitUrl;
            this.GitUser = gitUser;
            this.GitPass = gitPass;
        }

        public string ExecuteScan(TestModel test)
        {
            Thread.Sleep(1000 * 10); // Await 10 segundos de intervalo entre as execucoes dos processos.

            Process process = new Process();
            process.StartInfo.FileName = "trufflehog";
            string argument = $"git https://{this.GitUser}:{this.GitPass}@{this.GitUrl.Replace("https://", "")} --json";
            
            process.StartInfo.Arguments = argument;

            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.CreateNoWindow = true;

            int timeout = 1000 * 60 * 5;

            StringBuilder output = new StringBuilder();
            StringBuilder error = new StringBuilder();

            using (AutoResetEvent outputWaitHandle = new AutoResetEvent(false))
            using (AutoResetEvent errorWaitHandle = new AutoResetEvent(false))
            {
                process.OutputDataReceived += (sender, e) =>
                {
                    if (e.Data == null)
                        try
                        {
                            outputWaitHandle.Set();
                        }
                        catch (Exception) { }
                    else
                    {
                        output.AppendLine(e.Data);
                        //Console.WriteLine(e.Data.ToString());
                        var jsonTh = e.Data.ToString();
                        var th = JsonConvert.DeserializeObject<TrufflehogResponseModel>(jsonTh);

                        //Send to DefectDojo
                        DefectDojoService defectDojoService = new DefectDojoService(UtilEnviroment.DefectDojoUrl(), UtilEnviroment.DefectDojoToken());

                        string uniqueId = jsonTh.CreateMD5();
                        var existsFinding = defectDojoService.SearchFindingByExternalId(uniqueId);

                        if(existsFinding.Count == 0)
                        {    
                            DDCreateFindingRequestModel finding = new DDCreateFindingRequestModel();
                            finding.Title = $"Informação sensivel em código fonte - {th.SourceMetadata.Data.Git.Commit}";
                            finding.UniqueIdFromTool = uniqueId;
                            finding.VulnIdFromTool = uniqueId;
                            finding.Severity = "Critical";
                            List<int?> foundBy = new List<int?>();
                            foundBy.Add(1);
                            finding.FoundBy = foundBy;
                            finding.Active = true;

                            StringBuilder description = new StringBuilder();
                            StringBuilder mitigation = new StringBuilder();
                            
                            finding.Cwe = 540; // https://cwe.mitre.org/data/definitions/540.html - Inclusion of Sensitive Information in Source Code
                            description.AppendLine("Informação sensivel em código fonte");
                            description.AppendLine($"CommitId: {th.SourceMetadata.Data.Git.Commit}");
                            description.AppendLine($"Arquivo: {th.SourceMetadata.Data.Git.File}");
                            description.AppendLine($"Linha: {th.SourceMetadata.Data.Git.Line}");
                            description.AppendLine($"Usuário: {th.SourceMetadata.Data.Git.Email}");
                            description.AppendLine($"Repositório: {th.SourceMetadata.Data.Git.Repository}");
                            description.AppendLine($"Data Commit: {th.SourceMetadata.Data.Git.Timestamp}");
                            finding.Description = description.ToString();

                            mitigation.AppendLine("Remover o conteúdo do código.");
                            mitigation.AppendLine("=====================");
                            mitigation.AppendLine("Adicionar o conteudo sensivel via parametro (Variavel de ambiente, parametro, configuração, secret, etc)");
                            mitigation.AppendLine("=====================");
                            mitigation.AppendLine("Remover histórico do Git para não deixar o conteudo exposto via histórico.");
                            mitigation.AppendLine("=====================");
                            mitigation.AppendLine("Revogar o conteudo sensivel (senha ou segredo) e não reutiliza-lo.");
                            mitigation.AppendLine("=====================");

                            if(th.ExtraData != null)
                            {
                                mitigation.AppendLine(th.ExtraData.RotationGuide);
                                mitigation.AppendLine("====================="); 
                                finding.Mitigation = mitigation.ToString();
                            }
                            finding.FilePath = th.SourceMetadata.Data.Git.File;
                            finding.Line = th.SourceMetadata.Data.Git.Line;
                            finding.ComponentName = th.SourceMetadata.Data.Git.Repository;
                            finding.PublishDate = DateTime.Now.ToString("yyyy-MM-dd");
                            finding.Test = test.Id;
                            finding.Verified = th.Verified;

                            var response = defectDojoService.CreateFinding(finding);
                        }
                    }
                };
                process.ErrorDataReceived += (sender, e) =>
                {
                    if (e.Data == null)
                        try
                        {
                            errorWaitHandle.Set();
                        }
                        catch (Exception) { }
                    else
                    {
                        error.AppendLine(e.Data);
                        Console.WriteLine(e.Data.ToString());
                    }
                };

                process.Start();
                process.BeginOutputReadLine();
                process.BeginErrorReadLine();

                if (process.WaitForExit(timeout) && outputWaitHandle.WaitOne(timeout) && errorWaitHandle.WaitOne(timeout))
                {
                    return output.ToString();

                }
                else
                {
                    throw new Exception("Program time out");
                }
            }

            

        }

    }
}
using System;
using System.Text;

namespace DevSecOps.Utilities.Infra.Util
{
    public static class UtilEnviroment
    {
        public static string DefectDojoUrl()
        {
            return Environment.GetEnvironmentVariable("DefectDojoUrl");
        }

        public static string DefectDojoToken()
        {
            return Environment.GetEnvironmentVariable("DefectDojoToken");
        }

        public static string DependencyTrackUrl()
        {
            return Environment.GetEnvironmentVariable("DependencyTrackUrl");
        }

        public static string DependencyTrackToken()
        {
            return Environment.GetEnvironmentVariable("DependencyTrackToken");
        }

        public static string AzDevOpsUrl()
        {
            return Environment.GetEnvironmentVariable("AzDevOpsUrl");
        }

        public static string AzDevOpsToken()
        {
            return Environment.GetEnvironmentVariable("AzDevOpsToken");
        }

        public static string GitUser()
        {
            return Environment.GetEnvironmentVariable("GitUser");
        }

        public static string GitPass()
        {
            return Environment.GetEnvironmentVariable("GitPass");
        }

        public static string AzDevOpsStartGitUrl()
        {
            return Environment.GetEnvironmentVariable("AzDevOpsStartGitUrl");
        }

        public static string SbomUrl()
        {
            return Environment.GetEnvironmentVariable("SbomUrl");
        }
        public static string CompanyName()
        {
            return Environment.GetEnvironmentVariable("CompanyName");
        }

        public static string JIRAUrl()
        {
            return Environment.GetEnvironmentVariable("JIRAUrl");
        }

        public static string JIRAUser()
        {
            return Environment.GetEnvironmentVariable("JIRAUser");
        }

        public static string JIRAToken()
        {
            return Environment.GetEnvironmentVariable("JIRAToken");
        }

        public static string JIRAResolveStatus()
        {
            return Environment.GetEnvironmentVariable("JIRAResolveStatus");
        }

        public static string JIRAParentEpicKey()
        {
            return Environment.GetEnvironmentVariable("JIRAParentEpicKey");
        }

        public static string JIRAProjectKey()
        {
            return Environment.GetEnvironmentVariable("JIRAProjectKey");
        }
    }
}


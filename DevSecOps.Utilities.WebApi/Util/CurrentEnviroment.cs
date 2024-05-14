using System;
using System.Text;

namespace DevSecOps.Utilities.WebApi.Util
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

    }
}


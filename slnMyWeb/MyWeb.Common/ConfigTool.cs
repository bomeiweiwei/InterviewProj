using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWeb.Common
{
    public class ConfigTool
    {
        public static string GetDBConnectionString(string ConnName)
        {
            return System.Configuration.ConfigurationManager.ConnectionStrings[ConnName].ConnectionString.ToString();
        }

        public static string GetAppsetting(string Key)
        {
            string AppSetting = System.Configuration.ConfigurationManager.AppSettings[Key];
            return AppSetting;
        }
    }
}

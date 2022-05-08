using System.Configuration;

namespace ColoredPlugins.Data
{
    public class AppConnection
    {
        public static string ConnectionString => ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
    }
}

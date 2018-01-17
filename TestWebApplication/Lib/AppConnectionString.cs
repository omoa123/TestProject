using System.Configuration;

namespace TestConsoleApp
{
    public class AppConnectionString
    {
        /// <summary>
        /// B2C ConnectionString
        /// </summary>
        internal static string B2C => ConfigurationManager.ConnectionStrings["eService_B2C"].ToString();

    }
}

using Microsoft.Extensions.Configuration;

namespace Sdk_Tests
{
    internal class SettingsLoader
    {

    }
    internal class Settings
    {
        public string RECORDED_ENDPOINTS_FOLDER_PATH { get; set; } = string.Empty;
        public string APS_CLIENT_ID { get; set; } = string.Empty;
        public string APS_CLIENT_SECRET { get; set; } = string.Empty;
        public string HUB_NAME { get; set; } = string.Empty;
        public string PROJECT_NAME { get; set; } = string.Empty;
        public string PROJECT_ID { get; set; } = string.Empty;
        public string FOLDER_ID { get; set; } = string.Empty;
        public string FILE_URN { get; set; } = string.Empty;
        public string SAMPLE_FILE_PATH { get; set; } = string.Empty;
        public string REFRESH_TOKEN_FILE { get; set; } = string.Empty;
        public string THREE_LEGGED_APS_CLIENT_ID { get; set; } = string.Empty;
        public string THREE_LEGGED__APS_CLIENT_SECRET { get; set; } = string.Empty;

        private static IConfiguration? Configuration { get; set; }
        public static Settings Load()
        {

            if (Configuration is not null)
            {
                return Configuration.Get<Settings>() ?? new Settings();
            }

            var builder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            Configuration = builder.Build();

            return Configuration.Get<Settings>() ?? new Settings();
        }

    }


}

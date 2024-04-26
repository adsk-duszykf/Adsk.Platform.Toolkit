using Sdk_Tests;
using WireMock.Handlers;
using WireMock.RequestBuilders;
using WireMock.ResponseBuilders;
using WireMock.Server;
using WireMock.Settings;

namespace Tests
{
    internal class APSmockServer : IDisposable
    {
        private static readonly Settings config = Settings.Load();
        private static WireMockServer? _server;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="proxyUrl">URL used by HttpClient in replacement of APS host</param>
        /// <returns></returns>
        public static WireMockServer StartMockServer(string proxyUrl)
        {

            if (_server is not null)
            {
                return _server;
            }

            var recordingPath = config.RECORDED_ENDPOINTS_FOLDER_PATH;
            if (string.IsNullOrEmpty(recordingPath))
            {
                throw new ArgumentNullException($"'{nameof(recordingPath)}' is undefined in the config file");
            }

            if (Path.Exists(recordingPath) == false)
            {
                throw new DirectoryNotFoundException($"'{recordingPath}' not found");
            }


            _server = WireMockServer.Start(new WireMockServerSettings
            {

                //ReadStaticMappings = true,
                Urls = [proxyUrl],
                StartAdminInterface = true,
                FileSystemHandler = new LocalFileSystemHandler(recordingPath),

            });

            _server.Given(Request.Create().WithPath("*"))
                .RespondWith(Response.Create().WithProxy(new ProxyAndRecordSettings
                {
                    Url = "https://developer.api.autodesk.com",
                    SaveMapping = true,
                    SaveMappingToFile = true,
                    ExcludedHeaders = ["Authorization"],

                }));

            return _server;
        }

        public void Dispose()
        {
            _server?.Stop();
            _server?.Dispose();
        }
    }
}

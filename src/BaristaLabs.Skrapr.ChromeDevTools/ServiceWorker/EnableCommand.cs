namespace BaristaLabs.Skrapr.ChromeDevTools.ServiceWorker
{
    using Newtonsoft.Json;

    /// <summary>
    /// 
    /// </summary>
    public sealed class EnableCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "ServiceWorker.enable";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

    }

    public sealed class EnableCommandResponse : ICommandResponse<EnableCommand>
    {
    }
}
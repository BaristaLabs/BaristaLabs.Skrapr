namespace BaristaLabs.Skrapr.ChromeDevTools.ServiceWorker
{
    /// <summary>
    /// ServiceWorker error message.
    /// </summary>
    public sealed class ServiceWorkerErrorMessage
    {
    
        /// <summary>
        /// 
        ///</summary>
        public string ErrorMessage
        {
            get;
            set;
        }
    
        /// <summary>
        /// 
        ///</summary>
        public string RegistrationId
        {
            get;
            set;
        }
    
        /// <summary>
        /// 
        ///</summary>
        public string VersionId
        {
            get;
            set;
        }
    
        /// <summary>
        /// 
        ///</summary>
        public string SourceURL
        {
            get;
            set;
        }
    
        /// <summary>
        /// 
        ///</summary>
        public long LineNumber
        {
            get;
            set;
        }
    
        /// <summary>
        /// 
        ///</summary>
        public long ColumnNumber
        {
            get;
            set;
        }
    
    }
}
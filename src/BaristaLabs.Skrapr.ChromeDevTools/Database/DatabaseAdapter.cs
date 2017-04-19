namespace BaristaLabs.Skrapr.ChromeDevTools.Database
{
    using System;
    using System.Threading.Tasks;

    /// <summary>
    /// Represents an adapter for the Database domain to simplify the command interface.
    /// </summary>
    public class DatabaseAdapter
    {
        private readonly ChromeSession m_session;
        
        public DatabaseAdapter(ChromeSession session)
        {
            m_session = session ?? throw new ArgumentNullException(nameof(session));
        }

        /// <summary>
        /// Gets the ChromeSession associated with the adapter.
        /// </summary>
        public ChromeSession Session
        {
            get { return m_session; }
        }

    
        /// <summary>
        /// Enables database tracking, database events will now be delivered to the client.
        /// </summary>
        public async Task<EnableCommandResponse> Enable(EnableCommand command, int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<EnableCommand, EnableCommandResponse>(command, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    
        /// <summary>
        /// Disables database tracking, prevents database events from being sent to the client.
        /// </summary>
        public async Task<DisableCommandResponse> Disable(DisableCommand command, int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<DisableCommand, DisableCommandResponse>(command, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    
        /// <summary>
        /// 
        /// </summary>
        public async Task<GetDatabaseTableNamesCommandResponse> GetDatabaseTableNames(GetDatabaseTableNamesCommand command, int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<GetDatabaseTableNamesCommand, GetDatabaseTableNamesCommandResponse>(command, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    
        /// <summary>
        /// 
        /// </summary>
        public async Task<ExecuteSQLCommandResponse> ExecuteSQL(ExecuteSQLCommand command, int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<ExecuteSQLCommand, ExecuteSQLCommandResponse>(command, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
    

    
        /// <summary>
        /// 
        /// </summary>
        public void SubscribeToAddDatabaseEvent(Action<AddDatabaseEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
    
    }
}
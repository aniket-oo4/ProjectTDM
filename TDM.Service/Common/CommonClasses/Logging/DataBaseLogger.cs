using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDM.Data.DataManagers.CustomDataManagers;


namespace TDM.Service.Common.CommonClasses.Logging

{
    public class DatabaseLogger : ILogger
    {
        private readonly LogDataManager _logRepository;

        public DatabaseLogger(LogDataManager logRepository)
        {
            _logRepository = logRepository;
        }

        public void UpdateInfoLog(string message)
        {
            throw new NotImplementedException();
        }

        public void UpdateWarningLog(string message)
        {
            throw new NotImplementedException();
        }

        public void UpdateErrorLog(string message, Exception exception = null)
        {
            //_logRepository./*SaveLog*/("Error", message, exception?.ToString());
            throw new NotImplementedException();
        }
    }

}

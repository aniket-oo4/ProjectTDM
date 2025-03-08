using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDM.Service.Common.CommonClasses.Logging
{
    public interface ILogger
    {
        void UpdateInfoLog(string message);
        void UpdateWarningLog(string message);
        void UpdateErrorLog(string message, Exception exception = null);
    }

}

using System;
using System.Collections.Generic;
using System.Text;
using NLog;

namespace SharedLibrary.Common
{
    public class ApplicationBase
    {
        protected Logger Log { get; private set; }

        protected ApplicationBase(Type declaringType)
        {
            Log = LogManager.GetLogger(declaringType.FullName);
        }

    }
}

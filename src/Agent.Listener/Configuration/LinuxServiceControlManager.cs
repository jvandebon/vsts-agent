using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Microsoft.VisualStudio.Services.Agent.Configuration
{
    public class LinuxServiceControlManager : ServiceControlManager
    {
        public override Task ConfigureServiceAsync(AgentSettings settings, Dictionary<string, string> args, bool enforceSupplied)
        {
            throw new NotImplementedException();
        }
    }
}
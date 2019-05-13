using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panacea.Core
{
    public interface IServerSettingsProvider
    {
        Uri HospitalServerUri { get; }

        List<string> HospitalServers { get; }

        Uri Crutch { get; }

        ITerminalType TerminalType { get; }
    }

    public interface ITerminalType
    {
        string Pairs { get; }
    }
}

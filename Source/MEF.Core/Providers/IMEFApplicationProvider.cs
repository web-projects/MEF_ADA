using System;
using System.Collections.Generic;
using System.Text;

namespace MEF.Core.Providers
{
    public interface IMEFApplicationProvider
    {
        IMEFApplication GetMEFApplication();
    }
}

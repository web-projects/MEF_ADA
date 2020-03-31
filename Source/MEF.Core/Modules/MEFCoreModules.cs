using MEF.Core.Providers;
using System;
using System.Collections.Generic;
using System.Text;
using Ninject.Modules;

namespace MEF.Core.Modules
{
    public class MEFCoreModules : NinjectModule
    {
        public override void Load()
        {
            Bind<IMEFApplicationProvider>().To<MEFApplicationProvider>();

        }
    }
}

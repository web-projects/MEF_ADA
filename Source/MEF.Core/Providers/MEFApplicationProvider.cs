using Ninject;
using System;
using System.Collections.Generic;
using System.Text;

namespace MEF.Core.Providers
{
    public class MEFApplicationProvider : IMEFApplicationProvider
    {
        IMEFApplication IMEFApplicationProvider.GetMEFApplication()
        {
            MEFApplication application = new MEFApplication();

            using (IKernel kernel = new MEFKernelResolver().ResolveKernel())
            {
                kernel.Inject(application);
            }

            return application;
        }
    }
}

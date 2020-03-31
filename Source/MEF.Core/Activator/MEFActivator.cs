using MEF.Core.Providers;
using Ninject;
using System;
using System.Collections.Generic;
using System.Text;

namespace MEF.Core.Activator
{
    public class MEFActivator
    {
        [Inject]
        internal IMEFApplicationProvider MEFApplicationProvider { get; set; }

        public MEFActivator()
        {
            using (IKernel kernel = new MEFKernelResolver().ResolveKernel())
            {
                kernel.Inject(this);
            }
        }

        public IMEFApplication Start(string featurePath)
        {
            if (string.IsNullOrWhiteSpace(featurePath))
            {
                throw new ArgumentException(nameof(featurePath));
            }

            IMEFApplication application = MEFApplicationProvider.GetMEFApplication();
            application.Initialize(featurePath);
            return application;
        }
    }
}

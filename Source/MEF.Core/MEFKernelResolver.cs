using MEF.Core.Modules;
using Ninject;
using Ninject.Modules;
using System.Collections.Generic;

namespace MEF.Core
{
    public class MEFKernelResolver : IKernelModuleResolver
    {
        private const int NumberOfKnownModules = 2;

        public IKernel ResolveKernel(params NinjectModule[] modules)
        {
            List<NinjectModule> moduleList;

            if (modules != null && modules.Length > 0)
            {
                moduleList = new List<NinjectModule>(NumberOfKnownModules + modules.Length);
                moduleList.AddRange(modules);
            }
            else
            {
                moduleList = new List<NinjectModule>(NumberOfKnownModules);
            }

            moduleList.Add(new MEFCoreModules());
            //moduleList.Add(new MEFSdkModule());

            IKernel kernel = new StandardKernel(moduleList.ToArray());
            kernel.Settings.InjectNonPublic = true;
            kernel.Settings.InjectParentPrivateProperties = true;
            return kernel;
        }
    }
}

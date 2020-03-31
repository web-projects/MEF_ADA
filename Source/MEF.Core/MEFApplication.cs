using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MEF.Core
{
    internal class MEFApplication : IMEFApplication
    {
        private string featurePath;

        public void Initialize(string featurePath) => (this.featurePath) = featurePath;

        public Task Run()
        {
            return Task.CompletedTask;
        }

        public void Shutdown()
        {

        }
    }
}

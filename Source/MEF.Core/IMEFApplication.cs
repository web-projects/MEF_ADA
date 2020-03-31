using System;
using System.Threading.Tasks;

namespace MEF.Core
{
    public interface IMEFApplication
    {
        void Initialize(string featurePath);
        Task Run();
        void Shutdown();
    }
}

using Ninject;
using System;
using Xunit;

namespace MEF.Core.Tests
{
    public class MEFApplicationTests : IDisposable
    {
        readonly MEFApplication subject;
        readonly MEFStateMachineAsyncManager asyncManager;

        const string someFakePath = @"C:\fakefeaturepath";

        public MEFApplicationTests()
        {
            subject = new MEFApplication();

            using (IKernel kernel = new MEFKernelResolver().ResolveKernel())
            {
                kernel.Inject(subject);
            }

            asyncManager = new MEFStateMachineAsyncManager();
        }

        public void Dispose() => asyncManager.Dispose();

        [Fact]
        public void Initialize_ShouldSetFeaturePath_When_Called()
        {
            subject.Initialize(someFakePath);

            string pluginPath = TestHelper.Helper.GetFieldValueFromInstance<string>("featurePath", false, false, subject);

            Assert.Equal(someFakePath, pluginPath);
        }
    }
}

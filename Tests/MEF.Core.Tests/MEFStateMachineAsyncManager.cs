using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MEF.Core.Tests
{
    class MEFStateMachineAsyncManager
    {
        readonly ManualResetEvent resetEvent;

        public MEFStateMachineAsyncManager()
            => resetEvent = new ManualResetEvent(false);

        //public MEFStateMachineAsyncManager(ref Mock<IMEFStateController> mockController, IMEFStateAction stateAction)
        //    : this()
        //{
        //    mockController.Setup(e => e.Complete(stateAction)).Callback(() => resetEvent.Set());
        //    mockController.Setup(e => e.Error(stateAction)).Callback(() => resetEvent.Set());
        //}

        public void Trigger() => resetEvent.Set();

        public bool WaitFor(int timeout = 2000) => resetEvent.WaitOne(timeout);

        public void Dispose() => resetEvent.Dispose();
    }
}

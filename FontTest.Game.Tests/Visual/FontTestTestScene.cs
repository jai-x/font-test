using osu.Framework.Testing;

namespace FontTest.Game.Tests.Visual
{
    public class FontTestTestScene : TestScene
    {
        protected override ITestSceneTestRunner CreateRunner() => new FontTestTestSceneTestRunner();

        private class FontTestTestSceneTestRunner : FontTestGameBase, ITestSceneTestRunner
        {
            private TestSceneTestRunner.TestRunner runner;

            protected override void LoadAsyncComplete()
            {
                base.LoadAsyncComplete();
                Add(runner = new TestSceneTestRunner.TestRunner());
            }

            public void RunTestBlocking(TestScene test) => runner.RunTestBlocking(test);
        }
    }
}

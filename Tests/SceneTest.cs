using Data;
using Logic;

namespace Tests
{
    [TestClass]
    public class SceneTest
    {
        [TestMethod]
        public void GetterTest()
        {
            IData apiData = new DataApi();
            ILogic apiLogic = new LogicApi(apiData);               

            double sceneXDim = 100;
            double sceneYDim = 300;
            int orbCount = 20;
            int orbRad = 10;

            apiLogic.Init(sceneYDim, sceneXDim, orbCount, orbRad);   

            Assert.AreEqual(sceneYDim, apiData.SceneYDimension);
            Assert.AreEqual(sceneXDim, apiData.SceneXDimension);
        }

        [TestMethod]
        public void SceneOrbCountTest()
        {
            IData apiData = new DataApi();
            ILogic apiLogic = new LogicApi(apiData);

            double sceneXDim = 100;
            double sceneYDim = 300;
            int orbCount = 20;
            int orbRad = 10;

            apiLogic.Init(sceneYDim, sceneXDim, orbCount, orbRad);

            Assert.AreEqual(orbCount, apiData.GetOrbs().Count);
        }

        [TestMethod]
        public void EnableTest()
        {
            IData apiData = new DataApi();
            ILogic apiLogic = new LogicApi(apiData);

            Assert.IsFalse(apiData.IsEnabled);

            apiLogic.Enable();

            Assert.IsTrue(apiData.IsEnabled);

            apiLogic.Disable();

            Assert.IsFalse(apiData.IsEnabled);
        }
    }
}

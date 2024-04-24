using Data;

namespace Tests
{
    [TestClass]
    public class DataOrbListTest
    {
        [TestMethod]
        public void AddOrbTest()
        {
            IData dataApi = new DataApi();    

            Assert.AreEqual(0, dataApi.GetOrbs().Count);

            double rad = 20;
            double posX = 5;
            double posY = 10;
            double velX = 2;
            double velY = 3;

            dataApi.AddOrb(rad, posX, posY, velX, velY, 0);

            Assert.AreEqual(1, dataApi.GetOrbs().Count);

            dataApi.ClearOrbs();

            Assert.AreEqual(0, dataApi.GetOrbs().Count);
        }
    }
}

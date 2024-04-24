using Data;

namespace Tests
{
    [TestClass]
    public class DataOrbTest
    {
        [TestMethod]
        public void GetterTest()
        {
            double rad = 20;
            double posX = 5;
            double posY = 10;
            double velX = 2;
            double velY = 3;

            Orb orb = new(rad, posX, posY, velX, velY, 0, 0);

            Assert.AreEqual(rad, orb.Radius);
            Assert.AreEqual(posX, orb.PositionX);
            Assert.AreEqual(posY, orb.PositionY);
            Assert.AreEqual(velX, orb.VelocityX);
            Assert.AreEqual(velY, orb.VelocityY);
        }

        [TestMethod]
        public void SetterTest()
        {
            double rad = 20;
            double posX = 5;
            double posY = 10;
            double velX = 2;
            double velY = 3;

            Orb orb = new(rad, posX, posY, velX, velY, 0, 0);

            orb.PositionX = 15;
            orb.PositionY = 25;

            orb.VelocityX = 5;
            orb.VelocityY = 4;

            Assert.AreEqual(15, orb.PositionX);
            Assert.AreEqual(25, orb.PositionY);

            Assert.AreEqual(5, orb.VelocityX);
            Assert.AreEqual(4, orb.VelocityY);
        }
    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace bowlingApp.Test
{
    [TestClass]
    public class GameTest
    {

        /// <summary>
        /// 1st Round
        /// </summary>

        private Game g;

        [TestInitialize]
        public void Init()
        {
            g = new Game();
        }


        [TestCleanup]
        public void TestCleanUp()
        {
            g = null;
        }

        [TestMethod]
        public void TestGame()
        {
        }

        [TestMethod]
        public void TestRoll()
        {
            g.Roll(0);
        }


        [TestMethod]
        public void TestScore()
        {

            for (int i = 0; i < 20; i++)
            {
                g.Roll(1);
            }

            Assert.AreEqual(20, g.Score(20));
        }


        [TestMethod]
        public void TestSpare()
        {
            g.Roll(4);
            g.Roll(6); // 4 + 6 = 12 due to spare
            g.Roll(2);
            for (int i = 0; i < 17; i++)
            {
                g.Roll(0);
            }

            //Assert.AreEqual(14, g.Score());
        }

    }
}

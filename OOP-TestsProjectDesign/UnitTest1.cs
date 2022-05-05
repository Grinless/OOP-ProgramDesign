using NUnit.Framework;
using Game.Systems;

namespace OOP_TestsProjectDesign
{
    public class TESTSTimer
    {
        Timer timer; 

        [SetUp]
        public void Setup()
        {
            timer = new Timer(300); 
        }

        [Test]
        public void Test1()
        {
            timer.StartTimer();
            while(timer.TimerComplete == false)
            {
                
            }

            Assert.IsTrue(timer.Time <= 0);
        }
    }
}
using ConsoleForGit;

namespace ConsoleForGitTest
{
    public class Tests
    {
        SuperMath _math;
        [SetUp]
        public void Setup()
        {
            _math = new SuperMath();
        }

        [Test]
        public void Sum()
        {
            List<int> list = new List<int>() { 1, 2, 3 };
            int sum = _math.Sum(list);
            Assert.IsTrue(sum == list.Sum());
        }

        [Test]
        public void AddStr()
        {
            int addResult = _math.Add("2", "5");
            Assert.That(addResult, Is.EqualTo(7));
        }

        [Test]
        public void AddStrWithEmptyParamsThrowException()
        {
            Assert.Throws<ArgumentNullException>(delegate { 
                int addResult = _math.Add("", ""); 
            });
        }

        [Test]
        public void AddStrWithNotANumberThrowException()
        {
            Assert.Throws<ArgumentException>(delegate {
                int addResult = _math.Add("NotANumber", "");
            });
        }

    }
}
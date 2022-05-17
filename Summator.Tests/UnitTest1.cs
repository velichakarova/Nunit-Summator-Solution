namespace Summator.Tests
{
    public class Tests
    {
        [Test]
      public void Test_SumTwoPossitiveNumbers()
        {
            int result = Summator.Sum(new int[] { 5, 7 });

            Assert.That(result == 12);
        }
        [Test]
        public void Test_SumOnePossitiveNumbers()
        {
            int result = Summator.Sum(new int[] { 5 });

            Assert.That(result == 5);
        }
        [Test]
        public void Test_SumTwoNegativePossitiveNumbers()
        {
            int expect = Summator.Sum(new int[] { -5,-7 });
            int actual = -12;

             Assert.That(expect == actual);
        }
        [Test]
        public void Test_EmpetyArr()
        {
            int expect = Summator.Sum(new int[] {  });
            int actual = 0;

            Assert.That(expect == actual);
        }
        [Test]
        public void Test_BigValues()
        {
            int expected = Summator.Sum(new int[] { 2000000000, 2000000000 , 2000000000, });

            Assert.That(expected, Is.EqualTo(6000000000)); 
        }
        [Test]
        public void Test_Average()
        {
            int expected = Summator.Average(new int[] { 3,3,3 });
            int actual = 3;
            Assert.That(expected==actual);
        }
    }
}
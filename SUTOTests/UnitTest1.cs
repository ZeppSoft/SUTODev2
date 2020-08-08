using Moq;
using NUnit.Framework;
using SUTODev2;

namespace SUTOTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [TestFixture]
        public class BankAccountTest
        {
            [Test]
            public void DepositIntegrationTest()
            {
                var log = new Mock<ILog>().Object;
                var ba = new BankAccount(log) { Balance = 100 };
                ba.Deposit(100);

               Assert.That(ba.Balance,Is.EqualTo(200));

            }
        }
    }
}
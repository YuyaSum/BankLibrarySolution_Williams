using BankLibrary;

namespace BankLibraryTests
{
    [TestClass]
    public class UnitTest1
    {
        //Withdraw Function
        [TestMethod]
        public void WithdrawFiveHundredSuccess()
        {
            Bank b = new Bank("Bob", 500);
            double result = b.Withdraw(626);
            Assert.AreEqual(0, result);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void WithdrawLessThanZeroFail()
        {
            Bank b = new Bank("Bob", 0);
            double result = b.Withdraw(0);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => result);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void WithdrawGreaterThanBalanceFail() {
            Bank b = new Bank("Bob", 1);
            double result = b.Withdraw(2);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => result);
        }
        [TestMethod]
        public void WithdrawReturnBalanceSuccess() {
            Bank b = new Bank("Bob", 500);
            double result = b.Withdraw(24);
            Assert.AreEqual(476, result);
        }

        //Deposit Method
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void DepositLessThanZeroFail() 
        {
            Bank b = new Bank("Bob", 50);
            double result = b.Deposit(-1);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => result);
        }
        [TestMethod]
        public void DepositAddBalance()
        {
            Bank b = new Bank("Bob", 50);
            double result = b.Deposit(800);
            Assert.AreEqual(850, result);
        }

        //Create Bank Method - 2 Variables
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void BankGreaterBalanceFail() 
        {
            Bank b = new Bank("Bob", 10001);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => b);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void BankZeroBalanceFail()
        {
            Bank b = new Bank("Bob", 0);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => b);
        }

        //Customer
        [TestMethod]
        public void CustomerSuccess() 
        {
            Bank b = new Bank("Bob", 1);
            Assert.AreEqual("Bob", b.Customer);
        }
        [TestMethod]
        public void CustomerFail()
        {
            Bank b = new Bank();
            Assert.AreEqual(null, b.Customer);
        }

        //Balance
        [TestMethod]
        public void BalanceSuccess()
        {
            Bank b = new Bank("Bob", 1);
            Assert.AreEqual(1, b.Balance);
        }
        [TestMethod]
        public void BalanceFail()
        {
            Bank b = new Bank();
            Assert.AreEqual(0, b.Balance);
        }
    }
}
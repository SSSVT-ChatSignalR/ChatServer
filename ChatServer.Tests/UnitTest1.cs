using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChatServer.Tests
{
    [TestClass]
    public class UnitTest1
    {
        private UserRepository _usrRepository = new UserRepository();
        [TestMethod]
        public void TestRegister()
        {
            //Hubs.RegisterHub.AddUser("testNick", "123456", "testName", "testSurname", 99, "test@test.cz");
        }
    }
}

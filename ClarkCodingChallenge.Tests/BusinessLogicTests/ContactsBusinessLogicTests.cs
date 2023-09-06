using ClarkCodingChallenge.BusinessLogic;
using ClarkCodingChallenge.DataAccess;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace ClarkCodingChallenge.Tests.BusinessLogicTests
{
    [TestClass]
    public class ContactsBusinessLogicTests
    {
        private ContactsService contactsService;
        private ContactsDataAccess contactsDataAccess;

        [TestMethod]
        public void TestMethod1()
        {
            Setup();
            string lastName = "a";

            var result = contactsService.GetContactInformation(lastName, false);

            Assert.IsNotNull(result);
            Assert.IsNotNull(result.Where(x => x.LastName == lastName));
        }

        private void Setup()
        {
            contactsDataAccess = new ContactsDataAccess();
            contactsService = new ContactsService(contactsDataAccess);
        }
    }
}

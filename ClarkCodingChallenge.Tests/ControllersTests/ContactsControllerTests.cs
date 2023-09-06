using ClarkCodingChallenge.BusinessLogic;
using ClarkCodingChallenge.Controllers;
using ClarkCodingChallenge.DataAccess;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace ClarkCodingChallenge.Tests.ControllerTest
{
    [TestClass]
    public class ContactsControllerTests
    {
        private ContactsController contactsController;
        private ContactsService contactsService;
        private ContactsDataAccess contactsDataAccess;

        [TestMethod]
        public void ContactsControllerGetEntriesReturnRow()
        {
            Setup();
            string lastName = "Maddyson";

            var result = contactsController.GetContactInformation(lastName);

            Assert.IsNotNull(result);
            Assert.IsNotNull(result.Where(x => x.LastName == lastName));
        }

        private void Setup()
        {
            contactsDataAccess = new ContactsDataAccess();
            contactsService = new ContactsService(contactsDataAccess);
            contactsController = new ContactsController(contactsService);
        }
    }
}

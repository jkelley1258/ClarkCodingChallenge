using ClarkCodingChallenge.DataAccess;
using ClarkCodingChallenge.Models;
using System.Collections.Generic;
using System.Linq;

namespace ClarkCodingChallenge.BusinessLogic
{
    public class ContactsService : IContactsService
    {
        //TODO: Place business logic for contact here
        private readonly IContactsDataAccess contactsDataAccess;

        public ContactsService(IContactsDataAccess contactsDataAccess)
        {
            this.contactsDataAccess = contactsDataAccess;
        }

        public IList<ContactInformationModel> GetContactInformation(string lastName, bool descFlag)
        {
            IList<ContactInformationEntity> entityList = contactsDataAccess.GetContactInformation(lastName, descFlag);

            //add something like automapper here
            IList<ContactInformationModel> modelList = new List<ContactInformationModel>();
            
            foreach(ContactInformationEntity entity in entityList)
            {
                ContactInformationModel model = new ContactInformationModel(entity);
                modelList.Add(model);
            }

            return modelList;
        }

        public void SubmitContactInformation(ContactInformationModel contactInformationModel)
        {
            ContactInformationEntity entity = new ContactInformationEntity(contactInformationModel);
            contactsDataAccess.SubmitContactInformation(entity);
        }
    }
}

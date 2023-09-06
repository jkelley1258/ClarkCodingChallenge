using ClarkCodingChallenge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClarkCodingChallenge.BusinessLogic
{
    public interface IContactsService
    {
        IList<ContactInformationModel> GetContactInformation(string lastName, bool descFlag);

        void SubmitContactInformation(ContactInformationModel contactInformationEntity);
    }
}

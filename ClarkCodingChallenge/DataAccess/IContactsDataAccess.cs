using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClarkCodingChallenge.DataAccess
{
    public interface IContactsDataAccess
    {
        void SubmitContactInformation(ContactInformationEntity contactInformationEntity);

        IList<ContactInformationEntity> GetContactInformation(string lastName, bool descFlag);
    }
}

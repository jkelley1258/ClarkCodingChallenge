using ClarkCodingChallenge.Models;

namespace ClarkCodingChallenge.DataAccess
{
    public class ContactInformationEntity
    {
        public int id { get; set; }

        public string first_name { get; set; }

        public string last_name { get; set; }

        public string email { get; set; }

        public ContactInformationEntity(ContactInformationModel model)
        {
            first_name = model.FirstName;
            last_name = model.LastName;
            email = model.Email;
        }

        public ContactInformationEntity() { }
    }
}

using ClarkCodingChallenge.DataAccess;

namespace ClarkCodingChallenge.Models
{
    public class ContactInformationModel
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public ContactInformationModel(ContactInformationEntity entity)
        {
            FirstName = entity.first_name;
            LastName = entity.last_name;
            Email = entity.email;
        }

        public ContactInformationModel() { }
    }
}

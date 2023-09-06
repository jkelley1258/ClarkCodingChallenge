using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ClarkCodingChallenge.DataAccess
{
    public class ContactsDataAccess : IContactsDataAccess
    {
        private readonly string filePath = Path.Combine(Directory.GetCurrentDirectory(), "TestData.json");

        //TODO: Place data access code here
        public IList<ContactInformationEntity> GetContactInformation(string lastName, bool descFlag)
        {
            string jsonText = File.ReadAllText(filePath);
            IList<ContactInformationEntity> contactInformation = JsonSerializer.Deserialize<IList<ContactInformationEntity>>(jsonText);

            // should use strategy pattern here, but database sproc would handle this
            if (string.IsNullOrWhiteSpace(lastName))
            {
                return descFlag ? contactInformation.OrderByDescending(x => x.last_name).ThenByDescending(x => x.first_name).ToList() 
                    : contactInformation.OrderBy(x => x.last_name).ThenBy(x => x.first_name).ToList();
            }
            else
            {
                return descFlag ? contactInformation.Where(x => x.last_name == lastName).OrderByDescending(x => x.last_name).ThenByDescending(x => x.first_name).ToList()
                    : contactInformation.Where(x => x.last_name == lastName).OrderBy(x => x.last_name).ThenBy(x => x.first_name).ToList();
            }
        }

        public void SubmitContactInformation(ContactInformationEntity contactInformationEntity)
        {
            IList<ContactInformationEntity> contactInfo = GetContactInformation(string.Empty, false);
            contactInformationEntity.id = contactInfo.OrderByDescending(x => x.id).FirstOrDefault().id + 1;
            contactInfo.Add(contactInformationEntity);
            string jsonText = JsonSerializer.Serialize(contactInfo);
            File.WriteAllText(filePath, jsonText);
        }
    }
}

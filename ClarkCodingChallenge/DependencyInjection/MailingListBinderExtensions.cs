using ClarkCodingChallenge.BusinessLogic;
using ClarkCodingChallenge.DataAccess;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClarkCodingChallenge.DependencyInjection
{
    public static class MailingListBinderExtensions
    {
        public static void SetupMailingListDI(this IServiceCollection services)
        {
            services.AddTransient<IContactsDataAccess, ContactsDataAccess>();
            services.AddTransient<IContactsService, ContactsService>();
        }
    }
}

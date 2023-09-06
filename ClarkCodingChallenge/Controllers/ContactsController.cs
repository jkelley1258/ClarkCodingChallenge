using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ClarkCodingChallenge.Models;
using System.Net.Http;
using System.Net;
using System.Collections.Generic;
using ClarkCodingChallenge.BusinessLogic;
using System;

namespace ClarkCodingChallenge.Controllers
{
    public class ContactsController : Controller
    {
        private readonly IContactsService contactsService;

        public ContactsController(IContactsService contactsService)
        {
            this.contactsService = contactsService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public IActionResult SubmitContactInformation(ContactInformationModel contactInformation)
        {
            try
            {
                contactsService.SubmitContactInformation(contactInformation);
                return new OkObjectResult(contactInformation);
            }
            catch (Exception ex)
            {
                return new BadRequestObjectResult(ex);
            }
        }

        [HttpGet]
        public IList<ContactInformationModel> GetContactInformation(string lastName = null, bool descFlag = false)
        {
            return contactsService.GetContactInformation(lastName, descFlag);
        }
    }
}

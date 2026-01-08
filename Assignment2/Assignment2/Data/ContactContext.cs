using System;
using System.Collections.Generic;
using System.Linq;

using System.Web;
using Assignment2.Models;
using System.Data.Entity;


namespace Assignment2.Data
{

    namespace YourProjectName.DAL
    {
        public class ContactContext : DbContext
        {
            public ContactContext() : base("name=ContactDB")
            {
            }

            public DbSet<Contact> Contacts { get; set; }
        }
    }

}
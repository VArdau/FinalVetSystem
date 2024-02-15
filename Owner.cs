using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalVetSystem
{
    internal class Owner
    {
        protected string ownerID;
        protected string ownerFirstName;
        protected string ownerLastName;
        protected string ownerPhone;
        protected string ownerEmail;


        public Owner(string ownerID, string ownerFirstName, string ownerLastName, string ownerPhone, string ownerEmail)
        {
            this.ownerID = ownerID;
            this.ownerFirstName = ownerFirstName;
            this.ownerLastName = ownerLastName;
            this.ownerPhone = ownerPhone;
            this.ownerEmail = ownerEmail;
        }

        public string OwnerID
        {
            get { return ownerID; }
            set { ownerID = value; }
        }

        public string OwnerFirstName
        {
            get { return ownerFirstName; }
            set { ownerFirstName = value; }
        }

        public string OwnerLastName
        {
            get { return ownerLastName; }
            set { ownerLastName = value; }
        }

        public string OwnerPhone
        {
            get { return ownerPhone; }
            set { ownerPhone = value; }
        }

        public string OwnerEmail
        {
            get { return ownerEmail; }
            set { ownerEmail = value; }
        }
    }
}

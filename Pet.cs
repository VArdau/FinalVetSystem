using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalVetSystem
{
    internal class Pet : Owner
    {
        private string petID;
        private string petName;
        private string petType;
        private string petBreed;
        private string petDOB;
        private string petKg;
        private string petAddress;

        public Pet(string ownerID, string petID, string petName, string petType, string petBreed, string petDOB, 
            string petKg, string petAddress) : base(ownerID, "", "", "", "") 
        {
            OwnerID = ownerID;
            this.petID = petID;
            this.petName = petName;
            this.petType = petType;
            this.petBreed = petBreed;
            this.petDOB = petDOB;
            this.petKg = petKg;
            this.petAddress = petAddress;
        }

        public string PetID
        {
            get { return petID; }
            set { petID = value; }
        }

        public string PetName
        {
            get { return petName; }
            set { petName = value; }
        }

        public string PetType
        {
            get { return petType; }
            set { petType = value; }
        }

        public string PetBreed
        {
            get { return petBreed; }
            set { petBreed = value; }
        }

        public string PetDOB
        {
            get { return petDOB; }
            set { petDOB = value; }
        }

        public string Petkg
        {
            get { return petKg; }
            set { petKg = value; }
        }

        public string PetAddress
        {
            get { return petAddress; }
            set { petAddress = value; }
        }


    }
}

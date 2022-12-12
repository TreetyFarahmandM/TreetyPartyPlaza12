using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyPlaza
{
    internal class MySupplier : MyEntity
    {
        private string businessName, contactSurname, contactForename, email;
        public MySupplier() : base()
        {
            this.businessName = ""; this.contactSurname = ""; this.contactForename = "";
        }
        public MySupplier(int idNo, string title, string businessName, string contactSurname, string contactForename, string street, string town, string county, string postcode, string telNo)
            : base(idNo, street, town, county, postcode, telNo)
        {
            this.businessName = businessName; this.contactSurname = contactSurname; this.contactForename = contactForename;
        }

        public string BusinessName
        {
            get
            {
                return businessName;
            }
            set
            {
                if (MyValidation.validLength(value, 2, 30) && MyValidation.validLetterNumberWhitespace(value))
                {
                    businessName = MyValidation.firstLetterEachWordToUppper(value);
                }
                else
                    throw new MyException("Business Name must be 2 - 30 letters");
            }
        }
        public string ContactSurname
        {
            get
            {
                return contactSurname;
            }
            set
            {
                if (MyValidation.validLength(value, 2, 15) && MyValidation.validSurname(value))
                {
                    contactSurname = MyValidation.firstLetterEachWordToUppper(value);
                }
                else
                    throw new MyException("Surname must be 2 - 15 letters");
            }
        }
        public string ContactForename
        {
            get
            {
                return contactForename;
            }
            set
            {
                if (MyValidation.validLength(value, 2, 15) && MyValidation.validForename(value))
                {
                    contactForename = MyValidation.firstLetterEachWordToUppper(value);
                }
                else
                    throw new MyException("Forename must be 2 - 15 letters");
            }
        }
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                if (MyValidation.validLength(value, 2, 55) && MyValidation.validEmail(value))
                {
                    email = value;
                }
                else
                    throw new MyException("It must be a valid email.");
            }
        }
    }
}

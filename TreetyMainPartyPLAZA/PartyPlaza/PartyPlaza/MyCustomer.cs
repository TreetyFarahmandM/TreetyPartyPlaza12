using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyPlaza
{
    internal class MyCustomer : MyEntity
    {
        private string  surname, forename, email;
        public MyCustomer() : base()
        {
            this.surname = ""; this.forename = ""; this.email = "";
        }

        public MyCustomer(int idNum,  string surname, string forename,
            string street, string town, string county, string postcode, string telNum, string email) :
            base(idNum, street, town, county, postcode, telNum)
        {
            
            this.surname = surname;
            this.forename = forename;
            this.email = email;
        }

       
        public string Surname
        {
            get { return surname; }
            set
            {
                if (MyValidation.validLength(value, 2, 20) && MyValidation.validLetterNumberWhitespace(value))
                {
                    surname = MyValidation.firstLetterEachWordToUppper(value);
                }
                else
                    throw new MyException("Surname must be 2 to 20 letters");
            }
        }
        public string Forename
        {
            get { return forename; }
            set
            {
                if (MyValidation.validLength(value, 2, 20) && MyValidation.validLetterNumberWhitespace(value))
                {
                    forename = MyValidation.firstLetterEachWordToUppper(value);
                }
                else
                    throw new MyException("Forename must be 2 to 20 letters");
            }
        }
        public string Email
        {
            get { return email; }
            set {
                if (MyValidation.validLength(value, 12, 55) && MyValidation.validEmail(value))
                {
                    email = value;
                }
                else
                    throw new MyException("Email must be 7 to 55 letters");
            }
        }
    }
}

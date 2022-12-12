using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyPlaza
{
    internal class MyEntity
    {
        private int idNum;
        private string street, town, county, postcode, telNum;

        public MyEntity()
        {
            this.street = "";
            this.town = "";
            this.county = "";
            this.postcode = "";
            this.telNum = "";
        }
        public MyEntity(int idNum, string street, string town, string county, string postcode, string telNum)
        {
            this.idNum = idNum;
            this.street = street;
            this.town = town;
            this.county = county;
            this.postcode = postcode;
            this.telNum = telNum;
        }

        public int IDNum
        {
            get { return idNum; }
            set { idNum = value; }
        }
        public string Street
        {
            get { return street; }
            set
            {
                if (MyValidation.validLength(value, 5, 40) && MyValidation.validLetterNumberWhitespace(value))
                {
                    street = MyValidation.firstLetterEachWordToUppper(value);
                }
                else
                    throw new MyException("Street must be 5-40 letters");
            }
        }
        public string Town
        {
            get { return town; }
            set
            {
                if (MyValidation.validLength(value, 2, 20) && MyValidation.validLetterNumberWhitespace(value))
                {
                    town = MyValidation.firstLetterEachWordToUppper(value);
                }
                else
                    throw new MyException("Town must be 2 to 20 letters");
            }
        }
        public string County
        {
            get { return county; }
            set
            {
                if (MyValidation.validLength(value, 2, 20) && MyValidation.validLetterNumberWhitespace(value))
                {
                    county = MyValidation.firstLetterEachWordToUppper(value);
                }
                else
                    throw new MyException("County must be 2 to 20 letters");
            }
        }
        public string Postcode
        {
            get { return postcode; }
            set
            {
                if (MyValidation.validLength(value, 7, 8) && MyValidation.validLetterNumberWhitespace(value))
                {
                    postcode = value;
                }
                else
                    throw new MyException("Postcode must be 7 or 8 letters, also only alphabetic characters");
            }
        }
        public string TelNum
        {
            get { return telNum; }
            set
            {
                if (MyValidation.validTelLength(value, 11) && MyValidation.validNumber(value))
                {
                    telNum = value;
                }
                else
                    throw new MyException("Telephone Number must be 11 Numbers");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoolLib
{
    public class Club
    {
        private int clubRegistrationNumber;
        public static int NumberOfClub = 0;
        private string name;
        public List<Registrant> RegistrantList = new List<Registrant>();
        public List<Coach> CoachList = new List<Coach>();
        private Address clubAddress;
        private static Address defaultAddress = new Address();
        private long phoneNumber;

        public Club() : this(null, defaultAddress, 0)
        {

        }
        public Club(string name) : this(name, defaultAddress, 0)
        {

        }
        public Club(string name, Address adress, long telNumber)
        {
            Address = adress;
            clubRegistrationNumber = ++Registrant.NoOfRegistrant;
            NumberOfClub++;
            Name = name;
            phoneNumber = telNumber;
        }
        public int ClubRegistrationNumber
        {
            get
            {
                return clubRegistrationNumber;
            }
            set
            {
                clubRegistrationNumber = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public Address Address
        {
            get
            {
                return clubAddress;
            }
            set
            {
                clubAddress = value;
            }
        }
        public long PhoneNumber
        {
            get
            {
                return phoneNumber;
            }
            set
            {
                if (value.ToString().Length > 10)
                {
                    phoneNumber = long.Parse(value.ToString().Substring(0, 10));
                }
                else
                {
                    phoneNumber = value;
                }
            }
        }
        public String GetInfo()
        {
            return String.Format(
                "Name: {0} \n" +
                "Adress: {2} {3} {4} {5} \n" +
                "Phone: {6}\n" +
                "Reg Number: {1}\n" +
                "Swimmers:" +
                "         {7}\n"+
                "Coaches:"+
                "         {8}"
                , Name, ClubRegistrationNumber, Address.StreetLine, Address.City,
                Address.State, Address.ZipCode, PhoneNumber, DisplayRegistrantList(), DisplayCoachesList());
        }
        public string DisplayRegistrantList()
        {
            string result = "";
            if (RegistrantList.Count > 0)
            {
                foreach (Registrant aRegistrant in RegistrantList)
                {
                    result = result+ "\n          " + aRegistrant.Name;
                }
            }
            return result;
        }
        public string DisplayCoachesList()
        {
            string result = "";
            if (CoachList.Count > 0)
            {
                foreach (Coach aCoach in CoachList)
                {
                    result = "\n          "+result + aCoach.Name;
                }
            }
            return result;
        }
        public void AddSwimmer(Registrant registrant)
        {
            registrant.Club = this;
        }
        public void AddCoach(Coach aCoach)
        {
            aCoach.Club = this;
        }
        public override string ToString()
        {
            return GetInfo();
        }
    }
}

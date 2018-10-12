using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoolLib
{
    public class Coach : Registrant
    {
        private string credentials;
        public List<Swimmer> ListOfCoachedSwimmers= new List<Swimmer>();
        public Coach(): base()
        {
            Credentials = "";
            club = new Club("Not assigned");
            club.ClubRegistrationNumber = 0;
            NoOfRegistrant--;
        }
        public Coach(String name): base (name)
        {
            Credentials = "";
            club = new Club("Not assigned");
            club.ClubRegistrationNumber = 0;
            NoOfRegistrant--;
        }
        public Coach(string name, DateTime dOB, Address adress, long telNumber): base(name,dOB,adress,telNumber)
        {
            Credentials = "";
            club = new Club("Not assigned");
            club.ClubRegistrationNumber = 0;
            NoOfRegistrant--;
        }
        public string Credentials
        {
            get
            {
                return credentials;
            }

            set
            {
                credentials = value;
            }
        }
        public override Club Club
        {
            get
            {
                return base.Club;
            }

            set
            {
                if (club.Name != "Not assigned")
                {
                    if (club.ClubRegistrationNumber != value.ClubRegistrationNumber)
                    {
                        throw new Exception(Name + " is registered with  " + Club.Name + "\n");
                    }
                    else
                    {
                        throw new Exception(Club.Name + " already have " + Name + "\n");
                    }
                }
                else
                {
                    club = value;
                    value.CoachList.Add(this);
                }
            }
        }
        public void AddSwimmer(Swimmer aSwimmer)
        {
            if(aSwimmer.Club==this.Club)
            {
                aSwimmer.Coach = this;
            }else if(this.Club.Name == "Not assigned")
            {
                throw new Exception("Coach is not assigned to a club");
            }else
            {
                throw new Exception("Coach and swimmer are not in the same club");
            }

        }
        private string DisplayRegistrantList()
        {
            string result = "";
            if (ListOfCoachedSwimmers.Count>0)
            {
                foreach (Swimmer aSwimmer in ListOfCoachedSwimmers)
                {
                    result = result +"\n          "+ aSwimmer.Name;
                } 
            }
            return result;
        }
        public override string GetInfo()
        {
            return base.GetInfo() + string.Format("\nCredentials: {0}\n"+ 
                                                  "Swimmers: {1}",Credentials,DisplayRegistrantList());
        }
        public override string ToString()
        {
            return GetInfo();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoolLib
{
    public class Swimmer : Registrant
    {
        private Coach coach;
        private int noOfBestTime;
        private Dictionary<string,TimeSpan> listofBestTimes= new Dictionary<string, TimeSpan>();

        public Swimmer(): base()
        {
            coach = new Coach("Not assigned");
            Coach.RegistrationNumber = 0;
            NoOfRegistrant--;
        }
        public Swimmer(string name) : base(name)
        {
            coach = new Coach("Not assigned");
            Coach.RegistrationNumber = 0;
            NoOfRegistrant--;
        }
        public Swimmer(string name, DateTime dOB, Address adress, long telNumber): base(name,dOB,adress,telNumber)
        {
            coach = new Coach("Not assigned");
            Coach.RegistrationNumber = 0;
            NoOfRegistrant--;
        }
        public Coach Coach
        {
            get
            {
                return coach;
            }

            set
            {
                if (value.Club==this.Club)
                {
                    if (this.Coach.Name== "Not assigned")
                    {
                        coach = value;
                        value.ListOfCoachedSwimmers.Add(this);
                    }
                    else
                    {
                        throw new Exception("The Swimmer is already assigned to "+coach.Name);
                    }
                }else if (this.Club.Name == "Not assigned")
                {
                    throw new Exception("The Swimmer is not assigned to a club");
                }else
                {
                    throw new Exception("Coach is not assigned to the club");
                }
            }
        }
        public TimeSpan GetBestTime(PoolType pType,Stroke stroke, EventDistance eDistance)
        {
            string eventName = Convert.ToString(pType) + Convert.ToString(stroke) + Convert.ToString(eDistance);
            TimeSpan bestRecord;
            listofBestTimes.TryGetValue(eventName, out bestRecord);
            return bestRecord;
        }
        public void AddAsBestTime(PoolType pType, Stroke stroke, EventDistance eDistance, TimeSpan time)
        {
            string eventName = Convert.ToString(pType) + Convert.ToString(stroke) + Convert.ToString(eDistance);
            if (noOfBestTime>0)
            {
                int match = 0;
                for (int i = 0; i < listofBestTimes.Count; i++)
                {
                    if (listofBestTimes.ContainsKey(eventName))
                    {
                        match++;
                    }
                }
                if (match == 0)
                {
                    listofBestTimes.Add(eventName, time);
                    noOfBestTime++;
                }
                else
                {
                    TimeSpan oldrecord;
                    listofBestTimes.TryGetValue(eventName, out oldrecord);
                    if (time < oldrecord)
                    {
                        listofBestTimes.Remove(eventName);
                        listofBestTimes.Add(eventName, time);
                        noOfBestTime++;
                    }
                } 
            } else
            {
                listofBestTimes.Add(eventName, time);
                noOfBestTime++;
            }
        }
        public override string GetInfo()
        {
            return base.GetInfo() + string.Format("\nCoach: {0}", Coach.Name);
        }
        public override string ToString()
        {
            return GetInfo();
        }
    }
}

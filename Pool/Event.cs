using System;
using System.Collections;
using System.Collections.Generic;

namespace PoolLib
{
    public class Event
    {
        private EventDistance eventDistance;
        private Stroke eventStroke;
        private string name;
        public Dictionary<Registrant, Swim> ListOfRegistrantSwim= new Dictionary<Registrant, Swim>();
        private Swim swim;
        private SwimMeet swimMeet;
        public bool EventSeed;

        public Event() : this(EventDistance._50, Stroke.Butterfly)
        {

        }
        public Event(EventDistance distance) : this(distance, Stroke.Butterfly)
        {

        }
        public Event(EventDistance distance, Stroke stroke)
        {
            Distance = distance;
            Stroke = stroke;
            EventSeed = false;
            SwimMeet = new SwimMeet();
        }
        public Swim aSwim
        {
            get
            {
                return swim;
            }
            set
            {
                swim = value;
            }
        }
        public EventDistance Distance
        {
            get
            {
                return eventDistance;
            }
            set
            {
                eventDistance = value;
            }
        }
        public Stroke Stroke
        {
            get
            {
                return eventStroke;
            }
            set
            {
                eventStroke = value;
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
        public SwimMeet SwimMeet
        {
            get
            {
                return swimMeet;
            }

            set
            {
                swimMeet = value;
            }
        }
        public string GetInfo()
        {
            return string.Format("{0} {1} \n" +
                                "       Swimmers:\n" +
                                "                {2}", Distance, Stroke, DisplayEventList());
        }
        public string DisplayEventList()
        {
            string result = "";
            if (ListOfRegistrantSwim.Count>0)
            {
                foreach (KeyValuePair<Registrant, Swim> entry in ListOfRegistrantSwim)
                {
                    if (EventSeed == true)
                    {
                        result = result +entry.Key.Name + "      \t" + entry.Value.GetInfo()+"\n                "; 
                    }else
                    {
                        result = result +entry.Key.Name + "      \t" + "\n                     Not seeded/no swim "+"\n                ";
                    }
                }
            }
            return result;
        }
        public void AddSwimmer(Registrant registrant)
        {
            aSwim = new Swim();
            int match = 0;
            if (this.ListOfRegistrantSwim.Count>0)
            {
                for (int i = 0; i < this.ListOfRegistrantSwim.Count; i++)
                {
                    if (this.ListOfRegistrantSwim.ContainsKey(registrant))
                    {
                        match++;
                        throw new Exception("Swimmer " + registrant.Name + "," + registrant.RegistrationNumber + " already entered " + this.Distance + this.Stroke + "\n");
                    }
                }
                if (match==0)
                {
                    this.ListOfRegistrantSwim.Add(registrant, aSwim);
                }
            }
            else
            {
                this.ListOfRegistrantSwim.Add(registrant,aSwim);
            }
        }
        public void EnterSwimmersTime(Registrant registrant, string time)
        {
            TimeSpan myTime = TimeSpan.Parse("00:"+time);
            int match = 0;
            foreach(KeyValuePair<Registrant, Swim> entry in ListOfRegistrantSwim)
            {
                if(entry.Key== registrant)
                {
                    ListOfRegistrantSwim[registrant].TimeSwam = myTime;
                    match++;
                    Swimmer aSwimmer = registrant as Swimmer;
                    if (aSwimmer != null)
                    {
                        aSwimmer.AddAsBestTime(SwimMeet.PType, Stroke, Distance, myTime);
                    }
                }
            }
            if (match == 0)
            {
                throw new Exception(registrant.Name + " has not entered " + this.Name);
            }
        }
        public void Seed()
        {
            int nLane = 0;
            int nHeat = 1;
            int count = 0;
            var values = ListOfRegistrantSwim.Values;
            foreach(Swim entry in values)
            {
                if (count+ 1 > SwimMeet.NumberOfLane)
                {
                    nLane = 1;
                    entry.NumberOfLane = nLane;
                    entry.NumberOfTheHeat = ++nHeat;
                }
                else
                {
                    entry.NumberOfLane = ++nLane;
                }
                count++;
            }
            EventSeed = true;
        }
        public override string ToString()
        {
            return GetInfo();
        }
    }
    public enum EventDistance { _50 = 50, _100 = 100, _200 = 200, _400 = 400, _800 = 800, _1500 = 1500 }
    public enum Stroke { Butterfly, Backstroke, Breaststroke, Freestyle, Individualmedley }
}

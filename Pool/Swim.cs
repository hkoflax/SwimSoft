using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoolLib
{
    public class Swim
    {
        private TimeSpan timeSwam;
        private int numberOfTheHeat;
        private int numberOfLane;
        public Swim(): this (new TimeSpan(), 1,0)
        {

        }
        public Swim(TimeSpan time): this(time,1,0)
        {

        }
        public Swim(TimeSpan time, int nbOfHeat, int nbOflane)
        {
            TimeSwam = time;
            NumberOfTheHeat = nbOfHeat;
            NumberOfLane = nbOflane;
        }
        public TimeSpan TimeSwam
        {
            get
            {
                return timeSwam;
            }
            set
            {
                timeSwam = value;
            }
        }
        public int NumberOfTheHeat
        {
            get
            {
                return numberOfTheHeat;
            }
            set
            {
                numberOfTheHeat = value;
            }
        }
        public int NumberOfLane
        {
            get
            {
                return numberOfLane;
            }
            set
            {
                numberOfLane = value;
            }
        }
        public string GetInfo()
        {
            if (TimeSwam== new TimeSpan())
            {
                return String.Format("H" + NumberOfTheHeat + "L" + NumberOfLane + "    \t" + "Time: no Time"); 
            }else
            {
                return String.Format("H" + NumberOfTheHeat + "L" + NumberOfLane + "    \t" + "Time: " + TimeSwam.ToString(@"mm\:ss\.ff"));
            }
        }
        public override string ToString()
        {
            return GetInfo();
        }
    }
}

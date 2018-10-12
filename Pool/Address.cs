using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoolLib
{
    public struct Address
    {
        public string StreetLine;
        public string ZipCode;
        public string State;
        public string City;

        public Address(string streetNameAndNumber,string streetcity,string streetState, string streetZipcode)
        {
            StreetLine = streetNameAndNumber;
            ZipCode = streetZipcode;
            State = streetState;
            City = streetcity;
        }
        public override string ToString() 
        {
            return string.Format(StreetLine+"," + City+ "," + State + "," + ZipCode);
        }
    }
}

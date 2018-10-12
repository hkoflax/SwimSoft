using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoolLib.Managers
{
    public class SwimmersManager : IRegistrantsRepository
    {
        private Registrant[] swimmers;
        private int numberOfSwimmers;
        private ClubsManager clubManager;

        public SwimmersManager(ClubsManager clubManager)
        {
            ClubManager = clubManager;
            Swimmers = new Registrant[100];
            Number = 0;
        }
        public int Number
        {
            get
            {
                return numberOfSwimmers;
            }

            set
            {
                numberOfSwimmers = value;
            }
        }
        public Registrant[] Swimmers
        {
            get
            {
                return swimmers;
            }

            set
            {
                swimmers = value;
            }
        }
        public ClubsManager ClubManager
        {
            get
            {
                return clubManager;
            }

            set
            {
                clubManager = value;
            }
        }
        public void Add(Registrant aRegistrant)
        {
            if (Number == 0)
            {
                Swimmers[Number] = aRegistrant;
                if (aRegistrant.Club.ClubRegistrationNumber != 0)
                {
                    if (ClubManager.GetByRegNum(aRegistrant.Club.ClubRegistrationNumber) == null)
                    {
                        ClubManager.Add(aRegistrant.Club);
                    }
                }
                Number++;
            }
            else
            {
                bool resultCheck = checkSwimmerExistance(aRegistrant);
                if (resultCheck == true)
                {
                    Exception error = new Exception("Invalid swimmer record. Swimmer with the registration number already exists: \n     " + aRegistrant.RegistrationNumber + ","
                                                                                                                             + aRegistrant.Name + ","
                                                                                                                             + aRegistrant.Address.StreetLine + ","
                                                                                                                             + aRegistrant.Address.City + ","
                                                                                                                             + aRegistrant.Address.State + ","
                                                                                                                             + aRegistrant.Address.ZipCode + ","
                                                                                                                             + aRegistrant.PhoneNumber + ","
                                                                                                                             + aRegistrant.Club.ClubRegistrationNumber);
                    Console.WriteLine(error.Message);
                }
                else
                {
                    Swimmers[Number] = aRegistrant;
                    if (aRegistrant.Club.ClubRegistrationNumber != 0)
                    {
                        if (ClubManager.GetByRegNum(aRegistrant.Club.ClubRegistrationNumber) == null)
                        {
                            ClubManager.Add(aRegistrant.Club);
                        }
                    }
                    Number++;
                }
            }
        }
        public Registrant GetByRegNum(int regNumber)
        {
            Registrant aRegistrant = new Registrant();
            Registrant.NoOfRegistrant--;
            int found = 0;
            for (int i = 0; i < Number; i++)
            {
                aRegistrant = Swimmers[i];
                if (aRegistrant.RegistrationNumber == regNumber)
                {
                    found++;
                    aRegistrant = Swimmers[i];
                    break;
                }
            }
            if (found != 0)
            {
                return aRegistrant;
            }
            else
            {
                return null;
            }
        }
        public void Load(string fileName, string delimiter)
        {
            FileStream swimmersFile = null;
            StreamReader fileReader = null;
            try
            {
                swimmersFile = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                fileReader = new StreamReader(swimmersFile);
                string recordInFile;
                string[] swimmerFields;
                bool correctSwimmerInfo;
                recordInFile = fileReader.ReadLine();
                while (recordInFile != null)
                {
                    Registrant registrant = new Registrant();
                    Registrant.NoOfRegistrant--;
                    swimmerFields = recordInFile.Split(char.Parse(delimiter));
                    correctSwimmerInfo = checkClubMandatoryFieldsOnLoad(swimmerFields);
                    if (correctSwimmerInfo == true)
                    {
                        registrant.RegistrationNumber = Convert.ToInt32(swimmerFields[0]);
                        registrant.Name = swimmerFields[1];
                        registrant.DateOfBirth = DateTime.Parse(swimmerFields[2]);
                        registrant.Address = new Address(swimmerFields[3], swimmerFields[4], swimmerFields[5], swimmerFields[6]);
                        registrant.PhoneNumber = long.Parse(swimmerFields[7]);
                        if (swimmerFields[8] != "")
                        {
                            var result = ClubManager.GetByRegNum(int.Parse(swimmerFields[8]));
                            if (result!=null)
                            {
                                registrant.Club = result; 
                            }
                        }
                        Add(registrant);
                    }
                    recordInFile = fileReader.ReadLine();
                }
            }
            catch (Exception error)
            {

                throw error;
            }
            finally
            {
                if (fileReader != null) fileReader.Close();
                if (swimmersFile != null) swimmersFile.Close();
            }

        }
        public void Save(string fileName, string delimiter)
        {
            Registrant aRegistrant = new Registrant();
            Registrant.NoOfRegistrant--;
            FileStream clubOutFile = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            StreamWriter clubWriter = new StreamWriter(clubOutFile);
            for (int i = 0; i < Number; i++)
            {
                aRegistrant = Swimmers[i];
                if (aRegistrant.Club.ClubRegistrationNumber == 0)
                {
                    clubWriter.WriteLine(aRegistrant.RegistrationNumber + delimiter + aRegistrant.Name + delimiter + aRegistrant.DateOfBirth + delimiter +
                                         aRegistrant.Address.StreetLine + delimiter + aRegistrant.Address.City +
                                         delimiter + aRegistrant.Address.State + delimiter + aRegistrant.Address.ZipCode + delimiter + aRegistrant.PhoneNumber +
                                         delimiter);
                }
                else
                {
                    clubWriter.WriteLine(aRegistrant.RegistrationNumber + delimiter + aRegistrant.Name + delimiter + aRegistrant.DateOfBirth + delimiter +
                                         aRegistrant.Address.StreetLine + delimiter + aRegistrant.Address.City +
                                         delimiter + aRegistrant.Address.State + delimiter + aRegistrant.Address.ZipCode + delimiter + aRegistrant.PhoneNumber +
                                         delimiter + aRegistrant.Club.ClubRegistrationNumber);
                }
            }
            clubWriter.Close();
            clubOutFile.Close();
        }
        private bool checkClubMandatoryFieldsOnLoad(string[] fields)
        {
            int idResult;
            long phoneResult;
            DateTime dob;
            bool validNumber = int.TryParse(fields[0], out idResult);
            bool correctPhoneNumber = long.TryParse(fields[7], out phoneResult);
            bool validDob = DateTime.TryParse(fields[2], out dob);

            if (validNumber == false)
            {
                Exception error = new Exception("Invalid swimmer record. Invalid registration number:  \n     " + fields[0] + "," +
                                                                                                                  fields[1] + "," +
                                                                                                                  fields[2] + "," +
                                                                                                                  fields[3] + "," +
                                                                                                                  fields[4] + "," +
                                                                                                                  fields[5] + "," +
                                                                                                                  fields[6] + "," +
                                                                                                                  fields[7] + "," +
                                                                                                                  fields[8]);
                Console.WriteLine(error.Message);
                return false;
            }
            else if (fields[1] == "")
            {
                Exception error = new Exception("Invalid swimmer record. Invalid swimmer name:  \n     " + fields[0] + "," +
                                                                                                           fields[1] + "," +
                                                                                                           fields[2] + "," +
                                                                                                           fields[3] + "," +
                                                                                                           fields[4] + "," +
                                                                                                           fields[5] + "," +
                                                                                                           fields[6] + "," +
                                                                                                           fields[7] + "," +
                                                                                                           fields[8]);
                Console.WriteLine(error.Message);
                return false;
            }
            else if (validDob == false)
            {
                Exception error = new Exception("Invalid swimmer record. Birth date is invalid:  \n     " + fields[0] + "," +
                                                                                                            fields[1] + "," +
                                                                                                            fields[2] + "," +
                                                                                                            fields[3] + "," +
                                                                                                            fields[4] + "," +
                                                                                                            fields[5] + "," +
                                                                                                            fields[6] + "," +
                                                                                                            fields[7] + "," +
                                                                                                            fields[8]);
                Console.WriteLine(error.Message);
                return false;
            }
            else if (correctPhoneNumber == false)
            {
                Exception error = new Exception("Invalid swimmer record. Phone number wrong format:  \n     " + fields[0] + "," +
                                                                                                                fields[1] + "," +
                                                                                                                fields[2] + "," +
                                                                                                                fields[3] + "," +
                                                                                                                fields[4] + "," +
                                                                                                                fields[5] + "," +
                                                                                                                fields[6] + "," +
                                                                                                                fields[7] + "," +
                                                                                                                fields[8]);
                Console.WriteLine(error.Message);
                return false;
            }
            else
            {
                return true;
            }
        }
        private bool checkSwimmerExistance(Registrant registrant)
        {
            int found = 0;
            for (int i = 0; i < Number; i++)
            {
                if ( Swimmers[i].RegistrationNumber == registrant.RegistrationNumber)
                {
                    found++;
                    Swimmers[i]= registrant;
                    break;
                }
            }
            if (found != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

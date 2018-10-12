using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoolLib.Managers
{
    public class ClubsManager : IClubsRepository
    {
        private Club[] clubs;
        private int numberOfClubs;

        public ClubsManager()
        {
            Clubs = new Club[100];
            Number = 0;
        }
        public int Number
        {
            get
            {
                return numberOfClubs;
            }

            set
            {
                numberOfClubs = value;
            }
        }
        public Club[] Clubs
        {
            get
            {
                return clubs;
            }

            set
            {
                clubs = value;
            }
        }
        public void Add(Club aClub)
        {
            bool resultCheck = checkClubExistance(aClub);
            if (Number==0)
            {
                Clubs[Number] = aClub;
                Number++; 
            }else
            {
                if (resultCheck==true)
                {
                    Exception error = new Exception("Invalid club record. Club with the registration number already exists:  \n     " + aClub.ClubRegistrationNumber + "," 
                                                                                                                             + aClub.Name + "," 
                                                                                                                             + aClub.Address.StreetLine + ","
                                                                                                                             + aClub.Address.City + ","
                                                                                                                             + aClub.Address.State+ ","
                                                                                                                             + aClub.Address.ZipCode + ","
                                                                                                                             + aClub.PhoneNumber);
                    Console.WriteLine(error.Message);
                }
                else
                {
                    Clubs[Number] = aClub;
                    Number++;
                }
            }
        }
        public Club GetByRegNum(int regNumber)
        {
            Club aClub = new Club();
            Registrant.NoOfRegistrant--;
            int found = 0;
            for (int i = 0; i < Number; i++)
            {
                if (Clubs[i].ClubRegistrationNumber == regNumber)
                {
                    found++;
                    aClub = Clubs[i];
                    break;
                }
            }
            if (found != 0)
            {
                return aClub;
            }
            else
            {
                return null;
            }
        }
        public void Load(string fileName, string delimiter)
        {
            FileStream clubFile = null;
            StreamReader fileReader = null;
            try
            {
                clubFile = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                fileReader = new StreamReader(clubFile);
                string recordInFile;
                string[] ClubFields;
                bool correctClubInfo;
                recordInFile = fileReader.ReadLine();
                while (recordInFile != null)
                {
                    Club club = new Club();
                    Registrant.NoOfRegistrant--;
                    ClubFields = recordInFile.Split(char.Parse(delimiter));
                    correctClubInfo = checkClubMandatoryFieldsOnLoad(ClubFields);
                    if (correctClubInfo == true)
                    {
                        club.ClubRegistrationNumber = Convert.ToInt32(ClubFields[0]);
                        club.Name = ClubFields[1];
                        club.Address = new Address(ClubFields[2], ClubFields[3], ClubFields[4], ClubFields[5]);
                        club.PhoneNumber = long.Parse(ClubFields[6]);
                        Add(club);
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
                if(fileReader!=null) fileReader.Close();
                if(clubFile!=null) clubFile.Close();
            }

        }
        public void Save(string fileName, string delimiter)
        {
            Club aClub = new Club();
            Registrant.NoOfRegistrant--;
            FileStream clubOutFile = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            StreamWriter clubWriter = new StreamWriter(clubOutFile);

            for (int i = 0; i < Number; i++)
            {
                aClub = Clubs[i];
                clubWriter.WriteLine(aClub.ClubRegistrationNumber + delimiter + aClub.Name + delimiter +
                                     aClub.Address.StreetLine + delimiter + aClub.Address.City +
                                     delimiter +aClub.Address.State+delimiter+aClub.Address.ZipCode+delimiter+aClub.PhoneNumber);
            }
            clubWriter.Close();
            clubOutFile.Close();
        }
        private bool checkClubMandatoryFieldsOnLoad(string [] fields)
        {
            int idResult;
            long phoneResult;
            bool validNumber= int.TryParse(fields[0], out idResult);
            bool correctPhoneNumber= long.TryParse(fields[6], out phoneResult);

            if (validNumber==false)
            {
                Exception error = new Exception("Invalid club record. Club number is not valid: \n     " + fields[0]+" ," + fields[1] + " ," + fields[2]+ "," + fields[3]+ "," + fields[4]+ "," + fields[5]+ "," + fields[6]);
                Console.WriteLine(error.Message);
                return false;
            }
            else if (fields[1] =="")
            {
                Exception error= new Exception("Invalid club record. No Club name: \n     " + fields[0] + "," + fields[1] + " ," + fields[2] + "," + fields[3] + "," + fields[4] + "," + fields[5] + "," + fields[6]);
                Console.WriteLine(error.Message);
                return false;
            }
            else if (correctPhoneNumber==false)
            {
                Exception error = new Exception("Invalid club record. Phone number wrong format: \n     " + fields[0] + "," + fields[1] + " ," + fields[2] + "," + fields[3] + "," + fields[4] + "," + fields[5] + "," + fields[6]);
                Console.WriteLine(error.Message);
                return false;
            }
            else
            {
                return true;
            }
        }
        private bool checkClubExistance(Club club)
        {
            int found = 0;
            for (int i = 0; i < Number; i++)
            {
                if (Clubs[i].ClubRegistrationNumber == club.ClubRegistrationNumber)
                {
                    found++;
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

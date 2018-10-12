namespace PoolLib.Managers
{
    public interface IClubsRepository
    {
        int Number { get; set; }
        Club[] Clubs { get; set; }

        void Add(Club aClub);
        Club GetByRegNum(int regNumber);
        void Load(string fileName, string delimiter);
        void Save(string fileName, string delimiter);
    }
}
namespace PoolLib.Managers
{
    public interface IRegistrantsRepository
    {
        int Number { get;}
        ClubsManager ClubManager { get;}
        Registrant[] Swimmers { get;}

        void Add(Registrant aRegistrant);
        Registrant GetByRegNum(int regNumber);
        void Load(string fileName, string delimiter);
        void Save(string fileName, string delimiter);
    }
}
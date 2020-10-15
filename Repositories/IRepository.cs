using System.Threading.Tasks;

public interface IRepository
{
    void AddAllCharactersToDatabase();
    Task<string> ResetallCharacterData();
    Task<Fighter> InputFighterToDb(int fighterId);
    Task<Game> StartGame(int p1, int p2);
    Task<Fighter> InputWinner(int fighterId);
    Task<Fighter> InputLoser(int fighterId);
    Task<int> GetTimesPlayed(int fighterId);
    Task<int> GetTimesLost(int fighterId);
    Task<int> GetTimesWon(int fighterId);
    Task<Fighter[]> TopWinners();
    Task<Fighter[]> TopPlayed();

}
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System.Linq;


public class MongoDbRepository : IRepository
{

    private readonly IMongoCollection<Game> _gamesCollection;
    private readonly IMongoCollection<Fighter> _fighterCollection;
    private readonly IMongoCollection<Game> _seasonCollection;
    private readonly IMongoCollection<BsonDocument> _bsonDocumentCollection;
    public MongoDbRepository()
    {
        MongoClient mongoClient = new MongoClient("mongodb://localhost:27017");
        var database = mongoClient.GetDatabase("StreetFighterStats");
        _gamesCollection = database.GetCollection<Game>("games");
        _fighterCollection = database.GetCollection<Fighter>("fighters");
        _seasonCollection = database.GetCollection<Game>("seasongames");
        _bsonDocumentCollection = database.GetCollection<BsonDocument>("fighters");
    }

    public void AddAllCharactersToDatabase()
    {
        for (int i = 0; i < 40; i++)
        {
            Fighter newFighter = new Fighter();
            newFighter.name = Enum.GetName(typeof(Fighter_id), i);
            newFighter.fighterId = (int)(Fighter_id)i;
            newFighter.timesPlayed = 0;
            newFighter.timesLost = 0;
            newFighter.timesWon = 0;
            _fighterCollection.InsertOneAsync(newFighter);
        }
    }
    public async Task<int> GetTimesPlayed(int _fighterId)
    {
        var filter = Builders<Fighter>.Filter.Eq(f => f.fighterId, _fighterId);
        Fighter foundFighter = await _fighterCollection.Find(filter).FirstAsync();
        return foundFighter.timesPlayed;
    }
    public async Task<int> GetTimesLost(int _fighterId)
    {
        var filter = Builders<Fighter>.Filter.Eq(f => f.fighterId, _fighterId);
        Fighter foundFighter = new Fighter();
        foundFighter = await _fighterCollection.Find(filter).FirstAsync();
        return foundFighter.timesLost;
    }
    public async Task<int> GetTimesWon(int _fighterId)
    {
        var filter = Builders<Fighter>.Filter.Eq(f => f.fighterId, _fighterId);
        Fighter foundFighter = new Fighter();
        foundFighter = await _fighterCollection.Find(filter).FirstAsync();
        return foundFighter.timesWon;
    }

    public async Task<Fighter> InputFighterToDb(int fighterId) //tämä kutsutaan aina kun pelaaja valitaan alkunäkymässä
    {
        var filter = Builders<Fighter>.Filter.Eq(f => f.fighterId, fighterId);
        Fighter foundFighter = new Fighter();
        foundFighter = await _fighterCollection.Find(filter).FirstAsync();
        foundFighter.timesPlayed += 1;
        await _fighterCollection.ReplaceOneAsync(filter, foundFighter);
        return foundFighter;
    }

    public async Task<Game> StartGame(int fighterId1, int fighterId2) //tällä voidaan aloittaa peli kahden valitun hahmon kanssa
    {
        Fighter player1 = new Fighter();
        player1.name = Enum.GetName(typeof(Fighter_id), fighterId1);
        player1.fighterId = fighterId1;
        player1.timesPlayed = await GetTimesPlayed(fighterId1);
        player1.timesLost = await GetTimesLost(fighterId1);
        player1.timesWon = await GetTimesWon(fighterId1);
        // await InputFighterToDb(fighterId1);


        Fighter player2 = new Fighter();
        player2.name = Enum.GetName(typeof(Fighter_id), fighterId2);
        player2.fighterId = fighterId2;
        player2.timesPlayed = await GetTimesPlayed(fighterId2);
        player2.timesLost = await GetTimesLost(fighterId2);
        player2.timesWon = await GetTimesWon(fighterId2);
        // await InputFighterToDb(fighterId2);

        Game newGame = new Game(player1, player2);
        await _gamesCollection.InsertOneAsync(newGame);
        return newGame;
    }

    public async Task<Fighter> InputWinner(int fighterId)
    {
        var player_filter = Builders<Fighter>.Filter.Eq(f => f.fighterId, fighterId);
        var foundFighter = await _fighterCollection.Find(player_filter).FirstAsync();
        foundFighter.timesPlayed += 1;
        foundFighter.timesWon += 1;
        await _fighterCollection.ReplaceOneAsync(player_filter, foundFighter);
        return foundFighter;
    }
    public async Task<Fighter> InputLoser(int fighterId)
    {
        var player_filter = Builders<Fighter>.Filter.Eq(f => f.fighterId, fighterId);
        var foundFighter = await _fighterCollection.Find(player_filter).FirstAsync();
        foundFighter.timesPlayed += 1;
        foundFighter.timesLost += 1;
        await _fighterCollection.ReplaceOneAsync(player_filter, foundFighter);
        return foundFighter;
    }

    public async Task<String> ResetallCharacterData()
    {
        MongoClient mongoClient = new MongoClient("mongodb://localhost:27017");
        var database = mongoClient.GetDatabase("StreetFighterStats");
        await database.DropCollectionAsync("fighters");
        AddAllCharactersToDatabase();
        return "All characters reset";
    }

    public async Task<Fighter[]> TopWinners()
    {
        var filter = Builders<Fighter>.Filter.Empty;
        List<Fighter> allFighters = await _fighterCollection.Find(filter).ToListAsync();
        List<Fighter> removedFighters = new List<Fighter>();
        foreach (var fighter in allFighters)
        {
            if (fighter.timesPlayed == 0 || fighter.timesWon == 0 || fighter.timesPlayed == 0)
            {
                removedFighters.Add(fighter);
            }
        }

        for (int i = 0; i < removedFighters.Count; i++)
        {
            allFighters.Remove(removedFighters[i]);
        }
        List<Fighter> sortedFighters = allFighters.OrderByDescending(f => f.timesWon / f.timesPlayed).ToList();
        Fighter[] topThree = new Fighter[3];
        if (sortedFighters.Count > 0)
        {

            topThree[0] = sortedFighters[0];
            topThree[1] = sortedFighters[1];
            topThree[2] = sortedFighters[2];
        }
        return topThree;
    }
    public async Task<Fighter[]> TopPlayed()
    {
        var filter = Builders<Fighter>.Filter.Empty;
        List<Fighter> allFighters = await _fighterCollection.Find(filter).ToListAsync();
        List<Fighter> sortedFighters = allFighters.OrderByDescending(f => f.timesPlayed).ToList();
        Fighter[] topThree = new Fighter[3];
        topThree[0] = sortedFighters[0];
        topThree[1] = sortedFighters[1];
        topThree[2] = sortedFighters[2];
        return topThree;
    }
    public async Task<List<Game>> GetSeasonScoreboard()
    {
        var games = new List<Game>();
        for (int i = 0; i < 40; i++)
        {
            for (int j = 0; j < 40; j++)
            {
                if (i == j)
                    continue;

                var filter1 = Builders<Game>.Filter.Where(g => g.player_1.fighterId == j);
                var listOfPlayerIGames = _seasonCollection.Find(filter1).ToList();
                if (listOfPlayerIGames.Count > 0)
                {
                    continue;
                }

                Fighter playerOne = new Fighter();
                playerOne.name = Enum.GetName(typeof(Fighter_id), i);
                playerOne.fighterId = i;
                playerOne.timesLost = 0;
                playerOne.timesPlayed = 0;
                playerOne.timesWon = 0;

                Fighter playerTwo = new Fighter();
                playerTwo.name = Enum.GetName(typeof(Fighter_id), j);
                playerTwo.fighterId = j;
                playerTwo.timesLost = 0;
                playerTwo.timesPlayed = 0;
                playerTwo.timesWon = 0;
                Game seasonGame = new Game(playerOne, playerTwo);
                seasonGame.winner = null;
                games.Add(seasonGame);
                await _seasonCollection.InsertOneAsync(seasonGame);
                continue;

            }
        }
        return games;
    }

    public async Task<Fighter[]> GetStats()
    {
        Fighter[] fighters = new Fighter[40];
        var filter = Builders<Fighter>.Filter.Empty;
        List<Fighter> list = await _fighterCollection.Find(filter).ToListAsync();
        if (list.Count > 0)
        {
            for (int i = 0; i < fighters.Length; i++)
            {
                fighters[i] = list[i];
            }
        }
        return fighters;
    }

    public async Task<string[]> GetWinPercentage()
    {
        string[] retArr = new string[40];
        for (int i = 0; i < 40; i++)
        {
            int timesPlayed = await GetTimesPlayed(i);
            int timesWon = await GetTimesWon(i);

            float winPercentage = 0;
            if (timesPlayed != 0 && timesWon != 0)
            {
                winPercentage = (float)timesWon / (float)timesPlayed;
            }
            retArr[i] = winPercentage.ToString("P0");
        }
        return retArr;
    }
}

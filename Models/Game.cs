using System;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[BsonIgnoreExtraElements]
public class Game
{
    public string GameId { get; set; }
    public Fighter player_1 { get; set; }
    public Fighter player_2 { get; set; }
    public Fighter winner { get; set; }

    public Game(Fighter p1, Fighter p2)
    {
        GameId = Guid.NewGuid().ToString();
        player_1 = p1;
        player_2 = p2;
    }
}
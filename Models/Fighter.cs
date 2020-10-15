using System.ComponentModel.DataAnnotations;
using MongoDB.Bson.Serialization.Attributes;

public enum Fighter_id
{
    Birdie, Cammy, ChunLi, Dhalsim, FANG, Karin, Ken, Laura,
    MBison, Nash, Necalli, RMika, Rashid, Ryu, Vega, Zangief,
    Alex, Balrog, Guile, Ibuki, Juri, Urien, Abigail, Akuma,
    Ed, Kolin, Menat, Zeku, Blanka, Cody, Falke, G, Sagat, Sakura,
    EHonda, Gill, Kage, Lucia, Poison, Seth
}
[BsonIgnoreExtraElements]
public class Fighter
{
    public string name { get; set; }
    public int fighterId { get; set; }
    public int timesPlayed { get; set; }
    public int timesWon { get; set; }
    public int timesLost { get; set; }


}
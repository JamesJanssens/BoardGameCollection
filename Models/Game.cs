using System;

namespace BoardGameCollection.Models
{
    public class Game {
    public string Name {get;set;}
    public int MinNumberOfPlayers {get;set;}
    public int MaxNumberOfPlayers {get;set;}
    public int rating {get;set;}
    public DateTime LastPlayed {get;set;}
    public string Publisher {get;set;}
    
    }

}
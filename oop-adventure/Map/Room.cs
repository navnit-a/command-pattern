namespace oop_adventure.Map;

public class Room
{
    public string Name { get; set; } = Text.Text.Language.DefaultRoomName;
    public string Description { get; set; } = Text.Text.Language.DefaultRoomDescription;

    public Dictionary<Directions, int> Neighbours { get; set; } = new()
    {
        { Directions.North, -1 },
        { Directions.South, -1 },
        { Directions.East, -1 },
        { Directions.West, -1 },
        { Directions.None, -1 }
    };

    public bool Visited { get; set; }


}
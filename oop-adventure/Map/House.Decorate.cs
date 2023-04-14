using oop_adventure.Items;

namespace oop_adventure.Map
{
    public partial class House
    {
        public void DecorateRooms()
        {
            foreach (var room in Rooms)
            {
                var roomDescription = Text.Text.Language.RoomDescriptions[0];

                if (Text.Text.Language.RoomDescriptions.Count > 1 && _random.Next(0, 2) == 1)
                {
                    roomDescription = Text.Text.Language.RoomDescriptions[_random.Next(1, Text.Text.Language.RoomDescriptions.Count)];

                    Text.Text.Language.RoomDescriptions.Remove(roomDescription);
                }

                room.Description = string.Format(Text.Text.Language.DefaultRoomDescription, roomDescription, "{0}");
            }
        }

        public void PopulateRooms(List<Item> items)
        {
            var i = 0;

            while (i != items.Count)
            {
                var room = Rooms[_random.Next(0, Rooms.Length)];

                if (room.Total == 0)
                {
                    room.Add(items[i]);
                    i++;
                }
            }
        }
    }
}

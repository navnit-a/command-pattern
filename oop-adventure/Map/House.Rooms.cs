﻿namespace oop_adventure.Map
{
    public partial class House
    {
        private int CalculateRoomIndex(int c, int r)
        {
            return Math.Clamp(c, -1, Width) + Math.Clamp(r, -1, Height) * Width;
        }

        public void CreateRooms(int width, int height)
        {
            Width = Math.Clamp(width, 2, 10);
            Height = Math.Clamp(height, 2, 10);

            var total = Width * Height;

            Rooms = new Room[total];

            for (int i = 0; i < total; i++)
            {
                var temRoom = new Room();

                var c = i % Width;
                var r = i / Width;

                temRoom.Name = string.Format(Text.Text.Language.DefaultRoomName, i, c, r);

                if (c < Width - 1)
                {
                    temRoom.Neighbours[Directions.East] = CalculateRoomIndex(c + 1, r);
                }

                if (c > 0)
                {
                    temRoom.Neighbours[Directions.West] = CalculateRoomIndex(c - 1, r);
                }

                if (r < Height -1)
                {
                    temRoom.Neighbours[Directions.South] = CalculateRoomIndex(c, r + 1);
                }

                if (r > 0)
                {
                    temRoom.Neighbours[Directions.North] = CalculateRoomIndex(c, r - 1);
                }

                Rooms[i] = temRoom;

            }
        }
    }
}

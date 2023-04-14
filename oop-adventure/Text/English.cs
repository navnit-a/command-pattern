using oop_adventure.Map;

namespace oop_adventure.Text
{
    public class English : Language
    {
        public English()
        {
            ChooseYourName = "Hello, what is your name?";
            DefaultName = "No Name";
            Welcome = "Welcome {0} to your OOP Adventure!";
            DefaultRoomName = "Room {0} ({1},{2})";
            DefaultRoomDescription = " You are in a {0} room with doors to the {1}.";
            ActionError = "You can't do that";
            Go = "Go";
            GoError = "You can't go that way";
            WhatToDo = "What do you want to do?";
            Quit = "quit";
            RoomNew = "You entered {0}";
            RoomOld = "You returned to {0}";
            And = "and";
            Comma = ",";
            Space = " ";
            RoomDescriptions = new List<string>
            {
                "normal",
                "cold",
                "warm",
                "dark",
                "bright",
                "scary",
                "strange",
            };
            NoItem = "You don't have {0}.";
            Backpack = "Backpack";
            BackpackError = "You don't have anything in your backpack";
            BackpackDescription = "Your backpack contains: {0}";
            Chest = "chest";
            UnlockChest = "You unlocked the chest";
            Key = "key";
            CheckEmpty = "The chest is empty";
            ChestFound = "You found {0}";
            Gold = "{0} gold {1}";
            Coin = "coin";
            Coins = Coin + Plural;
            Is = "is";
            Are = "are";
            Plural = "s";
            TotalItems = " There {0} {1} item{2} in the room: ";
            Period = ".";
            Take = "Take";
            TakeError = "There is nothing to take.";
            NotTaken = "You can't take that";
            TookDescription = "You took a {0}.";
            CantTakeDescription = "You can't take the {0}.";
            Use = "Use";
            UseSuccess = "You used the {0}";
            UseError = "You can't use that.";
        }
    }
}

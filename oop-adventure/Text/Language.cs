namespace oop_adventure.Text
{
    public abstract partial class Language
    {
        public string Welcome { get; protected set; } = "";
        public string ChooseYourName { get; protected set; } = "";
        public string DefaultName { get; protected set; } = "";
        public string DefaultRoomName { get; protected set; } = "";
        public string DefaultRoomDescription { get; protected set; } = "";
        public string ActionError { get; protected set; } = "";
        public string Go { get; protected set; } = "";
        public string GoError { get; protected set; } = "";
        public string WhatToDo { get; protected set; } = "";
        public string Quit { get; protected set; } = "";
        public string RoomNew { get; protected set; } = "";
        public string RoomOld { get; protected set; } = "";
        public string And { get; protected set; } = "";
        public string Comma { get; protected set; } = "";
        public string Space { get; protected set; } = "";
        public List<string> RoomDescriptions { get; protected set; }
        public string NoItem { get; protected set; } = "";
        public string Backpack { get; set; } = "";
        public string BackpackError { get; set; } = "";
        public static string BackpackDescription { get; set; } = "";
        public string Chest { get; set; } = "";
        public string UnlockChest { get; set; } = "";
        public string Key { get; set; } = "";
        public string CheckEmpty { get; set; } = "";
        public string ChestFound { get; set; } = "";
        public string Gold { get; set; } = "";
        public string Coin { get; set; } = "";
        public string Coins { get; set; } = "";
        public string Plural { get; set; } = "";
        public string Is { get; set; } = "";
        public string Are { get; set; } = "";
        public string TotalItems { get; set; } = "";
        public string Period { get; set; } = "";
        public string Take { get; set; } = "";
        public string TakeError { get; set; } = "";
        public string NotTaken { get; set; } = "";
        public string TookDescription { get; set; } = "";
        public string CantTakeDescription { get; set; } = "";
        public string Use { get; set; } = "";
        public string UseSuccess { get; set; } = "";
        public string UseError { get; set; } = "";
    }
}

using oop_adventure.Actions;
using oop_adventure.Map;
using oop_adventure.Text;
using oop_adventure.Text.Characters;

namespace oop_adventure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Text.Text.LoadLanguage(new English());

            Console.WriteLine(Text.Text.Language.ChooseYourName);

            var name  = Console.ReadLine();

            if (name == String.Empty)
            {
                name = Text.Text.Language.DefaultName;
            }

            var player = new Player(name);

            Console.WriteLine(Text.Text.Language.Welcome, player.Name);

            var house = new House(player);

            Actions.Actions.Instance.Register(new Go(house));

            var run = true;

            Room lastRoom = null;

            while (run)
            {
                if (lastRoom != house.CurrentRoom)
                {
                    Console.WriteLine(house.CurrentRoom.ToString());
                    lastRoom = house.CurrentRoom;
                }

                Console.WriteLine(Text.Text.Language.WhatToDo);

                var input = Console.ReadLine().ToLower();

                if (input == Text.Text.Language.Quit)
                {
                    run = false;
                }
                else
                {
                    Actions.Actions.Instance.Execute(input.Split(" "));
                }
            }
        }
    }
}
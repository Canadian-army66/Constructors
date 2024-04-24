namespace Constructors_Kohnen_Christian
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game myGame = new Game("Lurid", "Physological Horror"); //assigns new value to title and genre
            Console.WriteLine($"My favorite game is {myGame.title} and it is a {myGame.genre} game!"); //prints with updated values

            Game myOtherGame = new Game(); //does not assign a value to title and genre
            Console.WriteLine($"My favorite game is {myOtherGame.title} and it is a {myOtherGame.genre} game!"); //It prints the default value stated in Class.cs
        }
    }
}
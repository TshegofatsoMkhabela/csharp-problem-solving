using System;

class Program
{
    static void Main()
    {
        // Define an array of Pokemon names 
        string[] pokemons = {"Pikachu", "Bulbasaur", "Charmander", "Squirtle" };

        // Print each Pokemon name on a new line
        foreach (string pokemon in pokemons) 
        {
            Console.WriteLine(pokemon);
        }

        // Wait for user input before closing the console
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
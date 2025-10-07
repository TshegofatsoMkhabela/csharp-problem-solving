using System;

class Program
{
    static void Main()
    {
        int variableA = 6;
        int variableB = 7;

        // Swap the values of variableA and variableB
        (variableA, variableB) = (variableB, variableA);

        Console.WriteLine($"Variable A is now: {variableA} and Variable B is now: {variableB}");
    }
}
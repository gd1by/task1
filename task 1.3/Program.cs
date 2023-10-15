using System;

class Program
{
    static void Main()
    {
        // Create an array of engine powers for 30 car models
        int[] enginePowers = { 180, 220, 190, 205, 210, 175, 195, 215, 198, 202, 188, 230, 185, 195, 199, 205, 215, 180, 185, 192, 220, 240, 175, 210, 196, 206, 198, 190, 195, 215 };

        bool hasModelWithHighPower = false;

        // Check each model in the array
        foreach (int power in enginePowers)
        {
            if (power > 200)
            {
                hasModelWithHighPower = true;
                Console.WriteLine($"Model with engine power > 200 hp: {power} hp");
            }
        }

        if (hasModelWithHighPower)
        {
            Console.WriteLine("There is a model with engine power exceeding 200 hp.");
        }
        else
        {
            Console.WriteLine("There is no model with engine power exceeding 200 hp.");
        }
    }
}

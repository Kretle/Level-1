using System;

var Random = new Random();
int strengthTotal = 0;
for (int counter = 0; counter < 3; counter++)
{
    int strengthScore = Random.Next(1, 7);
    strengthTotal += (strengthScore);
}
Console.WriteLine($"A character with strength {strengthTotal} was created.");

int cubeHP = 0;
for (int counter2 = 0; counter2 < 8; counter2++)
{
    int cubeRoll = Random.Next(1, 11);
    cubeHP += (cubeRoll);
}
Console.WriteLine($"A gelatinous cube with {cubeHP + 40} HP appears!");

int cubeArmyTotalHP = 0;
for (int counter3 = 0; counter3 < 100; counter3++)
{
    for (int cubeCounter = 0; cubeCounter < 8; cubeCounter++)
    {
        int cubeRoll = Random.Next(1, 11);
        cubeArmyTotalHP += (cubeRoll);
    }
}
Console.WriteLine($"Dear gods, an army of 100 cubes descends upon us with a total of {cubeArmyTotalHP + 40 * 100} HP. We are doomed!");

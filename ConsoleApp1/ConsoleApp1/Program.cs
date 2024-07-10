using System;
using System.ComponentModel.Design;
using System.Linq;

var random = new  Random();
int diceRoll = random.Next(1, 7);
int total = (diceRoll);
Console.WriteLine("The player rolls: " + diceRoll);
while (diceRoll < 6)
{
    diceRoll = random.Next(1, 7);
    Console.WriteLine("The player rolls: " + diceRoll);
    total += diceRoll;
}
if (diceRoll == 6)
    Console.WriteLine("Total score: " + total);

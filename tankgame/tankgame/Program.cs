using System;
using System.Text;

var random = new Random();
int tankDistance = random.Next(40, 71);

Console.WriteLine("DANGER!!! A tank is approaching our position. Your artilery unit is our only hope! \n");
Console.WriteLine("What is your name, Commander?");
string playerName = Console.ReadLine();
Console.WriteLine("Commander name: " + playerName);

Console.WriteLine("Here is a map of the battlefield, " + playerName + ": \n");
string battlefield = "_/_______________________________________________________________________________";
var battlefield_ = battlefield.Substring(0, tankDistance) + "T" + battlefield.Substring(tankDistance + 1);
Console.WriteLine(battlefield_);
int bullets = 5;

do
{
    Console.WriteLine("Aim your shot Commander! " + bullets + " shots remain.");
    string artillery = Console.ReadLine();
    int myInt = 0; // Int32.Parse(artillery);

    if (Int32.TryParse(artillery, out int myInt2))
    {
        myInt = myInt2;
    }
    else
    {
        continue;
    }

    string battlefieldEmpty = ("                                                                                ");
    var artillery__ = battlefieldEmpty.Substring(0, myInt) + "*";
    Console.WriteLine(artillery__);
    bullets--;

    {

        if (myInt == tankDistance)
        {
            Console.WriteLine("Direct hit! Great work Commander " + playerName + "! " + "You had " + bullets + " shots remaining!");
            break;
        }
        else if (bullets == 0)
        {
            Console.WriteLine("You have used up all your remaining ammunition and the tank still stands, Commander " + playerName + ". Game over.");
        }
        else if (myInt > tankDistance)
        {
            Console.WriteLine("You fired too far! Try again, Commander. You have " + bullets + " shots remaining.");
        }
        else if (myInt < tankDistance)
        {
            Console.WriteLine("You fired too close! Try again, Commander. You have " + bullets + " shots remaining.");
        }
  
    }
} while (bullets > 0);

// _/______________________________________________________________________________
//"                                                                                "
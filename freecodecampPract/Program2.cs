// Using Random.Next() method simulate three six-sided dice.

// - Evaluate the rolled values to calculate the score.
// - If the score is greater than an arbitrary total, display a winning message to the user.
// - If the score is below the cutoff, display a losing message to the user.

If any two dice you roll result in the same value, you get two bonus points for rolling doubles.
If all three dice you roll result in the same value, you get six bonus points for rolling triples.
If the sum of the three dice rolls, plus any point bonuses, is 15 or greater, you win the game. Otherwise, you lose.


Random dice = new Random();

int dice1 = dice.Next(1, 7);
int dice2 = dice.Next(1, 7);
int dice3 = dice.Next(1, 7);

int arbitraryTotal = 16;

int rollTotal = dice1 + dice2 + dice3;

Console.WriteLine($"Dice rolled: {dice1} + {dice2} + {dice3} = {rollTotal}");

if ((dice1 == dice2) || (dice1 == dice3) || (dice2 == dice3))
{
    if ((dice1 == dice2) && (dice2 == dice3))
    {
        Console.WriteLine("You rolled triples! +6 bonus to rolltotal! ---");
        Console.WriteLine($"Score due to triples {rollTotal += 2}");
    }
    else // Double check both statement
    {
        Console.WriteLine("You rolled doubles! +2 bonus to rolltotal!");
        Console.WriteLine($"Score due to doubles {rollTotal += 2}");
    }
}

if (rollTotal >= arbitraryTotal)
{
    Console.WriteLine("You win a new car!");
}
else if (rollTotal >= 10)
{
    Console.WriteLine("You win a new laptop!");
}
else if (rollTotal == 7)
{
    Console.WriteLine("You win a trip!");
}
else
{
    Console.WriteLine("You win a kitten");
}


// string message = "The quick brown fox jumps over the lazy dog.";
// bool result = message.Contains("dog");
// Console.WriteLine();
// Console.WriteLine(result);

// if (message.Contains("fox"))
// {
//     Console.WriteLine("What does the fox say?");
// }
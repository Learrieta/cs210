Random randomG = new Random();
int number = randomG.Next(1,10);
Console.WriteLine($"This is the magic number: {number}");

string input = "yes";

while (input == "yes"){

    Console.WriteLine("What is your guess?");
    int answer = int.Parse(Console.ReadLine());


    if (answer > number){
        Console.WriteLine("Lower!");
    }else if (answer < number)  {
        Console.WriteLine("Higher");
    }else {
        Console.WriteLine("You guessed it!");
        input = "no";
    }

}


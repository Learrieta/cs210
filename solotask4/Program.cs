using System.Collections.Generic;


List<int> numbers = new List<int> ();

Console.WriteLine("Enter a list of numbers, type 0 when finished:");

int number = -1;

while (number !=0){
    int answer = Int32.Parse(Console.ReadLine());

    if (answer > 0){
        numbers.Add(answer);
    }else {
        number = 0;
        foreach(int numbero in numbers){
            Console.Write($"{numbero},");
            
        }
        Console.WriteLine();
        int sum  = numbers.Sum();
        Console.WriteLine($"The total sum is {sum}.");
        double average = Queryable.Average(numbers.AsQueryable());
        Console.WriteLine($"The Average is: {average}.");
        int largest = numbers.Max();
        Console.WriteLine($"Largest number is: {largest}.");
    }
    

}


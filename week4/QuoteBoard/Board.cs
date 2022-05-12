public class Board{
    List<Quote> quotes = new List<Quote>();

    public void NicePrint(string item){
        Console.WriteLine("---------------------------------");
        Console.WriteLine($"{item}");
        Console.WriteLine("---------------------------------");

    }

    public void ShowQuotes(){
        foreach(Quote quote in quotes){
            NicePrint(quote.GetQuote());
        }
    }
    public void AddQuote( Quote quote){
        quotes.Add(quote);
    }
    public void GetRandomQuote(){
        var random = new Random();
        var rNum = random.Next(0, quotes.Count);
        NicePrint(quotes[rNum].GetQuote());
    }
}
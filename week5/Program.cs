

VendingMachine v = new VendingMachine();
v.Populate();
v.getList();

public class Item{
    private string name;
    private double price ;
    private string location;
    private int quantity;



    public Item(string name, double price, string location, int quantity = 1){
        this.name = name;
        this.price = price;
        this.location = location;
        this.quantity = quantity;
    }
    private double totalValue(){
        return quantity * price;
    }
    public void ShowItem(){
        Console.WriteLine($"{name} - {price} - {location} QTY:{quantity}");
        Console.WriteLine($"Total Value: {totalValue()}");
    }

}

public class VendingMachine{
   private  List<Item> items  = new List<Item>();

    public VendingMachine(){
        Console.WriteLine("I am a vending machine");
    } 
    public void Populate(){
        items.Add(new Item("doritos", 2.5,"A2"));

    }
    public void  getList(){
        foreach (Item item in items){
            item.ShowItem();
            
        }
        
    }
    }
class Car {
    public string model;
    public string make;
    public int year
    public int milesPerGallon;
    public int gallons;
    public Person Owner;

    public Car(string make, string model, int milesPerGallon, int gallons) {
        this.model = model;
        this.make = make;
        this.milesPerGallon = milesPerGallon;
        this.gallons = gallons;
    }

    public int TotalRange() 
    {
        return gallons * milesPerGallon;
    }

    public void Display() 
    {
         System.Console.WriteLine($"{c.make} {c.model} {c.gallons} gallons {c.milesPerGallon}mpg": TotalRange = {c.TotalRange()});
    }
}


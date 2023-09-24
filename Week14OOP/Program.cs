//OOP - Objekt orienteeritud programmeerimine

Console.WriteLine("Name your dog:");
string myDogName = Console.ReadLine();
Dog myDog = new Dog(myDogName); //Dog = class; myDog = object 

Dog neighboursDog = new Dog("Good girl");

Console.WriteLine($"My dogs name is {myDog.Name}.");
Console.WriteLine($"My neighbours dog name is {neighboursDog.Name}.");

myDog.Rename("Bad boy");
Console.WriteLine($"Level of happiness: {myDog.LevelOfHapiness}");

while (myDog.LevelOfHapiness != 5 )
{
    myDog.Bark();
}

myDog.WagTail();


class Dog
{
    private string _name; //private tähendab et väli "_name" ei ole väljaspool klassi kättesaadav
    private int _levelOfHapiness;

    //constuctor
    public Dog(string name) //name - lets the user name the dog
    {
        _name = name;
        _levelOfHapiness = 0;
    }

    //getter - on selleks et ainult kuvada aga ümber nimetada ei saa
    public string Name
    { 
        get { return _name;} 
    }   
    public int LevelOfHapiness
    {
        get { return _levelOfHapiness;}
    }

    public void Rename(string newName)
    {
        _name = newName;
        Console.WriteLine($"The dog has been rename to: {newName}");
    }

    public void Bark()
    {
        Console.WriteLine("Woof-woof");
        _levelOfHapiness++;
    }

    public void WagTail()
    {
        Console.WriteLine("Wiggle-wiggle");
    }
}
    
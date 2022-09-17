using Practice2;

internal class MainClass
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello buddies!!");
        Person person1 = new("12po!", "Juan", "Valenzuela", 19, "Man", "Cevrolet", "Yellow");
        person1.addVehicle(new("10/02/2007", "Mamalonas", "Red", "Ford", "A", "A very nice car", "ss1"));
        person1.addLicense(new("A", "10/12/2020", "10/12/2023", person1.getKeyCode()));
    }
}
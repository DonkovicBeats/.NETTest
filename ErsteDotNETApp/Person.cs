namespace ErsteDotNETApp;

public class Person
{
    private int height;

    public int Height
    {
        get => height;
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                height = value;
            }
        }
    }

    public Person(int height)
    {
        Height = height;
        Console.WriteLine($"Person with Height of: {Height}cm initialized.");
    }
   
}
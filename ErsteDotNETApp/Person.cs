namespace ErsteDotNETApp;

public class Person : Animal
{
    public int Height
    {
        get;
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                field = value;
            }
        }
    }

    public string? Name
    {
        get;
        set
        {
            if (value is null)
                throw new NullReferenceException();
            
            else
            {
                field = value;
            }
        }
    }

    public Person(string name)
    {
        Console.WriteLine("Größe: ");
        
        while (true)
        {
            
            string? input = Console.ReadLine();
            if (int.TryParse(input, out int result))
            {
                Height = result;
                break;
            }
            else
            {
                Console.WriteLine("Ungültige Eingabe.");
                throw new ArgumentException();
            }

            
        }

        Console.WriteLine($"Person with Height of: {Height}cm initialized.");
        Heartbeat();
    }


}
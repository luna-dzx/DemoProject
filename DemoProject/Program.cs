namespace DemoProject;

public class Program
{
    
    public static String Version {
        get {
            return System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }
    }

    
    public static void Main(string[] args)
    {
        Console.WriteLine("Goodbye World | Version: "+ Version);
    }
}

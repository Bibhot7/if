namespace iszaf;

internal class Program
{
    static void Main(string[] args)
    {
        //if statements practice.
        Console.WriteLine( "what is temperature like?");
        string temperature =  Console.ReadLine();   
        //conversing string into num
        int numTemp = int.Parse(temperature);

        if (numTemp < 20)
        {
            Console.WriteLine("its less than 20 degrees outside");
        }

        else if (numTemp == 20)
        {
            Console.WriteLine( "temperature is exactly 20 degrees");
        }

        else (numTemp > 20)
        {
            Console.WriteLine( "it kinda hot outside");
        }
    }
}

// See https://aka.ms/new-console-template for more information
namespace mijnApp
{
    public class oefening3
    {
        public static void Main(String[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                int resultaat = i * 7; 
                Console.WriteLine(resultaat);

                if (resultaat >= 546)
                {
                    break;
                }
            }
        }
    }
}

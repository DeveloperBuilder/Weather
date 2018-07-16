using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather
{
    class Program
    {        
        /* Instructies
        Maak een applicatie Weather. De applicatie Weather heeft een class Weather. 
        De class Weather heeft een instance variabele producten, wat een array is.
        Het arrayobject, bevat objecten van het type Temperature.
        De class Temperature heeft de string sun en de int windspeed als attributen. Maak de class Temperature abstract.
        Maak van Temperature twee subclasses, namelijk Warm en Cold en initialiseert in de subclasses voor ieder attribuut een waarde. 
        Laat in een demo-applicatie zien dat er Warm en Cold in de Weather geplaatst kunnen worden. */

        static void Main(string[] args)
        {
        }
    }

    public class Weather
    {
        public List<Temperature> temperature;

        public Weather()
        {
            temperature = new List<Temperature>();
        }
    }

    public abstract class Temperature
    {
        public string Sun;
        public int Windspeed;
    }

    public class Warm : Temperature
    {
        public void Sunshine(String Sun)
        {
            Sun = "VeryHot";
        }
    }

    public class Cold : Temperature
    {
        public void Wind(int Windspeed)
        {
            Windspeed = 15;
        }
    }
}

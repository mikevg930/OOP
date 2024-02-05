using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Lightbulb
    {
        private string ConnectionType;
        private string Type;
        private string Colour;
        private int Wattage;

        public Lightbulb(string colour, string type, string connectiontype, int wattage)
        {
            Colour = colour;
            Type = type;
            ConnectionType = connectiontype;
            Wattage = wattage;
        }

        public int getWattage()
        {
            return Wattage;
        }

        public string getColour()
        {
            return Colour;
        }

        public string getType()
        {
            return Type;
        }

        public string getConnectionType()
        {
            return ConnectionType;
        }

        public void setWattage(int newwattage)
        {
            Wattage = newwattage;
        }

        public void setColour(string newcolour)
        {
            Colour = newcolour;
        }

        public void setType(string newtype)
        {
            Type = newtype;
        }

        public void setConnectionType(string newconnectiontype)
        {
            ConnectionType = newconnectiontype;
        }

        public static void BulbTests()
        {
            Lightbulb bulb = new Lightbulb("blue", "LED", "Screw", 50);

            Console.WriteLine(bulb.getConnectionType());
            Console.WriteLine(bulb.getColour());
            Console.WriteLine(bulb.getType());
            Console.WriteLine(bulb.getWattage());

            bulb.setColour("green");
            bulb.setType("flourescent");
            bulb.setWattage(100);
            bulb.setConnectionType("socket");

            Console.WriteLine(bulb.getConnectionType());
            Console.WriteLine(bulb.getColour());
            Console.WriteLine(bulb.getType());
            Console.WriteLine(bulb.getWattage());


        }
    }


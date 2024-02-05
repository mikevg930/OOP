using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Abstract
{

}

public abstract class Canine
{
    protected string Breed;
    protected string Colour;
    protected int Age;

    public void Woof() { }
    public void OtherThings() { }
    public static void CanineTests()
    {
        Dog Dog1 = new Dog("pug", "brown", 3);
    }
    public Canine(string myBreed, string myColour, int myAge)
    { 
        Breed = myBreed;
        Colour = myColour;
        Age = myAge;

        foreach (string Realbreed in GetRealBreeds())
        {
            if (Realbreed != myBreed)
            {
                throw new Exception("Not an acceptable breed");
            }
        }
    }

    public abstract List<string> GetRealBreeds();
    
}

public class Dog : Canine
{
    List<string> RealBreeds = new List<string> { "Pug", "Doberman", "Husky", "Maltese"}; 
    public Dog(string myBreed, string myColour, int myAge) : base(myBreed, myColour, myAge)
    {

    }
    override public List<string> GetRealBreeds() { return RealBreeds; }

}
public class Fox : Canine
{
    List<string> RealBreeds = new List<string> { "Snow", "Urban", "Wild", "Desert" };
    public Fox(string myBreed, string myColour, int myAge) : base(myBreed, myColour, myAge) 
    {
    
    }

    override public List<string> GetRealBreeds() { return RealBreeds; }
}






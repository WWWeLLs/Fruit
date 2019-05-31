using System;

namespace Fruit
{
    public class Fruit
    //CREATE NEW CLASS CALLED FRUIT
    //Your new class file will house your parent class and any subclasses that you create
    {
        //CREATE FRUIT CHARACTER PROPERTIES
        public string _name { set; get; }

        public string _type { set; get; }
        public string _color { set; get; }

        //CREATE FRUIT CONSTRUCTOR/ PARAMETERS
        public Fruit(string name, string type, string color)
        {
            _name = name;
            _type = type;
            _color = color;
            Console.WriteLine("Fruit becomes real Characters");
        }

        //FRUIT METHOD 1
        public void flavor(string flavorBurst)
        {
            Console.WriteLine("Hello my flavor {0}", _name, flavorBurst);
        }
    }

    public class Pineapple : Fruit
    {
        //PROPERTIES
        public string _emotion { set; get; }

        //CONSTRUCTOR
        public Pineapple(string name, string type, string color, string emotion) : base(name, type, color)
        {
            _name = name;
            _type = type;
            _color = color;
            _emotion = emotion;
        }

        public void loving(string loving)
        {
            Console.WriteLine("Hello my I love {0}", _name, loving);
        }



    }
}

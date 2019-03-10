using System;
namespace Application
{
    public class Pet
    {
        public string type;
        public string name;
        public string owner;
        public double weight;

      
        public Pet(string type, string name, string owner, double weight)
        {
            this.type = type;
            this.name = name;
            this.owner = owner;
            this.weight = weight;
        } //end Pet method

        public string GetTag()
        {
            return "If lost, call " + owner;
        }

    } // end Class Pet
} // end namespace

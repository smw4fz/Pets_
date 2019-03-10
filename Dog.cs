using System;
namespace Pets
{
    public class Dog
    {
        internal string name;
        internal string weight;
        private string v1;
        private double v2;

        public Dog(string v)
        {
        }

        public Dog(string v, string v1, double v2) : this(v)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        internal bool bark(int v)
        {
            throw new NotImplementedException();
        }
    }
}

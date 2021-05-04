using System.Collections.Generic;
namespace RRModels
{
    public class Restaurant
    {
        // A property is a member that provides a flexible mechanism to read, write, or compute the value of a private field.
        // Properties can be used as if they are public data members, but they are actually special methods called accessors.
        // This enables data to be accessed easily and still helps promote the safety and flexibility of methods.
        public string Name { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public Cuisine Cuisine { get; set; }
        public List<Review> Reviews { get; set; }

        public override string ToString()
        {
            return $" Name: {Name} \n Location: {City}, {State} \n Cuisine: {Cuisine}";
        }

    }
}
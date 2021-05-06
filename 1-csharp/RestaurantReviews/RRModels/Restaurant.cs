using System.Collections.Generic;
/// <summary>
/// Namespace for the models/custom data structures involved in Restaurant Reviews
/// </summary>
namespace RRModels
{
    /// <summary>
    /// Data structure used to define a restaurant 
    /// </summary>
    public class Restaurant
    {
        // Class Members
        // 1. Constructor - use this to create an instance of the class
        // 2. Fields - defines the characteristics of a class
        // 3. Methods - defines the behavior of a class
        // 4. Properties - also known as smart fields, are accessor methods used to access private backing fields (private fields)
        // *Note that properties are analogous to Java getter and setter
        // * Property naming convention uses PascalCase (like methods)
        public Restaurant(string name, string city, string state)
        {
            this.Name = name;
            this.City = city;
            this.State = state;
        }
        public Restaurant()
        {

        }
        /// <summary>
        /// This describes the name of your restaurant
        /// </summary>
        /// <value></value>
        public string Name { get; set; }
        /// <summary>
        /// This describes the location
        /// </summary>
        /// <value></value>
        public string City { get; set; }
        /// <summary>
        /// This describes the location
        /// </summary>
        /// <value></value>
        public string State { get; set; }
        /// <summary>
        /// This contains the review of a particular restaurant
        /// </summary>
        /// <value></value>
        public List<Review> Reviews { get; set; }
        public override string ToString()
        {
            return $" Name: {Name} \n Location: {City}, {State}";
        }
        public bool Equals(Restaurant restaurant)
        {
            return this.Name.Equals(restaurant.Name) && this.City.Equals(restaurant.City) && this.State.Equals(restaurant.State);
        }
    }
}
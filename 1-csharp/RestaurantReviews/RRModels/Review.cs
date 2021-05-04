namespace RRModels
{
    /// <summary>
    /// Data structure for storing reviews
    /// </summary>
    public class Review
    {
        /// <summary>
        /// Numeric rating of the overall restaurant experience
        /// </summary>
        /// <value></value>
        public int Rating { get; set; }
        /// <summary>
        /// Notes on the restaurant experience
        /// </summary>
        /// <value></value>
        public string Description { get; set; }
        /// <summary>
        /// Method used to print the data in string format, by default returns the class name
        /// stored in stack
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"\t Rating: {Rating} \n\t Description: {Description}";
        }
    }
}
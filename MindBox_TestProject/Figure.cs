namespace Forms
{
    public abstract class Figure
    {
        /// <summary>
        /// Figure area
        /// </summary>
        private protected double? Area { get; set; }
        /// <summary>
        /// Abstract method of calculating figure area
        /// </summary>
        /// <returns>Area of figure</returns>
        public abstract double GetArea();
    }
}

namespace Forms
{
    public class Triangle : Figure
    {
        /// <summary>
        /// Edges of triangle
        /// </summary>
        public double FirstEdge { get; }
        public double SecondEdge { get; }
        public double ThirdEdge { get; }
        public Triangle(double firstEdge, double secondEdge, double thirdEdge) : base()
        {
            FirstEdge = firstEdge;
            SecondEdge = secondEdge;
            ThirdEdge = thirdEdge;

            if (!IsTriangleExists())
                throw new ArgumentException("Triangle with given sides doesn't exist");
        }
        /// <summary>
        /// method of calculating triangle area
        /// First time area calculates and puts into "Area" field,
        /// then on subsequent calls, returns the value from that field
        /// </summary>
        /// <returns>area of triangle</returns>
        public override double GetArea()
        {
            if (Area is not null)
                return Area.Value;

            double p = (FirstEdge + SecondEdge + ThirdEdge) / 2;

            Area = Math.Sqrt(p * (p - FirstEdge) * (p - SecondEdge) * (p - ThirdEdge));
            return Area.Value;
        }
        /// <summary>
        /// Сhecking for negative sides and fulfilling the triangle rule
        /// </summary>
        /// <returns> true if triangle with given sides exists</returns>
        private bool IsTriangleExists()
        {
            return (FirstEdge > 0 && SecondEdge > 0 && ThirdEdge > 0)
                   && (FirstEdge + SecondEdge > ThirdEdge)
                   && (FirstEdge + ThirdEdge > SecondEdge)
                   && (SecondEdge + ThirdEdge > FirstEdge);
        }
        /// <summary>
        ///  Сhecking that the sum of the squares of the two smaller sides is equal to the area of ​​the larger 
        /// </summary>
        /// <returns>true if triangle is right</returns>
        public bool IsRightTriangle()
        {
            double maxEdge = new[] { FirstEdge, SecondEdge, ThirdEdge }.Max();

            // a^2 + b^2 + c^2 = 2 * c^2
            return Math.Abs(FirstEdge * FirstEdge + SecondEdge * SecondEdge + ThirdEdge * ThirdEdge - 2 * maxEdge * maxEdge) < Double.Epsilon;
        }
    }

    public class Circle : Figure
    {
        /// <summary>
        /// Radius of circle
        /// </summary>
        public double Radius { get; }
        public Circle(double radius)
        {
            Radius = radius;

            if (radius <= 0)
                throw new ArgumentException("Radius can't be negative or zero");
        }
        /// <summary>
        /// method of calculating circle area
        /// </summary>
        /// <returns>area of circle</returns>
        public override double GetArea()
        {
            if (Area is not null)
                return Area.Value;

            Area = Math.PI * Radius * Radius;
            return Area.Value;
        }
    }
}

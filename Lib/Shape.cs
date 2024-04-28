namespace Lib
{
    //Решил сделать абстрактный класс фигуры, от которого наследуются реализуемые фигуры, можно было бы и через интерфейс, но на мой взгляд в данном случае лучше абстрактный класс
    public abstract class Shape
    {
        public abstract double GetArea();
    }
    public class Circle: Shape
    {
        public double Radius { get; private set; }
        /// <summary>
        /// Конструктор инициализации для круга
        /// </summary>
        /// <param name="radius">Радиус круга</param>
        public Circle(double radius)
        {
            Radius = radius;
        }
        /// <summary>
        /// Возвращает площадь круга
        /// </summary>
        /// <returns></returns>
        public override double GetArea()
        {
            return Math.PI*Math.Pow(Radius, 2);
        }
    }
    public class Triangle : Shape
    {
        public double Edge1{ get; private set; }
        public double Edge2 { get; private set; }
        public double Edge3 { get; private set; }
        /// <summary>
        /// Конструктор инициализации для треугольника
        /// </summary>
        /// <param name="edge1">Длина первого ребра</param>
        /// <param name="edge2">Длина второго ребра</param>
        /// <param name="edge3">Длина третьего ребра</param>
        public Triangle(double edge1, double edge2, double edge3)
        {
            if (edge1+edge2 > edge3 && edge1+edge3>edge2 && edge2 + edge3 > edge1)
            {
                Edge1 = edge1;
                Edge2 = edge2;
                Edge3 = edge3;
            }
            else
            {
                throw new ArgumentException("Треугольник с такими сторонами не существует");
            }
        }
        /// <summary>
        /// Возвращает площадь треугольника
        /// </summary>
        /// <returns></returns>
        public override double GetArea()
        {
            //По формуле Герона
            double semiPerimeter = (Edge1 + Edge2 + Edge3) / 2;
            return Math.Sqrt(semiPerimeter*(semiPerimeter-Edge1)*(semiPerimeter-Edge2)*(semiPerimeter-Edge3));
        }
        /// <summary>
        /// Проверка на прямоугольность треугольника
        /// </summary>
        /// <returns></returns>
        public bool IsRectangularTriangle()
        {
            List<double> edges = new List<double>(){Edge1,Edge2,Edge3};
            double maxEdge = edges.Max();
            edges.Remove(maxEdge);
            if (Math.Pow(maxEdge, 2) == Math.Pow(edges[0], 2) + Math.Pow(edges[1], 2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

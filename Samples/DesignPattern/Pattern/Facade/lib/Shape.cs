namespace Facade
{
    public interface Shape
    {
        void Draw();
    }

    public class Rectangle : Shape
    {
        public void Draw()
        {
            Console.WriteLine("rectangle");
        }
    }

    public class Circle : Shape
    {
        public void Draw()
        {
            Console.WriteLine("circle");
        }
    }

    public class ShapeCreator
    {
        private Shape rectangle;
        private Shape circle;
        public ShapeCreator()
        {
            this.rectangle = new Rectangle();
            this.circle = new Circle();
        }
        public void DrawRectangle()
        {
            this.rectangle.Draw();
        }
        public void DrawCircle()
        {
            this.circle.Draw();
        }
    }
}
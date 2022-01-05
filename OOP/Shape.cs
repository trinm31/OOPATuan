namespace OOP
{
    public class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Shape(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public Shape()
        {
            
        }
        //override method
        public virtual string Test()
        {
            return "This is from shape class";
        }
    }
}
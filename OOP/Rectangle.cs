namespace OOP
{
    public class Rectangle:Shape
    {
        public int Deep { get; set; }
        public Rectangle(int width, int height, int deep) : base(width, height)
        {
            Deep = deep;
        }

        public Rectangle()
        {
            
        }
        
        public int GetArea()
        {
            return Width * Height ;
        }
         
        public int GetTheTich()
        {
            return Width * Height*Deep;
        }
    }
}
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
        
        //Overload
        public void Resize(int sameSize)
        {
            Width = sameSize;
            Height = sameSize;
        }
        
        public void Resize(int width, int height)
        {
            Width = width;
            Height = height;
        }
        
        public void Resize(double width, double height)
        {
            Width = (int)width;
            Height = (int)height;
        }
        
        //overwriting

        public override string Test()
        {
            return base.Test() + "But now it is modified by rectangle classs";
        }
    }
}
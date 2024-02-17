using system;

namespace RectApp
{
    class rectangle
    {
        // member variables
        public double length;
        public double width;
    }

    public double GetArea()
    {
        return length * width;
    }
    public void Display()
    {
        console.writeline("length: {0}", length);
        console.writeline("width: {0}", width);
        console.writeline("area: {0}", GetArea());
    }
  
    class ExeciteRect
    {
        static void main(string[] args)
        {
            rectangle r = new rectangle();
            r.length = 4.5;
            r.width = 3.5;
            r.Display();
            console.writeline("area: {0}", r.GetArea());
        }
    }

}

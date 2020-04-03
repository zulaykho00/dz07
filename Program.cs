using System;

namespace ddzz7
{
    class Rectangle
    {
         double side1,side2,area,perimeter;
         public double Area{get{return area;} }
         public double Perimeter{get{return perimeter;} }
          
        public Rectangle(double side1,double side2)
        {
            this.side1=side1;
            this.side2=side2;
    
        }
       public  void AreaCalculator()
        {
            area=side1*side2;
          
        }
        public void PerimeterCalculator()
        {
           perimeter=2*(side1+side2);
         
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        double side1,side2;
        Console.Write("side1=");
        side1=Convert.ToDouble(Console.ReadLine());
        Console.Write("side2=");
        side2=Convert.ToDouble(Console.ReadLine());
        Rectangle ABC=new Rectangle(side1,side2);
        ABC.AreaCalculator();
        ABC.PerimeterCalculator();
        Console.WriteLine(ABC.Area);
        Console.WriteLine(ABC.Perimeter);

        }
    }
}

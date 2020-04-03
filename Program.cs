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
    
    class Book
    {
        public Title title=new Title();
        public Author author=new Author();
        public Content content=new Content();
        public void Show()
        {
            Console.WriteLine("Информация о книге:");
            Console.ForegroundColor=ConsoleColor.Yellow;
            title.Show();
            Console.ForegroundColor=ConsoleColor.Blue;
            author.Show();
            Console.ForegroundColor=ConsoleColor.DarkRed;
            content.Show();
            Console.ForegroundColor=ConsoleColor.White;
        }
    }
    class Title
    {
        public string title{get;set;}
        public void Show()
        {
            Console.WriteLine($"Название книги: {title}");
        }
    }
    class Author
    {
        public string author{get;set;}
        public void Show()
        {
            Console.WriteLine($"Автор книги: {author}");
        }
    }
    class Content
    {
        public string content{get;set;}
        public void Show()
        {
            Console.WriteLine($"Содержание книги: {content}");
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("ZADANIE#2");
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
        
        Console.WriteLine("ZADANIE#3");
        string t,a,c;
        Book x=new Book();
        Console.WriteLine("Название книги: ");
        t=Console.ReadLine();
        Console.WriteLine("Автор книги: ");
        a=Console.ReadLine();
        Console.WriteLine("Содержание книги: ");
        c=Console.ReadLine();
        x.title.title=t;
        x.author.author=a;
        x.content.content=c;
        x.Show();

        }
    }
}

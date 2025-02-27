using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5_C2
{
    //commit lan 3
    enum Color
    {
        LightBlue,
        BloodRed,
        Gold 
    }
    class Point
    {
        public int x_224 { set; get; }
        public int y_224 { set; get; }
        public Color color {set; get;}

        public Point(int x_224, int y_224, Color color)
        {
            this.x_224 = x_224;
            this.y_224 = y_224;
            this.color = color;
        }

      

        public String GetInfo()
        {
            return String.Format($"positon x: {this.x_224}, y: {this.y_224}, Color: {color}");
        }

    }

    class Rectangle
    {
        public Point UppreLeft_224 { set; get; }
        public Point BottomRight_224 { set; get; }

        public Rectangle(Point x_224, Point y_224)
        {
            this.UppreLeft_224 = x_224;
            this.BottomRight_224 = y_224;
        }

        public void GetInfo()
        {
            Console.WriteLine("Toa do la: ");
            Console.WriteLine("UpperLeft: " + UppreLeft_224.GetInfo());
            Console.WriteLine("BottomRight: " + BottomRight_224.GetInfo());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Point point1_224 = new Point(3, 4, Color.BloodRed);
            Point point2_224 = new Point(5, 7, Color.LightBlue);
            Console.WriteLine(point2_224.GetInfo());

            Rectangle rectangle = new Rectangle(point1_224, point2_224);
            rectangle.GetInfo();
            Console.ReadKey();
        }
    }
}

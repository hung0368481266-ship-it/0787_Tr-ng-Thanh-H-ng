using System;
class PTB1
{
    public void Giai(double a, double b)
    {
        if (a == 0)
        {
            if (b == 0) Console.WriteLine("Phuong trinh vo so nghiem");
            else Console.WriteLine("Phuong trinh vo nghiem");
        }
        else
        {
            double x = -b / a;
            Console.WriteLine("Nghiem x = " + x);
        }
    }
}
class PTB2 : PTB1
{
    public void Giai(double a, double b, double c)
    {
        if (a == 0)
        {
            Console.WriteLine("→ Day la phuong trinh bacc 1");
            base.Giai(b, c); 
            return;
        }
        double delta = b * b - 4 * a * c;
        if (delta < 0)
            Console.WriteLine("Phuong trinh vo nghiem");
        else if (delta == 0)
            Console.WriteLine("Phuong trinh co nghiem kep x = " + (-b / (2 * a)));
        else
        {
            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
            Console.WriteLine("Phuong trinh co 2 nghiem: x1 = {0}, x2 = {1}", x1, x2);
        }
    }
}
class Program
{
    static void Main()
    {
        PTB2 pt = new PTB2();
        Console.Write("Nhap a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Nhap b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Nhap c: ");
        double c = double.Parse(Console.ReadLine());
        pt.Giai(a, b, c);
    }
}
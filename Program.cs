Console.WriteLine("Задание 1");
Console.WriteLine("Создать класс Triangle для представления треугольника. Поля данных должны включать углы и стороны. Требуется реализовать операции: получения и изменения полей данных, вычисления площади, вычисления периметра, вычисления высот, а также определения вида прямоугольника (равносторонний, равнобедренный или прямоугольный).");

double side1 = 0, side2 = 0, side3 = 0, angle1 = 0, angle2 = 0, angle3 = 0;
bool inputSuccess = false;

while (inputSuccess == false)
{
    try
    {
        Console.WriteLine("Введите длину сторон и углы треугольника.");
        Console.Write("Введите сторону А: ");
        side1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите сторону В: ");
        side2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите сторону С: ");
        side3 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите угол 1: ");
        angle1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите угол 2: ");
        angle2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите угол 3: ");
        angle3 = Convert.ToDouble(Console.ReadLine());
        if ((angle1 + angle2 + angle3 == 180) & (side1 + side2 > side3) & (side1 + side3 > side2) & (side2 + side3 > side1) & (angle1 != 0 & angle2 != 0 & angle3 != 0))
        {
            inputSuccess = true;
        }
    }
    catch
    {
        Console.WriteLine("Ошибка ввода данных. Повторите попытку.");
    }
}

Triangle triangle = new Triangle(side1, side2, side3, angle1, angle2, angle3);

Console.WriteLine("S треугольника: " + triangle.CalculateArea());
Console.WriteLine("P треугольника: " + triangle.CalculatePerimeter());
Console.WriteLine("H(А) треугольника: " + triangle.CalculateHeight());
Console.WriteLine("Тип треугольника: " + triangle.GetTypeOfTriangle());


class Triangle
{
    private double sideA, sideB, sideC;
    private double angleA, angleB, angleC;

    public Triangle(double a, double b, double c, double angle1, double angle2, double angle3)
    {
        sideA = a;
        sideB = b;
        sideC = c;
        angleA = angle1;
        angleB = angle2;
        angleC = angle3;
    }

    public double SideA { get; set; }
    public double SideB { get; set; }
    public double SideC { get; set; }
    public double AngleA { get; set; }
    public double AngleB { get; set; }
    public double AngleC { get; set; }

    public double CalculateArea()
    {
        double s = (sideA + sideB + sideC) / 2;
        double area = Math.Sqrt(s * (s - sideA) * (s - sideB) * (s - sideC));
        return area;
    }

    public double CalculatePerimeter()
    {
        return sideA + sideB + sideC;
    }

    public double CalculateHeight()
    {
        double height = (2 * CalculateArea()) / sideA;
        return height;
    }

    public string GetTypeOfTriangle()
    {
        if (sideA == sideB && sideB == sideC)
        {
            return "Равносторонний треугольник";
        }
        else if (sideA == sideB || sideA == sideC || sideB == sideC)
        {
            return "Равнобедренный треугольник";
        }
        else if (angleA == 90 || angleB == 90 || angleC == 90)
        {
            return "Прямоугольный треугольник";
        }
        else
        {
            return "Скалярный треугольник";
        }
    }
}
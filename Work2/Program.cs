// Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
//задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

/*математическое решение: k1X+b1 = k2X+b2
                          k1X-k2X = b2-b1
                          x = b2-b1/k1-k2 
                          y = k1 * (b2-b1/k1-k2) + b1  */

int GetCoordinat (string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}

double IntersectionPointX (double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    return x;
}

double IntersectionPointY (double b1, double k1, double b2, double k2)
{
    double y = k1 * ((b2 - b1) / (k1 - k2)) + b1;
    return y;
}

void CheckAndPrintXY (double x, double y, double b1, double k1, double b2, double k2)
{
    if((k1 == k2) && (b1 == b2))
        Console.WriteLine("Прямые проходят по одним и тем же точкам");
    else if(k1==k2)
        Console.WriteLine("Прямые параллельны и не пересекаются");
    else
        Console.WriteLine($"Точка пересечения двух отрезков = x{x} y{y}");
}

double b1 = GetCoordinat("Введите координату b1");
double k1 = GetCoordinat("Введите координату k1");
double b2 = GetCoordinat("Введите координату b2");
double k2 = GetCoordinat("Введите координату k2");

double x =IntersectionPointX(b1, k1, b2, k2);
double y =IntersectionPointY(b1, k1, b2, k2);

CheckAndPrintXY(x, y, b1, k1, b2, k2);




                         

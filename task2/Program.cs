// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)
double Promt(string message)
{
    Console.Write(message);
    double a = double.Parse(Console.ReadLine());
    return a;
}

double CalcX(double b1, double k1, double b2, double k2)
{
    double X = (b2 - b1) / (k1 - k2);
    return X;
}

double CalcY(double b1, double k1, double X)
{
    double Y = k1 * X + b1;
    return Y;
}

double b1 = Promt("Введите коэффициент b1 = ");
double k1 = Promt("Введите коэффициент k1 = ");
double b2 = Promt("Введите коэффициент b2 = ");
double k2 = Promt("Введите коэффициент k2 = ");

if (k1 != k2)
{
    double itogX = CalcX(b1, k1, b2, k2);
    double itogY = CalcY(b1, k1, itogX);
    System.Console.WriteLine($"Координаты точки пересечения прямых ({itogX};{itogY})");
}
else
{
    if (b1 != b2)
    {
        System.Console.WriteLine("Прямы параллельны");
    }
    else
    {
        System.Console.WriteLine("Прямые совпадают");
    }
}
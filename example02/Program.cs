// Напишите программу, которая найдет точку пересечения двух прямых, заднааых уравнениями y = k1*x + b1, y = k2*x + b2
// bi, k1, b2, k2 задаются пользователем
// b1 = 2; k1 = 5; b2 = 4; k2 = 9 =>(-0,5; -0,5)

double Get(string message)
{
Console.WriteLine(message);
string numberStr = Console.ReadLine() ??"";
double number = double.Parse(numberStr);
return number;
}
double b1 = Get("Введите b1: ");
double k1 = Get("Введите k1: ");
double b2 = Get("Введите b2: ");
double k2 = Get("Введите k2: ");

{
    if (k1 == 0 || k2 == 0)
    {
        Console.WriteLine("Заданные параметры не соответсвуют линейным функциям");
    }

    else if(k1 == k2)
    {
       Console.WriteLine("Прямые параллельны"); 
    }

    else
    { 
        double y = (b2 - b1) / (k1 - k2);
        double x = (y - b1) / k1;
        Console.WriteLine($"Точка с координатами ({x}, {y}) ");
    }
   
}



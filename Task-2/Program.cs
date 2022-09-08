/*----------------------------------------------------------------------------------
Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями 
    y = k1 * x + b1
    y = k2 * x + b2
значения *b1, k1, b2* и *k2* задаются пользователем.
----------------------------------------------------------------------------------*/

void FillParam(ref int b1, ref int k1, ref int b2, ref int k2)
{
    Console.Write("Please enter b1 :");
    b1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    Console.Write("Please enter k1 :");
    k1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    Console.Write("Please enter b2 :");
    b2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    Console.Write("Please enter k2 :");
    k2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
}


void PointCross(int b1, int k1, int b2, int k2)
{
    double crossX = (double) (b1-b2) / (k2-k1);
    double crossY = (double) (b1*k2 - b2*k1) / (k2-k1);
    Console.WriteLine($"The point two lines are crossing is ({crossX:f1}; {crossY:f1})" );
}

int b1=0, k1=0, b2=0, k2=0;
FillParam(ref b1, ref k1, ref b2, ref k2);
PointCross(b1, k1, b2, k2);
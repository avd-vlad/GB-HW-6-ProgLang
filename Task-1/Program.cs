/*----------------------------------------------------------------------------------
Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
----------------------------------------------------------------------------------*/
int[] GetUserNumbers()
{
    Console.Write("Please enter quantity of numbers for further analysys: ");
    int n = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine();
    
    int[] arr = new int[n];
    
    for(int i = 0; i < n; i++)
    {
        Console.Write("Please enter nubmer :");
        arr[i] = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
    }

    return arr;
}

void ShowArr(int[] arr)
{

    Console.Write("[");
    for(int i=0; i<arr.Length;i++)
        if(i==arr.Length-1)
            Console.Write($"{arr[i]} ]");
        else
            Console.Write($"{arr[i]}, ");
    Console.WriteLine();
}

int CountPositive(int[] arr)
{
    int qty=0;
    foreach(int x in arr)
        if(x >= 0) qty++;
    
    return qty;
}

int[] arr = GetUserNumbers();
ShowArr(arr);
Console.WriteLine($"the positive number count is : {CountPositive(arr)}");
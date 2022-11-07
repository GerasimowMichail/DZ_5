// Задача 36: Задайте одномерный массив, заполненный случайными числами.
//  Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0void FillArray(int[] collection)3

//Объявляем функция генерации массива с размером
Console.WriteLine("Укажите размер массива:");
int size=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Начало выборки :");
int start = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Конец выборки :");
int end = Convert.ToInt32(Console.ReadLine());

int [] CreateRandomArray(int size, int start, int end)
{
    int [] randomArray = new int [size];
    for(int i=0; i<size; i++)
    {  
         randomArray[i] = new Random().Next(start, end);
        
    }
    return randomArray;
}

//Метод для пока массива
void PrintArray(int [] Array1 )
{
    for(int i=0; i<size; i++)
    {
        Console.Write($"{Array1[i]} ");
    }    
}

// сумма элементов по нечетному индексу

int SumOfEven(int [] MyArray)
{
    int sum=0;
    for(int i=1; i<size; i=i+2)
    {
    sum = sum + MyArray[i]; 
    }
    return sum;
    }   

int [] MyArray= new int [size];
MyArray = CreateRandomArray(size, start, end);
PrintArray(MyArray);
Console.WriteLine("Сумма элементов на нечетных позициях "+SumOfEven(MyArray));
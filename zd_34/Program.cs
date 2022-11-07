// Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

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

// поиск четного элемента

int CointOfEven(int [] MyArray)
{
    int count=0;
    for(int i=0; i<size; i++)
    {
    if (( MyArray[i])%2 ==0) count=count+1; 
    }
    return count;
    }

    
int [] MyArray= new int [size];
MyArray = CreateRandomArray(size, start, end);

PrintArray(MyArray);
Console.WriteLine("Количество четных чисел массива: "+CointOfEven(MyArray));

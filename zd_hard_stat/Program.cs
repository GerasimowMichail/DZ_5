// Задача HARD STAT необязательная: Задайте массив случайных целых чисел. 
// Найдите максимальный элемент и его индекс, минимальный элемент и его индекс, 
// среднее арифметическое всех элементов. Сохранить эту инфу в отдельный массив и вывести на экран с пояснениями. 
// Найти медианное значение первоначалального массива , 
// возможно придется кое-что для этого дополнительно выполнить.
Console.WriteLine("Введите размерность массива: ");
int size=Convert.ToInt32(Console.ReadLine());

int [] CreateRandomArray(int lengh)
{
    int [] mas= new int[lengh];
    for(int i=0; i<lengh; i++)
    {
        mas[i]=new Random().Next(0,10);
    }
    return mas;
}

void PrintArray(int [] array)
{
    for(int i=0; i<array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

//Ищем минимальное значение элемента и его индекс
int [] MinFind(int [] array)
{
    int minIndex=0;
    int minNumber=array[0];
    int [] resultMin= new int[2];
        for(int i=1; i<array.Length; i++)
            {
                if(array[i]<minNumber) 
                {
                    minNumber=array[i];
                    minIndex=i;
                }
            }
            resultMin[0]=minNumber;
            resultMin[1]=minIndex;
    return resultMin;
}
//Ищем максимальное значение элемента и его индекс
int [] MaxFind(int [] array)
{
    int maxIndex=0;
    int maxNumber=array[0];
    int [] resultMax= new int[2];
        for(int i=1; i<array.Length; i++)
            {
                if(array[i]>maxNumber) 
                {
                    maxNumber=array[i];
                    maxIndex=i;
                }
            }
            resultMax[0]=maxNumber;
            resultMax[1]=maxIndex;
    return resultMax;
}
//ищем среднее значение элементов массива
double MeanSum(int [] massiv)
{
    double sumMean=0;
    double sum=0;
    for(int i=0; i<massiv.Length; i++)
    {
        sum=sum+massiv[i];
       
    }
     sumMean=sum/(massiv.Length);
    return sumMean;
}
//Сортируем массив для дальнейшего поиска медианы
int [] SortAray(int [] array)
{
    int temp=0;

    for(int i=0; i<array.Length; i++)
    {
        for(int j=0; j<array.Length-1; j++)
        {
            if(array[j]>array[j+1]) 
            {
                temp=array[j];
                array[j]=array[j+1];
                array[j+1]=temp;
            }
        
        }
    }
    return array;
}
//Ищем медианное значение массива
int Mediana(int [] array)
{
    int medianaArray=array[0];
    if((array.Length)%2==0) 
    {
        medianaArray=(array[(array.Length/2-1)]+array[(array.Length)/2])/2;
    }
    else medianaArray=array[(array.Length-1)/2];
    
    return medianaArray;
}



int [] massiv = new int[size];
massiv=CreateRandomArray(size);
Console.WriteLine();
// Вывод на экран
Console.Write($"Сгенерированый массив из {size} элементов: ");
PrintArray(massiv);
Console.WriteLine();

int [] resMin=MinFind(massiv);
int [] resMax=MaxFind(massiv);
Console.WriteLine($"{resMin[0]    }   - Минимальное значение в массиве  " );
Console.WriteLine($"{resMin[1]    }   - Индекс минимального элемента в массиве  " );
Console.WriteLine($"{resMax[0]    }   - Максимальное значение в массиве  " );
Console.WriteLine($"{resMax[1]    }   - Индекс Максимального элемента в массиве  " );
Console.WriteLine($"{MeanSum(massiv)  } - Среднее арифметическое значение элементов массива  " );
Console.WriteLine();
//Сортируем массив
SortAray(massiv);
PrintArray(massiv);
//находим медианное значение массива
Console.WriteLine();
//медиана массива
Mediana(massiv);
Console.WriteLine($"Медианное значение массива {Mediana(massiv)} " );



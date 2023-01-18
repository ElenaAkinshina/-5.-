/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/


int[] GetArray(int size, int minValue, int maxValue){
    int[] res = new int [size];
    for(int i = 0; i < size; i++){
        res[i] = new Random().Next(minValue, maxValue + 1);
            }
            return res;
}

/*int[] array = GetArray(10, 100, 999);
Console.WriteLine($"[{String.Join(",", array)}]");

int evenNum(int[] array){
int count = 0;   
foreach (int el in array){
    if((el % 2)==0){
        count++;
    }
   }
return count;
}

Console.WriteLine($"количество чётных чисел в массив -> {evenNum(array)}");*/



/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных индексах.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

int[] array = GetArray(10, -10, 10);
Console.WriteLine($"[{String.Join(",", array)}]");


int sumOddNum = 0;  
for (int i = 1; i < array.Length; i+=2){ 
     
    sumOddNum += array[i];
}


Console.WriteLine($"сумма элементов, стоящих на нечётных индексах -> {sumOddNum}");

/*Задача 37: Найдите произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний и т.д.
Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21*/

/*int[] array = GetArray(10, -5, 5);
Console.WriteLine($"[{String.Join(",", array)}]");


int sum = 0;   

    for (int i =0; i < array.Length / 2; i++)
    {
        sum+=array[i] * array[array.Length - 1 - i];
       Console.Write($"{sum}");
    }*/
    
   

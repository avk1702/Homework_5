// Задача 34: Задайте массив заполненный случайными положительными 
//трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int Prompt(string massage)
{
  System.Console.Write(massage);
  string ReadInput = System.Console.ReadLine();
  int result = int.Parse(ReadInput);
  return result;
}
int[] Array(int Length)
{
  int[] array = new int[Length];
    for (int i = 0; i < Length; i++)
  {
    array[i] = new Random().Next(100,999);
   
    Console.Write(array[i].ToString() + " ");
  }
  return array;
}

int CountEven(int[] array)
{
  int count = 0;
  for (int i = 0; i < array.Length; i++)
   
  if (array[i] % 2 == 0)
  {
    count++;
  }

  return count;
}

int Length = Prompt ("Длина массива:  ");
int[] array = Array(Length);
//array = Array(Length);
//Console.WriteLine(count);
Console.WriteLine();
Console.WriteLine($"Количество четных чисел в массиве {CountEven(array)}");
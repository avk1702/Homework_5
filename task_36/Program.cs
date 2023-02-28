//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
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
    array[i] = new Random().Next(0,99);
   
    Console.Write(array[i].ToString() + " ");
    
  }
  return array;
}
int Length = Prompt ("Длина массива:  ");
int[] array = Array(Length);

int sum = 0;
for (int i = 1; i < Length; i = i + 2)

  //if (i % 2 != 0)
  //{
    sum = sum + array[i];
  
Console.WriteLine();
Console.WriteLine($" Сумма элементов, стоящих на нечётных позициях {sum}");


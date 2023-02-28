//Задача 38: Задайте массив вещественных чисел 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

 int Prompt(string massage)
{
  System.Console.Write(massage);
  string ReadInput = System.Console.ReadLine();
  int result = int.Parse(ReadInput);
  return result;
}
double[] Array(int Length)
{
  double[] array = new double[Length];
    for ( int i = 0; i < Length; i++)
  {
    array[i] = new Random().NextDouble() * 100;
   
    Console.Write(array[i].ToString("F2") + " " );
    
  }
  return array;
}
int Length = Prompt ("Длина массива:  ");
double[] array = Array(Length);

double min = array[0];
double max = array[0];

for ( int i = 1; i < Length; i++)
{
  if (array[i] < min)
  {
    min = array[i];
  }
  else if (array[i] > max)
  {
    max = array[i];
  }
  
}
double diffMaxMin = max - min;

Console.WriteLine("Разница между максимальным и минимальным элементом массива равна  " + diffMaxMin.ToString("F2"));


Console.Write($"Введите количество чисел М (количество чисел): ");
int m = Convert.ToInt32(Console.ReadLine());
int[] arrayNum = new int[m];

void InputNum(int m){
for (int i = 0; i < m; i++)
  {
    Console.Write($"Введите {i+1} число: ");
    arrayNum[i] = Convert.ToInt32(Console.ReadLine());
  }
}

int Comparison(int[] arrayNum)
{
  int count = 0;
  for (int i = 0; i < arrayNum.Length; i++)
  {
    if(arrayNum [i] > 0 )
     count += 1; 
  }
  return count;
}

InputNum(m);
Console.WriteLine($"Количество чисел больше нуля: {Comparison(arrayNum)} ");
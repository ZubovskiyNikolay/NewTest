Console.WriteLine("Введите строку символов");
string text = Console.ReadLine();
int linetext = text.Length;
int textnum = 0;
int sum = 0;
int num = 0;
int[] array = new int[linetext];
int index=0;
for (int count=0;count<linetext;count++)
{
  string textchr = Convert.ToString(text[count]);
  bool result = int.TryParse(textchr, out textnum);
  {
    if(result)
    {
      array[index] = textnum;
      sum = sum+textnum;
      num++;
      index++;
    }
  }
}
int[] arraynum = new int[num];
for(int count=0;count<num;count++)
{
  arraynum[count] = array[count];
  Console.Write($" {arraynum[count]} ");
}

Console.WriteLine($"\nКоличество символов в строке - {linetext}\nКоличество цифр в строке - {num};\nСумма цифр в строке - {sum};");

// измененение файла на github



/* Задача 33: Задайте массив.Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив[6, 7, 19, 345, 3]->нет
3; массив[6, 7, 19, 345, 3]->да
Выводить сообщение "да" или "нет" ТОЛЬКО ОДИН РАЗ */
int[] FillArrayWithRandomNumbers(int size, int leftRange, int rightRange)
{
	int[] array = new int[size];
	Random random = new Random();

	for (int i = 0; i < size; i++)
	{
		array[i] = random.Next(leftRange, rightRange + 1);
	}
	return array;
}
int[] arr = FillArrayWithRandomNumbers(5, -10, 10);
System.Console.WriteLine($"Наш массив: [{string.Join(", ", arr)}]");

System.Console.Write("Какое число вы хотите найти в массиве? ");
int number = Convert.ToInt32(Console.ReadLine());

bool result = IsNumberInArray(arr, number);
if (result == true)
{
	System.Console.WriteLine("Да");
}
else
{
	System.Console.WriteLine("Нет");
}

bool IsNumberInArray(int[] array, int findNumber)
{
	bool flag = false;
	for (int i = 0; i < array.Length; i++)
	{
		if (array[i] == findNumber)
		{
			flag = true;
			break;
		}
	}
	return flag;
}


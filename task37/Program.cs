/* Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6]-> 36 21 */
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
int[] arr = FillArrayWithRandomNumbers(5, 1, 5);
System.Console.WriteLine($"Наш массив: [{string.Join(", ", arr)}]");

int newLenght = arr.Length / 2 + arr.Length % 2;
int[] newArray = new int[newLenght];
for (int i = 0; i < newLenght; i++)
{
	newArray[i] = arr[i] * arr[arr.Length - 1 - i];
}
if (arr.Length % 2 == 1)
{
	newArray[newArray.Length - 1] = arr[arr.Length / 2];
}
System.Console.WriteLine($"Новый массив: [{string.Join(", ", newArray)}]");



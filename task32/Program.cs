/* Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]
 */
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

void SwapSignOfArrayElements(int[] array)
{
	for (int i = 0; i < array.Length; i++)
	{
		array[i] = -array[i];
	}
}

int[] arr = FillArrayWithRandomNumbers(5, -9, 9);
System.Console.WriteLine($"Наш массив: [{string.Join(", ", arr)}]");

SwapSignOfArrayElements(arr);
System.Console.WriteLine($"Наш новый массив: [{string.Join(", ", arr)}]");
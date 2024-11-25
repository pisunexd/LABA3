// Ввод числа N
int N = int.Parse(Console.ReadLine());
// Создаем массив длиной N
int[] arr = new int[N];
// Заполняем массив нечетными числами
for (int i = 0; i < N; i++)
{
    arr[i] = 2 * i + 1; // нечетные числа: 1, 3, 5...
}
// Вывод массива
for (int i = 0; i < N; i++)
{
    Console.Write(arr[i] + " ");
}
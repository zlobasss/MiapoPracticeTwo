using Practice.Model;

namespace Practice.Controller;

public class SortController
{
    public void MainController()
    {
        Random random = new Random();
        int[] array = new int[random.Next(100,1000)]; 

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(1, 100); 
        }

        Console.WriteLine("Случайный массив:");
        foreach (int element in array)
        {
            Console.Write(element + " ");
        }

        Console.WriteLine("Выберите метод сортировки:");
        Console.WriteLine("1 - Сортировка линейным выбором");
        Console.WriteLine("2 - Сортировка минимального/максимального числа");
        Console.WriteLine("3 - Сортировка пузырьком");
        Console.WriteLine("4 - Челночная сортировка");
        
        int choice = int.Parse(Console.ReadLine());
        while(choice < 1 || choice > 4)
        {
            Console.WriteLine("Некорректный выбор, введите заново!");
            choice = int.Parse(Console.ReadLine());
        }

        switch (choice)
        {
            case 1:
                Sort.SelectionSort(array);
                break;
            case 2:
                Sort.MinimumMaximumSort(array);
                break;
            case 3:
                Sort.BubbleSort(array);
                break;
            case 4:
                Sort.ShuttleSort(array);
                break;
            
        }
        
        Console.WriteLine("Отсортированный массив:");
        Sort.PrintArray(array); 
    }
}
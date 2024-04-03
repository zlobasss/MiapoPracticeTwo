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
        
        int choice = int.Parse(Console.ReadLine());
        while(choice < 1 || choice > 1)
        {
            Console.WriteLine("Некорректный выбор, введите заново!");
            choice = int.Parse(Console.ReadLine());
        }

        switch (choice)
        {
            case 1:
                Sort.SelectionSort(array);
                break;
        }
        
        Console.WriteLine("Отсортированный массив:");
        Sort.PrintArray(array); 
    }
}
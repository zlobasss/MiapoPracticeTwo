namespace Practice.Model;

public class Sort
{
    // Метод для вывода массива на консоль
    public static void PrintArray(int[] array)
    {
        foreach (int element in array)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }

    // Метод сортировки с использованием вспомогательного массива
    public static int[] SelectionSort(int[] arr)
    {
        int[] sortedArray = new int[arr.Length]; // Создаем новый массив для отсортированных элементов
        int index = 0;

        while (arr.Length > 0)
        {
            int maxIndex = FindMaxIndex(arr); // Находим индекс максимального элемента в исходном массиве
            sortedArray[index] = arr[maxIndex]; // Переносим максимальный элемент во вспомогательный массив
            index++;

            arr = RemoveElement(arr, maxIndex); // Удаляем максимальный элемент из исходного массива
        }

        return sortedArray;
    }

    // Метод для поиска индекса максимального элемента в массиве
    static int FindMaxIndex(int[] array)
    {
        int maxIndex = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > array[maxIndex])
            {
                maxIndex = i;
            }
        }
        return maxIndex;
    }

    // Метод для удаления элемента из массива по индексу
    static int[] RemoveElement(int[] arr, int index)
    {
        int[] newArr = new int[arr.Length - 1];
        for (int i = 0, j = 0; i < arr.Length; i++)
        {
            if (i != index)
            {
                newArr[j] = arr[i];
                j++;
            }
        }
        return newArr;
    }
    
    // Метод сортировки минимального/максимального числа
    public static void MinimumMaximumSort(int[] array)
    {
        int FindMinElement(int[] arr)
        {
            if (arr == null || arr.Length == 0)
            {
                throw new ArgumentException("Массив пуст или не существует");
            }

            int minIndex = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < arr[minIndex])
                {
                    minIndex = i;
                }
            }

            return arr[minIndex];
        }

    }
}
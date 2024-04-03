using Practice.Controller;
using Practice.Model;

namespace Practice;

class Program
{
    static void Main()
    {
        NotebookController _bookController = new NotebookController();
        SortController _sortController = new SortController();
        int choice = -1;
        Book book = new Book();

        while (choice != 0)
        {
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1) Записная книжка");
            Console.WriteLine("2) Сортировщик случайного массива");
            Console.WriteLine("0) Выйти из программы");
            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    _bookController.MainControl(book);
                    break;
                case 2:
                    _sortController.MainController();
                    break;
            }
        }
    }
}
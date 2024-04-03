using System;
using System.Runtime.InteropServices;
using Practice.Model;

namespace Practice.Controller;
public class NotebookController
{
    public Note InputDataNote()
    {
        Note note;
        string name;
        string description;
        Console.WriteLine("Введите название заметки: ");
        name = Console.ReadLine();
        Console.WriteLine("Введите описание заметки: ");
        description = Console.ReadLine();
        note = new Note(name, description);
        return note;
    }
    
    public void MainControl(Book book)
    {
        int choice = -1;
        
        while (choice != 0)
        {
            int id;
            Note note;
            Console.WriteLine("Выберите действие с записной книжкой:");
            Console.WriteLine("0 - Выйти из записной книжки");
            Console.WriteLine("1 - Добавить запись");
            Console.WriteLine("2 - Удалить запись");
            Console.WriteLine("3 - Изменить запись");

            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 0:
                    break;
                case 1:
                    note = InputDataNote();
                    book.AddNote(note.GetName(), note.GetDescription());
                    break;
                case 2:
                    Console.WriteLine("Введите номер элемента:");
                    id = int.Parse(Console.ReadLine()) - 1;
                    if (id >= 0 && id < book.Count())
                    {
                        book.DeleteNote(id);
                    }
                    break;
                case 3:
                    note = InputDataNote();
                    string name;
                    string description;
                    book.AddNote(note.GetName(), note.GetDescription());
                    Console.WriteLine("Введите номер элемента:");
                    id = int.Parse(Console.ReadLine()) - 1;
                    if (id >= 0 && id < book.Count())
                    {
                        if (note.GetName().Length == 0)
                        {
                            name = book.GetNote(id).GetName();
                        }
                        else
                        {
                            name = note.GetName();
                        }

                        if (note.GetDescription().Length == 0)
                        {
                            description = book.GetNote(id).GetDescription();
                        }
                        else
                        {
                            description = note.GetDescription();
                        }
                        
                        book.EditNote(id, name, description);
                    }
                    break;
                default:
                    continue;
            }
        }
    }
    
    
}
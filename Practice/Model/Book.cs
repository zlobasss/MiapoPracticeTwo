using System;
using System.Collections.Generic;
namespace Practice.Model;

public class Book
{
    private List<Note> _notes;

    public Book()
    {
        _notes = new List<Note>();
    }
    
    // Метод преобразования массив заметок в строку
    public override string ToString()
    {
        string result = "";
        int num = 1;
        foreach (Note note in _notes)
        {
            result += $"{num})" + note + '\n';
            ++num;
        }

        return result;
    }

    // Добавление заметки в книгу
    public void AddNote(string name, string description)
    {
        _notes.Add(new Note(name, description));
    }

    // Удаление заметки из книги
    public void DeleteNote(int id)
    {
        _notes.RemoveAt(id - 1);
    }
    
    // Изменение заметки
    public void EditNote(int id, string name, string description)
    {
        _notes[id - 1] = new Note(name, description);
    }
}
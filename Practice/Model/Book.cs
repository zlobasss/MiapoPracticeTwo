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

    // Получение заметки по айди
    public Note GetNote(int id)
    {
        return _notes[id - 1];
    }
    
    public int Count()
    {
        return _notes.Count();
    }
    
    public void SortNotesByName()
    {
        for (int i = 0; i < _notes.Count - 1; ++i)
        {
            for (int j = i + 1; j < _notes.Count - 1; ++j)
            {
                string name1 = _notes[i].GetName();
                string name2 = _notes[j].GetName();
                if (string.CompareOrdinal(name1, name2) < 0)
                {
                    (_notes[i], _notes[j]) = (_notes[j], _notes[i]);
                }
            }
        }
    }
}
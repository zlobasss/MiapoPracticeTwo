using System;
namespace Practice.Model;

public class Note
{
    private string _name;
    private string _description;

    public Note(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public Note(Note note)
    {
        _name = note.GetName();
        _description = note.GetDescription();
    }

    public string GetName()
    {
        return _name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public override string ToString()
    {
        return "(note: имя=" + _name + ", описание=" + _description + ')';
    }
}
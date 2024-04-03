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
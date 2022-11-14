using System.ComponentModel.DataAnnotations;

namespace MvcLabManager.Models;

public class Lab
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Number { get; set; }
    public string Block { get; set; }

    public Lab() { }

    public Lab(int id, string name, int number, string block)
    {
        Id = id;
        Name = name;
        Number = number;
        Block = block;
    }
}

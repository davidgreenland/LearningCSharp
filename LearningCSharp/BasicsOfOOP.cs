using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp;

public class Person
{
    public readonly string Name;
    private int _age;

    public int Age
    {
        get
        {
            return _age;
        }
        private set
        {
            if (value > 0)
            {
                _age = value;
            }
        }
    }

    public Person(string name, int age)
    {
        if (age < 0) throw new ArgumentException("Age cannot be negative");
        Name = name;
        _age = age;

    }

    public void Greet() => Console.WriteLine($"Hello {Name}.");
}


/*Завдання 2
Створіть клас «Футбольна Команда». Клас має містити
інформацію про гравців футбольної команди. Реалізуйте
підтримку ітератора для класу «Футбольна Команда».
Протестуйте можливість використання foreach для класу
«Футбольна Команда».*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

interface ITeamMember
{
    string Name { get; }
    string Position { get; }
    int Goals { get; }
}

class Football_Team : IEnumerable<ITeamMember>
{
    private List<ITeamMember> teamMembers = new List<ITeamMember>();

    public void AddTeamMember(ITeamMember member)
    {
        teamMembers.Add(member);
    }

    public IEnumerator<ITeamMember> GetEnumerator()
    {
        return teamMembers.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

class Forward : ITeamMember
{
    public string Name { get; }
    public string Position { get; }
    public int Goals { get; }

    public Forward(string name, int goals)
    {
        Name = name;
        Position = "Нападающий";
        Goals = goals;
    }
}

class Midfielder : ITeamMember
{
    public string Name { get; }
    public string Position { get; }
    public int Goals { get; }

    public Midfielder(string name, int goals)
    {
        Name = name;
        Position = "Полузащитник";
        Goals = goals;
    }
}

class Defender : ITeamMember
{
    public string Name { get; }
    public string Position { get; }
    public int Goals { get; }

    public Defender(string name, int goals)
    {
        Name = name;
        Position = "Защитник";
        Goals = goals;
    }
}

class Goalkeeper : ITeamMember
{
    public string Name { get; }
    public string Position { get; }
    public int Goals { get; }

    public Goalkeeper(string name, int goals)
    {
        Name = name;
        Position = "Вратарь";
        Goals = goals;
    }
}

class Program
{
    static void Main()
    {
        Football_Team team = new Football_Team();
        team.AddTeamMember(new Forward("Пеле", 1281));
        team.AddTeamMember(new Midfielder("Марадона", 345));
        team.AddTeamMember(new Defender("Мальдини", 40));
        team.AddTeamMember(new Goalkeeper("Тибо Куртуа", 1000));

        Console.WriteLine("Лучшие игроки мира всех времен:");
        foreach (ITeamMember member in team)
        {
            Console.WriteLine($"{member.Name} ({member.Position}) - Забитых или пойманных мячей: {member.Goals}");
        }
        Console.ReadKey();
    }
}



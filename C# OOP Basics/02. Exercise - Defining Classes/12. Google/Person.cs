using System.Collections.Generic;
using System.Text;

public class Person
{
    private string name;
    private Company company;
    private List<Pokemon> pokemons;
    private List<Parent> parents;
    private List<Children> childrens;
    private Car car;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public Company Company
    {
        get { return company; }
        set { company = value; }
    }

    public List<Pokemon> Pokemons
    {
        get { return pokemons; }
        set { pokemons = value; }
    }

    public List<Parent> Parents
    {
        get { return parents; }
        set { parents = value; }
    }

    public List<Children> Childrens
    {
        get { return childrens; }
        set { childrens = value; }
    }

    public Car Car
    {
        get { return car; }
        set { car = value; }
    }

    public Person(string name)
    {
        this.name = name;
        this.pokemons = new List<Pokemon>();
        this.parents = new List<Parent>();
        this.childrens = new List<Children>();
    }

    public override string ToString()
    {
        var sb = new StringBuilder();

        sb.AppendLine($"{this.Name}");
        sb.AppendLine("Company:");
        if (this.Company != null)
        {
            sb.AppendLine($"{this.Company.Name} {this.Company.Department} {this.Company.Salary:f2}");
        }
        sb.AppendLine("Car:");
        if (this.Car != null)
        {
            sb.AppendLine($"{Car.Model} {Car.Speed}");
        }
        sb.AppendLine("Pokemon:");
        if (this.Pokemons != null)
        {
            foreach (var pokemon in this.Pokemons)
            {
                sb.AppendLine($"{pokemon.Name} {pokemon.Type}");
            }
        }
        sb.AppendLine("Parents:");
        if (this.Parents != null)
        {
            foreach (var parent in this.Parents)
            {
                sb.AppendLine($"{parent.Name} {parent.Birthday}");
            }
        }
        sb.AppendLine("Children:");
        if (this.Childrens != null)
        {
            foreach (var children in this.Childrens)
            {
                sb.AppendLine($"{children.Name} {children.Birthday}");
            }
        }

        return sb.ToString();
    }
}
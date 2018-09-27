using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


public class Family
{
    List<Person> family = new List<Person>();

    public void AddMember(Person member)
    {
        family.Add(member);
    }

    public Person GetOldestMember()
    {
        return this.family
                .OrderByDescending(m => m.Age)
                .FirstOrDefault();
    }
}
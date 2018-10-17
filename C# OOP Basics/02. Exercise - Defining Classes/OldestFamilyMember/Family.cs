using System.Collections.Generic;
using System.Linq;

namespace OldestFamilyMember
{
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
}
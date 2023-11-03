using System;

namespace Learn73.Ref_local_re_assignment
{
    public static class RefLocalReAssignment
    { 
        public static void Example()
        {
            var people = new[]
            {
                new Person { Name = "Person 1" },
                new Person { Name = "Person 2" }
            };
            ref var personRef = ref GetPerson(ref people, 0);
            // C# 7.3 ref re-assignment - note the 'ref' keyword in front of the assigned value
            // This will not change the value it points to, just update the reference itself.
            personRef.Name = "Test";
            Console.WriteLine(people[0].Name);
            personRef = ref GetPerson(ref people, 1);
            personRef.Name = "Test";
            Console.WriteLine(people[1].Name);
            // Now people[0] and people[1] are still the same. personRef holds a reference to people[1].
        }
        public static ref Person GetPerson(ref Person[] people, int id)
        {
            return ref people[id]; 
        }

    }
}
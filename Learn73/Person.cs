namespace Learn73
{
    public struct Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        } 
        public string FullName => $"{Name} ({Age})";
    }
}
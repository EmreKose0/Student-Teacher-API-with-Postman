namespace PersonApı.Entities
{
    public abstract class Person   //Inheritance class
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Surname { get; set; }
        public int Age { get; set; }
    }
}

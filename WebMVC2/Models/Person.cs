namespace WebMVC2.Models
{
    public class Person
    {
        public virtual int Id { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual int DepId { get; set; }
    }

    public class Department
    {
        public virtual int Id { get; set; }
        public virtual string Type { get; set; }
        public virtual string Name { get; set; }
    }
}
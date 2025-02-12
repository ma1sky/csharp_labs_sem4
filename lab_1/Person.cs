public class Person
{
    private string name;
    private string surname;
    private DateTime birthday;

    public Person() :
        this(
            string.Empty,
            string.Empty,
            DateTime.Now
            )
    { }

    public Person(string name, string surname, DateTime birthday)
    {
        this.name = name;
        this.surname = surname;
        this.birthday = birthday;
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public string Surname
    {
        get { return surname; }
        set { surname = value; }
    }
    public DateTime Birthday
    {
        get { return birthday; }
        set { birthday = value; }
    }

    public override string ToString()
    {
        return $"{name} {surname}, Дата рождения: {birthday.ToShortDateString()}";
    }

    public virtual string ToShortString()
    {
        return $"{name} {surname}";
    }
}

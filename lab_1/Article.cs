public enum Frequency
{
    Weekly,
    Monthly,
    Yearly
}

public class Article
{
    public Person author { get; set; }
    public string title { get; set; }
    public double rating { get; set; }

    public Article()
    {
        this.author = new Person();
        this.title = string.Empty;
        this.rating = 0;
    }

    public Article(Person author, string title, double rating)
    {
        this.author = author;
        this.title = title;
        this.rating = rating;
    }

    public override string ToString()
    {
        return $"Статья: {title}, Автор: {author}, Рейтинг: {rating}";
    }
}
public class Magazine
{
    private Frequency frequency;
    private string title;
    private DateTime releaseDate;
    private int circ;
    private Article[] articles;
    private double average;

    

    Magazine(string title, Frequency frequency, DateTime releaseDate, int circ, Article[] articles)
    {
        this.title = title;
        this.frequency = frequency;
        this.releaseDate = releaseDate;
        this.circ = circ;
        this.articles = articles;
        
        for (int i = 0; i < this.articles.Length; i++)
        {
            average += articles[i].rating;
        }
        average /= this.articles.Length;
    }

    Magazine() 
    {
        this.title = string.Empty;
        this.frequency = Frequency.Weekly;
        this.releaseDate = DateTime.Now;
        this.circ = 0;
        this.articles = new Article[this.circ];
        this.average = 0;
    }

    public double Average
    {
        get
        {
            return average;
        }
    }

    public bool this[Frequency frequency]
    {
        get
        {
            return this.frequency == frequency;
        }
    }

    public override string ToString()
    {
        string articleList = string.Join(Environment.NewLine, articles.Select(a => $"{a.title} (Rating: {a.rating})"));
        return $"Magazine Frequency: {frequency}\nAverage Rating: {average}\nArticles:\n{articleList}";
    }
    public virtual string ToShortString()
    {
        return $"Magazine Frequency: {frequency}\nAverage Rating: {average}";
    }
}
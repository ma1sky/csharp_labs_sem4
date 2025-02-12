using System.Diagnostics;

class Program { 
    static void Main()
    {
        Random rand = new Random(DateTime.Now.Millisecond);
        Stopwatch timer = new Stopwatch();

        Console.WriteLine("Write columns and rows in formats:\nx,y \nx|y");
        string[] input = Console.ReadLine().Split(',', '|');
        int nrow = Convert.ToInt16(input[0]);
        int ncol = Convert.ToInt16(input[1]);


        int[] oneDimArr = new int[nrow * ncol];

        timer.Start();
        for (int i = 0; i < oneDimArr.Length; i++) { 
            oneDimArr[i] = rand.Next(1, 100); 
        }
        timer.Stop();
        Console.WriteLine($"Time elapsed initialization on one-direction array: {timer.Elapsed.TotalMilliseconds}");


        int[,] twoDimArr = new int[ncol, nrow];

        timer.Reset();
        timer.Restart();
        for (int i = 0; i < ncol; i++)
        {
            for (int j = 0; j < nrow; j++)
            {
                twoDimArr[i, j] = rand.Next(1, 100);
            }
        }
        timer.Stop();
        Console.WriteLine($"Time elapsed initialization on two-direction array: {timer.Elapsed.TotalMilliseconds}");
        
        
        int[][] jaggerArr = new int[ncol][];
        for (int i = 0;i < ncol; i++)
        {
            jaggerArr[i] = new int[nrow];
        }

        timer.Reset();
        timer.Restart();
        for (int i = 0; i < ncol; i++)
        {
            for (int j = 0; j < nrow; j++)
            {
                jaggerArr[i][j] = rand.Next(1, 100);
            }
        }
        timer.Stop();
        Console.WriteLine($"Time elapsed initialization on jagger-direction array: {timer.Elapsed.TotalMilliseconds}");

    }
}
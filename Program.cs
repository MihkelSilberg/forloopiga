namespace forloopiga
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("maja v diamond");

           string valik = Console.ReadLine();
            switch (valik)
            {
                case "1":
                    Maja();
                    break;
                case "2":
                    Diamond();
                    break;
            }
        }
        static void Maja()
        {
            {
                Console.WriteLine("ruut");
                Console.WriteLine("sisesta ruudu suurus");

                int size = int.Parse(Console.ReadLine());
                int row;
                int column;

                for (column = 0; column < size; column++)
                {
                    for (row = 1; row < size - column; row++)
                    {
                        Console.Write(" ");
                    }
                    for (row = 1; row <= 2 * column - 1; row++)
                    {
                        Console.Write("*");
                    }
                    Console.Write("\n");
                }


                for (row = 1; row <= size; row++)
                {
                    for (column = 1; column <= size * 2 - 3; column++)
                    {
                        string mark;
                        if (row == column || row + column <= size + 1)
                        {
                            mark = "*";
                        }
                        else
                        {
                            mark = "*";
                        }
                        Console.Write(mark);
                    }
                    Console.WriteLine();
                }
            }
        }
        static void Diamond()
        {
            int i, j, r; 

            Console.Write("\n\n"); 
            Console.Write("teemant:\n");  
            Console.Write("-----------------------------------");  
            Console.Write("\n\n"); 

            Console.Write("Mitu rida tahad? (pool diamondi): ");  
            r = Convert.ToInt32(Console.ReadLine());  

            
            for (i = 0; i <= r; i++)
            {
                for (j = 1; j <= r - i; j++)
                    Console.Write(" ");  

                for (j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");  

                Console.Write("\n");  
            }

  
            for (i = r - 1; i >= 1; i--)
            {
                for (j = 1; j <= r - i; j++)
                    Console.Write(" ");

                for (j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");  

                Console.Write("\n"); 
            }
        }
    }
}
    
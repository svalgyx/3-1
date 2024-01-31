namespace HW3_1
{
    class Jagged
    {
        private int r = 0;
        private bool init = true;
        private int[][] arr;

        public Jagged(int input_r, bool input_init = true)
        {
            r = input_r;
            init = input_init; 
            arr = new int[r][];
        }

        public void NewArray()
        {
            if (init)
            {
                for (int i = 0; i < r; i++)
                {
                    string r = Console.ReadLine();
                    string[] array_r = r.Split(' ');
                    arr[i] = new int[array_r.Length];
                    for (int j = 0; j < array_r.Length; j++)
                    {
                        arr[i][j] = int.Parse(array_r[j]);
                    }
                }
            }
            else
            {
                Random rnd = new Random();
                for (int i = 0; i < r; i++)
                {
                    int array_r_len = rnd.Next(1, 10);
                    arr[i] = new int[array_r_len];
                    for (int j = 0; j < array_r_len; j++)
                    {
                        arr[i][j] = rnd.Next(1, 100);
                    }
                }
            }
        }

        public void WriteArray()
        {
            Console.WriteLine("Writing jagged array: ");
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j] + " ");
                }
                Console.WriteLine();
            }
        }

        public double Average()
        {
            int sum = 0;
            int counter = 0;
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    sum += arr[i][j];
                    counter += 1;
                }
            }
            Console.WriteLine("Counted the average value of the array: ");
            return (double)sum / (double)counter;
        }

        public double[] AverageValues()
        {
            double[] average_values = new double[r];
            for (int i = 0; i < r; i++)
            {
                int sum = 0;
                for (int j = 0; j < arr[i].Length; j++)
                {
                    sum += arr[i][j];
                }
                average_values[i] = (double)sum / (double)arr[i].Length;
            }
            Console.WriteLine(" average values of the array: ");
            return average_values;
        }

        public void NumsToo()
        {
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    if (arr[i][j] % 2 == 0)
                    {
                        arr[i][j] = i * j;
                    }
                }
            }
            Console.WriteLine("Elements were changed too with multiplication of their indices: ");
        }
    }
}

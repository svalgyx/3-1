namespace HW3_1
{
    class TwoStep
    {
        private int r = 0;
        private int c = 0;
        private bool init = true;
        private int[,] arr;

        public TwoStep(int input_r, int input_c, bool input_init = true)
        {
            r = input_r;
            c = input_c;
            init = input_init;
            arr = new int[r, c];
        }

        public void CreateArray()
        {
            if (init)
            {
                for (int i = 0; i < r; i++)
                {
                    string r = Console.ReadLine();
                    string[] array_r = r.Split(' ');
                    for (int j = 0; j < c; j++)
                    {
                        arr[i, j] = int.Parse(array_r[j]);
                    }
                }
            }
            else
            {
                Random rnd = new Random();
                for (int i = 0; i < r; i++)
                {
                    for (int j = 0; j < c; j++)
                    {
                        arr[i, j] = rnd.Next(1, 100);
                    }
                }
            }
        }

        public void WriteArray()
        {
            Console.WriteLine("Writing two-step array: ");
            for (int i = 0; i < r; i++)
            {
                string r = "";
                for (int j = 0; j < c; j++)
                {
                    r += arr[i, j] + " ";
                }
                Console.WriteLine(r);
            }
            Console.WriteLine("Writing two-step array in a snake pattern: ");
            for (int i = 0; i < r; i++)
            {
                string r = "";
                if (i % 2 == 0)
                {
                    for (int j = 0; j < c; j++)
                    {
                        r += arr[i, j] + " ";
                    }
                }
                else
                {
                    for (int j = c - 1; j >= 0; j--)
                    {
                        r += arr[i, j] + " ";
                    }
                }
                Console.WriteLine(r);
            }
        }

        public double Average()
        {
            int sum = 0;
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    sum += arr[i, j];
                }
            }
            Console.WriteLine("Counted the average value of the array: ");
            return (double)sum / (double)(r * c);
        }
    }
}

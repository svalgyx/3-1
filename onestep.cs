namespace HW3_1
{
    class OneStep
    {
        private int len = 0;
        private bool init = true;
        private int[] arr;

        public OneStep(int inputlen, bool initinput = true)
        {
            len = inputlen;
            init = initinput;
            arr = new int[len];
        }

        public void NewArray()
        {
            if (init)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                for (int i = 0; i < len; i++)
                {
                    arr[i] = int.Parse(inputs[i]);
                }
            }
            else
            {
                Random rnd = new Random();
                for (int i = 0; i < len; i++)
                {
                    arr[i] = rnd.Next(0, 1000);
                }
            }
        }

        public void WriteArray()
        {
            Console.WriteLine("Writing one-step array: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }

        public double Average()
        {
            int counter = 0;
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                counter++;
            }
            Console.WriteLine(" average value of the array: ");
            return (double)sum / (double)counter;
        }

        public void ArrayMod100()
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] <= 100 && arr[i] >= -100)
                {
                    count++;
                }
            }
            int[] cleararray = new intcount();
            count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arri <= 100 && arri >= -100)
                {
                    cleararray[count] = arr[i];
                    count++;
                }
            }
            arr = cleararray;
            Console.WriteLine(" elements higher than 100 deleted: ");
        }

        private bool ContainsStopIndex(int arr, int element, int stopindex)
        {
            for (int i = 0; i < stopindex; i++)
            {
                if (arri == element)
                {
                    return true;
                }
            }
            return false;
        }

        public void ClearArray()
        {
            int cleararray = new int[arr.Length];
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (!(ContainsStopIndex(cleararray, arri, count)))
                {
                    cleararray[count] = arr[i];
                    count++;
                }
            }
            int[] cleararrayresult = new int[count];
            Array.Copy(cleararray, 0, cleararrayresult, 0, count);
            arr = cleararrayresult;
            Console.WriteLine("All repeating elements were deleted: ");
        }
    }
}

using System;

class HelloWorld {

  static void Main() 

  {



  }

}

class OneDims

{

    private int[] mass;

    static int[] Mass(int n)

  {

    int[] mass1 = new int[n];

    Console.Write("Массив заполняется пользователем?(true или false) ");

    bool choice = bool.Parse(Console.ReadLine());

    if (choice)

    {

        for (int i = 0; i < n; i++)

        {

            int elem = int.Parse(Console.ReadLine());

            mass1[i] = elem;

        

        }

    }

    else

    {

        GetMass(n);

    }



    return mass1;

  }

 

 

  static int AveRage(int[] mass1, int n)

  {

    int sum = 0;

    foreach(int el in mass1)

    {

        sum += el;

    }

    return sum/n;

  }

 

  static int[] DelEl(int[] mass1, int n)

  {

    int k = 0;

    for(int i=0; i < n; i++)

    {

        if(Math.Abs(mass1[i])< 100)

        {

            k += 1;

        }

    }

    int[] mas1 = new int[k];

    int x = 0;

    for(int i=0; i < n; i++)

    {

        if(Math.Abs(mass1[i])< 100)

        {

            mas1[x] = mass1[i];

            x+=1;

        }

    }

    return mas1;

  }

 





  private static int[] GetMassWODubs(int[] mass)

  {

    int newMassLength = mass.Length;

    for(int i = 0; i < mass.Length; i++)

    {

    for(int j = i; j < mass.Length; j++)

    {

        if(mass[i] == mass[j] && i != j)

        {

            newMassLength--;

            break;

        }

    }

    }

    Console.WriteLine("New array length = " + newMassLength + "\n");

    

    int[] newMass = new int[newMassLength];

    for(int i = 0; i < newMass.Length; i++)

    {

        newMass[i] = int.MinValue;

    }

    int c = 0;

    for(int i = 0; i < mass.Length; i++)

    {

        if(!Ex(mass[i], newMass))

        {

            newMass[c] = mass[i];

            c++;

            //   Console.WriteLine("newMass[" + (c - 1) + "]= " + newMass[c] + " ");

        }

    }

    return newMass;

  }



  private static bool Ex(int val, int[] mass)

  {

    for(int i = 0; i < mass.Length; i++)

    {

        if(mass[i] == val)

        {

            return true;

        }

    }

    return false;

  }

 

 

 

  private static void printMass(int[] mass)

  {

    foreach(var val in mass)

    {

        Console.Write(val + " ");

    }

  }

 

 

  static int[] GetMass(int massLength)

  {

    Random random = new Random();

    int[] mass = new int[massLength];

    for(int i = 0; i < massLength; i++)

    {

        int val = random.Next(0,10);

        mass[i] = val;

    }

    return mass;

  }

}







class TwoDims

{



 

  static void PrintMass(int m1, int[,] mass)

  {

    int c = 0;

    foreach(int el in mass)

        {

            if (c != (m1 - 1))

            {

                Console.Write($"{el}" + " ");

                c++;

            }

            else

            {

                Console.Write($"{el}" + "\n");

                c = 0;

            }

        }

    }

     





  static int[,] GetMass(int m1, int m2)

  {

    int[,] new_mass = new int[m1,m2];

    Console.Write("Массив заполняется пользователем?(true или false) ");

    bool choice = bool.Parse(Console.ReadLine());

    if (choice)

    {

        for (int i = 0; i < m1; i++)

        {

            for(int j =  0; j < m2; j++)

            {

                Console.Write($"Элемент [{i},{j}]: ");

                new_mass[i, j] = Convert.ToInt32(Console.ReadLine());

            }

        }

    }

    else

    {

        Random random = new Random();

        for (int i = 0; i < m1; i++)

            {

                for(int j =  0; j < m2; j++)

                {

                    Console.Write($"Элемент [{i},{j}]: ");

                    new_mass[i, j] =  random.Next(0,10);

                }

            }

    }

    return new_mass;

  }

 



  static int[,] GetMass2(int m1, int m2)

  {

    int[,] new_mass = new int[m1,m2];

    for (int i = 0; i < m1; i++)

    {

            Console.Write($"Строка {i}: ");

            string a = Console.ReadLine();

            string[] str = a.Split(" ");

            for (int j = 0; j < m2; j++)

            {new_mass[i, j] = Convert.ToInt32(str[j]);}

     

    }

    return new_mass;

  }

 



  static int[,] GetMass3(int m1, int m2)

  {

    int[,] mass = new int[m1,m2];

    for (int i = 0; i < m1; i++)

    {

            if (i%2 == 0)

            {

                int c = (m2 * i) +1;

                for (int j = 0; j < m2; j++)

                {

                    mass[i,j] = c;

                    c++;

                }

            }

            else

            {

                int c =m2 * (i +1);

                for (int j = 0; j < m2; j++)

                {

                    mass[i,j] = c;

                    c--;

                }

            }

  }

  return mass;

 

 }

 

static int AveRage(int[,] mass1)

  {

    int sum1 = 0;

    int n = 0;

    foreach(int el in mass1)

    {

            sum1 += el;

            n+=1;

    }

    return sum1/n;

  }

 

}





class Steps

{

    static int[][] InputArray(int n)

  {

    int[][] j_array = new int[n][];

    Console.Write("Массив заполняется пользователем?(true или false) ");

    bool choice = bool.Parse(Console.ReadLine());

    if (choice)

    {

        for (int i = 0; i<n;i++)

        {

            Console.Write($"Введите длину {i+1} строки: ");

            int len = int.Parse(Console.ReadLine());

            j_array[i] = new int[len];

            for (int j = 0; j < len; j++)

            {

                Console.Write($"Элемент [{i},{j}]: ");

                j_array[i][j] = Convert.ToInt32(Console.ReadLine());

            }

        }

    }

    else

    {

        Random random = new Random();

         for (int i = 0; i<n;i++)

        {

            Console.Write($"Введите длину {i+1} строки: ");

            int len = random.Next(0,10);

            j_array[i] = new int[len];

            for (int j = 0; j < len; j++)

            {

                Console.Write($"Элемент [{i},{j}]: ");

                j_array[i][j] = random.Next(0,10);

            }

        }

    }

    return j_array;

  }



    static int[][] EditArray(int[][] mass)

  {

    for (int i = 0; i<mass.Length;i++)

    {

        for (int j = 0; j < mass[i].Length; j++)

        {

            if (mass[i][j] %2 == 0)

            {

                mass[i][j] = i*j;

             

            }

        }

    }

    return mass;

 }

 

 static void PrintArray(int[][] mass)

  {

    int c = 0;

    for (int i = 0; i<mass.Length;i++)

    {

    foreach(int el in mass[i])

        {

            if (c != (mass[i].Length - 1))

            {

                Console.Write($"{el}" + " ");

                c++;

            }

            else

            {

                Console.Write($"{el}" + "\n");

                c = 0;

            }

        }

  }

  }

 

  static int AveRage(int[][] massive)

  {

    int sum = 0;

    int n = 0;

    foreach(int[] el in massive)

    {

        foreach(int i in el)

        {

            sum += i;

            n+=1;

        }

    }

    return sum/n;

  }

 

  static void AveRage_inside(int[][] massive)

  {

    int sum = 0;

    int n = 0;

    foreach(int[] el in massive)

    {

        foreach(int i in el)

        {

            sum += i;

            n+=1;

        }

        Console.Write(sum/n);

    }

     

  }

 

}
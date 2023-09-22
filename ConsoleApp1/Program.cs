
//Task String Method





//

//
//{
//    static string ReverseString(string s)
//    {

//        char[] array = s.ToCharArray();
//        Array.Reverse(array);
//        return new string(array);
//    }

//    static void Main()
//    {
//        Console.WriteLine(ReverseString("Tofiq"));
//        Console.WriteLine(ReverseString("Haci"));
//    }
//}





























////Task 1

//static void NumIs(int n)
//{
//    if (n % 3 == 0 && n % 7 == 0)
//    {
//        Console.WriteLine("Number is divide 3 and 7");
//    }
//    else
//    {
//        Console.WriteLine("Enter another number");
//    }
//}

//NumIs(21);


//Task2


//static void NumIs(int n,int m)
//{int sum = 0;

//    if (n % 2 == 0 && m % 2 == 0)
//    {
//        sum = n + m;
//        Console.WriteLine(sum);
//    }
//    else
//    {
//        Console.WriteLine("Number is not odd");
//    }

//}
//NumIs(4,6);


//Task3


//static void Nums(int n, int m)
//{
//    int count = 0;
//    for (int i = n; i < m; i++)
//    {
//        if (i % 2 == 1)
//        {
//            count++;
//        }
//    }
//    Console.WriteLine(count);
//}


//Nums(4, 7);


//Task4



//static void Nums(int n, int m)
//{
//    int sum = 0;
//    for (int i = n; i < m; i++)
//    {
//        if (i % 2 == 1)
//        {
//            sum+= i;
//        }
//    }
//    Console.WriteLine(sum);
//}


//Nums(4, 9);



//Task5



//static void NumIs(int[] nums)
//{
//    int sum = 0;

//    for (int i = 0; i < nums.Length; i++)
//    {
//        if (nums[i] % 2 == 1)
//        {

//            sum += nums[i];

//        }



//    }
//    Console.WriteLine(sum);
//}

//int[] nums = { 2, 4, 5, 7 };

//NumIs(nums);




//Task6



//static void NumIs(int[] nums)
//{
//    int sum = 0;

//    for (int i = 0; i < nums.Length; i++)
//    {
//        if (nums[i] % 2 == 0)
//        {

//            sum += nums[i];

//        }



//    }
//    Console.WriteLine(sum);
//}

//int[] nums = { 2, 4, 5, 7 };

//NumIs(nums);





//task7



//static void Main(int n)
//{
//    int count = 0;
//    for (int i = 1; i <= n; i++)
//    {
//        if (n % i == 0)
//        {
//            count++;
//        }
//    }
//    if (count == 2)
//    {
//        Console.WriteLine("{0} is a prime number", n);
//    }
//    else
//    {
//        Console.WriteLine("{0} is  not a prime number", n);
//    }
//}

//Main(14);



//Task9


//static void ArrIs(int[] nums)
//{
//    int result = 1;

//    for (int i = 0; i < nums.Length; i++)
//    {
//        if (nums[i] <20)
//        {

//          result *= nums[i];

//        }
//    }

//    Console.WriteLine(result);


//}

//int[] arr = {5,45,32,15,4};
//ArrIs(arr);
using System.Globalization;

namespace Demo5
{
    internal class Program
        
    {
        public static void PrintShape(string Pattern, int Count =10)
        {
            for (int i = 0; i < Count; i++)
            {
                Console.WriteLine(Pattern);
            }

        }
        public static void Swap(ref int X , ref int Y)
        {
            int Temp = X; 
            X = Y;
            Y = Temp;   
        }
        public static int SumArray(int X,params int[] Arr)
        {
            int Sum = 0;
            //Arr[0] = 100;
            //Arr = new int[] {4,5,6 };
            for(int i  = 0; i < Arr.Length; i++) 
        {
                Sum += Arr[i];
            }
            return Sum;

        }
        public static int SumArray(ref int[] Arr)
        {
            int Sum = 0;
            //Arr[0] = 100;
            Arr = new int[] {4,5,6};
            for (int i = 0; i < Arr.Length; i++)
            {
                Sum += Arr[i];
            }
            return Sum;
        }
        public static void SumMul(int X, int Y,ref int Sum, ref int Mul )
        {
             Sum = X + Y;
             Mul = X * Y;

        }
        static void Main(string[] args)
        {
            #region Casting [Boxing - Unboxing]
            //Boxing Casting => Convert from Reference Type to Value Type To Reference Type
            //unBoxing Casting => Covert from Reference Type to Value Type
            //object obj = new object();
            //obj= "Mostafa"
            //obj = 2;


            #region Boxing [Safe Code]
            //int x = 10;
            //object obj01 = new object();
            //obj01 = x;
            //Console.WriteLine(obj01); 
            #endregion

            #region Unboxing [un safe Code]
            //object obj02 = new object();
            //obj02 = 10;
            //int x = (int)obj02;
            //Console.WriteLine(x);  
            #endregion
            #region Nullable Datatype
            #region Value Type
            //int x = null; // int Number only
            //int? x = null; // Int Number and null

            //int x = 10;
            //int y = /*(int?)*/x;

            //int? x = 10;
            //int y;
            //if (x != null) {
            //     y = (int)x; //casting
            // }
            //else
            // {
            //     y = 0;
            // }
            //if (x.HasValue)
            //{
            //    y = x.Value; // not casting
            //} 
            //else
            //{
            //    y = 0;
            //}
            // y= x.HasValue ? x.Value : 0;   
            //Console.WriteLine(y); 
            #endregion
            #region Referene Type
            //string? name = null;
            //Console.WriteLine(name);
            #endregion
            #region Null PROPAGATION operator
            //int[] Numbers = null;
            //if (Numbers != null)
            //{

            //    for (int i = 0; i < Numbers.Length; i++)
            //    {
            //        Console.WriteLine(Numbers[i]);
            //    }
            //}
            //int Length = Numbers?.Length ?? 0;
            //Console.WriteLine(Length);
            //Employee Emp = new Employee();
            //Emp.Department = new Department();
            ////if (Emp != null)
            ////{
            ////    if (Emp.Department != null)
            ////    {
            ////        Console.WriteLine(Department.Name);
            ////    }
            ////}
            //Console.WriteLine(Emp?.Department?.Name ?? "not found");

            #endregion
            #endregion
            #endregion
            #region Functions
            //PrintShape(10, "*-*");
            //PrintShape(Pattern: "*-*",Count:10);
            //PrintShape();


            // Hellow Mostafa
            // Welcome To Route
            //Console.WriteLine(" Hellow Mostafa\nWelcome to\t");
            // String path:
            #endregion
            #region Value Type Paramters
            #region By Value
            //int A = 5;
            //int B = 9;
            //Console.WriteLine(A);
            //Console.WriteLine(B);
            //Swap(A, B);
            //Console.WriteLine(A);
            //Console.WriteLine(B);
            #endregion
            #region By Reference
            //int A = 5;
            //int B = 9;
            //Console.WriteLine(A);
            //Console.WriteLine(B);
            //Swap(ref A, ref B);
            //Console.WriteLine(A);
            //Console.WriteLine(B);
            #endregion
            #endregion
            #region Refernce Type
            #region Ex1
            #region ByValue
            //int[] Numbers = { 1, 2, 3 };
            //Console.WriteLine(Numbers);
            //Console.WriteLine(Numbers[0]); 
            #endregion
            #region By Ref
            //int[] Numbers = { 1, 2, 3 };
            //Console.WriteLine(SumArray(ref Numbers));
            //Console.WriteLine(Numbers[0]); 
            #endregion

            #endregion
            #region Ex02
            #region By Value
            //int[] Numbers = { 1, 2, 3 };
            //Console.WriteLine(SumArray(Numbers));
            //Console.WriteLine(Numbers[0]);

            #endregion
            #region by Ref
            //int[] Numbers = { 1, 2, 3 };
            //Console.WriteLine(SumArray(ref Numbers));
            //Console.WriteLine(Numbers[0]);
            #endregion
            #endregion
            #endregion
            #region Functions = Passing By out
            //int A = 10;
            //int B = 20;
         
            //int Sum = 0, Mul = 0;
            //SumMul(A, B, ref Sum, ref Mul);
            //Console.WriteLine(Sum);
            //Console.WriteLine(Mul);

            #endregion
            #region Functions - Parmas
            //int[] Numbers = {1, 2, 3,4,5,6,7,8,9,10};
            //Console.WriteLine(SumArray(1, 2, 3, 4, 5, 6, 7, 8, 9, 10));
            int A= 10, B = 20 ,C = 30;
            Console.WriteLine("A:{0},B:{1},C: {2}",A,B,C);
            #endregion
        }
    }
}

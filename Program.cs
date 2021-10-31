using System;

namespace PocDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            // Delegate
            // [access modifier] delegate [return type] [delegate name]([parameters])
            //var MyDelegateOptionOne = new MyDelegate(MethodA);
            //MyDelegateOptionOne.Invoke("Hello There");
            //MyDelegateOptionOne("Test");

            // or (available only at c# 10.0)
            // var MyDelegateOptionTwo = MethodA;
            
            // or set lambda expression (available only at c# 10.0)
            //var MyDelegateOptionThree = (string msg) => Console.WriteLine(msg);

            // Func
            // public delegate TResult Func<in T, out TResult>(T arg);
            //Func<int, int, int> myFunc = MethodB2;
            //Console.WriteLine(myFunc(10, 10));

            // Action
            // public delegate void Print(int val);
            //Action<string> myAction = MethodC;
            //myAction("Test");

            // Predicate
            //public delegate bool Predicate<in T>(T obj);
            //Predicate<int> myPredicate = MethodD;
            //Console.WriteLine(myPredicate(1));

            // Anonymous 
            // public delagate void Print(int value);
            //MethodE print = delegate(int val) { Console.WriteLine(val); };
            //print(1);
        }

        public static void MethodA(string message)
        {
            Console.WriteLine(message);
        }

        public static int MethodB1(int a)
        {
            return a;
        }

        public static int MethodB2(int a, int b)
        {
            return a + b;
        }

        public static void MethodC(string message)
        {
            Console.WriteLine(message);
        }

        public static bool MethodD(int a)
        {
            return a > 10;
        }

        delegate void MethodE(int a);

        //In another word this delegate is an Action
        //Because has an input but do not returns a value
        delegate void MyDelegate(string msg);
    }
}

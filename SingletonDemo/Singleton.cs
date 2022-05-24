using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDemo
{
    // Using Method
    class SingletonMethod1
    {
        private SingletonMethod1() {
            Console.WriteLine($" SingletonMethod1 ");
        }

        private static SingletonMethod1 _instance;
        public static SingletonMethod1 GetInstance()
        {
            if (_instance == null)
            {
                _instance = new SingletonMethod1();
            }
            return _instance;
        }

        public void PrintMsg(string message)
        {
            Console.WriteLine(message);
        }
    }

    // No Thread Safe Singleton - Using Properties
    public sealed class SingletonMethod2
    {
        private SingletonMethod2() {
            Console.WriteLine($" SingletonMethod2 ");
        }

        private static SingletonMethod2 _instance = null;

        public static SingletonMethod2 instance
        {
            get {
                if (_instance == null)
                {
                    _instance = new SingletonMethod2();
                }
                return _instance;
            }

        }

        public void PrintMsg(string message)
        {
            Console.WriteLine(message);
        }
    }

    // No Thread Safe Singleton - Using Properties (2)
    internal sealed class Singleton
    {
        private static int counter = 0;
        
        private static Singleton instance = null;
        public static Singleton GetInstance {
            get {
                if (instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }
        private Singleton()
        {
            counter++;
            Console.WriteLine($"Counter value: {counter} ");
        }
        public void PrintMsg(string message)
        {
            Console.WriteLine(message);
        }
    }

    // Using lock
    public sealed class SingletonMethod3
    {
        private static readonly object Instancelock = new object();
        private SingletonMethod3() {
            Console.WriteLine($" SingletonMethod3 ");
        }

        private static SingletonMethod3 _instance = null;

        public static SingletonMethod3 instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (Instancelock)
                    {
                        if (_instance == null)
                        {
                            _instance = new SingletonMethod3();
                        }
                    }
                }
                return _instance;
            }

        }

        public void PrintMsg(string message)
        {
            Console.WriteLine(message);
        }
    }
}

﻿// file:	singleton.cs
//
// summary:	Implements the singleton class

using System;

namespace _0001_First_Singleton
{
    public sealed class Singleton
    {
        private static int _counter = 0;

        private static Singleton _instance = null;

        private static readonly object obj = new object();

        public static Singleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (obj)
                    {
                        if (_instance == null)
                            _instance = new Singleton();
                    }
                }
                return _instance;
            }
        }

        private Singleton()
        {
            _counter++;
            Console.WriteLine("I'm the counter from default constructor, count - {0}", _counter);
        }

        public void PrintDetails(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}

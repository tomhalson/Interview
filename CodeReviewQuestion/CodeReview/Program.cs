﻿using System;

namespace CodeReview
{
    class Program
    {
        static void Main(string[] args)
        {
            var cat = new Animal("Cat");
            var dog = new Animal("Dog");
            cat.MakeSound();
            dog.MakeSound();
            cat.MakeSound();
            dog.MakeSound();
            Console.ReadKey();
            
        }
    }
}

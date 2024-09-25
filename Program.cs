﻿using System;
using System.Collections.Generic;

namespace RangeException
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<char> characters = new List<char>();
                characters.InsertRange(0, new Char[] { 'a', 'b', 'c', 'd', 'e', 'f' });
                int value = characters[6];
            }
            catch (ArgumentOutOfRangeException ex)
            {
                System.Console.WriteLine(ex.Message);
            }
        }
    }
}
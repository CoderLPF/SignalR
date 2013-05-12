﻿using System;
using Microsoft.Owin.Hosting;

namespace Microsoft.AspNet.Owin.Samples
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (WebApp.Start<Startup>(8080))
            {
                Console.WriteLine("Server running at http://localhost:8080/");
                Console.ReadLine();
            }
        }
    }
}

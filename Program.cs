﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace AudioDGRestarter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Audio DG Restarter"; //Set Console title
            Process.Start("cmd", "/C taskkill /f /im audiodg.exe && audiodg.exe");
        }
    }
}

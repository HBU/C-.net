﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Test13_1
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Test13_1());
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Test8
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
            Application.Run(new Test8_3.Test8_3());
        }
    }
}

﻿using System;
using System.Windows.Forms;

namespace Спецодежда_СИЗ
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Авторизация());
            }
            catch
            {
            }
        }
    }
}

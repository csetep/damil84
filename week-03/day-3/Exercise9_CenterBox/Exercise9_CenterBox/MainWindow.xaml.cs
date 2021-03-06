﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using GreenFox;

namespace Exercise9_CenterBox
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            int x = 50;
            var foxDraw = new FoxDraw(canvas);
            FourSquare(foxDraw, x);
        }

        public static void FourSquare(FoxDraw foxDraw, int x)
        {
            foxDraw.BackgroundColor(Colors.LightGray);
            var random = new Random();
            for (int i = 0; i < 3; i++)
            {

                foxDraw.DrawRectangle((250-x/2), (250-x/2), x, x);
                foxDraw.FillColor(Color.FromRgb((byte)random.Next(), (byte)random.Next(), (byte)random.Next()));

            }
        }
    }
}
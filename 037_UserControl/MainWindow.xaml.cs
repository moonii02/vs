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

namespace _037_UserControl
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Red_Click(object sender, RoutedEventArgs e)
        {
            btnColor.Background = Brushes.Red;
        }

        private void Green_Click(object sender, RoutedEventArgs e)
        {
            btnColor.Background = Brushes.Green;
        }

        private void Blue_Click(object sender, RoutedEventArgs e)
        {
            btnColor.Background = Brushes.Blue;
        }
    }
}

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

namespace _036_Language
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

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            CheckBox[] cbs = new CheckBox[] { cbC, cbCp, cbCs, cbP, cbJ };
            CheckBox[] cbb = { cbC, cbCp, cbCs, cbP, cbJ };

            string s = string.Empty;
            foreach (var x in cbs)
            { 
                if (x.IsChecked == true)
                s += x.Content + " ";
            }
            MessageBox.Show(s + " 언어를 선택하셨습니다.", "Language Preferred");
        }
    }
}

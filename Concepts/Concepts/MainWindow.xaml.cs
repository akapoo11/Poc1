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

namespace Concepts
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Covariance_Net35_Click(object sender, RoutedEventArgs e)
        {
            Covariance_Net3._5.Learning.Learn();
            
        }

        private void Covariance_NET45_Click(object sender, RoutedEventArgs e)
        {
            Covariance_NET4._5.Learning.Learn();
            
        }
    }
}

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

namespace WpfQuanAn.view
{
    /// <summary>
    /// Interaction logic for PageThongBaoUserControl.xaml
    /// </summary>
    public partial class PageThongBaoUserControl : UserControl
    {
        public PageThongBaoUserControl()
        {
            InitializeComponent();
        }

        private void Ok_Click(object sender, RoutedEventArgs e)
        {
            this.GridPage.Children.Clear();
            BanAnUserControl uc = new BanAnUserControl();
            this.GridPage.Children.Add(uc);
        }
    }
}

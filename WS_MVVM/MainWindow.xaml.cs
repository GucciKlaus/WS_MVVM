﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WS_MVVM
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            /*Context anlegen und dann mitgeben*/
            this.DataContext = new PatientViewModel();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            (this.DataContext as PatientViewModel).Patients.Add(new Patient { Firstname = "Sepp", Lastname = "neu" });
        }
    }
}
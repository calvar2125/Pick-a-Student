using System;
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

namespace ProtoypeofPrototype
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const string pcName = "COSC 9001";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void editClass_Click(object sender, RoutedEventArgs e)
        {
            WhatCourse.Content = pcName;
            editCB.IsEnabled = true;
            randomizer.IsEnabled = true;
        }
       //AddStudentToClass window1 = null;
        addStudentVerFancy window3 = null;
        private void editCourse(object sender, RoutedEventArgs e)
        {
           /* if(!Application.Current.Windows.OfType<AddStudentToClass>().Any())
            {
                window1 = new AddStudentToClass();
                window1.Show();
            }*/
            if(!Application.Current.Windows.OfType<addStudentVerFancy>().Any())
            {
                window3 = new addStudentVerFancy();
                window3.Show();
            }
            
        }
        PICK_A_STUDENT window2 = null;
        private void pickAStudent(object sender, RoutedEventArgs e)
        {
            if (!Application.Current.Windows.OfType<PICK_A_STUDENT>().Any())
            {
                window2 = new PICK_A_STUDENT();
                window2.Show();
            }
        }
    }
}

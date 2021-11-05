using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ProtoypeofPrototype
{
    /// <summary>
    /// Interaction logic for addStudentVerFancy.xaml
    /// </summary>
    /// 
    /*TODO:
    1.) Hook up to draw names from Database.
    2.) Add names to Database
    3.) Remove names from Database
    4.) Get delete function working
    5.) Migrate to separate page, not window
    6.) Add ability to save changes.
         
    */
    public partial class addStudentVerFancy : Window
    {
        //public static string name = "";
        public addStudentVerFancy()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
            
            
        }

        private void addStudent_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(stuName.Text))
            {
                stuList.Items.Add(stuName.Text);
                //name = stuName.Text;
                stuName.Clear();
               // MessageBox.Show("The Name: " + name);
            }
        }

        private void ListBoxItem_Selected(object sender, RoutedEventArgs e)
        {
            stuName.Text = item1.Content.ToString();
        }

        private void item2_Selected(object sender, RoutedEventArgs e)
        {
            stuName.Text = item2.Content.ToString();
        }

        private void item3_Selected(object sender, RoutedEventArgs e)
        {
            stuName.Text = item3.Content.ToString();
        }

        private void item4_Selected(object sender, RoutedEventArgs e)
        {
            stuName.Text = item4.Content.ToString();
        }

        private void item5_Selected(object sender, RoutedEventArgs e)
        {
            stuName.Text = item5.Content.ToString();
        }

        private void deleteStudent(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(stuName.Text))
            {
                int index = stuList.Items.IndexOf(stuName.Text);
                stuList.Items.RemoveAt(index);
                stuName.Clear();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}

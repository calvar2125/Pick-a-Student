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
    /// Interaction logic for AddStudentToClass.xaml
    /// </summary>
    public partial class AddStudentToClass : Window
    {
        public AddStudentToClass()
        {
            InitializeComponent();
        }

        private void ButtonNameAdd_Click(object sender, RoutedEventArgs e)
        {
           /* lstNames.Items.Add(stuNameBox.Text);
            stuNameBox.Clear();
            stuID.Items.Add(stuIDBox.Text);
            stuIDBox.Clear();*/
            if (!string.IsNullOrWhiteSpace(stuNameBox.Text) && !string.IsNullOrWhiteSpace(stuIDBox.Text) && !lstNames.Items.Contains(stuNameBox.Text) && !stuID.Items.Contains(stuIDBox.Text))
            {
                lstNames.Items.Add(stuNameBox.Text);
                stuNameBox.Clear();
                stuID.Items.Add(stuIDBox.Text);
                stuIDBox.Clear();
            }
        }
    }
}

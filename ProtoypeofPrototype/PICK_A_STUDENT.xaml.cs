using System;
using System.Collections.Generic;
using System.IO;
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
    /// Interaction logic for PICK_A_STUDENT.xaml
    /// </summary>
    /// 
    //NOTE:
    /*TODO
    1.) Create Global State that can keep track of variables needing to be updated in the database (such as smilies.)
    2.) Give students unique Random ID that program can use instead of indexes, may negate necessity of above for smilies purpose
    3.) Create floating bubbles that pop after a set time.
    4.) Add music.
         
    */
    public partial class PICK_A_STUDENT : Window
    {

        public PICK_A_STUDENT()
        {
            InitializeComponent();
            Reset_Button.Visibility = Visibility.Hidden;
            Save.Visibility = Visibility.Hidden;
        }
        //Global is bad, but I just need to make this work, haha.
        FileStream fs = new FileStream("ClassList.txt", FileMode.Open, FileAccess.Read);
        string[] lines = System.IO.File.ReadAllLines("ClassList.txt");
        int[] randomIntList = new int[15];
        int[] largeRandIntList = new int[200];
        int[] numbers = new int[15];
        public static int clicks1;
        public static int clicks2;
        public static int clicks3;
        public static int clicks4;


        private void randomstudentList()
        {
            Random random = new Random();
            
            for (int i = 0; i < 200; i++)
            {
                largeRandIntList[i] = random.Next(1, 15);
            }

            int count = 0;
            for (int i = 0; i < 200; i++)
            {
                if (largeRandIntList[i] > -1 && count < 15)
                {
                    numbers[count] = largeRandIntList[i];
                    int temp = largeRandIntList[i];
                    count++;
                    for (int j = 0; j < 200; j++)
                    {
                        if (largeRandIntList[j] == temp)
                        {
                            largeRandIntList[j] = -1;
                        }
                    }
                }
            }
        }
        
        private void beginRandom(object sender, RoutedEventArgs e)
        {
            randomstudentList();
            Reset_Button.Visibility = Visibility.Visible;
            Save.Visibility = Visibility.Visible;
            nextStu.Visibility = Visibility.Visible;
            begin.Visibility = Visibility.Hidden;
            smile1.Visibility = Visibility.Visible;
            smile2.Visibility = Visibility.Visible;
            smile3.Visibility = Visibility.Visible;
            smile4.Visibility = Visibility.Visible;
            getNextStudent();

        }

        private void nextStudent(object sender, RoutedEventArgs e)
        {
            smile1.Source = new BitmapImage(new Uri("goodAnswer.png",UriKind.Relative));
            smile2.Source = new BitmapImage(new Uri("thinkAnswer.png", UriKind.Relative));
            smile3.Source = new BitmapImage(new Uri("notQuiteAnswer.png", UriKind.Relative));
            smile4.Source = new BitmapImage(new Uri("absentAnswer.png", UriKind.Relative));
            getNextStudent();
        }
        private void getNextStudent()
        {
            bool findStudent = false;
            bool emptyList = false;
            nextStu.IsEnabled = true;
            Save.IsEnabled = true;
            int i = 0;
            while(!findStudent)
            {
                if(i < 15)
                {
                    if (numbers[i] != -1)
                    {
                        stuName.Content = lines[numbers[i]];
                        numbers[i] = -1;
                        findStudent = true;
                    }
                    else
                    {
                        if (i < 15)
                        {
                            i++;
                        }
                    }
                }
                else
                {
                    findStudent = true;
                    emptyList = true;
                }
            }
            if(emptyList == true)
            {
                stuName.Content = "FINISHED";
                nextStu.IsEnabled = false;
                begin.IsEnabled = false;
                Save.IsEnabled = false;
                MessageBox.Show("button has been clicked " + clicks1 + " " + clicks2 + " " + clicks3 + " " + clicks4);
                //MessageBox.Show("button has been clicked " + listOfClicks1 + " " + listOfClicks2 + " " + listOfClicks3 + " " + listOfClicks4);


            }
            
        }

        private void smile1Click(object sender, MouseButtonEventArgs e)
        {
            
            smile1.Source = new BitmapImage(new Uri("goodAnswerSelected.png", UriKind.Relative));
            smile2.Source = new BitmapImage(new Uri("thinkAnswer.png", UriKind.Relative));
            smile3.Source = new BitmapImage(new Uri("notQuiteAnswer.png", UriKind.Relative));
            smile4.Source = new BitmapImage(new Uri("absentAnswer.png", UriKind.Relative));
            clicks1++;
        }

        private void smile2Click(object sender, MouseButtonEventArgs e)
        {
            
            smile2.Source = new BitmapImage(new Uri("thinkAnswerSelected.png", UriKind.Relative));
            smile1.Source = new BitmapImage(new Uri("goodAnswer.png", UriKind.Relative));
            smile3.Source = new BitmapImage(new Uri("notQuiteAnswer.png", UriKind.Relative));
            smile4.Source = new BitmapImage(new Uri("absentAnswer.png", UriKind.Relative));
            clicks2++;
        }

        private void smile3Click(object sender, MouseButtonEventArgs e)
        {
            
            smile3.Source = new BitmapImage(new Uri("notQuiteAnswerSelected.png", UriKind.Relative));
            smile1.Source = new BitmapImage(new Uri("goodAnswer.png", UriKind.Relative));
            smile2.Source = new BitmapImage(new Uri("thinkAnswer.png", UriKind.Relative));
            smile4.Source = new BitmapImage(new Uri("absentAnswer.png", UriKind.Relative));
            clicks3++;
        }

        private void smile4Click(object sender, MouseButtonEventArgs e)
        {
      
            smile4.Source = new BitmapImage(new Uri("absentAnswerSelected.png", UriKind.Relative));
            smile1.Source = new BitmapImage(new Uri("goodAnswer.png", UriKind.Relative));
            smile2.Source = new BitmapImage(new Uri("thinkAnswer.png", UriKind.Relative));
            smile3.Source = new BitmapImage(new Uri("notQuiteAnswer.png", UriKind.Relative));
            clicks4++;
        }

        private void Reset_Button_Click(object sender, RoutedEventArgs e)
        {
            randomstudentList();
            Reset_Button.Visibility = Visibility.Visible;
            Save.Visibility = Visibility.Visible;
            nextStu.Visibility = Visibility.Visible;
            begin.Visibility = Visibility.Hidden;
            smile1.Visibility = Visibility.Visible;
            smile2.Visibility = Visibility.Visible;
            smile3.Visibility = Visibility.Visible;
            smile4.Visibility = Visibility.Visible;
            getNextStudent();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {

        }

        private void exitMenu(object sender, MouseButtonEventArgs e)
        {
            Close();
        }
    }

}

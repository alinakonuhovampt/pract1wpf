using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
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

namespace pract1wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string t = "";

        int[] array = new int[9];
        Button[] btn = new Button[9];
        Random rnd = new Random();
            
        public MainWindow()
        {
            InitializeComponent();
            if (rnd.Next(1,10) <= 5)
            {
                t = "X";
            }
            else
            {
                t = "Ходят нолики";
            }
            btn[0] = Button1;
            btn[1] = Button2;
            btn[2] = Button3;
            btn[3] = Button4;
            btn[4] = Button5;
            btn[5] = Button6;
            btn[6] = Button7;
            btn[7] = Button8;
            btn[8] = Button9;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < btn.Length; i++)
            {
                array[i] = 0;
                btn[i].Content = "";

                if (rnd.Next(1, 10) <= 5)
                {
                    t = "Крестики";

                }
                else
                {
                    t = "Ходят 0";
                }

                btn[i].IsEnabled = true;

            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (t == "X") { 
            for (int i = 0;  i < btn.Length; i++)
                {
                    if (sender == btn[i])
                    {
                        btn[i].Content = "X";
                        t = "1";
                        btn[i].IsEnabled = false;
                        array[i] = 1;
                        break;
                    }
                }
            }


            else 
            {
                for (int i = 0; i < btn.Length; i++)
                {
                    if (sender == btn[i])
                    {
                        btn[i].Content = "O";
                        t = "X";
                        btn[i].IsEnabled = false;
                        array[i] = 2;
                        break;
                    }
                }

            }
            for (int i = 0; i < btn.Length; i++)
            {
                array[i] = 0;
                btn[i].Content = "";

                if (rnd.Next(1, 10) <= 5)
                {
                    t = "Крестики";
                }
                else
                {
                    t = "Ходят 0";

                }

                btn[i].IsEnabled = true;

            }

            if (array[0] == 1 && array[1] == 1 && array[2] == 1)
            {

                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].IsEnabled = false;
                }

                MessageBox.Show("Победили крестики");


            }

            else if (array[3] == 1 && array[4] == 1 && array[5] == 1)
            {


                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].IsEnabled = false;
                }

                MessageBox.Show("Победили крестики");


            }

            else if (array[6] == 1 && array[7] == 1 && array[8] == 1)
            {

                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].IsEnabled = false;
                }

                MessageBox.Show("Победили крестики");


            }


            else if (array[1] == 1 && array[3] == 1 && array[6] == 1)
            {
                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].IsEnabled = false;
                }

                MessageBox.Show("Победили крестики");


            }


            else if (array[1] == 1 && array[4] == 1 && array[7] == 1)
            {

                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].IsEnabled = false;
                }

                MessageBox.Show("Победили крестики");


            }

            else if (array[2] == 1 && array[5] == 1 && array[8] == 1)
            {

                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].IsEnabled = false;
                }

                MessageBox.Show("Победили нолики");


            }

            else if (array[0] == 1 && array[4] == 1 && array[8] == 2)
            {

                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].IsEnabled = false;
                }

                MessageBox.Show("Победили нолики");


            }

            else if (array[2] == 2 && array[4] == 2 && array[6] == 2)
            {

                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].IsEnabled = false;
                }

                MessageBox.Show("Победили нолики");


            }

            else if (array[0] == 2 && array[1] == 2 && array[2] == 2)
            {


                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].IsEnabled = false;
                }

                MessageBox.Show("Победили нолики");


            }

            else if (array[3] == 2 && array[4] == 2 && array[5] == 2)
            {


                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].IsEnabled = false;
                }

                MessageBox.Show("Победили нолики");


            }

            else if (array[6] == 2 && array[7] == 2 && array[8] == 2)
            {

                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].IsEnabled = false;
                }

                MessageBox.Show("Победили нолики");


            }


            else if (array[0] == 2 && array[3] == 2 && array[6] == 2)
            {

                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].IsEnabled = false;
                }

                MessageBox.Show("Победили нолики");


            }

            else if (array[1] == 2 && array[4] == 2 && array[7] == 2)
            {


                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].IsEnabled = false;
                }

                MessageBox.Show("Победили нолики");


            }

            else if (array[2] == 2 && array[5] == 2 && array[8] == 2)
            {

                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].IsEnabled = false;
                }

                MessageBox.Show("Победили нолики");


            }

            else if (array[0] == 2 && array[4] == 2 && array[8] == 2)
            {

                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].IsEnabled = false;
                }

                MessageBox.Show("Победили нолики");


            }


            else if (array[2] == 2 && array[4] == 2 && array[6] == 2)
            {

                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].IsEnabled = false;
                }

                MessageBox.Show("Победили нолики");


            }
        }
    }

}

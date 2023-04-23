using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Basic_Calculator : Form
    {

        /// The process to calculate two number is to add #1, add sign, add #2 to text screen.
        private double number1;
        private char sign;
        private double number2;
        private bool control;

        public Basic_Calculator()
        {
           
            InitializeComponent();
            number1 = 0;
            number2 = 0;
            sign = ' ';
            control = false;
        }

        public void btn_sign_click(object sender, EventArgs e)
        {
            /// sender represents elements that trigger the event.
            /// for example btn_close_Click represents to close calculator.
            /// e represent the event. 
            /// for example closing is an event.

            /// MessageBox is "Console" for Windows form applications.
            /// At the line below, it is said that sender is button.
            Button button = sender as Button;
            //MessageBox.Show(button.Name + " : " + button.Text);

            /// The first element of text is assigned to sign.
            /// for example in 395+, + is assigned to sign.
            sign = button.Text[0];

            /// txt_screen.Text is assigned to number1
            Double.TryParse(txt_screen.Text, out number1); 

            /// to reset screen to get number2 after adding sign
            control = true;


            /// all the signs, such as "+", are assigned to btn_sign_click.
        }

        private void press_key (int key)
        {
            /// To reset screen to get number2
            if (control)
            {
                txt_screen.Text = "0";
                control = false;
            }
            
            /// TextBox storages string type values
            /// Button storages System.Windows.Forms.Button
            /// Button is a class that provides properties, methods, and events.
            /// press_key takes integer argument as called key.
            /// Any number in buttons from 0 to 9 is assigned to key as integer by press_key method.
            /// Integer values must be converted to String value to be shown at TextBox.
            /// If a number starts with a digit from 1 to 9, any leading 0 will be removed in a calculator.
            ///In the scenario, when a user press button on calculator about a digit from 0 to 9, the press_key function is activated and it takes the number as an integer value and displays it in the TextBox. However, if the number starts with 1 to 9, the default 0 at the screen of calculator will be removed. Since the TextBox returns string value, key must be converted to string from integer.
            if (txt_screen.Text == "0")
            {
                txt_screen.Text = key.ToString();
            }
            else
            {
                /// key will be converted to string automatically. 
                txt_screen.Text += key;
            }
        }

        private void btn_one_Click(object sender, EventArgs e)
        {
            press_key(1);
            /// The value can be taken by the other method below:
            /// txt_screen.Text = "1"
            /// However, if the way above is implemented, the aim of press_key function will be applied for each of numbers separately, potentially making the operation time-consuming. 
        }

        private void btn_two_Click(object sender, EventArgs e)
        {
            press_key(2);
        }

        private void btn_three_Click(object sender, EventArgs e)
        {
            press_key(3);
        }

        private void btn_four_Click(object sender, EventArgs e)
        {
            press_key(4);
        }

        private void btn_five_Click(object sender, EventArgs e)
        {
            press_key(5);
        }

        private void btn_six_Click(object sender, EventArgs e)
        {
            press_key(6);
        }

        private void btn_seven_Click(object sender, EventArgs e)
        {
            press_key(7);
        }

        private void btn_eight_Click(object sender, EventArgs e)
        {
            press_key(8);
        }

        private void btn_nine_Click(object sender, EventArgs e)
        {
            press_key(9);
        }

        private void btn_zero_Click(object sender, EventArgs e)
        {
            press_key(0);
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            /// The button is used for clean the screen and prints default 0.
            txt_screen.Text = "0";
        }

        private void btn_converter_Click(object sender, EventArgs e)
        {
            /// If the screen start with minus sign, remove it and print plus sign, and verci versi versa.
            if (txt_screen.Text.StartsWith("-"))
            {
                /// Start with second element in array. It means that minus sign will be deleted.
                /// Substring(1) means that take all the characters with second elements of array.
                txt_screen.Text = txt_screen.Text.Substring(1);
            }
            else
            {
                /// It means that if the text starts with plus sign, add minus sign to text.
                if (txt_screen.Text != "0")
                {
                    txt_screen.Text = '-' + txt_screen.Text;
                }
            }
                
          
        }

        private void btn_comma_Click(object sender, EventArgs e)
        {
            /// Contains mean that if the text contain what we search at any part of text, true will return.
            /// If the text does not contain comma sign, add it to text.
            /// if limits that comma could be added once.
            if(!txt_screen.Text.Contains(","))
            {
                txt_screen.Text += ","; 
            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (txt_screen.Text.Length > 0)
            {
                txt_screen.Text = txt_screen.Text.Substring(0,txt_screen.Text.Length - 1);
            }
        }

        private void btn_equal_Click(object sender, EventArgs e)
        {
            Double.TryParse(txt_screen.Text, out number2);

            switch (sign)
            {
                case '+':
                    txt_screen.Text = (number1 + number2).ToString();
                    break;
                case '-':
                    txt_screen.Text = (number1 - number2).ToString();
                    break;
                case '*':
                    txt_screen.Text = (number1 * number2).ToString();
                    break;
                case '/':
                    if (number2 == 0)
                    {
                        txt_screen.Text = "Cannot divide by zero";
                    }
                    else
                    {
                        txt_screen.Text = (number1 / number2).ToString();
                    }
                    break;
                default:
                    txt_screen.Text = "Invalid operation";
                    break;
            }

            /// Reset the variables to their initial values.
            number1 = 0;
            sign = ' ';
            number2 = 0;
            control = true;
            
        }

    }
 }


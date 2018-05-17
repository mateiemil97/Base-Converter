using System;
using System.Drawing;
using System.Windows.Forms;

namespace ED_Project
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
            Text = "Base converter";
            textBoxTitle.TabStop = false;
        }

        private string Base2 { get; set; }
        private string Base8 { get; set; }
        private string Base10 { get; set; }
        private string Base16 { get; set; }
       


        public void Clear()
        {
            //Radio Butons UnCheck

            radioButtonBits8.Checked = false;
            radioButtonBits16.Checked = false;
            radioButtonBits32.Checked = false;
            radioButtonComplement2.Checked = false;
           
            //TextBox Empty

            textBoxDecimal.Text = String.Empty;
            textBoxBinary.Text = String.Empty;
            textBoxHexadecimal.Text = String.Empty;
            textBoxOctal.Text = String.Empty;

            //ReadOnly StateChange

            textBoxDecimal.ReadOnly = false;
            textBoxBinary.ReadOnly = false;
            textBoxHexadecimal.ReadOnly = false;
            textBoxOctal.ReadOnly = false;

            buttonConvert.Enabled = true;

            //Reset Background color
            textBoxDecimal.BackColor = Color.FromArgb(224, 224, 224);
            textBoxBinary.BackColor = Color.FromArgb(224, 224, 224);
            textBoxHexadecimal.BackColor = Color.FromArgb(224, 224, 224);
            textBoxOctal.BackColor = Color.FromArgb(224, 224, 224);

            //Reset TextBox ForeColor
            textBoxDecimal.ForeColor = Color.FromArgb(33, 33, 33);
            textBoxBinary.ForeColor = Color.FromArgb(33, 33, 33);
            textBoxHexadecimal.ForeColor = Color.FromArgb(33, 33, 33);
            textBoxOctal.ForeColor = Color.FromArgb(33, 33, 33);
            
            labelOctal.Text = "Octal";

        }

        public void Clear(int a)
        {
            //Radio Butons UnCheck

            radioButtonBits8.Checked = false;
            radioButtonBits16.Checked = false;
            radioButtonBits32.Checked = false;


            //TextBox Empty

            textBoxDecimal.Text = String.Empty;
            textBoxBinary.Text = String.Empty;
            textBoxHexadecimal.Text = String.Empty;
            textBoxOctal.Text = String.Empty;

            //ReadOnly StateChange

            textBoxDecimal.ReadOnly = false;
            textBoxBinary.ReadOnly = false;
            textBoxHexadecimal.ReadOnly = false;
            textBoxOctal.ReadOnly = false;

            buttonConvert.Enabled = true;

            //Reset Background color
            textBoxDecimal.BackColor = Color.FromArgb(224, 224, 224);
            textBoxBinary.BackColor = Color.FromArgb(224, 224, 224);
            textBoxHexadecimal.BackColor = Color.FromArgb(224, 224, 224);
            textBoxOctal.BackColor = Color.FromArgb(224, 224, 224);

            //Reset TextBox ForeColor
            textBoxDecimal.ForeColor = Color.FromArgb(33, 33, 33);
            textBoxBinary.ForeColor = Color.FromArgb(33, 33, 33);
            textBoxHexadecimal.ForeColor = Color.FromArgb(33, 33, 33);
            textBoxOctal.ForeColor = Color.FromArgb(33, 33, 33);
        }
        //ReadOnly State


        public void ReadOnlyState()
        {
            //ReadOnly StateChange

            textBoxDecimal.ReadOnly = true;
            textBoxBinary.ReadOnly = true;
            textBoxHexadecimal.ReadOnly = true;
            textBoxOctal.ReadOnly = true;
            buttonConvert.Enabled = false;

            // Read Only Color
            textBoxDecimal.BackColor = Color.FromArgb(117, 117, 117);
            textBoxBinary.BackColor = Color.FromArgb(117, 117, 117);
            textBoxOctal.BackColor = Color.FromArgb(117, 117, 117);
            textBoxHexadecimal.BackColor = Color.FromArgb(117, 117, 117);

            //Fore colour

            textBoxDecimal.ForeColor = Color.FromArgb(224, 224, 224);
            textBoxBinary.ForeColor = Color.FromArgb(224, 224, 224);
            textBoxOctal.ForeColor = Color.FromArgb(224, 224, 224);
            textBoxHexadecimal.ForeColor = Color.FromArgb(224, 224, 224);

            
        }

        public void ReadOnlyState(TextBox number1, TextBox number2, TextBox number3)
        {
            number1.ReadOnly = true;
            number2.ReadOnly = true;
            number3.ReadOnly = true;
            
            // Read Only Color
            number1.BackColor = Color.FromArgb(117, 117, 117);
            number2.BackColor = Color.FromArgb(117, 117, 117);
            number3.BackColor = Color.FromArgb(117, 117, 117);
            
            //Fore colour

            number1.ForeColor = Color.FromArgb(224, 224, 224);
            number2.ForeColor = Color.FromArgb(224, 224, 224);
            number3.ForeColor = Color.FromArgb(224, 224, 224);
            
        }

        // Emphasis Base

        public void EmphasisBase(TextBox TextBoxBackColor)
        {
            TextBoxBackColor.BackColor = Color.FromArgb(224, 224, 224);
            TextBoxBackColor.ForeColor = Color.FromArgb(33, 33, 33);
        }


        //Buttons

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            int count = 0;

            if (!String.IsNullOrWhiteSpace(textBoxBinary.Text))
                count++;

            if (!String.IsNullOrWhiteSpace(textBoxDecimal.Text))
                count++;

            if (!String.IsNullOrWhiteSpace(textBoxOctal.Text))
                count++;

            if (!String.IsNullOrWhiteSpace(textBoxHexadecimal.Text))
                count++;

            if(count == 0)
            {
                MessageBox.Show("Please insert an input!", "Warning!");
            }

            else if (radioButtonComplement2.Checked)
            {
                Base2 = textBoxBinary.Text;

                //Binary to Decimal
                Base10 = Convert.ToInt32(Base2, 2).ToString();

                int Aux = Convert.ToInt32(Base10) * (-1);
                

                if (radioButtonBits8.Checked)
                {
                    Base2 = Convert.ToString(Aux, 2);
                    Base2 = Base2.Substring(Math.Max(Base2.Length - 8, 0)).PadLeft(8, '0');
                }
                else if (radioButtonBits16.Checked)
                    Base2 = Convert.ToString((short)Aux, 2).PadLeft(16, '0'); 
                
                else if(radioButtonBits32.Checked)
                    Base2 = Convert.ToString(Aux, 2);
            
                else
                {
                    Base2 = Convert.ToString(Aux, 2);
                    Base2 = Base2.Substring(Math.Max(Base2.Length - 8, 0)).PadLeft(8, '0');
                }

                textBoxOctal.Text = Base2;
                buttonConvert.Enabled = false;
                textBoxBinary.ReadOnly = true;

            }

            else 
            {
                ReadOnlyState();

                //Decimal Input
                if (!String.IsNullOrWhiteSpace(textBoxDecimal.Text))
                {
                    int dec;
                    dec = Convert.ToInt32(textBoxDecimal.Text);
                    //Decimal to binary

                    if (radioButtonBits8.Checked)
                    
                        Base2 = Convert.ToString(dec, 2).PadLeft(8, '0');
                    
                    else if(radioButtonBits16.Checked)
                        Base2 = Convert.ToString(dec, 2).PadLeft(16, '0');

                    else if(radioButtonBits32.Checked)
                        Base2 = Convert.ToString(dec, 2).PadLeft(32, '0');
                    else
                        Base2 = Convert.ToString(dec, 2).PadLeft(8, '0');

                    textBoxBinary.Text = Base2;

                    //Decimal to Octal

                    Base8 = Convert.ToString(dec, 8);
                    textBoxOctal.Text = Base8;

                    //Decimal to Hexadecimal
                    Base16 = dec.ToString("X");
                    textBoxHexadecimal.Text = Base16;

                    //Emphasis base
                    EmphasisBase(textBoxDecimal);

                }

                // Binary Input

                else if (!String.IsNullOrWhiteSpace(textBoxBinary.Text))
                {

                    Base2 = textBoxBinary.Text;

                    //Binary to Decimal
                    Base10 = Convert.ToInt32(Base2, 2).ToString();
                    textBoxDecimal.Text = Base10;


                    //Binary to Octal

                    Base8 = Convert.ToString(Convert.ToInt32(Base10), 8);
                    textBoxOctal.Text = Base8;

                    //Binary to Hexadecimal

                    Base16 = Convert.ToInt32(Base10).ToString("X");
                    textBoxHexadecimal.Text = Base16;

                    //Emphasis base
                    EmphasisBase(textBoxBinary);

                }

                //Octal Input

                else if (!String.IsNullOrWhiteSpace(textBoxOctal.Text))
                {
                    Base8 = textBoxOctal.Text;

                    //Octal to Decimal

                    Base10 = Convert.ToInt32(Base8, 8).ToString();
                    textBoxDecimal.Text = Base10;

                    //Octal to Binary
                    
                    if (radioButtonBits8.Checked)
                    {
                        Base2 = Convert.ToString(Convert.ToInt32(Base10), 2).PadLeft(8, '0');
                    }
                    else if (radioButtonBits16.Checked)
                        Base2 = Convert.ToString(Convert.ToInt32(Base10), 2).PadLeft(16, '0');

                    else if (radioButtonBits32.Checked)
                        Base2 = Convert.ToString(Convert.ToInt32(Base10), 2).PadLeft(16, '0');
                    else
                        Base2 = Convert.ToString(Convert.ToInt32(Base10), 2);
                    
                    textBoxBinary.Text = Base2;

                    //Octal to Hexadecimal

                    Base16 = Convert.ToInt32(Base10).ToString("X");
                    textBoxHexadecimal.Text = Base16;

                    //Emphasis base
                    EmphasisBase(textBoxOctal);

                }

                //Hexadecimal Input

                else if (!String.IsNullOrWhiteSpace(textBoxHexadecimal.Text))
                {


                    Base16 = textBoxHexadecimal.Text;

                    //Hexadecimal to Decimal

                    Base10 = Convert.ToInt32(Base16, 16).ToString();
                    textBoxDecimal.Text = Base10;

                    //Hexadecimal to Binary

                    if (radioButtonBits8.Checked)
                    {
                        Base2 = Convert.ToString(Convert.ToInt32(Base10), 2).PadLeft(8, '0');
                    }
                    else if (radioButtonBits16.Checked)
                        Base2 = Convert.ToString(Convert.ToInt32(Base10), 2).PadLeft(16, '0');

                    else if (radioButtonBits32.Checked)
                        Base2 = Convert.ToString(Convert.ToInt32(Base10), 2).PadLeft(16, '0');
                    else
                        Base2 = Convert.ToString(Convert.ToInt32(Base10), 2);

                    textBoxBinary.Text = Base2;

                    //Hexadecimal to Octal

                    Base8 = Convert.ToString(Convert.ToInt32(Base10), 8);
                    textBoxOctal.Text = Base8;

                    //Emphasis base
                    EmphasisBase(textBoxHexadecimal);

                }
            }

            

        }

        
        //Clear Button
        private void buttonClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        //New Button Tool Strip Menu
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clear();
        }

        //Exit Tool Strip Button
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        //About Toll Strip Button
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is an app for base conversions." + "\n" + "Press ENTER to get the result" + "\n" + "Press ESC to clear fields" +"\n" + "\n" + "Digital Electronic Project 2018" + "\n" + "By Matei Emil" + "\n", "Help");
        }

        
        //Key restrictions

        //Binary TextBox
        private void textBoxBinary_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (ch != '0' && ch != '1' && ch != 08 && ch != 13)
                e.Handled = true;
                
            if (ch == 13)
                buttonConvert_Click(sender, e);

            ReadOnlyState(textBoxDecimal, textBoxOctal, textBoxHexadecimal);
            EmphasisBase(textBoxOctal);

            if (ch == 27)
                buttonClear_Click(sender, e);
        }

        //Decimal TextBox
        private void textBoxDecimal_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8  && ch != 13 && ch != '-')
                e.Handled = true;

            if (ch == 13)
                buttonConvert_Click(sender, e);
            ReadOnlyState(textBoxBinary, textBoxOctal, textBoxHexadecimal);
            if (ch == 27)
                buttonClear_Click(sender, e);
        }

        //Octal TextBox

        private void textBoxOctal_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (ch != '0' && ch != '1' && ch != '2' && ch != '3' && ch != '4' && ch != '5' && ch != '6' &&
                ch != '7' && ch != 08 && ch != 13 && ch != '-')

                e.Handled = true;

            if (ch == 13)
                buttonConvert_Click(sender, e);

            ReadOnlyState(textBoxDecimal, textBoxBinary, textBoxHexadecimal);

            if (ch == 27)
                buttonClear_Click(sender, e);
        }

        //Hexadecimal TextBox

        private void textBoxHexadecimal_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            char ch =Char.ToUpper(e.KeyChar);
            

            if (!Char.IsDigit(ch)  && ch != 'A' && ch != 'B' && ch != 'C' && ch != 'D' && ch != 'E' && ch != 'F' &&
                ch != 08 && ch != 13)
                e.Handled = true;

            if (ch == 13)
                buttonConvert_Click(sender, e);

            ReadOnlyState(textBoxDecimal, textBoxOctal, textBoxBinary);

            if (ch == 27)
                buttonClear_Click(sender,e);
        }


        private void Calculator_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;


            if (ch != 08 && ch != 13)
                e.Handled = true;

            if (ch == 13 && buttonConvert.Enabled != true)
                buttonConvert_Click(sender, e);

            if (ch == 27)
                buttonClear_Click(sender, e);
        }

        private void radioButtonComplement2_CheckedChanged(object sender, EventArgs e)
        {
            Clear(0);
            ReadOnlyState(textBoxDecimal, textBoxOctal, textBoxHexadecimal);
            labelOctal.Text = "Two’s Complement";
            EmphasisBase(textBoxOctal);
        }

       
    }
}

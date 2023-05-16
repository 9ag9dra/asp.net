using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01.Calculator_application_win_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")                 //testbox1 ke ander value empty nahi de sakte or na hi textbox2 me 
            {


                    float num1 = float.Parse(textBox1.Text);
                    float num2 = float.Parse(textBox2.Text);

                    float result = num1 + num2;
                    label4.Text = "addition result is" + " " + result.ToString();   // lebel 4 ke text ko hum result ki value provode kar rahe hai
                    label4.Visible = true;                                           // lebel 4 ko visible kar liya hai taki hum backend per isko use kar sake 

                    //  MessageBox.Show( "addition result is"+" "+ result.ToString());

                   
                
  
            }
            else
            {
                MessageBox.Show("please enter valid  number ");
            }

        }

        private void subtractbutton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != ""  && textBox2.Text!= "")   // textbox1 and textbox2 ki  value empty n ahi hiniu chahiye
            {


                float num1 = float.Parse(textBox1.Text);
                float num2 = float.Parse(textBox2.Text);

                float result = num1 - num2;
                label4.Text = "subtraction result is" + " " + result.ToString();   // lebel 4.text ko hum result ki value provide kar rahe hai 
                label4.Visible = true;                                             // lebel 4 is visible so that we can see the result given ti it , iski help se hi result show hoga 

                //  MessageBox.Show( "subtraction result is"+" "+ result.ToString());
            }
            else
            {
                MessageBox.Show("please enter valid  number");
            }



        }

        private void multiplybutton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")   // textbox1 and textbox2 ki  value empty n ahi hiniu chahiye
            {


                float num1 = float.Parse(textBox1.Text);
                float num2 = float.Parse(textBox2.Text);

                float result = num1 * num2;
                label4.Text = "multiplication result is" + " " + result.ToString();   // lebel 4.text ko hum result ki value provide kar rahe hai 
                label4.Visible = true;                                             // lebel 4 is visible so that we can see the result given ti it , iski help se hi result show hoga 

                //  MessageBox.Show( "multiplication result is"+" "+ result.ToString());
            }
            else
            {
                MessageBox.Show("please enter valid  number");
            }



        }

        private void dividebutton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox2.Text  != "0")   // textbox1 and textbox2 ki  value empty n ahi hiniu chahiye
            {


                float num1 = float.Parse(textBox1.Text);
                float num2 = float.Parse(textBox2.Text);

                float result = num1 /num2;
                label4.Text = "devision result is " + "" + result.ToString();       // lable4 ke ander hum result ki value print karva rahehai 
                label4.Visible = true;                                             // lebel 4 is visible so that we can see the result given ti it , iski help se hi result show hoga 

                //  MessageBox.Show( "division result is"+" "+ result.ToString());   // message ko messagebix ke throgh bhi show ya print karva sakte hai
            }
            else if  ( textBox1.Text != "0" &&  textBox2.Text == "0" )
            {
                label4.Text = "infinite";   
                label4.Visible = true;

              //  MessageBox.Show("infinite");


            }
            else            // if (textBox1.Text ==  "0"   && textBox2.Text  == "0")
            {
                label4.Text = "undefined"; 
                label4.Visible = true;
              //  MessageBox.Show("undefined");
            }

            
        }
    }
        
}  
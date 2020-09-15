using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/***************************************************************
* Name        : HelloWorldForm.cs
* Author      : Kabrina Brady
* Created     : 8/24/2019
* Course      : CIS 169 - C#
* Version     : 1.0
* OS          : Windows 10
* Copyright   : This is my own original work, based on a tutorial issued by my instructor
* Description : When the user clicks "Show Message", a message "Hello World" appears. The exit button exits the program.
*               Input:  Mouse (clicking buttons "Display Message" and "Exit")
*               Output: "Display Message" displays "Hello World" and "Exit" terminates the program
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or unmodified. I have not given other fellow student(s) access to my program.         
***************************************************************/

namespace HelloWorld_FirstProject
{
    public partial class HelloWorldForm : Form
    {
        public HelloWorldForm()
        {
            InitializeComponent();
        }
        //This method makes the Message Button display "Hello World" when clicked
        private void MessageButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World");
        }
        //This method makes the Exit Button terminate the program when clicked
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

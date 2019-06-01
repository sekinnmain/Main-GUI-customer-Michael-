using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Screen
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            UserNameTextBox.Clear();
            UserNameTextBox.ForeColor = Color.Black;
            if (UserNameTextBox.Text == "")
            {
                PassWordTextBox.ForeColor = Color.Gray;
                PassWordTextBox.Text = "Enter User Name Here";
            }

        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            
            PassWordTextBox.Clear();
            PassWordTextBox.ForeColor = Color.Black;
            if (UserNameTextBox.Text == "")
            {
                UserNameTextBox.ForeColor = Color.Gray;
                UserNameTextBox.Text = "Enter User Name Here";
            }
        }

        private void linkLabel2_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (UserNameTextBox.Text != "" && PassWordTextBox.Text != "")
            {
                if (UserNameTextBox.Text != "Enter User Name Here" && PassWordTextBox.Text != "Enter Pass Word Here")
                {
                    VipPanel.Visible = true;
                }
                else
                {
                    InvalidTextPanel.Visible = true;
                }

            }
            else
            {
                InvalidTextPanel.Visible = true;
            }
            

        }

        private void InvalidOKbutton_Click(object sender, EventArgs e)
        {
            InvalidTextPanel.Visible = false;
        }

        private void VipPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LogOutLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            VipPanel.Visible = false;
        }

        private void VIPorderFromMenuButton_Click(object sender, EventArgs e)
        {
            VipChooseLocationPanel.Visible = true;
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            VipChooseLocationPanel.Visible = false;
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GuestPanel.Visible = true;
        }

        private void GuestOrderFromMenuButton_Click(object sender, EventArgs e)
        {
            GuestLocationPanel.Visible = true;
        }

        private void SignInLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GuestPanel.Visible =false ;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GuestLocationPanel.Visible = false;
        }

        private void EatInsdieButton_MouseEnter(object sender, EventArgs e)
        {
            EatInsdieButton.BackColor = Color.DarkGoldenrod;
        }

        private void EatInsdieButton_MouseLeave(object sender, EventArgs e)
        {
            EatInsdieButton.BackColor = Color.Goldenrod;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            EatSomeWhereElseButtonGuestButton.BackColor = Color.DarkGoldenrod;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            EatSomeWhereElseButtonGuestButton.BackColor = Color.Goldenrod;
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            EatInsideButton.BackColor = Color.DarkGoldenrod;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            EatInsideButton.BackColor = Color.Goldenrod;
        }

        private void EatSomeWhereElseButton_MouseEnter(object sender, EventArgs e)
        {
            EatSomeWhereElseButton.BackColor = Color.DarkGoldenrod;
        }

        private void EatSomeWhereElseButton_MouseLeave(object sender, EventArgs e)
        {
            EatSomeWhereElseButton.BackColor = Color.Goldenrod;
        }

        private void GamesButton_MouseEnter(object sender, EventArgs e)
        {
            GamesButton.BackColor = Color.DarkGoldenrod;
        }

        private void GamesButton_MouseLeave(object sender, EventArgs e)
        {
            GamesButton.BackColor = Color.Goldenrod;
        }

        private void GuestOrderFromMenuButton_MouseEnter(object sender, EventArgs e)
        {
            GuestOrderFromMenuButton.BackColor = Color.DarkGoldenrod;
        }

        private void GuestOrderFromMenuButton_MouseLeave(object sender, EventArgs e)
        {
            GuestOrderFromMenuButton.BackColor = Color.Goldenrod;
        }

        private void GuestRetrunButton_MouseEnter(object sender, EventArgs e)
        {
            GuestRetrunButton.BackColor = Color.DarkGoldenrod;
        }

        private void GuestRetrunButton_MouseLeave(object sender, EventArgs e)
        {
            GuestRetrunButton.BackColor = Color.Goldenrod;
        }

        private void LoginButton_MouseEnter(object sender, EventArgs e)
        {
            LoginButton.BackColor = Color.DarkGoldenrod;
        }

        private void LoginButton_MouseLeave(object sender, EventArgs e)
        {
            LoginButton.BackColor = Color.Goldenrod;
        }

        private void PointShopButton_MouseEnter(object sender, EventArgs e)
        {
            PointShopButton.BackColor = Color.DarkGoldenrod;
        }

        private void PointShopButton_MouseLeave(object sender, EventArgs e)
        {
            PointShopButton.BackColor = Color.Goldenrod;
        }

        private void ReturnButton_MouseEnter(object sender, EventArgs e)
        {
            ReturnButton.BackColor = Color.DarkGoldenrod;
        }

        private void ReturnButton_MouseLeave(object sender, EventArgs e)
        {
            ReturnButton.BackColor = Color.Goldenrod;
        }

        private void VIPorderFromMenuButton_MouseEnter(object sender, EventArgs e)
        {
            VIPorderFromMenuButton.BackColor = Color.DarkGoldenrod;
        }

        private void VIPorderFromMenuButton_MouseLeave(object sender, EventArgs e)
        {
            VIPorderFromMenuButton.BackColor = Color.Goldenrod;
        }

        private void GuestLocationPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GuestLocationPanel_Click(object sender, EventArgs e)
        {
            if (UserNameTextBox.Text == "")
            {
                UserNameTextBox.ForeColor = Color.Gray;
                UserNameTextBox.Text = "Enter User Name Here";
            }
            if (PassWordTextBox.Text == "")
            {
                PassWordTextBox.ForeColor = Color.Gray;
                PassWordTextBox.Text = "Enter User Name Here";
            }
        }

        private void LoginScreen_Click(object sender, EventArgs e)
        {
            if (UserNameTextBox.Text == "")
            {
                UserNameTextBox.ForeColor = Color.Gray;
                UserNameTextBox.Text = "Enter User Name Here";
            }
            if (PassWordTextBox.Text == "")
            {
                PassWordTextBox.ForeColor = Color.Gray;
                PassWordTextBox.Text = "Enter User Name Here";
            }
        }

        private void GuestSignUpLabal_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void SignUpLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void SignInGuestLabel_Click(object sender, EventArgs e)
        {

        }

        private void SignUpLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void GuestSignUpLabal_Click(object sender, EventArgs e)
        {
            SignUp sign = new SignUp();
            sign.Show();
        }
    }
}

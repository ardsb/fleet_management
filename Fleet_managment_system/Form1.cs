﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Fleet_managment_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string conString = "Data Source=HYPERDESK-MINI;Initial Catalog=fleet_management;Integrated Security=True";

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {

                {
                    string q = "insert into Vehicle(Type,Reg_ID,Brand,Model,color,Year)values('" + Vehiclebox.Text + "','" + regidbox.Text.ToString() + "','" + brandbox.Text.ToString() + "','" + modelbox.Text.ToString() + "','" + colorbox.Text.ToString() + "','" + yearbox.Text.ToString() + "')";
                    SqlCommand cmd = new SqlCommand(q, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Vehicle has been Successfully Added ");
                }
            }
        }

            private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want delete your data","Warning",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Vehiclebox.ResetText();
                regidbox.Text = "";
                brandbox.Text = "";
                modelbox.Text = "";
                colorbox.Text = "";
                yearbox.ResetText();
            }
            
           
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {

            userControl21.Show();
            userControl21.BringToFront();

        }

        private void userControl11_Load(object sender, EventArgs e)
        {
            
        }

        private void userControl11_Load_1(object sender, EventArgs e)
        {

        }

        private void userControl12_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            userControl21.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            userControl21.Hide();
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Vehiclebox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void userControl21_Load(object sender, EventArgs e)
        {
        }
    }
}

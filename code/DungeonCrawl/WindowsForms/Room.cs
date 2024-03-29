﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsForms
{
    public partial class Room : Form
    {
        
        public Room(Form callingForm)
        {
            InitializeComponent();
            mainForm = callingForm as ObjectsForm;
        }

        private ObjectsForm mainForm = null;
        private void Room_Load(object sender, EventArgs e)
        {
            exitSouthComboBox.Items.Add("Yes");
            exitSouthComboBox.Items.Add("No");

            exitNorthComboBox.Items.Add("Yes");
            exitNorthComboBox.Items.Add("No");
        }


        private void AddButton_Click(object sender, EventArgs e)   
        {
            int northInt = 1;
            int southInt = 1;
            
            if(exitNorthComboBox.SelectedItem.ToString() == "Yes")
            {
                northInt = 0;
            }
            else if(exitNorthComboBox.SelectedItem.ToString() == "No")
            {
                northInt = -1;
            }

            if (exitSouthComboBox.SelectedItem.ToString() == "Yes")
            {
                southInt = 0;
            }
            else if (exitSouthComboBox.SelectedItem.ToString() == "No")
            {
                southInt = -1;
            }

            try
            {
                StreamWriter outputFile = File.AppendText(@"../../../ClassLibrary/Data/Rooms.txt");

                outputFile.WriteLine($"{roomIdTextBox.Text},{roomNameTextBox.Text},{roomDescTextBox.Text},{northInt},{southInt}");

                mainForm.roomsListBox.Items.Add(roomNameTextBox.Text);

                outputFile.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Cannot read file");
            }

            roomIdTextBox.Clear();
            roomNameTextBox.Clear();
            roomDescTextBox.Clear();
            exitNorthComboBox.SelectedIndex = -1;
            exitSouthComboBox.SelectedIndex = -1;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using System;
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
    public partial class CreateRoomForm : Form
    {
        public CreateRoomForm(Form callingForm)
        {
            InitializeComponent();
            mainForm = callingForm as ObjectsForm;
        }
        private ObjectsForm mainForm;
        private void CreateRoomForm_Load(object sender, EventArgs e)
        {
            exitSComboBox.Items.Add("Yes");
            exitSComboBox.Items.Add("No");

            exitNComboBox.Items.Add("Yes");
            exitNComboBox.Items.Add("No");
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            int northInt = 1;
            int southInt = 1;

            if (exitNComboBox.SelectedItem.ToString() == "Yes")
            {
                northInt = 0;
            }
            else if (exitNComboBox.SelectedItem.ToString() == "No")
            {
                northInt = -1;
            }

            if (exitSComboBox.SelectedItem.ToString() == "Yes")
            {
                southInt = 0;
            }
            else if (exitSComboBox.SelectedItem.ToString() == "No")
            {
                southInt = -1;
            }

            try
            {
                using (var outputFile = new StreamWriter(@"../../../ClassLibrary/Data/Rooms.txt", true))
                {
                    outputFile.WriteLine($"{roomIdTextBox.Text},{roomNameTextBox.Text},{roomDescTextBox.Text},{northInt},{southInt}");
                    outputFile.Close();
                }
                mainForm.roomsListBox.Items.Add(roomNameTextBox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Cannot read file");
            }
            this.Close();
        }
    }
}

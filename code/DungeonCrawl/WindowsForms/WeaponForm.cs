using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;
using System.IO;

namespace WindowsForms
{
    public partial class WeaponForm : Form
    {
        public WeaponForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter outputFile = File.AppendText(@"../../../ClassLibrary/Data/Weapons.txt");

                outputFile.WriteLine($"{weapNameComboBox.Text},{dmgTextBox.Text},{dmgTypeTextBox.Text},{costTextBox.Text}");

                outputFile.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Cannot read file!");
            }

            dmgTextBox.Clear();
            dmgTypeTextBox.Clear();
            costTextBox.Clear();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WeaponForm_Load(object sender, EventArgs e)
        {
            weapNameComboBox.Items.Add("Battleaxe");
            weapNameComboBox.Items.Add("Spear");
            weapNameComboBox.Items.Add("Quarterstaff");
            weapNameComboBox.Items.Add("Bow");
        }

        private void WeapNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(weapNameComboBox.SelectedItem.Equals("Battleaxe"))
            {
                dmgTextBox.Text = "1d8";
                dmgTypeTextBox.Text = "Slashing";
                costTextBox.Text = "10";
            }

            if (weapNameComboBox.SelectedItem.Equals("Spear"))
            {
                dmgTextBox.Text = "1d6";
                dmgTypeTextBox.Text = "Piercing";
                costTextBox.Text = "1";
            }

            if (weapNameComboBox.SelectedItem.Equals("Quarterstaff"))
            {
                dmgTextBox.Text = "1d6";
                dmgTypeTextBox.Text = "Bludgeoning";
                costTextBox.Text = "2";
            }

            if (weapNameComboBox.SelectedItem.Equals("Bow"))
            {
                dmgTextBox.Text = "1d10";
                dmgTypeTextBox.Text = "Piercing";
                costTextBox.Text = "5";
            }
        }
    }
}

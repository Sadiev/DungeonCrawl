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
    public partial class CreateWeaponForm : Form
    {
        public CreateWeaponForm(Form callingForm)
        {
            InitializeComponent();
            mainForm = callingForm as ObjectsForm;
        }
        private ObjectsForm mainForm = null;

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (var outputFile = new StreamWriter(@"../../../ClassLibrary/Data/Weapons.txt", true))
                {
                    outputFile.WriteLine($"{weapNameTextBox.Text},{dmgAmtTextBox.Text},{dmgTypeTextBox.Text},{costTextBox.Text}");
                    outputFile.Close();
                }
                mainForm.weaponsListBox.Items.Add(weapNameTextBox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Error reading file");
            }
            this.Close();
        }
    }
}

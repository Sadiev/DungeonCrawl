using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class CreateMobForm : Form
    {
        public CreateMobForm(Form callingForm)
        {
            InitializeComponent();
            mainForm = callingForm as ObjectsForm;
        }
        private ObjectsForm mainForm;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (var outputFile = new StreamWriter(@"../../../ClassLibrary/Data/Mobs.txt", true))
                {
                    outputFile.Write($"\n{NameTextBox.Text},{DescTextBox.Text},{HPTextBox.Text},{ACTextBox.Text},{DeadCheckBox.Checked},{DemageTextBox.Text}");
                }
                mainForm.MobListBox.Items.Add(NameTextBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Close();
        }
    }
}

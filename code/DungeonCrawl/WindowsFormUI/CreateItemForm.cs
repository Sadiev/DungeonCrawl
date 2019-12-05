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
    public partial class CreateItemForm : Form
    {
        public CreateItemForm(Form callingForm)
        {
            InitializeComponent();
            mainForm = callingForm as ObjectsForm;
        }
        private ObjectsForm mainForm = null;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (var outputFile = new StreamWriter(@"../../../ClassLibrary/Data/Items.txt", true))
                {
                    outputFile.Write($"\n{NameTextBox.Text},{DescTextBox.Text},{ValueTextBox.Text}");
                }
                mainForm.ItemListBox.Items.Add(NameTextBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Close();
        }
    }
}

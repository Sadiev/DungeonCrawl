using ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class ObjectsForm : Form
    {
        public ObjectsForm()
        {
            InitializeComponent();
        }

        private void ObjectsForm_Load(object sender, EventArgs e)
        {
            Upload.Items();
            Upload.Mobs();
            foreach (var item in Global.items)
            {
                ItemListBox.Items.Add(item.Name);
            }
            foreach (var mob in Global.mobs)
            {
                MobListBox.Items.Add(mob.Name);
            }
        }

        private void AddMobButton_Click(object sender, EventArgs e)
        {
            CreateMobForm mob = new CreateMobForm(this);
            mob.ShowDialog();
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            CreateItemForm item = new CreateItemForm(this);
            item.ShowDialog();
        }
    }
}

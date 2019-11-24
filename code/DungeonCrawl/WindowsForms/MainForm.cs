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
    public partial class ObjectsForm : Form
    {
        public ObjectsForm()
        {
            InitializeComponent();
        }

        private void ObjectsForm_Load(object sender, EventArgs e)
        {
            Upload.Weapons();
            Upload.Rooms();

            foreach(var i in Global.weapon)
            {
                weaponsListBox.Items.Add(i.Name);
            }

            foreach (var i in Global.rooms)
            {
                roomsListBox.Items.Add(i.RoomName);
            }
        }

        private void weaponsButton_Click(object sender, EventArgs e)
        {
            WeaponForm newWeapon = new WeaponForm();

            newWeapon.ShowDialog();
        }

        private void roomsButton_Click(object sender, EventArgs e)
        {
            Room newRoom = new Room();

            newRoom.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}

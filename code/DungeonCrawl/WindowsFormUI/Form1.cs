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
            Upload.Weapons();
            Upload.Rooms();
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
            foreach (var i in Global.weapon)
            {
                weaponsListBox.Items.Add(i.Name);
            }
            foreach (var i in Global.rooms)
            {
                roomsListBox.Items.Add(i.RoomName);
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

        private void AddWeaponButton_Click(object sender, EventArgs e)
        {
            CreateWeaponForm weapon = new CreateWeaponForm(this);
            weapon.ShowDialog();
        }

        private void AddRoomsButton_Click(object sender, EventArgs e)
        {
            CreateRoomForm room = new CreateRoomForm(this);
            room.ShowDialog();
        }
    }
}


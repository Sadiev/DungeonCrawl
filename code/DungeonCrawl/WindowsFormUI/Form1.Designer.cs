namespace WindowsForms
{
    partial class ObjectsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MobListBox = new System.Windows.Forms.ListBox();
            this.ItemListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddMobButton = new System.Windows.Forms.Button();
            this.AddItemButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.weaponsListBox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.roomsListBox = new System.Windows.Forms.ListBox();
            this.addWeaponButton = new System.Windows.Forms.Button();
            this.addRoomsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MobListBox
            // 
            this.MobListBox.FormattingEnabled = true;
            this.MobListBox.Location = new System.Drawing.Point(24, 36);
            this.MobListBox.Margin = new System.Windows.Forms.Padding(2);
            this.MobListBox.Name = "MobListBox";
            this.MobListBox.Size = new System.Drawing.Size(131, 95);
            this.MobListBox.TabIndex = 0;
            // 
            // ItemListBox
            // 
            this.ItemListBox.FormattingEnabled = true;
            this.ItemListBox.Location = new System.Drawing.Point(184, 36);
            this.ItemListBox.Margin = new System.Windows.Forms.Padding(2);
            this.ItemListBox.Name = "ItemListBox";
            this.ItemListBox.Size = new System.Drawing.Size(131, 95);
            this.ItemListBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mobs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Items";
            // 
            // AddMobButton
            // 
            this.AddMobButton.Location = new System.Drawing.Point(58, 144);
            this.AddMobButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddMobButton.Name = "AddMobButton";
            this.AddMobButton.Size = new System.Drawing.Size(56, 19);
            this.AddMobButton.TabIndex = 4;
            this.AddMobButton.Text = "Add";
            this.AddMobButton.UseVisualStyleBackColor = true;
            this.AddMobButton.Click += new System.EventHandler(this.AddMobButton_Click);
            // 
            // AddItemButton
            // 
            this.AddItemButton.Location = new System.Drawing.Point(217, 144);
            this.AddItemButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddItemButton.Name = "AddItemButton";
            this.AddItemButton.Size = new System.Drawing.Size(56, 19);
            this.AddItemButton.TabIndex = 5;
            this.AddItemButton.Text = "Add";
            this.AddItemButton.UseVisualStyleBackColor = true;
            this.AddItemButton.Click += new System.EventHandler(this.AddItemButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(340, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Weapons";
            // 
            // weaponsListBox
            // 
            this.weaponsListBox.FormattingEnabled = true;
            this.weaponsListBox.Location = new System.Drawing.Point(332, 36);
            this.weaponsListBox.Margin = new System.Windows.Forms.Padding(2);
            this.weaponsListBox.Name = "weaponsListBox";
            this.weaponsListBox.Size = new System.Drawing.Size(131, 95);
            this.weaponsListBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Rooms";
            // 
            // roomsListBox
            // 
            this.roomsListBox.FormattingEnabled = true;
            this.roomsListBox.Location = new System.Drawing.Point(24, 206);
            this.roomsListBox.Margin = new System.Windows.Forms.Padding(2);
            this.roomsListBox.Name = "roomsListBox";
            this.roomsListBox.Size = new System.Drawing.Size(131, 95);
            this.roomsListBox.TabIndex = 1;
            // 
            // addWeaponButton
            // 
            this.addWeaponButton.Location = new System.Drawing.Point(370, 144);
            this.addWeaponButton.Name = "addWeaponButton";
            this.addWeaponButton.Size = new System.Drawing.Size(56, 19);
            this.addWeaponButton.TabIndex = 7;
            this.addWeaponButton.Text = "Add";
            this.addWeaponButton.UseVisualStyleBackColor = true;
            this.addWeaponButton.Click += new System.EventHandler(this.AddWeaponButton_Click);
            // 
            // addRoomsButton
            // 
            this.addRoomsButton.Location = new System.Drawing.Point(58, 322);
            this.addRoomsButton.Name = "addRoomsButton";
            this.addRoomsButton.Size = new System.Drawing.Size(56, 19);
            this.addRoomsButton.TabIndex = 8;
            this.addRoomsButton.Text = "Add";
            this.addRoomsButton.UseVisualStyleBackColor = true;
            this.addRoomsButton.Click += new System.EventHandler(this.AddRoomsButton_Click);
            // 
            // ObjectsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.addRoomsButton);
            this.Controls.Add(this.addWeaponButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AddItemButton);
            this.Controls.Add(this.AddMobButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.roomsListBox);
            this.Controls.Add(this.weaponsListBox);
            this.Controls.Add(this.ItemListBox);
            this.Controls.Add(this.MobListBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ObjectsForm";
            this.Text = "List of objects";
            this.Load += new System.EventHandler(this.ObjectsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddMobButton;
        private System.Windows.Forms.Button AddItemButton;
        public System.Windows.Forms.ListBox ItemListBox;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.ListBox MobListBox;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ListBox weaponsListBox;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.ListBox roomsListBox;
        private System.Windows.Forms.Button addWeaponButton;
        private System.Windows.Forms.Button addRoomsButton;
    }
}




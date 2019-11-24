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
            this.SuspendLayout();
            // 
            // MobListBox
            // 
            this.MobListBox.FormattingEnabled = true;
            this.MobListBox.ItemHeight = 16;
            this.MobListBox.Location = new System.Drawing.Point(32, 44);
            this.MobListBox.Name = "MobListBox";
            this.MobListBox.Size = new System.Drawing.Size(173, 116);
            this.MobListBox.TabIndex = 0;
            // 
            // ItemListBox
            // 
            this.ItemListBox.FormattingEnabled = true;
            this.ItemListBox.ItemHeight = 16;
            this.ItemListBox.Location = new System.Drawing.Point(245, 44);
            this.ItemListBox.Name = "ItemListBox";
            this.ItemListBox.Size = new System.Drawing.Size(173, 116);
            this.ItemListBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mobs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Items";
            // 
            // AddMobButton
            // 
            this.AddMobButton.Location = new System.Drawing.Point(77, 177);
            this.AddMobButton.Name = "AddMobButton";
            this.AddMobButton.Size = new System.Drawing.Size(75, 23);
            this.AddMobButton.TabIndex = 4;
            this.AddMobButton.Text = "Add";
            this.AddMobButton.UseVisualStyleBackColor = true;
            this.AddMobButton.Click += new System.EventHandler(this.AddMobButton_Click);
            // 
            // AddItemButton
            // 
            this.AddItemButton.Location = new System.Drawing.Point(289, 177);
            this.AddItemButton.Name = "AddItemButton";
            this.AddItemButton.Size = new System.Drawing.Size(75, 23);
            this.AddItemButton.TabIndex = 5;
            this.AddItemButton.Text = "Add";
            this.AddItemButton.UseVisualStyleBackColor = true;
            this.AddItemButton.Click += new System.EventHandler(this.AddItemButton_Click);
            // 
            // ObjectsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddItemButton);
            this.Controls.Add(this.AddMobButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ItemListBox);
            this.Controls.Add(this.MobListBox);
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
    }
}


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
            this.weaponsListBox = new System.Windows.Forms.ListBox();
            this.weaponsButton = new System.Windows.Forms.Button();
            this.roomsListBox = new System.Windows.Forms.ListBox();
            this.roomsButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // weaponsListBox
            // 
            this.weaponsListBox.FormattingEnabled = true;
            this.weaponsListBox.Location = new System.Drawing.Point(617, 34);
            this.weaponsListBox.Name = "weaponsListBox";
            this.weaponsListBox.Size = new System.Drawing.Size(191, 134);
            this.weaponsListBox.TabIndex = 0;
            // 
            // weaponsButton
            // 
            this.weaponsButton.Location = new System.Drawing.Point(672, 207);
            this.weaponsButton.Name = "weaponsButton";
            this.weaponsButton.Size = new System.Drawing.Size(75, 23);
            this.weaponsButton.TabIndex = 1;
            this.weaponsButton.Text = "Add";
            this.weaponsButton.UseVisualStyleBackColor = true;
            this.weaponsButton.Click += new System.EventHandler(this.weaponsButton_Click);
            // 
            // roomsListBox
            // 
            this.roomsListBox.FormattingEnabled = true;
            this.roomsListBox.Location = new System.Drawing.Point(617, 260);
            this.roomsListBox.Name = "roomsListBox";
            this.roomsListBox.Size = new System.Drawing.Size(191, 121);
            this.roomsListBox.TabIndex = 2;
            // 
            // roomsButton
            // 
            this.roomsButton.Location = new System.Drawing.Point(672, 420);
            this.roomsButton.Name = "roomsButton";
            this.roomsButton.Size = new System.Drawing.Size(75, 23);
            this.roomsButton.TabIndex = 3;
            this.roomsButton.Text = "Add";
            this.roomsButton.UseVisualStyleBackColor = true;
            this.roomsButton.Click += new System.EventHandler(this.roomsButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(378, 552);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ObjectsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 605);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.roomsButton);
            this.Controls.Add(this.roomsListBox);
            this.Controls.Add(this.weaponsButton);
            this.Controls.Add(this.weaponsListBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ObjectsForm";
            this.Text = "List of objects";
            this.Load += new System.EventHandler(this.ObjectsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox weaponsListBox;
        private System.Windows.Forms.Button weaponsButton;
        private System.Windows.Forms.ListBox roomsListBox;
        private System.Windows.Forms.Button roomsButton;
        private System.Windows.Forms.Button exitButton;
    }
}


namespace WindowsForms
{
    partial class CreateRoomForm
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
            this.roomIdLabel = new System.Windows.Forms.Label();
            this.roomNameLabel = new System.Windows.Forms.Label();
            this.roomDescLabel = new System.Windows.Forms.Label();
            this.exitNLabel = new System.Windows.Forms.Label();
            this.exitSLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.roomIdTextBox = new System.Windows.Forms.TextBox();
            this.roomNameTextBox = new System.Windows.Forms.TextBox();
            this.roomDescTextBox = new System.Windows.Forms.TextBox();
            this.exitNComboBox = new System.Windows.Forms.ComboBox();
            this.exitSComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // roomIdLabel
            // 
            this.roomIdLabel.AutoSize = true;
            this.roomIdLabel.Location = new System.Drawing.Point(22, 21);
            this.roomIdLabel.Name = "roomIdLabel";
            this.roomIdLabel.Size = new System.Drawing.Size(47, 13);
            this.roomIdLabel.TabIndex = 0;
            this.roomIdLabel.Text = "Room Id";
            // 
            // roomNameLabel
            // 
            this.roomNameLabel.AutoSize = true;
            this.roomNameLabel.Location = new System.Drawing.Point(22, 53);
            this.roomNameLabel.Name = "roomNameLabel";
            this.roomNameLabel.Size = new System.Drawing.Size(66, 13);
            this.roomNameLabel.TabIndex = 1;
            this.roomNameLabel.Text = "Room Name";
            // 
            // roomDescLabel
            // 
            this.roomDescLabel.AutoSize = true;
            this.roomDescLabel.Location = new System.Drawing.Point(22, 86);
            this.roomDescLabel.Name = "roomDescLabel";
            this.roomDescLabel.Size = new System.Drawing.Size(91, 13);
            this.roomDescLabel.TabIndex = 2;
            this.roomDescLabel.Text = "Room Description";
            // 
            // exitNLabel
            // 
            this.exitNLabel.AutoSize = true;
            this.exitNLabel.Location = new System.Drawing.Point(22, 120);
            this.exitNLabel.Name = "exitNLabel";
            this.exitNLabel.Size = new System.Drawing.Size(65, 13);
            this.exitNLabel.TabIndex = 3;
            this.exitNLabel.Text = "Exit to North";
            // 
            // exitSLabel
            // 
            this.exitSLabel.AutoSize = true;
            this.exitSLabel.Location = new System.Drawing.Point(22, 155);
            this.exitSLabel.Name = "exitSLabel";
            this.exitSLabel.Size = new System.Drawing.Size(67, 13);
            this.exitSLabel.TabIndex = 4;
            this.exitSLabel.Text = "Exit to South";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(169, 206);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 12;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // roomIdTextBox
            // 
            this.roomIdTextBox.Location = new System.Drawing.Point(249, 21);
            this.roomIdTextBox.Name = "roomIdTextBox";
            this.roomIdTextBox.Size = new System.Drawing.Size(121, 20);
            this.roomIdTextBox.TabIndex = 5;
            // 
            // roomNameTextBox
            // 
            this.roomNameTextBox.Location = new System.Drawing.Point(249, 53);
            this.roomNameTextBox.Name = "roomNameTextBox";
            this.roomNameTextBox.Size = new System.Drawing.Size(121, 20);
            this.roomNameTextBox.TabIndex = 7;
            // 
            // roomDescTextBox
            // 
            this.roomDescTextBox.Location = new System.Drawing.Point(249, 86);
            this.roomDescTextBox.Name = "roomDescTextBox";
            this.roomDescTextBox.Size = new System.Drawing.Size(121, 20);
            this.roomDescTextBox.TabIndex = 8;
            // 
            // exitNComboBox
            // 
            this.exitNComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.exitNComboBox.FormattingEnabled = true;
            this.exitNComboBox.Location = new System.Drawing.Point(249, 120);
            this.exitNComboBox.Name = "exitNComboBox";
            this.exitNComboBox.Size = new System.Drawing.Size(121, 21);
            this.exitNComboBox.TabIndex = 10;
            // 
            // exitSComboBox
            // 
            this.exitSComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.exitSComboBox.FormattingEnabled = true;
            this.exitSComboBox.Location = new System.Drawing.Point(249, 155);
            this.exitSComboBox.Name = "exitSComboBox";
            this.exitSComboBox.Size = new System.Drawing.Size(121, 21);
            this.exitSComboBox.TabIndex = 11;
            // 
            // CreateRoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 241);
            this.Controls.Add(this.exitSComboBox);
            this.Controls.Add(this.exitNComboBox);
            this.Controls.Add(this.roomDescTextBox);
            this.Controls.Add(this.roomNameTextBox);
            this.Controls.Add(this.roomIdTextBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.exitSLabel);
            this.Controls.Add(this.exitNLabel);
            this.Controls.Add(this.roomDescLabel);
            this.Controls.Add(this.roomNameLabel);
            this.Controls.Add(this.roomIdLabel);
            this.Name = "CreateRoomForm";
            this.Text = "CreateRoomForm";
            this.Load += new System.EventHandler(this.CreateRoomForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label roomIdLabel;
        private System.Windows.Forms.Label roomNameLabel;
        private System.Windows.Forms.Label roomDescLabel;
        private System.Windows.Forms.Label exitNLabel;
        private System.Windows.Forms.Label exitSLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox roomIdTextBox;
        private System.Windows.Forms.TextBox roomNameTextBox;
        private System.Windows.Forms.TextBox roomDescTextBox;
        private System.Windows.Forms.ComboBox exitNComboBox;
        private System.Windows.Forms.ComboBox exitSComboBox;
    }
}
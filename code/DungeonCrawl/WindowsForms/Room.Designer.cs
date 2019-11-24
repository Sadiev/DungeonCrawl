namespace WindowsForms
{
    partial class Room
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.roomDescTextBox = new System.Windows.Forms.TextBox();
            this.roomNameTextBox = new System.Windows.Forms.TextBox();
            this.roomIdTextBox = new System.Windows.Forms.TextBox();
            this.exitSouthComboBox = new System.Windows.Forms.ComboBox();
            this.exitNorthComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Room Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 109);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Room Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 166);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "Room Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 220);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 26);
            this.label4.TabIndex = 0;
            this.label4.Text = "Exit to North";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 275);
            this.label5.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 26);
            this.label5.TabIndex = 0;
            this.label5.Text = "Exit to South";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(197, 362);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(131, 56);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(447, 362);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(131, 56);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // roomDescTextBox
            // 
            this.roomDescTextBox.Location = new System.Drawing.Point(423, 166);
            this.roomDescTextBox.Name = "roomDescTextBox";
            this.roomDescTextBox.Size = new System.Drawing.Size(205, 32);
            this.roomDescTextBox.TabIndex = 2;
            // 
            // roomNameTextBox
            // 
            this.roomNameTextBox.Location = new System.Drawing.Point(423, 109);
            this.roomNameTextBox.Name = "roomNameTextBox";
            this.roomNameTextBox.Size = new System.Drawing.Size(205, 32);
            this.roomNameTextBox.TabIndex = 2;
            // 
            // roomIdTextBox
            // 
            this.roomIdTextBox.Location = new System.Drawing.Point(423, 54);
            this.roomIdTextBox.Name = "roomIdTextBox";
            this.roomIdTextBox.Size = new System.Drawing.Size(205, 32);
            this.roomIdTextBox.TabIndex = 2;
            // 
            // exitSouthComboBox
            // 
            this.exitSouthComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.exitSouthComboBox.FormattingEnabled = true;
            this.exitSouthComboBox.Location = new System.Drawing.Point(423, 275);
            this.exitSouthComboBox.Name = "exitSouthComboBox";
            this.exitSouthComboBox.Size = new System.Drawing.Size(205, 33);
            this.exitSouthComboBox.TabIndex = 3;
            // 
            // exitNorthComboBox
            // 
            this.exitNorthComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.exitNorthComboBox.FormattingEnabled = true;
            this.exitNorthComboBox.Location = new System.Drawing.Point(423, 220);
            this.exitNorthComboBox.Name = "exitNorthComboBox";
            this.exitNorthComboBox.Size = new System.Drawing.Size(205, 33);
            this.exitNorthComboBox.TabIndex = 3;
            // 
            // Room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1733, 865);
            this.Controls.Add(this.exitNorthComboBox);
            this.Controls.Add(this.exitSouthComboBox);
            this.Controls.Add(this.roomIdTextBox);
            this.Controls.Add(this.roomNameTextBox);
            this.Controls.Add(this.roomDescTextBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "Room";
            this.Text = "Room";
            this.Load += new System.EventHandler(this.Room_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox roomDescTextBox;
        private System.Windows.Forms.TextBox roomNameTextBox;
        private System.Windows.Forms.TextBox roomIdTextBox;
        private System.Windows.Forms.ComboBox exitSouthComboBox;
        private System.Windows.Forms.ComboBox exitNorthComboBox;
    }
}
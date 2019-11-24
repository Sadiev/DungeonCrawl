namespace WindowsForms
{
    partial class WeaponForm
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
            this.addButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.weapNameLabel = new System.Windows.Forms.Label();
            this.dmgLabel = new System.Windows.Forms.Label();
            this.dmgTypeLabel = new System.Windows.Forms.Label();
            this.costLabel = new System.Windows.Forms.Label();
            this.dmgTextBox = new System.Windows.Forms.TextBox();
            this.dmgTypeTextBox = new System.Windows.Forms.TextBox();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.weapNameComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(189, 350);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(120, 50);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(473, 350);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(120, 50);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // weapNameLabel
            // 
            this.weapNameLabel.AutoSize = true;
            this.weapNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weapNameLabel.Location = new System.Drawing.Point(105, 42);
            this.weapNameLabel.Name = "weapNameLabel";
            this.weapNameLabel.Size = new System.Drawing.Size(169, 26);
            this.weapNameLabel.TabIndex = 2;
            this.weapNameLabel.Text = "Weapon Name";
            // 
            // dmgLabel
            // 
            this.dmgLabel.AutoSize = true;
            this.dmgLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dmgLabel.Location = new System.Drawing.Point(105, 125);
            this.dmgLabel.Name = "dmgLabel";
            this.dmgLabel.Size = new System.Drawing.Size(252, 26);
            this.dmgLabel.TabIndex = 3;
            this.dmgLabel.Text = "Damage Amount (1d6)";
            // 
            // dmgTypeLabel
            // 
            this.dmgTypeLabel.AutoSize = true;
            this.dmgTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dmgTypeLabel.Location = new System.Drawing.Point(105, 204);
            this.dmgTypeLabel.Name = "dmgTypeLabel";
            this.dmgTypeLabel.Size = new System.Drawing.Size(159, 26);
            this.dmgTypeLabel.TabIndex = 4;
            this.dmgTypeLabel.Text = "Damage Type";
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costLabel.Location = new System.Drawing.Point(105, 278);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(61, 26);
            this.costLabel.TabIndex = 5;
            this.costLabel.Text = "Cost";
            // 
            // dmgTextBox
            // 
            this.dmgTextBox.Location = new System.Drawing.Point(481, 125);
            this.dmgTextBox.Name = "dmgTextBox";
            this.dmgTextBox.ReadOnly = true;
            this.dmgTextBox.Size = new System.Drawing.Size(100, 20);
            this.dmgTextBox.TabIndex = 7;
            // 
            // dmgTypeTextBox
            // 
            this.dmgTypeTextBox.Location = new System.Drawing.Point(481, 204);
            this.dmgTypeTextBox.Name = "dmgTypeTextBox";
            this.dmgTypeTextBox.ReadOnly = true;
            this.dmgTypeTextBox.Size = new System.Drawing.Size(100, 20);
            this.dmgTypeTextBox.TabIndex = 8;
            // 
            // costTextBox
            // 
            this.costTextBox.Location = new System.Drawing.Point(481, 278);
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.ReadOnly = true;
            this.costTextBox.Size = new System.Drawing.Size(100, 20);
            this.costTextBox.TabIndex = 9;
            // 
            // weapNameComboBox
            // 
            this.weapNameComboBox.FormattingEnabled = true;
            this.weapNameComboBox.Location = new System.Drawing.Point(481, 42);
            this.weapNameComboBox.Name = "weapNameComboBox";
            this.weapNameComboBox.Size = new System.Drawing.Size(121, 21);
            this.weapNameComboBox.TabIndex = 12;
            this.weapNameComboBox.SelectedIndexChanged += new System.EventHandler(this.WeapNameComboBox_SelectedIndexChanged);
            // 
            // WeaponForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.weapNameComboBox);
            this.Controls.Add(this.costTextBox);
            this.Controls.Add(this.dmgTypeTextBox);
            this.Controls.Add(this.dmgTextBox);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.dmgTypeLabel);
            this.Controls.Add(this.dmgLabel);
            this.Controls.Add(this.weapNameLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.addButton);
            this.Name = "WeaponForm";
            this.Text = " ";
            this.Load += new System.EventHandler(this.WeaponForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label weapNameLabel;
        private System.Windows.Forms.Label dmgLabel;
        private System.Windows.Forms.Label dmgTypeLabel;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.TextBox dmgTextBox;
        private System.Windows.Forms.TextBox dmgTypeTextBox;
        private System.Windows.Forms.TextBox costTextBox;
        private System.Windows.Forms.ComboBox weapNameComboBox;
    }
}
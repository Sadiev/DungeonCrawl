namespace WindowsForms
{
    partial class CreateWeaponForm
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
            this.weapNameLabel = new System.Windows.Forms.Label();
            this.dmgAmtLabel = new System.Windows.Forms.Label();
            this.dmgTypeLabel = new System.Windows.Forms.Label();
            this.Cost = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.weapNameTextBox = new System.Windows.Forms.TextBox();
            this.dmgAmtTextBox = new System.Windows.Forms.TextBox();
            this.dmgTypeTextBox = new System.Windows.Forms.TextBox();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // weapNameLabel
            // 
            this.weapNameLabel.AutoSize = true;
            this.weapNameLabel.Location = new System.Drawing.Point(35, 23);
            this.weapNameLabel.Name = "weapNameLabel";
            this.weapNameLabel.Size = new System.Drawing.Size(79, 13);
            this.weapNameLabel.TabIndex = 0;
            this.weapNameLabel.Text = "Weapon Name";
            // 
            // dmgAmtLabel
            // 
            this.dmgAmtLabel.AutoSize = true;
            this.dmgAmtLabel.Location = new System.Drawing.Point(35, 66);
            this.dmgAmtLabel.Name = "dmgAmtLabel";
            this.dmgAmtLabel.Size = new System.Drawing.Size(86, 13);
            this.dmgAmtLabel.TabIndex = 1;
            this.dmgAmtLabel.Text = "Damage Amount";
            // 
            // dmgTypeLabel
            // 
            this.dmgTypeLabel.AutoSize = true;
            this.dmgTypeLabel.Location = new System.Drawing.Point(35, 115);
            this.dmgTypeLabel.Name = "dmgTypeLabel";
            this.dmgTypeLabel.Size = new System.Drawing.Size(74, 13);
            this.dmgTypeLabel.TabIndex = 2;
            this.dmgTypeLabel.Text = "Damage Type";
            // 
            // Cost
            // 
            this.Cost.AutoSize = true;
            this.Cost.Location = new System.Drawing.Point(35, 160);
            this.Cost.Name = "Cost";
            this.Cost.Size = new System.Drawing.Size(57, 13);
            this.Cost.TabIndex = 3;
            this.Cost.Text = "Cost (gold)";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(141, 211);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // weapNameTextBox
            // 
            this.weapNameTextBox.Location = new System.Drawing.Point(249, 23);
            this.weapNameTextBox.Name = "weapNameTextBox";
            this.weapNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.weapNameTextBox.TabIndex = 0;
            // 
            // dmgAmtTextBox
            // 
            this.dmgAmtTextBox.Location = new System.Drawing.Point(249, 66);
            this.dmgAmtTextBox.Name = "dmgAmtTextBox";
            this.dmgAmtTextBox.Size = new System.Drawing.Size(100, 20);
            this.dmgAmtTextBox.TabIndex = 1;
            // 
            // dmgTypeTextBox
            // 
            this.dmgTypeTextBox.Location = new System.Drawing.Point(249, 115);
            this.dmgTypeTextBox.Name = "dmgTypeTextBox";
            this.dmgTypeTextBox.Size = new System.Drawing.Size(100, 20);
            this.dmgTypeTextBox.TabIndex = 2;
            // 
            // costTextBox
            // 
            this.costTextBox.Location = new System.Drawing.Point(249, 160);
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.Size = new System.Drawing.Size(100, 20);
            this.costTextBox.TabIndex = 3;
            // 
            // CreateWeaponForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 246);
            this.Controls.Add(this.costTextBox);
            this.Controls.Add(this.dmgTypeTextBox);
            this.Controls.Add(this.dmgAmtTextBox);
            this.Controls.Add(this.weapNameTextBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.Cost);
            this.Controls.Add(this.dmgTypeLabel);
            this.Controls.Add(this.dmgAmtLabel);
            this.Controls.Add(this.weapNameLabel);
            this.Name = "CreateWeaponForm";
            this.Text = "CreateWeaponForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label weapNameLabel;
        private System.Windows.Forms.Label dmgAmtLabel;
        private System.Windows.Forms.Label dmgTypeLabel;
        private System.Windows.Forms.Label Cost;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox weapNameTextBox;
        private System.Windows.Forms.TextBox dmgAmtTextBox;
        private System.Windows.Forms.TextBox dmgTypeTextBox;
        private System.Windows.Forms.TextBox costTextBox;
    }
}
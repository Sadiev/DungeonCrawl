namespace WindowsForms
{
    partial class CreateMobForm
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
            this.label6 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.DescTextBox = new System.Windows.Forms.TextBox();
            this.HPTextBox = new System.Windows.Forms.TextBox();
            this.ACTextBox = new System.Windows.Forms.TextBox();
            this.DemageTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.DeadCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "HP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "AC";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(394, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Demage";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(142, 29);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(213, 22);
            this.NameTextBox.TabIndex = 6;
            // 
            // DescTextBox
            // 
            this.DescTextBox.Location = new System.Drawing.Point(142, 57);
            this.DescTextBox.Name = "DescTextBox";
            this.DescTextBox.Size = new System.Drawing.Size(213, 22);
            this.DescTextBox.TabIndex = 7;
            // 
            // HPTextBox
            // 
            this.HPTextBox.Location = new System.Drawing.Point(142, 85);
            this.HPTextBox.Name = "HPTextBox";
            this.HPTextBox.Size = new System.Drawing.Size(213, 22);
            this.HPTextBox.TabIndex = 8;
            // 
            // ACTextBox
            // 
            this.ACTextBox.Location = new System.Drawing.Point(142, 113);
            this.ACTextBox.Name = "ACTextBox";
            this.ACTextBox.Size = new System.Drawing.Size(213, 22);
            this.ACTextBox.TabIndex = 9;
            // 
            // DemageTextBox
            // 
            this.DemageTextBox.Location = new System.Drawing.Point(461, 57);
            this.DemageTextBox.Name = "DemageTextBox";
            this.DemageTextBox.Size = new System.Drawing.Size(213, 22);
            this.DemageTextBox.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(397, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(277, 31);
            this.button1.TabIndex = 12;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DeadCheckBox
            // 
            this.DeadCheckBox.AutoSize = true;
            this.DeadCheckBox.Location = new System.Drawing.Point(397, 30);
            this.DeadCheckBox.Name = "DeadCheckBox";
            this.DeadCheckBox.Size = new System.Drawing.Size(64, 21);
            this.DeadCheckBox.TabIndex = 13;
            this.DeadCheckBox.Text = "Dead";
            this.DeadCheckBox.UseVisualStyleBackColor = true;
            // 
            // CreateMobForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 155);
            this.Controls.Add(this.DeadCheckBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DemageTextBox);
            this.Controls.Add(this.ACTextBox);
            this.Controls.Add(this.HPTextBox);
            this.Controls.Add(this.DescTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CreateMobForm";
            this.Text = "CreateMobForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox DescTextBox;
        private System.Windows.Forms.TextBox HPTextBox;
        private System.Windows.Forms.TextBox ACTextBox;
        private System.Windows.Forms.TextBox DemageTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox DeadCheckBox;
    }
}
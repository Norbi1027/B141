namespace WindowsFormsAppLogin
{
    partial class Form_delete
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
            this.listBox_termek = new System.Windows.Forms.ListBox();
            this.numericUpDown_termekid = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_termekid)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox_termek
            // 
            this.listBox_termek.FormattingEnabled = true;
            this.listBox_termek.Location = new System.Drawing.Point(12, 25);
            this.listBox_termek.Name = "listBox_termek";
            this.listBox_termek.Size = new System.Drawing.Size(120, 355);
            this.listBox_termek.TabIndex = 0;
            // 
            // numericUpDown_termekid
            // 
            this.numericUpDown_termekid.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.numericUpDown_termekid.Location = new System.Drawing.Point(361, 138);
            this.numericUpDown_termekid.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_termekid.Name = "numericUpDown_termekid";
            this.numericUpDown_termekid.Size = new System.Drawing.Size(47, 20);
            this.numericUpDown_termekid.TabIndex = 15;
            this.numericUpDown_termekid.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_termekid.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(195, 138);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(166, 20);
            this.textBox1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Kiválasztott termék:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label2.Location = new System.Drawing.Point(249, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 22);
            this.label2.TabIndex = 16;
            this.label2.Text = "Törlés";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(253, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form_delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 389);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown_termekid);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox_termek);
            this.Name = "Form_delete";
            this.Text = "Form_delete";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_termekid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_termek;
        private System.Windows.Forms.NumericUpDown numericUpDown_termekid;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}
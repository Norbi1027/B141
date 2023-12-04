namespace WindowsFormsAppLogin
{
    partial class Form_uj
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
            this.textBox_termeknev = new System.Windows.Forms.TextBox();
            this.insert = new System.Windows.Forms.Button();
            this.numericUpDown_termekar = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_termekdb = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_termekar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_termekdb)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_termeknev
            // 
            this.textBox_termeknev.Location = new System.Drawing.Point(111, 120);
            this.textBox_termeknev.Name = "textBox_termeknev";
            this.textBox_termeknev.Size = new System.Drawing.Size(209, 20);
            this.textBox_termeknev.TabIndex = 0;
            // 
            // insert
            // 
            this.insert.Location = new System.Drawing.Point(111, 207);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(209, 23);
            this.insert.TabIndex = 3;
            this.insert.Text = "Insert";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // numericUpDown_termekar
            // 
            this.numericUpDown_termekar.Location = new System.Drawing.Point(175, 146);
            this.numericUpDown_termekar.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numericUpDown_termekar.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_termekar.Name = "numericUpDown_termekar";
            this.numericUpDown_termekar.Size = new System.Drawing.Size(66, 20);
            this.numericUpDown_termekar.TabIndex = 4;
            this.numericUpDown_termekar.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown_termekdb
            // 
            this.numericUpDown_termekdb.Location = new System.Drawing.Point(175, 172);
            this.numericUpDown_termekdb.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_termekdb.Name = "numericUpDown_termekdb";
            this.numericUpDown_termekdb.Size = new System.Drawing.Size(66, 20);
            this.numericUpDown_termekdb.TabIndex = 5;
            this.numericUpDown_termekdb.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.Location = new System.Drawing.Point(107, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Termék név";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label2.Location = new System.Drawing.Point(67, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Termék ára";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label3.Location = new System.Drawing.Point(47, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "Termék darab";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label4.Location = new System.Drawing.Point(132, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "Új termék felvétele";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form_uj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 325);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown_termekdb);
            this.Controls.Add(this.numericUpDown_termekar);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.textBox_termeknev);
            this.Name = "Form_uj";
            this.Text = "Form_uj";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_termekar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_termekdb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_termeknev;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.NumericUpDown numericUpDown_termekar;
        private System.Windows.Forms.NumericUpDown numericUpDown_termekdb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
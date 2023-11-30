namespace WindowsFormsAppLogin
{
    partial class FormVasarlas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVasarlas));
            this.listBox_termek = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_vasarlas = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label_ar = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown_db = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_ar = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_vegosszeg = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_termekid = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_db)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_vegosszeg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_termekid)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox_termek
            // 
            this.listBox_termek.FormattingEnabled = true;
            this.listBox_termek.Location = new System.Drawing.Point(13, 13);
            this.listBox_termek.Name = "listBox_termek";
            this.listBox_termek.Size = new System.Drawing.Size(173, 342);
            this.listBox_termek.TabIndex = 0;
            this.listBox_termek.SelectedIndexChanged += new System.EventHandler(this.listBox_termek_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(199, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kiválasztott termék:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(202, 67);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 20);
            this.textBox1.TabIndex = 2;
            // 
            // button_vasarlas
            // 
            this.button_vasarlas.Location = new System.Drawing.Point(219, 249);
            this.button_vasarlas.Name = "button_vasarlas";
            this.button_vasarlas.Size = new System.Drawing.Size(166, 23);
            this.button_vasarlas.TabIndex = 3;
            this.button_vasarlas.Text = "Vásárlás";
            this.button_vasarlas.UseVisualStyleBackColor = true;
            this.button_vasarlas.Click += new System.EventHandler(this.button_vasarlas_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "raktár";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(202, 120);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            // 
            // label_ar
            // 
            this.label_ar.AutoSize = true;
            this.label_ar.Location = new System.Drawing.Point(202, 160);
            this.label_ar.Name = "label_ar";
            this.label_ar.Size = new System.Drawing.Size(16, 13);
            this.label_ar.TabIndex = 9;
            this.label_ar.Text = "ár";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(383, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "végösszeg";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(383, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "darab";
            // 
            // numericUpDown_db
            // 
            this.numericUpDown_db.Location = new System.Drawing.Point(383, 68);
            this.numericUpDown_db.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_db.Name = "numericUpDown_db";
            this.numericUpDown_db.Size = new System.Drawing.Size(47, 20);
            this.numericUpDown_db.TabIndex = 12;
            this.numericUpDown_db.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown_ar
            // 
            this.numericUpDown_ar.Location = new System.Drawing.Point(202, 176);
            this.numericUpDown_ar.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown_ar.Name = "numericUpDown_ar";
            this.numericUpDown_ar.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_ar.TabIndex = 14;
            // 
            // numericUpDown_vegosszeg
            // 
            this.numericUpDown_vegosszeg.Location = new System.Drawing.Point(383, 324);
            this.numericUpDown_vegosszeg.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.numericUpDown_vegosszeg.Name = "numericUpDown_vegosszeg";
            this.numericUpDown_vegosszeg.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_vegosszeg.TabIndex = 15;
            // 
            // numericUpDown_termekid
            // 
            this.numericUpDown_termekid.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.numericUpDown_termekid.Location = new System.Drawing.Point(407, 120);
            this.numericUpDown_termekid.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_termekid.Name = "numericUpDown_termekid";
            this.numericUpDown_termekid.Size = new System.Drawing.Size(47, 20);
            this.numericUpDown_termekid.TabIndex = 12;
            this.numericUpDown_termekid.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_termekid.Visible = false;
            // 
            // FormVasarlas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 377);
            this.Controls.Add(this.numericUpDown_vegosszeg);
            this.Controls.Add(this.numericUpDown_ar);
            this.Controls.Add(this.numericUpDown_termekid);
            this.Controls.Add(this.numericUpDown_db);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_ar);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_vasarlas);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox_termek);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormVasarlas";
            this.Text = "Vásárlás";
            this.Load += new System.EventHandler(this.FormVasarlas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_db)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_vegosszeg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_termekid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_termek;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_vasarlas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label_ar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown_db;
        private System.Windows.Forms.NumericUpDown numericUpDown_ar;
        private System.Windows.Forms.NumericUpDown numericUpDown_vegosszeg;
        private System.Windows.Forms.NumericUpDown numericUpDown_termekid;
    }
}
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.termékToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.újToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.módosítToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.törlésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_db)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_vegosszeg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_termekid)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox_termek
            // 
            this.listBox_termek.FormattingEnabled = true;
            this.listBox_termek.Location = new System.Drawing.Point(0, 52);
            this.listBox_termek.Name = "listBox_termek";
            this.listBox_termek.Size = new System.Drawing.Size(173, 342);
            this.listBox_termek.TabIndex = 0;
            this.listBox_termek.SelectedIndexChanged += new System.EventHandler(this.listBox_termek_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(186, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kiválasztott termék:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(189, 106);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(166, 20);
            this.textBox1.TabIndex = 2;
            // 
            // button_vasarlas
            // 
            this.button_vasarlas.Location = new System.Drawing.Point(206, 288);
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
            this.label2.Location = new System.Drawing.Point(186, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "raktár";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(189, 159);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            // 
            // label_ar
            // 
            this.label_ar.AutoSize = true;
            this.label_ar.Location = new System.Drawing.Point(189, 199);
            this.label_ar.Name = "label_ar";
            this.label_ar.Size = new System.Drawing.Size(16, 13);
            this.label_ar.TabIndex = 9;
            this.label_ar.Text = "ár";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(370, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "végösszeg";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(427, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "darab";
            // 
            // numericUpDown_db
            // 
            this.numericUpDown_db.Location = new System.Drawing.Point(427, 160);
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
            this.numericUpDown_db.ValueChanged += new System.EventHandler(this.numericUpDown_db_ValueChanged);
            // 
            // numericUpDown_ar
            // 
            this.numericUpDown_ar.Location = new System.Drawing.Point(189, 215);
            this.numericUpDown_ar.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown_ar.Name = "numericUpDown_ar";
            this.numericUpDown_ar.ReadOnly = true;
            this.numericUpDown_ar.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_ar.TabIndex = 14;
            // 
            // numericUpDown_vegosszeg
            // 
            this.numericUpDown_vegosszeg.Location = new System.Drawing.Point(370, 363);
            this.numericUpDown_vegosszeg.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.numericUpDown_vegosszeg.Name = "numericUpDown_vegosszeg";
            this.numericUpDown_vegosszeg.ReadOnly = true;
            this.numericUpDown_vegosszeg.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_vegosszeg.TabIndex = 15;
            // 
            // numericUpDown_termekid
            // 
            this.numericUpDown_termekid.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.numericUpDown_termekid.Location = new System.Drawing.Point(355, 106);
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.termékToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(508, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // termékToolStripMenuItem
            // 
            this.termékToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.újToolStripMenuItem,
            this.módosítToolStripMenuItem,
            this.törlésToolStripMenuItem});
            this.termékToolStripMenuItem.Name = "termékToolStripMenuItem";
            this.termékToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.termékToolStripMenuItem.Text = "Termék";
            // 
            // újToolStripMenuItem
            // 
            this.újToolStripMenuItem.Name = "újToolStripMenuItem";
            this.újToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.újToolStripMenuItem.Text = "új";
            this.újToolStripMenuItem.Click += new System.EventHandler(this.újToolStripMenuItem_Click);
            // 
            // módosítToolStripMenuItem
            // 
            this.módosítToolStripMenuItem.Name = "módosítToolStripMenuItem";
            this.módosítToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.módosítToolStripMenuItem.Text = "módosít";
            // 
            // törlésToolStripMenuItem
            // 
            this.törlésToolStripMenuItem.Name = "törlésToolStripMenuItem";
            this.törlésToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.törlésToolStripMenuItem.Text = "törlés";
            this.törlésToolStripMenuItem.Click += new System.EventHandler(this.törlésToolStripMenuItem_Click);
            // 
            // FormVasarlas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 424);
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
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormVasarlas";
            this.Text = "Vásárlás";
            this.Load += new System.EventHandler(this.FormVasarlas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_db)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_vegosszeg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_termekid)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem termékToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem újToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem módosítToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem törlésToolStripMenuItem;
    }
}
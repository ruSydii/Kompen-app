namespace kompen_pnj
{
    partial class input_data
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
            this.NIM_txtbox = new System.Windows.Forms.TextBox();
            this.nama_txtbox = new System.Windows.Forms.TextBox();
            this.kelas_txtbox = new System.Windows.Forms.TextBox();
            this.kompen_txtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NIM_txtbox
            // 
            this.NIM_txtbox.Location = new System.Drawing.Point(57, 47);
            this.NIM_txtbox.Name = "NIM_txtbox";
            this.NIM_txtbox.Size = new System.Drawing.Size(107, 20);
            this.NIM_txtbox.TabIndex = 0;
            this.NIM_txtbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.NIM_txtbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NIM_txtbox_KeyPress);
            // 
            // nama_txtbox
            // 
            this.nama_txtbox.Location = new System.Drawing.Point(69, 104);
            this.nama_txtbox.Name = "nama_txtbox";
            this.nama_txtbox.Size = new System.Drawing.Size(111, 20);
            this.nama_txtbox.TabIndex = 1;
            this.nama_txtbox.TextChanged += new System.EventHandler(this.nama_txtbox_TextChanged);
            // 
            // kelas_txtbox
            // 
            this.kelas_txtbox.Location = new System.Drawing.Point(69, 147);
            this.kelas_txtbox.Name = "kelas_txtbox";
            this.kelas_txtbox.Size = new System.Drawing.Size(64, 20);
            this.kelas_txtbox.TabIndex = 2;
            // 
            // kompen_txtbox
            // 
            this.kompen_txtbox.Location = new System.Drawing.Point(69, 189);
            this.kompen_txtbox.Name = "kompen_txtbox";
            this.kompen_txtbox.Size = new System.Drawing.Size(58, 20);
            this.kompen_txtbox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-3, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "NIM";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kelas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Kompen";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(69, 239);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.NIM_txtbox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(437, 73);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data";
            // 
            // input_data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 297);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.kompen_txtbox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.kelas_txtbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nama_txtbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "input_data";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "input_data";
            this.Load += new System.EventHandler(this.input_data_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NIM_txtbox;
        private System.Windows.Forms.TextBox nama_txtbox;
        private System.Windows.Forms.TextBox kelas_txtbox;
        private System.Windows.Forms.TextBox kompen_txtbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
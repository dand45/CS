namespace DTBS1
{
    partial class Form1
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
            this.judul = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.merek = new System.Windows.Forms.Label();
            this.tipe = new System.Windows.Forms.Label();
            this.harga = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // judul
            // 
            this.judul.AutoSize = true;
            this.judul.BackColor = System.Drawing.SystemColors.Control;
            this.judul.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.judul.Location = new System.Drawing.Point(111, 13);
            this.judul.Name = "judul";
            this.judul.Size = new System.Drawing.Size(167, 40);
            this.judul.TabIndex = 0;
            this.judul.Text = "DATA LAPTOP";
            this.judul.UseCompatibleTextRendering = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Controls.Add(this.btn_delete);
            this.panel1.Controls.Add(this.btn_edit);
            this.panel1.Controls.Add(this.btn_search);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.harga);
            this.panel1.Controls.Add(this.tipe);
            this.panel1.Controls.Add(this.merek);
            this.panel1.Location = new System.Drawing.Point(13, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 329);
            this.panel1.TabIndex = 1;
            // 
            // merek
            // 
            this.merek.AutoSize = true;
            this.merek.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.merek.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.merek.Location = new System.Drawing.Point(4, 16);
            this.merek.Name = "merek";
            this.merek.Size = new System.Drawing.Size(56, 20);
            this.merek.TabIndex = 0;
            this.merek.Text = "MEREK";
            // 
            // tipe
            // 
            this.tipe.AutoSize = true;
            this.tipe.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipe.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tipe.Location = new System.Drawing.Point(4, 46);
            this.tipe.Name = "tipe";
            this.tipe.Size = new System.Drawing.Size(39, 20);
            this.tipe.TabIndex = 1;
            this.tipe.Text = "TIPE";
            // 
            // harga
            // 
            this.harga.AutoSize = true;
            this.harga.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.harga.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.harga.Location = new System.Drawing.Point(3, 78);
            this.harga.Name = "harga";
            this.harga.Size = new System.Drawing.Size(55, 20);
            this.harga.TabIndex = 2;
            this.harga.Text = "HARGA";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(78, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(212, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(78, 48);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(283, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(78, 78);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(283, 20);
            this.textBox3.TabIndex = 5;
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_search.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_search.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_search.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_search.ImageKey = "(none)";
            this.btn_search.Location = new System.Drawing.Point(297, 16);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(64, 23);
            this.btn_search.TabIndex = 6;
            this.btn_search.Text = "CARI";
            this.btn_search.UseVisualStyleBackColor = false;
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_edit.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_edit.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_edit.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_edit.ImageKey = "(none)";
            this.btn_edit.Location = new System.Drawing.Point(297, 104);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(64, 23);
            this.btn_edit.TabIndex = 7;
            this.btn_edit.Text = "EDIT";
            this.btn_edit.UseVisualStyleBackColor = false;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_delete.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_delete.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_delete.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_delete.ImageKey = "(none)";
            this.btn_delete.Location = new System.Drawing.Point(190, 104);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(64, 23);
            this.btn_delete.TabIndex = 8;
            this.btn_delete.Text = "HAPUS";
            this.btn_delete.UseVisualStyleBackColor = false;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_save.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_save.ImageKey = "(none)";
            this.btn_save.Location = new System.Drawing.Point(78, 104);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(64, 23);
            this.btn_save.TabIndex = 9;
            this.btn_save.Text = "SIMPAN";
            this.btn_save.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 394);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.judul);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label judul;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label harga;
        private System.Windows.Forms.Label tipe;
        private System.Windows.Forms.Label merek;
    }
}


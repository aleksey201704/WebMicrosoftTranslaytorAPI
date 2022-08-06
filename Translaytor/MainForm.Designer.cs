namespace Translaytor
{
    partial class MainForm
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
            this.rTexBoxTop = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.lblinfo = new System.Windows.Forms.Label();
            this.gBoxLang = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rdButtonEng = new System.Windows.Forms.RadioButton();
            this.rdButtonGer = new System.Windows.Forms.RadioButton();
            this.rdButtonIta = new System.Windows.Forms.RadioButton();
            this.rdButtonRU = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gBoxLang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rTexBoxTop
            // 
            this.rTexBoxTop.AutoWordSelection = true;
            this.rTexBoxTop.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rTexBoxTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.rTexBoxTop.EnableAutoDragDrop = true;
            this.rTexBoxTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rTexBoxTop.ForeColor = System.Drawing.Color.Silver;
            this.rTexBoxTop.Location = new System.Drawing.Point(0, 0);
            this.rTexBoxTop.MaxLength = 1000;
            this.rTexBoxTop.Name = "rTexBoxTop";
            this.rTexBoxTop.Size = new System.Drawing.Size(597, 204);
            this.rTexBoxTop.TabIndex = 3;
            this.rTexBoxTop.Text = "Напишите текст";
            this.rTexBoxTop.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            this.rTexBoxTop.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rTexBoxTop_KeyPress);
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.Color.FloralWhite;
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.richTextBox2.EnableAutoDragDrop = true;
            this.richTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox2.ForeColor = System.Drawing.Color.Gray;
            this.richTextBox2.Location = new System.Drawing.Point(0, 204);
            this.richTextBox2.MaxLength = 1000;
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.richTextBox2.Size = new System.Drawing.Size(597, 208);
            this.richTextBox2.TabIndex = 4;
            this.richTextBox2.Text = "";
            // 
            // lblinfo
            // 
            this.lblinfo.AutoSize = true;
            this.lblinfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblinfo.Location = new System.Drawing.Point(0, 412);
            this.lblinfo.Name = "lblinfo";
            this.lblinfo.Size = new System.Drawing.Size(479, 25);
            this.lblinfo.TabIndex = 5;
            this.lblinfo.Text = "Осталось количество символов в этом месяце";
            // 
            // gBoxLang
            // 
            this.gBoxLang.Controls.Add(this.pictureBox1);
            this.gBoxLang.Controls.Add(this.rdButtonRU);
            this.gBoxLang.Controls.Add(this.rdButtonIta);
            this.gBoxLang.Controls.Add(this.rdButtonGer);
            this.gBoxLang.Controls.Add(this.rdButtonEng);
            this.gBoxLang.Controls.Add(this.label1);
            this.gBoxLang.Dock = System.Windows.Forms.DockStyle.Top;
            this.gBoxLang.Location = new System.Drawing.Point(0, 437);
            this.gBoxLang.Name = "gBoxLang";
            this.gBoxLang.Size = new System.Drawing.Size(597, 151);
            this.gBoxLang.TabIndex = 6;
            this.gBoxLang.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Переводить на";
            // 
            // rdButtonEng
            // 
            this.rdButtonEng.AutoSize = true;
            this.rdButtonEng.Checked = true;
            this.rdButtonEng.Location = new System.Drawing.Point(15, 42);
            this.rdButtonEng.Name = "rdButtonEng";
            this.rdButtonEng.Size = new System.Drawing.Size(85, 17);
            this.rdButtonEng.TabIndex = 2;
            this.rdButtonEng.TabStop = true;
            this.rdButtonEng.Text = "Английский";
            this.rdButtonEng.UseVisualStyleBackColor = true;
            this.rdButtonEng.CheckedChanged += new System.EventHandler(this.rdButtonEng_CheckedChanged);
            // 
            // rdButtonGer
            // 
            this.rdButtonGer.AutoSize = true;
            this.rdButtonGer.Location = new System.Drawing.Point(15, 65);
            this.rdButtonGer.Name = "rdButtonGer";
            this.rdButtonGer.Size = new System.Drawing.Size(77, 17);
            this.rdButtonGer.TabIndex = 3;
            this.rdButtonGer.Text = "Немецкий";
            this.rdButtonGer.UseVisualStyleBackColor = true;
            this.rdButtonGer.CheckedChanged += new System.EventHandler(this.rdButtonGer_CheckedChanged);
            // 
            // rdButtonIta
            // 
            this.rdButtonIta.AutoSize = true;
            this.rdButtonIta.Location = new System.Drawing.Point(15, 88);
            this.rdButtonIta.Name = "rdButtonIta";
            this.rdButtonIta.Size = new System.Drawing.Size(92, 17);
            this.rdButtonIta.TabIndex = 4;
            this.rdButtonIta.Text = "Итальянский";
            this.rdButtonIta.UseVisualStyleBackColor = true;
            this.rdButtonIta.CheckedChanged += new System.EventHandler(this.rdButtonIta_CheckedChanged);
            // 
            // rdButtonRU
            // 
            this.rdButtonRU.AutoSize = true;
            this.rdButtonRU.Location = new System.Drawing.Point(15, 111);
            this.rdButtonRU.Name = "rdButtonRU";
            this.rdButtonRU.Size = new System.Drawing.Size(67, 17);
            this.rdButtonRU.TabIndex = 5;
            this.rdButtonRU.Text = "Русский";
            this.rdButtonRU.UseVisualStyleBackColor = true;
            this.rdButtonRU.CheckedChanged += new System.EventHandler(this.rdButtonRU_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::Translaytor.Properties.Resources.Microsoft_Translator_Header_620x250;
            this.pictureBox1.Location = new System.Drawing.Point(260, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(334, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 646);
            this.Controls.Add(this.gBoxLang);
            this.Controls.Add(this.lblinfo);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.rTexBoxTop);
            this.Name = "MainForm";
            this.Text = "Переводчик";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.gBoxLang.ResumeLayout(false);
            this.gBoxLang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox rTexBoxTop;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label lblinfo;
        private System.Windows.Forms.GroupBox gBoxLang;
        private System.Windows.Forms.RadioButton rdButtonIta;
        private System.Windows.Forms.RadioButton rdButtonGer;
        private System.Windows.Forms.RadioButton rdButtonEng;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdButtonRU;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
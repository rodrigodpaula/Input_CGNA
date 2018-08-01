namespace Input_CGNA
{
    partial class CGNA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CGNA));
            this.lbl_Tit = new System.Windows.Forms.Label();
            this.btn_Ini = new System.Windows.Forms.Button();
            this.btn_CANC = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // lbl_Tit
            // 
            this.lbl_Tit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_Tit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Tit.Location = new System.Drawing.Point(12, 9);
            this.lbl_Tit.Name = "lbl_Tit";
            this.lbl_Tit.Size = new System.Drawing.Size(311, 47);
            this.lbl_Tit.TabIndex = 0;
            this.lbl_Tit.Text = "CGNA";
            this.lbl_Tit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Ini
            // 
            this.btn_Ini.Location = new System.Drawing.Point(17, 185);
            this.btn_Ini.Name = "btn_Ini";
            this.btn_Ini.Size = new System.Drawing.Size(112, 36);
            this.btn_Ini.TabIndex = 1;
            this.btn_Ini.Text = "Iniciar";
            this.btn_Ini.UseVisualStyleBackColor = true;
            // 
            // btn_CANC
            // 
            this.btn_CANC.Location = new System.Drawing.Point(208, 185);
            this.btn_CANC.Name = "btn_CANC";
            this.btn_CANC.Size = new System.Drawing.Size(115, 36);
            this.btn_CANC.TabIndex = 2;
            this.btn_CANC.Text = "Cancelar";
            this.btn_CANC.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(41, 79);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(50, 132);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // CGNA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(335, 238);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_CANC);
            this.Controls.Add(this.btn_Ini);
            this.Controls.Add(this.lbl_Tit);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CGNA";
            this.Text = "Imput Site CGNA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Tit;
        private System.Windows.Forms.Button btn_Ini;
        private System.Windows.Forms.Button btn_CANC;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}


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
            this.txt_User = new System.Windows.Forms.TextBox();
            this.openFILE = new System.Windows.Forms.OpenFileDialog();
            this.lbl_user = new System.Windows.Forms.Label();
            this.lbl_senha = new System.Windows.Forms.Label();
            this.txt_Pass = new System.Windows.Forms.TextBox();
            this.txt_ARQ = new System.Windows.Forms.TextBox();
            this.btn_Arq = new System.Windows.Forms.Button();
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
            this.btn_Ini.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Ini.Location = new System.Drawing.Point(17, 257);
            this.btn_Ini.Name = "btn_Ini";
            this.btn_Ini.Size = new System.Drawing.Size(112, 36);
            this.btn_Ini.TabIndex = 1;
            this.btn_Ini.Text = "Iniciar";
            this.btn_Ini.UseVisualStyleBackColor = true;
            this.btn_Ini.Click += new System.EventHandler(this.btn_Ini_Click);
            // 
            // btn_CANC
            // 
            this.btn_CANC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_CANC.Location = new System.Drawing.Point(208, 257);
            this.btn_CANC.Name = "btn_CANC";
            this.btn_CANC.Size = new System.Drawing.Size(115, 36);
            this.btn_CANC.TabIndex = 2;
            this.btn_CANC.Text = "Cancelar";
            this.btn_CANC.UseVisualStyleBackColor = true;
            this.btn_CANC.Click += new System.EventHandler(this.btn_CANC_Click);
            // 
            // txt_User
            // 
            this.txt_User.Location = new System.Drawing.Point(17, 79);
            this.txt_User.Name = "txt_User";
            this.txt_User.Size = new System.Drawing.Size(120, 20);
            this.txt_User.TabIndex = 3;
            // 
            // openFILE
            // 
            this.openFILE.FileName = "openFILE";
            this.openFILE.InitialDirectory = "C:\\Rodrigo-TMP";
            this.openFILE.Title = "Arquivo Input";
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Location = new System.Drawing.Point(14, 63);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(43, 13);
            this.lbl_user.TabIndex = 5;
            this.lbl_user.Text = "Usuario";
            // 
            // lbl_senha
            // 
            this.lbl_senha.AutoSize = true;
            this.lbl_senha.Location = new System.Drawing.Point(14, 123);
            this.lbl_senha.Name = "lbl_senha";
            this.lbl_senha.Size = new System.Drawing.Size(38, 13);
            this.lbl_senha.TabIndex = 6;
            this.lbl_senha.Text = "Senha";
            // 
            // txt_Pass
            // 
            this.txt_Pass.DataBindings.Add(new System.Windows.Forms.Binding("PasswordChar", global::Input_CGNA.Properties.Settings.Default, "Pass", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txt_Pass.Location = new System.Drawing.Point(17, 139);
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.PasswordChar = global::Input_CGNA.Properties.Settings.Default.Pass;
            this.txt_Pass.Size = new System.Drawing.Size(120, 20);
            this.txt_Pass.TabIndex = 4;
            this.txt_Pass.UseSystemPasswordChar = true;
            // 
            // txt_ARQ
            // 
            this.txt_ARQ.Location = new System.Drawing.Point(17, 195);
            this.txt_ARQ.Multiline = true;
            this.txt_ARQ.Name = "txt_ARQ";
            this.txt_ARQ.ReadOnly = true;
            this.txt_ARQ.Size = new System.Drawing.Size(196, 39);
            this.txt_ARQ.TabIndex = 7;
            this.txt_ARQ.TabStop = false;
            // 
            // btn_Arq
            // 
            this.btn_Arq.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Arq.Location = new System.Drawing.Point(219, 195);
            this.btn_Arq.Name = "btn_Arq";
            this.btn_Arq.Size = new System.Drawing.Size(104, 39);
            this.btn_Arq.TabIndex = 8;
            this.btn_Arq.Text = "Selecionar Arquivo";
            this.btn_Arq.UseVisualStyleBackColor = true;
            this.btn_Arq.Click += new System.EventHandler(this.btn_Arq_Click);
            // 
            // CGNA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(335, 305);
            this.Controls.Add(this.btn_Arq);
            this.Controls.Add(this.txt_ARQ);
            this.Controls.Add(this.lbl_senha);
            this.Controls.Add(this.lbl_user);
            this.Controls.Add(this.txt_Pass);
            this.Controls.Add(this.txt_User);
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
        private System.Windows.Forms.TextBox txt_User;
        private System.Windows.Forms.TextBox txt_Pass;
        private System.Windows.Forms.OpenFileDialog openFILE;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.Label lbl_senha;
        private System.Windows.Forms.TextBox txt_ARQ;
        private System.Windows.Forms.Button btn_Arq;
    }
}


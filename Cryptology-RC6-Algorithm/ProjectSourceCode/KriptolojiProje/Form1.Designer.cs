namespace KriptolojiProje
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
            this.labelEncryption = new System.Windows.Forms.Label();
            this.labelEPlainText = new System.Windows.Forms.Label();
            this.labelECipherText = new System.Windows.Forms.Label();
            this.labelDecryption = new System.Windows.Forms.Label();
            this.labelDCipherText = new System.Windows.Forms.Label();
            this.labelDPlainText = new System.Windows.Forms.Label();
            this.textboxEPlainText = new System.Windows.Forms.TextBox();
            this.textboxECipherText = new System.Windows.Forms.TextBox();
            this.textboxDCipherText = new System.Windows.Forms.TextBox();
            this.textboxDPlainText = new System.Windows.Forms.TextBox();
            this.buttonEncryption = new System.Windows.Forms.Button();
            this.buttonDecryption = new System.Windows.Forms.Button();
            this.buttonClearEncryption = new System.Windows.Forms.Button();
            this.buttonClearDecryption = new System.Windows.Forms.Button();
            this.textboxEKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonClearKey = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelEncryption
            // 
            this.labelEncryption.AutoSize = true;
            this.labelEncryption.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelEncryption.Location = new System.Drawing.Point(28, 148);
            this.labelEncryption.Name = "labelEncryption";
            this.labelEncryption.Size = new System.Drawing.Size(125, 24);
            this.labelEncryption.TabIndex = 12;
            this.labelEncryption.Text = "Encryption";
            // 
            // labelEPlainText
            // 
            this.labelEPlainText.AutoSize = true;
            this.labelEPlainText.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelEPlainText.Location = new System.Drawing.Point(30, 189);
            this.labelEPlainText.Name = "labelEPlainText";
            this.labelEPlainText.Size = new System.Drawing.Size(74, 17);
            this.labelEPlainText.TabIndex = 13;
            this.labelEPlainText.Text = "PlainText:";
            // 
            // labelECipherText
            // 
            this.labelECipherText.AutoSize = true;
            this.labelECipherText.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelECipherText.Location = new System.Drawing.Point(29, 326);
            this.labelECipherText.Name = "labelECipherText";
            this.labelECipherText.Size = new System.Drawing.Size(84, 17);
            this.labelECipherText.TabIndex = 14;
            this.labelECipherText.Text = "CipherText:";
            // 
            // labelDecryption
            // 
            this.labelDecryption.AutoSize = true;
            this.labelDecryption.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelDecryption.Location = new System.Drawing.Point(523, 148);
            this.labelDecryption.Name = "labelDecryption";
            this.labelDecryption.Size = new System.Drawing.Size(125, 24);
            this.labelDecryption.TabIndex = 15;
            this.labelDecryption.Text = "Decryption";
            // 
            // labelDCipherText
            // 
            this.labelDCipherText.AutoSize = true;
            this.labelDCipherText.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelDCipherText.Location = new System.Drawing.Point(525, 189);
            this.labelDCipherText.Name = "labelDCipherText";
            this.labelDCipherText.Size = new System.Drawing.Size(84, 17);
            this.labelDCipherText.TabIndex = 16;
            this.labelDCipherText.Text = "CipherText:";
            // 
            // labelDPlainText
            // 
            this.labelDPlainText.AutoSize = true;
            this.labelDPlainText.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelDPlainText.Location = new System.Drawing.Point(525, 326);
            this.labelDPlainText.Name = "labelDPlainText";
            this.labelDPlainText.Size = new System.Drawing.Size(74, 17);
            this.labelDPlainText.TabIndex = 17;
            this.labelDPlainText.Text = "PlainText:";
            // 
            // textboxEPlainText
            // 
            this.textboxEPlainText.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textboxEPlainText.Location = new System.Drawing.Point(32, 221);
            this.textboxEPlainText.Multiline = true;
            this.textboxEPlainText.Name = "textboxEPlainText";
            this.textboxEPlainText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textboxEPlainText.Size = new System.Drawing.Size(438, 48);
            this.textboxEPlainText.TabIndex = 2;
            this.textboxEPlainText.TextChanged += new System.EventHandler(this.textboxEPlainText_TextChanged);
            this.textboxEPlainText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textboxEPlainText_KeyPress);
            // 
            // textboxECipherText
            // 
            this.textboxECipherText.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textboxECipherText.Location = new System.Drawing.Point(32, 356);
            this.textboxECipherText.Multiline = true;
            this.textboxECipherText.Name = "textboxECipherText";
            this.textboxECipherText.ReadOnly = true;
            this.textboxECipherText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textboxECipherText.Size = new System.Drawing.Size(438, 50);
            this.textboxECipherText.TabIndex = 4;
            // 
            // textboxDCipherText
            // 
            this.textboxDCipherText.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textboxDCipherText.Location = new System.Drawing.Point(528, 221);
            this.textboxDCipherText.Multiline = true;
            this.textboxDCipherText.Name = "textboxDCipherText";
            this.textboxDCipherText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textboxDCipherText.Size = new System.Drawing.Size(438, 48);
            this.textboxDCipherText.TabIndex = 6;
            this.textboxDCipherText.TextChanged += new System.EventHandler(this.textboxDCipherText_TextChanged);
            this.textboxDCipherText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textboxDCipherText_KeyPress);
            // 
            // textboxDPlainText
            // 
            this.textboxDPlainText.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textboxDPlainText.Location = new System.Drawing.Point(528, 356);
            this.textboxDPlainText.Multiline = true;
            this.textboxDPlainText.Name = "textboxDPlainText";
            this.textboxDPlainText.ReadOnly = true;
            this.textboxDPlainText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textboxDPlainText.Size = new System.Drawing.Size(438, 50);
            this.textboxDPlainText.TabIndex = 8;
            // 
            // buttonEncryption
            // 
            this.buttonEncryption.Enabled = false;
            this.buttonEncryption.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonEncryption.Location = new System.Drawing.Point(193, 285);
            this.buttonEncryption.Name = "buttonEncryption";
            this.buttonEncryption.Size = new System.Drawing.Size(106, 26);
            this.buttonEncryption.TabIndex = 3;
            this.buttonEncryption.Text = "Encryption";
            this.buttonEncryption.UseVisualStyleBackColor = true;
            this.buttonEncryption.Click += new System.EventHandler(this.buttonEncryption_Click);
            // 
            // buttonDecryption
            // 
            this.buttonDecryption.Enabled = false;
            this.buttonDecryption.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonDecryption.Location = new System.Drawing.Point(714, 285);
            this.buttonDecryption.Name = "buttonDecryption";
            this.buttonDecryption.Size = new System.Drawing.Size(106, 26);
            this.buttonDecryption.TabIndex = 7;
            this.buttonDecryption.Text = "Decryption";
            this.buttonDecryption.UseVisualStyleBackColor = true;
            this.buttonDecryption.Click += new System.EventHandler(this.buttonDecryption_Click);
            // 
            // buttonClearEncryption
            // 
            this.buttonClearEncryption.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonClearEncryption.Location = new System.Drawing.Point(193, 422);
            this.buttonClearEncryption.Name = "buttonClearEncryption";
            this.buttonClearEncryption.Size = new System.Drawing.Size(106, 26);
            this.buttonClearEncryption.TabIndex = 5;
            this.buttonClearEncryption.Text = "Clear Encryption";
            this.buttonClearEncryption.UseVisualStyleBackColor = true;
            this.buttonClearEncryption.Click += new System.EventHandler(this.buttonClearEncryption_Click);
            // 
            // buttonClearDecryption
            // 
            this.buttonClearDecryption.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonClearDecryption.Location = new System.Drawing.Point(714, 422);
            this.buttonClearDecryption.Name = "buttonClearDecryption";
            this.buttonClearDecryption.Size = new System.Drawing.Size(106, 26);
            this.buttonClearDecryption.TabIndex = 9;
            this.buttonClearDecryption.Text = "Clear Decryption";
            this.buttonClearDecryption.UseVisualStyleBackColor = true;
            this.buttonClearDecryption.Click += new System.EventHandler(this.buttonClearDecryption_Click);
            // 
            // textboxEKey
            // 
            this.textboxEKey.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textboxEKey.Location = new System.Drawing.Point(137, 81);
            this.textboxEKey.Name = "textboxEKey";
            this.textboxEKey.Size = new System.Drawing.Size(614, 20);
            this.textboxEKey.TabIndex = 0;
            this.textboxEKey.TextChanged += new System.EventHandler(this.textboxEKey_TextChanged);
            this.textboxEKey.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textboxEKey_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(76, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "KEY:";
            // 
            // buttonClearKey
            // 
            this.buttonClearKey.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonClearKey.Location = new System.Drawing.Point(786, 77);
            this.buttonClearKey.Name = "buttonClearKey";
            this.buttonClearKey.Size = new System.Drawing.Size(106, 26);
            this.buttonClearKey.TabIndex = 1;
            this.buttonClearKey.Text = "Clear Key";
            this.buttonClearKey.UseVisualStyleBackColor = true;
            this.buttonClearKey.Click += new System.EventHandler(this.buttonClearKey_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(138, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(682, 31);
            this.label2.TabIndex = 10;
            this.label2.Text = "RC6 ALGORITHM ENCRYPTION/DECRYPTION";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 474);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonClearKey);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textboxEKey);
            this.Controls.Add(this.buttonClearDecryption);
            this.Controls.Add(this.buttonClearEncryption);
            this.Controls.Add(this.buttonDecryption);
            this.Controls.Add(this.buttonEncryption);
            this.Controls.Add(this.textboxDPlainText);
            this.Controls.Add(this.textboxDCipherText);
            this.Controls.Add(this.textboxECipherText);
            this.Controls.Add(this.textboxEPlainText);
            this.Controls.Add(this.labelDPlainText);
            this.Controls.Add(this.labelDCipherText);
            this.Controls.Add(this.labelDecryption);
            this.Controls.Add(this.labelECipherText);
            this.Controls.Add(this.labelEPlainText);
            this.Controls.Add(this.labelEncryption);
            this.Name = "Form1";
            this.Text = "RC6 Encryption/Decryption Program";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEncryption;
        private System.Windows.Forms.Label labelEPlainText;
        private System.Windows.Forms.Label labelECipherText;
        private System.Windows.Forms.Label labelDecryption;
        private System.Windows.Forms.Label labelDCipherText;
        private System.Windows.Forms.Label labelDPlainText;
        private System.Windows.Forms.TextBox textboxEPlainText;
        private System.Windows.Forms.TextBox textboxECipherText;
        private System.Windows.Forms.TextBox textboxDCipherText;
        private System.Windows.Forms.TextBox textboxDPlainText;
        private System.Windows.Forms.Button buttonEncryption;
        private System.Windows.Forms.Button buttonDecryption;
        private System.Windows.Forms.Button buttonClearEncryption;
        private System.Windows.Forms.Button buttonClearDecryption;
        private System.Windows.Forms.TextBox textboxEKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonClearKey;
        private System.Windows.Forms.Label label2;
    }
}


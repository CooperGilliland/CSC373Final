namespace Gilliland_FinalCSC373
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
            this.pictureBoxMain = new System.Windows.Forms.PictureBox();
            this.textBoxDetected = new System.Windows.Forms.TextBox();
            this.textBoxTranslated = new System.Windows.Forms.TextBox();
            this.buttonSelectImg = new System.Windows.Forms.Button();
            this.buttonTranslate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxLangSelect = new System.Windows.Forms.ComboBox();
            this.labelMenu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxMain
            // 
            this.pictureBoxMain.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBoxMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxMain.Location = new System.Drawing.Point(235, 64);
            this.pictureBoxMain.Name = "pictureBoxMain";
            this.pictureBoxMain.Size = new System.Drawing.Size(339, 293);
            this.pictureBoxMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMain.TabIndex = 0;
            this.pictureBoxMain.TabStop = false;
            // 
            // textBoxDetected
            // 
            this.textBoxDetected.Location = new System.Drawing.Point(23, 80);
            this.textBoxDetected.Multiline = true;
            this.textBoxDetected.Name = "textBoxDetected";
            this.textBoxDetected.ReadOnly = true;
            this.textBoxDetected.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDetected.Size = new System.Drawing.Size(190, 125);
            this.textBoxDetected.TabIndex = 1;
            // 
            // textBoxTranslated
            // 
            this.textBoxTranslated.Location = new System.Drawing.Point(23, 224);
            this.textBoxTranslated.Multiline = true;
            this.textBoxTranslated.Name = "textBoxTranslated";
            this.textBoxTranslated.ReadOnly = true;
            this.textBoxTranslated.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxTranslated.Size = new System.Drawing.Size(190, 133);
            this.textBoxTranslated.TabIndex = 2;
            // 
            // buttonSelectImg
            // 
            this.buttonSelectImg.Location = new System.Drawing.Point(235, 376);
            this.buttonSelectImg.Name = "buttonSelectImg";
            this.buttonSelectImg.Size = new System.Drawing.Size(88, 23);
            this.buttonSelectImg.TabIndex = 3;
            this.buttonSelectImg.Text = "Select Image";
            this.buttonSelectImg.UseVisualStyleBackColor = true;
            this.buttonSelectImg.Click += new System.EventHandler(this.buttonSelectImg_Click);
            // 
            // buttonTranslate
            // 
            this.buttonTranslate.Location = new System.Drawing.Point(342, 376);
            this.buttonTranslate.Name = "buttonTranslate";
            this.buttonTranslate.Size = new System.Drawing.Size(75, 23);
            this.buttonTranslate.TabIndex = 4;
            this.buttonTranslate.Text = "Translate";
            this.buttonTranslate.UseVisualStyleBackColor = true;
            this.buttonTranslate.Click += new System.EventHandler(this.buttonTranslate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Detected Characters";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Translation";
            // 
            // comboBoxLangSelect
            // 
            this.comboBoxLangSelect.FormattingEnabled = true;
            this.comboBoxLangSelect.Items.AddRange(new object[] {
            "Afrikaans",
            "Arabic",
            "Bangla",
            "Bosnian(Latin)",
            "Bulgarian",
            "Cantonese (Traditional)",
            "Catalan",
            "Chinese Simplified",
            "Chinese Traditional",
            "Croatian",
            "Czech",
            "Danish",
            "Dutch",
            "English",
            "Estonian",
            "Fijian",
            "Filipino",
            "Finnish",
            "French",
            "German",
            "Greek",
            "Hatian Creole",
            "Hebrew",
            "Hindi",
            "Hmong Daw",
            "Hungarian",
            "Indonesian",
            "Italian",
            "Japanese",
            "Kiswahili",
            "Klingon",
            "Klingon (plqaD)",
            "Korean",
            "Latvian",
            "Lithuanian",
            "Malagasy",
            "Malay",
            "Maltese",
            "Norwegian",
            "Persian",
            "Polish",
            "Portuguese",
            "Queretaro Otomi",
            "Romanian",
            "Russian",
            "Samoan",
            "Serbian (Cyrillic)",
            "Serbian (Latin)",
            "Slovak",
            "Slovenian",
            "Spanish",
            "Swedish",
            "Tahitian",
            "Tamil",
            "Thai",
            "Tongan",
            "Turkish",
            "Ukrainian",
            "Urdu",
            "Vietnamese",
            "Welsh",
            "Yucatec Maya"});
            this.comboBoxLangSelect.Location = new System.Drawing.Point(23, 40);
            this.comboBoxLangSelect.Name = "comboBoxLangSelect";
            this.comboBoxLangSelect.Size = new System.Drawing.Size(121, 21);
            this.comboBoxLangSelect.TabIndex = 7;
            this.comboBoxLangSelect.SelectedIndexChanged += new System.EventHandler(this.comboBoxLangSelect_SelectedIndexChanged);
            // 
            // labelMenu
            // 
            this.labelMenu.AutoSize = true;
            this.labelMenu.Location = new System.Drawing.Point(37, 24);
            this.labelMenu.Name = "labelMenu";
            this.labelMenu.Size = new System.Drawing.Size(88, 13);
            this.labelMenu.TabIndex = 8;
            this.labelMenu.Text = "Select Language";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 426);
            this.Controls.Add(this.labelMenu);
            this.Controls.Add(this.comboBoxLangSelect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonTranslate);
            this.Controls.Add(this.buttonSelectImg);
            this.Controls.Add(this.textBoxTranslated);
            this.Controls.Add(this.textBoxDetected);
            this.Controls.Add(this.pictureBoxMain);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text Conversion";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxMain;
        private System.Windows.Forms.TextBox textBoxDetected;
        private System.Windows.Forms.TextBox textBoxTranslated;
        private System.Windows.Forms.Button buttonSelectImg;
        private System.Windows.Forms.Button buttonTranslate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxLangSelect;
        private System.Windows.Forms.Label labelMenu;
    }
}


namespace DictionaryApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lstWords = new System.Windows.Forms.ListBox();
            this.btnNewWord = new System.Windows.Forms.Button();
            this.lblEnglish = new System.Windows.Forms.Label();
            this.lblTurkish = new System.Windows.Forms.Label();
            this.txtNewEnglish = new System.Windows.Forms.TextBox();
            this.txtNewTurkish = new System.Windows.Forms.TextBox();
            this.txtEnglish = new System.Windows.Forms.TextBox();
            this.txtTurkish = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lstWords
            // 
            this.lstWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstWords.FormattingEnabled = true;
            this.lstWords.ItemHeight = 25;
            this.lstWords.Location = new System.Drawing.Point(44, 80);
            this.lstWords.Name = "lstWords";
            this.lstWords.Size = new System.Drawing.Size(322, 329);
            this.lstWords.TabIndex = 0;
            this.lstWords.SelectedIndexChanged += new System.EventHandler(this.lstWords_SelectedIndexChanged);
            // 
            // btnNewWord
            // 
            this.btnNewWord.Location = new System.Drawing.Point(533, 390);
            this.btnNewWord.Name = "btnNewWord";
            this.btnNewWord.Size = new System.Drawing.Size(120, 23);
            this.btnNewWord.TabIndex = 4;
            this.btnNewWord.Text = "Add New Word";
            this.btnNewWord.UseVisualStyleBackColor = true;
            this.btnNewWord.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblEnglish
            // 
            this.lblEnglish.AutoSize = true;
            this.lblEnglish.BackColor = System.Drawing.SystemColors.Control;
            this.lblEnglish.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEnglish.Location = new System.Drawing.Point(426, 32);
            this.lblEnglish.Name = "lblEnglish";
            this.lblEnglish.Size = new System.Drawing.Size(110, 32);
            this.lblEnglish.TabIndex = 5;
            this.lblEnglish.Text = "English";
            // 
            // lblTurkish
            // 
            this.lblTurkish.AutoSize = true;
            this.lblTurkish.BackColor = System.Drawing.SystemColors.Control;
            this.lblTurkish.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTurkish.Location = new System.Drawing.Point(628, 32);
            this.lblTurkish.Name = "lblTurkish";
            this.lblTurkish.Size = new System.Drawing.Size(111, 32);
            this.lblTurkish.TabIndex = 6;
            this.lblTurkish.Text = "Turkish";
            // 
            // txtNewEnglish
            // 
            this.txtNewEnglish.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtNewEnglish.Location = new System.Drawing.Point(399, 348);
            this.txtNewEnglish.Name = "txtNewEnglish";
            this.txtNewEnglish.Size = new System.Drawing.Size(177, 32);
            this.txtNewEnglish.TabIndex = 7;
            this.txtNewEnglish.Text = "English Word";
            this.txtNewEnglish.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtNewEnglish_MouseClick);
            // 
            // txtNewTurkish
            // 
            this.txtNewTurkish.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtNewTurkish.Location = new System.Drawing.Point(598, 348);
            this.txtNewTurkish.Name = "txtNewTurkish";
            this.txtNewTurkish.Size = new System.Drawing.Size(182, 32);
            this.txtNewTurkish.TabIndex = 8;
            this.txtNewTurkish.Text = "Turkish Meaning";
            this.txtNewTurkish.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtNewTurkish_MouseClick);
            // 
            // txtEnglish
            // 
            this.txtEnglish.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEnglish.Location = new System.Drawing.Point(399, 78);
            this.txtEnglish.Name = "txtEnglish";
            this.txtEnglish.Size = new System.Drawing.Size(177, 32);
            this.txtEnglish.TabIndex = 9;
            // 
            // txtTurkish
            // 
            this.txtTurkish.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTurkish.Location = new System.Drawing.Point(598, 78);
            this.txtTurkish.Name = "txtTurkish";
            this.txtTurkish.Size = new System.Drawing.Size(182, 32);
            this.txtTurkish.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(399, 116);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(381, 226);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSearch.Location = new System.Drawing.Point(168, 32);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(198, 40);
            this.txtSearch.TabIndex = 12;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.BackColor = System.Drawing.SystemColors.Control;
            this.lblSearch.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSearch.Location = new System.Drawing.Point(55, 35);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(107, 32);
            this.lblSearch.TabIndex = 13;
            this.lblSearch.Text = "Search";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(814, 447);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtTurkish);
            this.Controls.Add(this.txtEnglish);
            this.Controls.Add(this.txtNewTurkish);
            this.Controls.Add(this.txtNewEnglish);
            this.Controls.Add(this.lblTurkish);
            this.Controls.Add(this.lblEnglish);
            this.Controls.Add(this.btnNewWord);
            this.Controls.Add(this.lstWords);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstWords;
        private System.Windows.Forms.Button btnNewWord;
        private System.Windows.Forms.Label lblEnglish;
        private System.Windows.Forms.Label lblTurkish;
        private System.Windows.Forms.TextBox txtNewEnglish;
        private System.Windows.Forms.TextBox txtNewTurkish;
        private System.Windows.Forms.TextBox txtEnglish;
        private System.Windows.Forms.TextBox txtTurkish;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
    }
}


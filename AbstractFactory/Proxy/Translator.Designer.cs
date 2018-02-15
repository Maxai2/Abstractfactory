namespace Proxy
{
    partial class Translator
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
            this.lRus = new System.Windows.Forms.Label();
            this.lEng = new System.Windows.Forms.Label();
            this.tBRus = new System.Windows.Forms.TextBox();
            this.tBEng = new System.Windows.Forms.TextBox();
            this.BTranslate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lRus
            // 
            this.lRus.AutoSize = true;
            this.lRus.Location = new System.Drawing.Point(35, 27);
            this.lRus.Name = "lRus";
            this.lRus.Size = new System.Drawing.Size(45, 13);
            this.lRus.TabIndex = 0;
            this.lRus.Text = "Russian";
            // 
            // lEng
            // 
            this.lEng.AutoSize = true;
            this.lEng.Location = new System.Drawing.Point(35, 84);
            this.lEng.Name = "lEng";
            this.lEng.Size = new System.Drawing.Size(41, 13);
            this.lEng.TabIndex = 1;
            this.lEng.Text = "English";
            // 
            // tBRus
            // 
            this.tBRus.Location = new System.Drawing.Point(86, 24);
            this.tBRus.Name = "tBRus";
            this.tBRus.Size = new System.Drawing.Size(100, 20);
            this.tBRus.TabIndex = 2;
            // 
            // tBEng
            // 
            this.tBEng.Location = new System.Drawing.Point(86, 81);
            this.tBEng.Name = "tBEng";
            this.tBEng.Size = new System.Drawing.Size(100, 20);
            this.tBEng.TabIndex = 3;
            // 
            // BTranslate
            // 
            this.BTranslate.Location = new System.Drawing.Point(99, 120);
            this.BTranslate.Name = "BTranslate";
            this.BTranslate.Size = new System.Drawing.Size(75, 23);
            this.BTranslate.TabIndex = 4;
            this.BTranslate.Text = "Translate";
            this.BTranslate.UseVisualStyleBackColor = true;
            this.BTranslate.Click += new System.EventHandler(this.BTranslate_Click);
            // 
            // Translator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 162);
            this.Controls.Add(this.BTranslate);
            this.Controls.Add(this.tBEng);
            this.Controls.Add(this.tBRus);
            this.Controls.Add(this.lEng);
            this.Controls.Add(this.lRus);
            this.MaximumSize = new System.Drawing.Size(249, 201);
            this.MinimumSize = new System.Drawing.Size(249, 201);
            this.Name = "Translator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Translator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lRus;
        private System.Windows.Forms.Label lEng;
        private System.Windows.Forms.TextBox tBRus;
        private System.Windows.Forms.TextBox tBEng;
        private System.Windows.Forms.Button BTranslate;
    }
}


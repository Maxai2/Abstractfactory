namespace Memento
{
    partial class FTextWork
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
            this.rTBWorkPlace = new System.Windows.Forms.RichTextBox();
            this.bSave = new System.Windows.Forms.Button();
            this.bLoad = new System.Windows.Forms.Button();
            this.bUndo = new System.Windows.Forms.Button();
            this.bRendo = new System.Windows.Forms.Button();
            this.GBStyles = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.GBStyles.SuspendLayout();
            this.SuspendLayout();
            // 
            // rTBWorkPlace
            // 
            this.rTBWorkPlace.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rTBWorkPlace.Location = new System.Drawing.Point(0, 99);
            this.rTBWorkPlace.Name = "rTBWorkPlace";
            this.rTBWorkPlace.Size = new System.Drawing.Size(343, 296);
            this.rTBWorkPlace.TabIndex = 0;
            this.rTBWorkPlace.Text = "";
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(12, 21);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(75, 23);
            this.bSave.TabIndex = 1;
            this.bSave.Text = "Save";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // bLoad
            // 
            this.bLoad.Location = new System.Drawing.Point(12, 50);
            this.bLoad.Name = "bLoad";
            this.bLoad.Size = new System.Drawing.Size(75, 23);
            this.bLoad.TabIndex = 2;
            this.bLoad.Text = "Load";
            this.bLoad.UseVisualStyleBackColor = true;
            // 
            // bUndo
            // 
            this.bUndo.Location = new System.Drawing.Point(104, 50);
            this.bUndo.Name = "bUndo";
            this.bUndo.Size = new System.Drawing.Size(75, 23);
            this.bUndo.TabIndex = 3;
            this.bUndo.Text = "Undo";
            this.bUndo.UseVisualStyleBackColor = true;
            // 
            // bRendo
            // 
            this.bRendo.Location = new System.Drawing.Point(104, 21);
            this.bRendo.Name = "bRendo";
            this.bRendo.Size = new System.Drawing.Size(75, 23);
            this.bRendo.TabIndex = 4;
            this.bRendo.Text = "Rendo";
            this.bRendo.UseVisualStyleBackColor = true;
            // 
            // GBStyles
            // 
            this.GBStyles.Controls.Add(this.button3);
            this.GBStyles.Controls.Add(this.button2);
            this.GBStyles.Controls.Add(this.button1);
            this.GBStyles.Location = new System.Drawing.Point(210, 21);
            this.GBStyles.Name = "GBStyles";
            this.GBStyles.Size = new System.Drawing.Size(97, 51);
            this.GBStyles.TabIndex = 5;
            this.GBStyles.TabStop = false;
            this.GBStyles.Text = "Styles";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(6, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "B";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(36, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(24, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "U";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(66, 15);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(22, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "I";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // FTextWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 395);
            this.Controls.Add(this.GBStyles);
            this.Controls.Add(this.bRendo);
            this.Controls.Add(this.bUndo);
            this.Controls.Add(this.bLoad);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.rTBWorkPlace);
            this.Name = "FTextWork";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TextWork";
            this.GBStyles.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rTBWorkPlace;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Button bLoad;
        private System.Windows.Forms.Button bUndo;
        private System.Windows.Forms.Button bRendo;
        private System.Windows.Forms.GroupBox GBStyles;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}


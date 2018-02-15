namespace FlyWeight
{
    partial class RandPics
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
            this.pBTopLeft = new System.Windows.Forms.PictureBox();
            this.pBBottomRight = new System.Windows.Forms.PictureBox();
            this.pBBottomLeft = new System.Windows.Forms.PictureBox();
            this.pBTopRight = new System.Windows.Forms.PictureBox();
            this.BChange = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pBTopLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBBottomRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBBottomLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBTopRight)).BeginInit();
            this.SuspendLayout();
            // 
            // pBTopLeft
            // 
            this.pBTopLeft.Location = new System.Drawing.Point(12, 12);
            this.pBTopLeft.Name = "pBTopLeft";
            this.pBTopLeft.Size = new System.Drawing.Size(150, 150);
            this.pBTopLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBTopLeft.TabIndex = 0;
            this.pBTopLeft.TabStop = false;
            // 
            // pBBottomRight
            // 
            this.pBBottomRight.Location = new System.Drawing.Point(168, 168);
            this.pBBottomRight.Name = "pBBottomRight";
            this.pBBottomRight.Size = new System.Drawing.Size(150, 150);
            this.pBBottomRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBBottomRight.TabIndex = 1;
            this.pBBottomRight.TabStop = false;
            // 
            // pBBottomLeft
            // 
            this.pBBottomLeft.Location = new System.Drawing.Point(12, 168);
            this.pBBottomLeft.Name = "pBBottomLeft";
            this.pBBottomLeft.Size = new System.Drawing.Size(150, 150);
            this.pBBottomLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBBottomLeft.TabIndex = 2;
            this.pBBottomLeft.TabStop = false;
            // 
            // pBTopRight
            // 
            this.pBTopRight.Location = new System.Drawing.Point(168, 12);
            this.pBTopRight.Name = "pBTopRight";
            this.pBTopRight.Size = new System.Drawing.Size(150, 150);
            this.pBTopRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBTopRight.TabIndex = 3;
            this.pBTopRight.TabStop = false;
            // 
            // BChange
            // 
            this.BChange.Location = new System.Drawing.Point(126, 324);
            this.BChange.Name = "BChange";
            this.BChange.Size = new System.Drawing.Size(75, 23);
            this.BChange.TabIndex = 4;
            this.BChange.Text = "Change";
            this.BChange.UseVisualStyleBackColor = true;
            this.BChange.Click += new System.EventHandler(this.BChange_Click);
            // 
            // RandPics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 360);
            this.Controls.Add(this.BChange);
            this.Controls.Add(this.pBTopRight);
            this.Controls.Add(this.pBBottomLeft);
            this.Controls.Add(this.pBBottomRight);
            this.Controls.Add(this.pBTopLeft);
            this.MaximumSize = new System.Drawing.Size(351, 399);
            this.MinimumSize = new System.Drawing.Size(351, 399);
            this.Name = "RandPics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RandPics";
            ((System.ComponentModel.ISupportInitialize)(this.pBTopLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBBottomRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBBottomLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBTopRight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pBTopLeft;
        private System.Windows.Forms.PictureBox pBBottomRight;
        private System.Windows.Forms.PictureBox pBBottomLeft;
        private System.Windows.Forms.PictureBox pBTopRight;
        private System.Windows.Forms.Button BChange;
    }
}


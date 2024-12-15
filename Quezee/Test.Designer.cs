namespace Quezee
{
    partial class Test
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
            this.title = new System.Windows.Forms.Label();
            this.urlTB = new System.Windows.Forms.TextBox();
            this.ripBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(67, 56);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(27, 13);
            this.title.TabIndex = 0;
            this.title.Text = "Title";
            // 
            // urlTB
            // 
            this.urlTB.Location = new System.Drawing.Point(27, 105);
            this.urlTB.Name = "urlTB";
            this.urlTB.Size = new System.Drawing.Size(216, 20);
            this.urlTB.TabIndex = 1;
            // 
            // ripBtn
            // 
            this.ripBtn.Location = new System.Drawing.Point(81, 150);
            this.ripBtn.Name = "ripBtn";
            this.ripBtn.Size = new System.Drawing.Size(75, 23);
            this.ripBtn.TabIndex = 2;
            this.ripBtn.Text = "Download";
            this.ripBtn.UseVisualStyleBackColor = true;
            this.ripBtn.Click += new System.EventHandler(this.ripBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(180, 150);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ripBtn);
            this.Controls.Add(this.urlTB);
            this.Controls.Add(this.title);
            this.Name = "Test";
            this.Text = "Test";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.TextBox urlTB;
        private System.Windows.Forms.Button ripBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
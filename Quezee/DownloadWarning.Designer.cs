namespace Quezee
{
    partial class DownloadWarning
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.yesBtn = new System.Windows.Forms.Button();
            this.noBtn = new System.Windows.Forms.Button();
            this.dontShowAgainCB = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Warning";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(408, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Quezee utilizes a custom-made downloader called Jack the Ripper.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(383, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Download times may vary depending on the length of the video.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Would you like to proceed?";
            // 
            // yesBtn
            // 
            this.yesBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.yesBtn.Location = new System.Drawing.Point(15, 112);
            this.yesBtn.Name = "yesBtn";
            this.yesBtn.Size = new System.Drawing.Size(75, 23);
            this.yesBtn.TabIndex = 9;
            this.yesBtn.TabStop = false;
            this.yesBtn.Text = "Yes";
            this.yesBtn.UseVisualStyleBackColor = true;
            this.yesBtn.Click += new System.EventHandler(this.yesBtn_Click);
            // 
            // noBtn
            // 
            this.noBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.noBtn.Location = new System.Drawing.Point(91, 112);
            this.noBtn.Name = "noBtn";
            this.noBtn.Size = new System.Drawing.Size(75, 23);
            this.noBtn.TabIndex = 10;
            this.noBtn.TabStop = false;
            this.noBtn.Text = "No";
            this.noBtn.UseVisualStyleBackColor = true;
            this.noBtn.Click += new System.EventHandler(this.noBtn_Click);
            // 
            // dontShowAgainCB
            // 
            this.dontShowAgainCB.AutoSize = true;
            this.dontShowAgainCB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dontShowAgainCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dontShowAgainCB.Location = new System.Drawing.Point(16, 142);
            this.dontShowAgainCB.Name = "dontShowAgainCB";
            this.dontShowAgainCB.Size = new System.Drawing.Size(177, 20);
            this.dontShowAgainCB.TabIndex = 11;
            this.dontShowAgainCB.TabStop = false;
            this.dontShowAgainCB.Text = "Don\'t show me this again.";
            this.dontShowAgainCB.UseVisualStyleBackColor = true;
            this.dontShowAgainCB.CheckedChanged += new System.EventHandler(this.dontShowAgainCB_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Silver;
            this.pictureBox1.Location = new System.Drawing.Point(12, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(446, 1);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // DownloadWarning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 173);
            this.Controls.Add(this.dontShowAgainCB);
            this.Controls.Add(this.noBtn);
            this.Controls.Add(this.yesBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DownloadWarning";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quezee";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.DownloadWarning_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button yesBtn;
        private System.Windows.Forms.Button noBtn;
        private System.Windows.Forms.CheckBox dontShowAgainCB;
    }
}
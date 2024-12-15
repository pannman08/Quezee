namespace Quezee
{
    partial class Results
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
            this.resultsLV = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // resultsLV
            // 
            this.resultsLV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultsLV.Location = new System.Drawing.Point(0, 0);
            this.resultsLV.MultiSelect = false;
            this.resultsLV.Name = "resultsLV";
            this.resultsLV.Size = new System.Drawing.Size(722, 516);
            this.resultsLV.TabIndex = 0;
            this.resultsLV.UseCompatibleStateImageBehavior = false;
            this.resultsLV.View = System.Windows.Forms.View.Details;
            this.resultsLV.SelectedIndexChanged += new System.EventHandler(this.resultsLV_SelectedIndexChanged);
            // 
            // Results
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(722, 516);
            this.Controls.Add(this.resultsLV);
            this.Name = "Results";
            this.ShowIcon = false;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView resultsLV;

    }
}
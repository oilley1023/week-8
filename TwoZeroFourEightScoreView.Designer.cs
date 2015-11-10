namespace twozerofoureight
{
    partial class TwoZeroFourEightScoreView
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
            this.lblScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblScore
            // 
            this.lblScore.Enabled = false;
            this.lblScore.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(35, 50);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(162, 68);
            this.lblScore.TabIndex = 0;
            this.lblScore.Text = "0";
     
            // 
            // TwoZeroFourEightScoreView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblScore);
            this.Name = "TwoZeroFourEightScoreView";
            this.Text = "TwoZeroFourEightScoreView";

            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblScore;
    }
}
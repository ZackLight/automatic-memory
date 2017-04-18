namespace NIce
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
            this.ultraLiveTileView1 = new Infragistics.Win.UltraWinLiveTileView.UltraLiveTileView();
            ((System.ComponentModel.ISupportInitialize)(this.ultraLiveTileView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ultraLiveTileView1
            // 
            this.ultraLiveTileView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ultraLiveTileView1.Location = new System.Drawing.Point(0, 0);
            this.ultraLiveTileView1.Name = "ultraLiveTileView1";
            this.ultraLiveTileView1.Size = new System.Drawing.Size(659, 434);
            this.ultraLiveTileView1.TabIndex = 0;
            this.ultraLiveTileView1.Text = "ultraLiveTileView1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 434);
            this.Controls.Add(this.ultraLiveTileView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ultraLiveTileView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Infragistics.Win.UltraWinLiveTileView.UltraLiveTileView ultraLiveTileView1;
    }
}


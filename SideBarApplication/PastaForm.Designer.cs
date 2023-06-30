namespace FoodOrderMenu
{
    partial class PastaForm
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
            this.PastaPanel = new System.Windows.Forms.Panel();
            this.PastaMenuPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.PastaTitlePanel = new System.Windows.Forms.Panel();
            this.PastaText = new System.Windows.Forms.Label();
            this.PastaPanel.SuspendLayout();
            this.PastaTitlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PastaPanel
            // 
            this.PastaPanel.Controls.Add(this.PastaMenuPanel);
            this.PastaPanel.Controls.Add(this.PastaTitlePanel);
            this.PastaPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PastaPanel.Location = new System.Drawing.Point(0, 0);
            this.PastaPanel.Name = "PastaPanel";
            this.PastaPanel.Size = new System.Drawing.Size(623, 407);
            this.PastaPanel.TabIndex = 0;
            // 
            // PastaMenuPanel
            // 
            this.PastaMenuPanel.AutoScroll = true;
            this.PastaMenuPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PastaMenuPanel.Location = new System.Drawing.Point(0, 40);
            this.PastaMenuPanel.Name = "PastaMenuPanel";
            this.PastaMenuPanel.Size = new System.Drawing.Size(623, 367);
            this.PastaMenuPanel.TabIndex = 1;
            // 
            // PastaTitlePanel
            // 
            this.PastaTitlePanel.AutoScroll = true;
            this.PastaTitlePanel.Controls.Add(this.PastaText);
            this.PastaTitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.PastaTitlePanel.Location = new System.Drawing.Point(0, 0);
            this.PastaTitlePanel.Name = "PastaTitlePanel";
            this.PastaTitlePanel.Size = new System.Drawing.Size(623, 40);
            this.PastaTitlePanel.TabIndex = 0;
            // 
            // PastaText
            // 
            this.PastaText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PastaText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PastaText.Location = new System.Drawing.Point(0, 0);
            this.PastaText.Name = "PastaText";
            this.PastaText.Size = new System.Drawing.Size(623, 40);
            this.PastaText.TabIndex = 0;
            this.PastaText.Text = "Pasta";
            this.PastaText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PastaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(623, 407);
            this.Controls.Add(this.PastaPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PastaForm";
            this.Text = "Pasta";
            this.PastaPanel.ResumeLayout(false);
            this.PastaTitlePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PastaPanel;
        private System.Windows.Forms.Panel PastaTitlePanel;
        private System.Windows.Forms.Label PastaText;
        private System.Windows.Forms.FlowLayoutPanel PastaMenuPanel;
    }
}
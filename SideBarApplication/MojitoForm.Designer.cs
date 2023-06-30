namespace FoodOrderMenu
{
    partial class MojitoForm
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
            this.MojitoTitlePanel = new System.Windows.Forms.Panel();
            this.MojitoTitleTxt = new System.Windows.Forms.Label();
            this.MojitoMenuPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.MojitoTitlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MojitoTitlePanel
            // 
            this.MojitoTitlePanel.Controls.Add(this.MojitoTitleTxt);
            this.MojitoTitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MojitoTitlePanel.Location = new System.Drawing.Point(0, 0);
            this.MojitoTitlePanel.Name = "MojitoTitlePanel";
            this.MojitoTitlePanel.Size = new System.Drawing.Size(623, 40);
            this.MojitoTitlePanel.TabIndex = 0;
            // 
            // MojitoTitleTxt
            // 
            this.MojitoTitleTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MojitoTitleTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MojitoTitleTxt.Location = new System.Drawing.Point(0, 0);
            this.MojitoTitleTxt.Name = "MojitoTitleTxt";
            this.MojitoTitleTxt.Size = new System.Drawing.Size(623, 40);
            this.MojitoTitleTxt.TabIndex = 0;
            this.MojitoTitleTxt.Text = "Mojito";
            this.MojitoTitleTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MojitoMenuPanel
            // 
            this.MojitoMenuPanel.AutoScroll = true;
            this.MojitoMenuPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MojitoMenuPanel.Location = new System.Drawing.Point(0, 40);
            this.MojitoMenuPanel.Name = "MojitoMenuPanel";
            this.MojitoMenuPanel.Size = new System.Drawing.Size(623, 367);
            this.MojitoMenuPanel.TabIndex = 1;
            // 
            // MojitoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(623, 407);
            this.Controls.Add(this.MojitoMenuPanel);
            this.Controls.Add(this.MojitoTitlePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MojitoForm";
            this.Text = "Mojito";
            this.MojitoTitlePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MojitoTitlePanel;
        private System.Windows.Forms.Label MojitoTitleTxt;
        private System.Windows.Forms.FlowLayoutPanel MojitoMenuPanel;
    }
}
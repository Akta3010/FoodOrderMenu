namespace FoodOrderMenu
{
    partial class SnacksForm
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
            this.SnacksPanel = new System.Windows.Forms.Panel();
            this.SnacksMenuPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SnacksTitlePanel = new System.Windows.Forms.Panel();
            this.SnacksTitleText = new System.Windows.Forms.Label();
            this.SnacksPanel.SuspendLayout();
            this.SnacksTitlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SnacksPanel
            // 
            this.SnacksPanel.Controls.Add(this.SnacksMenuPanel);
            this.SnacksPanel.Controls.Add(this.SnacksTitlePanel);
            this.SnacksPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SnacksPanel.Location = new System.Drawing.Point(0, 0);
            this.SnacksPanel.Name = "SnacksPanel";
            this.SnacksPanel.Size = new System.Drawing.Size(623, 407);
            this.SnacksPanel.TabIndex = 0;
            // 
            // SnacksMenuPanel
            // 
            this.SnacksMenuPanel.AutoScroll = true;
            this.SnacksMenuPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SnacksMenuPanel.Location = new System.Drawing.Point(0, 40);
            this.SnacksMenuPanel.Name = "SnacksMenuPanel";
            this.SnacksMenuPanel.Size = new System.Drawing.Size(623, 367);
            this.SnacksMenuPanel.TabIndex = 1;
            // 
            // SnacksTitlePanel
            // 
            this.SnacksTitlePanel.AutoScroll = true;
            this.SnacksTitlePanel.Controls.Add(this.SnacksTitleText);
            this.SnacksTitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SnacksTitlePanel.Location = new System.Drawing.Point(0, 0);
            this.SnacksTitlePanel.Name = "SnacksTitlePanel";
            this.SnacksTitlePanel.Size = new System.Drawing.Size(623, 40);
            this.SnacksTitlePanel.TabIndex = 0;
            // 
            // SnacksTitleText
            // 
            this.SnacksTitleText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SnacksTitleText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SnacksTitleText.Location = new System.Drawing.Point(0, 0);
            this.SnacksTitleText.Name = "SnacksTitleText";
            this.SnacksTitleText.Size = new System.Drawing.Size(623, 40);
            this.SnacksTitleText.TabIndex = 0;
            this.SnacksTitleText.Text = "Snacks";
            this.SnacksTitleText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SnacksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(623, 407);
            this.Controls.Add(this.SnacksPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SnacksForm";
            this.Text = "Sancs";
            this.SnacksPanel.ResumeLayout(false);
            this.SnacksTitlePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SnacksPanel;
        private System.Windows.Forms.Panel SnacksTitlePanel;
        private System.Windows.Forms.Label SnacksTitleText;
        private System.Windows.Forms.FlowLayoutPanel SnacksMenuPanel;
    }
}
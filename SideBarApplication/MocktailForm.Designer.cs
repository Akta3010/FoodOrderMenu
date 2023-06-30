namespace FoodOrderMenu
{
    partial class MocktailForm
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
            this.MocktailPanel = new System.Windows.Forms.Panel();
            this.MocktailTitlePanel = new System.Windows.Forms.Panel();
            this.MocktailTitleTxt = new System.Windows.Forms.Label();
            this.MocktailMenuPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.MocktailPanel.SuspendLayout();
            this.MocktailTitlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MocktailPanel
            // 
            this.MocktailPanel.Controls.Add(this.MocktailMenuPanel);
            this.MocktailPanel.Controls.Add(this.MocktailTitlePanel);
            this.MocktailPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MocktailPanel.Location = new System.Drawing.Point(0, 0);
            this.MocktailPanel.Name = "MocktailPanel";
            this.MocktailPanel.Size = new System.Drawing.Size(623, 407);
            this.MocktailPanel.TabIndex = 0;
            // 
            // MocktailTitlePanel
            // 
            this.MocktailTitlePanel.Controls.Add(this.MocktailTitleTxt);
            this.MocktailTitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MocktailTitlePanel.Location = new System.Drawing.Point(0, 0);
            this.MocktailTitlePanel.Name = "MocktailTitlePanel";
            this.MocktailTitlePanel.Size = new System.Drawing.Size(623, 40);
            this.MocktailTitlePanel.TabIndex = 0;
            // 
            // MocktailTitleTxt
            // 
            this.MocktailTitleTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MocktailTitleTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MocktailTitleTxt.Location = new System.Drawing.Point(0, 0);
            this.MocktailTitleTxt.Name = "MocktailTitleTxt";
            this.MocktailTitleTxt.Size = new System.Drawing.Size(623, 40);
            this.MocktailTitleTxt.TabIndex = 0;
            this.MocktailTitleTxt.Text = "Mocktail";
            this.MocktailTitleTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MocktailMenuPanel
            // 
            this.MocktailMenuPanel.AutoScroll = true;
            this.MocktailMenuPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MocktailMenuPanel.Location = new System.Drawing.Point(0, 40);
            this.MocktailMenuPanel.Name = "MocktailMenuPanel";
            this.MocktailMenuPanel.Size = new System.Drawing.Size(623, 367);
            this.MocktailMenuPanel.TabIndex = 1;
            // 
            // MocktailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(623, 407);
            this.Controls.Add(this.MocktailPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MocktailForm";
            this.Text = "Mocktail";
            this.MocktailPanel.ResumeLayout(false);
            this.MocktailTitlePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MocktailPanel;
        private System.Windows.Forms.Panel MocktailTitlePanel;
        private System.Windows.Forms.Label MocktailTitleTxt;
        private System.Windows.Forms.FlowLayoutPanel MocktailMenuPanel;
    }
}
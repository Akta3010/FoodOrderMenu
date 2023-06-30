namespace FoodOrderMenu
{
    partial class BurgerForm
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
            this.BurgerPanel = new System.Windows.Forms.Panel();
            this.BurgerMenuPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.BurgerTitlePanel = new System.Windows.Forms.Panel();
            this.BurgerMenuTxt = new System.Windows.Forms.Label();
            this.BurgerPanel.SuspendLayout();
            this.BurgerTitlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BurgerPanel
            // 
            this.BurgerPanel.AutoScroll = true;
            this.BurgerPanel.Controls.Add(this.BurgerMenuPanel);
            this.BurgerPanel.Controls.Add(this.BurgerTitlePanel);
            this.BurgerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BurgerPanel.Location = new System.Drawing.Point(0, 0);
            this.BurgerPanel.Name = "BurgerPanel";
            this.BurgerPanel.Size = new System.Drawing.Size(623, 407);
            this.BurgerPanel.TabIndex = 0;
            // 
            // BurgerMenuPanel
            // 
            this.BurgerMenuPanel.AutoScroll = true;
            this.BurgerMenuPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BurgerMenuPanel.Location = new System.Drawing.Point(0, 40);
            this.BurgerMenuPanel.Name = "BurgerMenuPanel";
            this.BurgerMenuPanel.Size = new System.Drawing.Size(623, 367);
            this.BurgerMenuPanel.TabIndex = 1;
            // 
            // BurgerTitlePanel
            // 
            this.BurgerTitlePanel.Controls.Add(this.BurgerMenuTxt);
            this.BurgerTitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.BurgerTitlePanel.Location = new System.Drawing.Point(0, 0);
            this.BurgerTitlePanel.Name = "BurgerTitlePanel";
            this.BurgerTitlePanel.Size = new System.Drawing.Size(623, 40);
            this.BurgerTitlePanel.TabIndex = 0;
            // 
            // BurgerMenuTxt
            // 
            this.BurgerMenuTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BurgerMenuTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BurgerMenuTxt.Location = new System.Drawing.Point(0, 0);
            this.BurgerMenuTxt.Name = "BurgerMenuTxt";
            this.BurgerMenuTxt.Size = new System.Drawing.Size(623, 40);
            this.BurgerMenuTxt.TabIndex = 0;
            this.BurgerMenuTxt.Text = "Burger";
            this.BurgerMenuTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BurgerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(623, 407);
            this.Controls.Add(this.BurgerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BurgerForm";
            this.Text = "Burger";
            this.BurgerPanel.ResumeLayout(false);
            this.BurgerTitlePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BurgerPanel;
        private System.Windows.Forms.Panel BurgerTitlePanel;
        private System.Windows.Forms.Label BurgerMenuTxt;
        private System.Windows.Forms.FlowLayoutPanel BurgerMenuPanel;
    }
}
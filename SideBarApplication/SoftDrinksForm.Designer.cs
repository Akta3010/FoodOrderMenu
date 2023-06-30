namespace FoodOrderMenu
{
    partial class SoftDrinksForm
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
            this.SoftDrinksTitlePanel = new System.Windows.Forms.Panel();
            this.SodftDrinksTitleTxt = new System.Windows.Forms.Label();
            this.SoftDrinksMenuPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SoftDrinksTitlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SoftDrinksTitlePanel
            // 
            this.SoftDrinksTitlePanel.Controls.Add(this.SodftDrinksTitleTxt);
            this.SoftDrinksTitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SoftDrinksTitlePanel.Location = new System.Drawing.Point(0, 0);
            this.SoftDrinksTitlePanel.Name = "SoftDrinksTitlePanel";
            this.SoftDrinksTitlePanel.Size = new System.Drawing.Size(605, 40);
            this.SoftDrinksTitlePanel.TabIndex = 0;
            // 
            // SodftDrinksTitleTxt
            // 
            this.SodftDrinksTitleTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SodftDrinksTitleTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SodftDrinksTitleTxt.Location = new System.Drawing.Point(0, 0);
            this.SodftDrinksTitleTxt.Name = "SodftDrinksTitleTxt";
            this.SodftDrinksTitleTxt.Size = new System.Drawing.Size(605, 40);
            this.SodftDrinksTitleTxt.TabIndex = 0;
            this.SodftDrinksTitleTxt.Text = "Soft Drinks";
            this.SodftDrinksTitleTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SoftDrinksMenuPanel
            // 
            this.SoftDrinksMenuPanel.AutoScroll = true;
            this.SoftDrinksMenuPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SoftDrinksMenuPanel.Location = new System.Drawing.Point(0, 40);
            this.SoftDrinksMenuPanel.Name = "SoftDrinksMenuPanel";
            this.SoftDrinksMenuPanel.Size = new System.Drawing.Size(605, 320);
            this.SoftDrinksMenuPanel.TabIndex = 1;
            // 
            // SoftDrinksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(605, 360);
            this.Controls.Add(this.SoftDrinksMenuPanel);
            this.Controls.Add(this.SoftDrinksTitlePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SoftDrinksForm";
            this.Text = "Soft Drinks";
            this.SoftDrinksTitlePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SoftDrinksTitlePanel;
        private System.Windows.Forms.Label SodftDrinksTitleTxt;
        private System.Windows.Forms.FlowLayoutPanel SoftDrinksMenuPanel;
    }
}
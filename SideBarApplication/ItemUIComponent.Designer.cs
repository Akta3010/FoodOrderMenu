namespace FoodOrderMenu
{
    partial class ItemUIComponent
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.itemPicture = new System.Windows.Forms.PictureBox();
            this.itemName = new System.Windows.Forms.Label();
            this.itemPrice = new System.Windows.Forms.Label();
            this.itemControlPanel = new System.Windows.Forms.Panel();
            this.itemPicPanel = new System.Windows.Forms.Panel();
            this.itemNamePanel = new System.Windows.Forms.Panel();
            this.ItemPricePanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.itemPicture)).BeginInit();
            this.itemControlPanel.SuspendLayout();
            this.itemPicPanel.SuspendLayout();
            this.itemNamePanel.SuspendLayout();
            this.ItemPricePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // itemPicture
            // 
            this.itemPicture.BackColor = System.Drawing.SystemColors.ControlDark;
            this.itemPicture.Location = new System.Drawing.Point(23, 7);
            this.itemPicture.Name = "itemPicture";
            this.itemPicture.Size = new System.Drawing.Size(100, 61);
            this.itemPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.itemPicture.TabIndex = 0;
            this.itemPicture.TabStop = false;
            this.itemPicture.Click += new System.EventHandler(this.itemPicture_Click);
            // 
            // itemName
            // 
            this.itemName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemName.Location = new System.Drawing.Point(0, 0);
            this.itemName.Name = "itemName";
            this.itemName.Size = new System.Drawing.Size(150, 56);
            this.itemName.TabIndex = 1;
            this.itemName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // itemPrice
            // 
            this.itemPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemPrice.Location = new System.Drawing.Point(0, 0);
            this.itemPrice.Name = "itemPrice";
            this.itemPrice.Size = new System.Drawing.Size(150, 32);
            this.itemPrice.TabIndex = 2;
            this.itemPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // itemControlPanel
            // 
            this.itemControlPanel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.itemControlPanel.Controls.Add(this.ItemPricePanel);
            this.itemControlPanel.Controls.Add(this.itemNamePanel);
            this.itemControlPanel.Controls.Add(this.itemPicPanel);
            this.itemControlPanel.Location = new System.Drawing.Point(0, 0);
            this.itemControlPanel.Name = "itemControlPanel";
            this.itemControlPanel.Size = new System.Drawing.Size(150, 164);
            this.itemControlPanel.TabIndex = 3;
            // 
            // itemPicPanel
            // 
            this.itemPicPanel.Controls.Add(this.itemPicture);
            this.itemPicPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.itemPicPanel.Location = new System.Drawing.Point(0, 0);
            this.itemPicPanel.Name = "itemPicPanel";
            this.itemPicPanel.Size = new System.Drawing.Size(150, 74);
            this.itemPicPanel.TabIndex = 0;
            // 
            // itemNamePanel
            // 
            this.itemNamePanel.Controls.Add(this.itemName);
            this.itemNamePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.itemNamePanel.Location = new System.Drawing.Point(0, 74);
            this.itemNamePanel.Name = "itemNamePanel";
            this.itemNamePanel.Size = new System.Drawing.Size(150, 56);
            this.itemNamePanel.TabIndex = 1;
            // 
            // ItemPricePanel
            // 
            this.ItemPricePanel.Controls.Add(this.itemPrice);
            this.ItemPricePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ItemPricePanel.Location = new System.Drawing.Point(0, 130);
            this.ItemPricePanel.Name = "ItemPricePanel";
            this.ItemPricePanel.Size = new System.Drawing.Size(150, 32);
            this.ItemPricePanel.TabIndex = 2;
            // 
            // ItemUIComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.itemControlPanel);
            this.Name = "ItemUIComponent";
            this.Size = new System.Drawing.Size(153, 166);
            ((System.ComponentModel.ISupportInitialize)(this.itemPicture)).EndInit();
            this.itemControlPanel.ResumeLayout(false);
            this.itemPicPanel.ResumeLayout(false);
            this.itemNamePanel.ResumeLayout(false);
            this.ItemPricePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox itemPicture;
        private System.Windows.Forms.Label itemName;
        private System.Windows.Forms.Label itemPrice;
        private System.Windows.Forms.Panel itemControlPanel;
        private System.Windows.Forms.Panel ItemPricePanel;
        private System.Windows.Forms.Panel itemNamePanel;
        private System.Windows.Forms.Panel itemPicPanel;
    }
}

namespace FoodOrderMenu
{
    partial class PizzaForm
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
            this.PizzaPanel = new System.Windows.Forms.Panel();
            this.PizzaMenuPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.PizzaTitlePanel = new System.Windows.Forms.Panel();
            this.PizzaTitleTxt = new System.Windows.Forms.Label();
            this.PizzaPanel.SuspendLayout();
            this.PizzaTitlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PizzaPanel
            // 
            this.PizzaPanel.Controls.Add(this.PizzaMenuPanel);
            this.PizzaPanel.Controls.Add(this.PizzaTitlePanel);
            this.PizzaPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PizzaPanel.Location = new System.Drawing.Point(0, 0);
            this.PizzaPanel.Name = "PizzaPanel";
            this.PizzaPanel.Size = new System.Drawing.Size(623, 407);
            this.PizzaPanel.TabIndex = 0;
            // 
            // PizzaMenuPanel
            // 
            this.PizzaMenuPanel.AutoScroll = true;
            this.PizzaMenuPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PizzaMenuPanel.Location = new System.Drawing.Point(0, 40);
            this.PizzaMenuPanel.Margin = new System.Windows.Forms.Padding(0);
            this.PizzaMenuPanel.Name = "PizzaMenuPanel";
            this.PizzaMenuPanel.Size = new System.Drawing.Size(623, 367);
            this.PizzaMenuPanel.TabIndex = 1;
            // 
            // PizzaTitlePanel
            // 
            this.PizzaTitlePanel.AutoScroll = true;
            this.PizzaTitlePanel.Controls.Add(this.PizzaTitleTxt);
            this.PizzaTitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.PizzaTitlePanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PizzaTitlePanel.Location = new System.Drawing.Point(0, 0);
            this.PizzaTitlePanel.Name = "PizzaTitlePanel";
            this.PizzaTitlePanel.Size = new System.Drawing.Size(623, 40);
            this.PizzaTitlePanel.TabIndex = 0;
            // 
            // PizzaTitleTxt
            // 
            this.PizzaTitleTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PizzaTitleTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PizzaTitleTxt.Location = new System.Drawing.Point(0, 0);
            this.PizzaTitleTxt.Name = "PizzaTitleTxt";
            this.PizzaTitleTxt.Size = new System.Drawing.Size(623, 40);
            this.PizzaTitleTxt.TabIndex = 0;
            this.PizzaTitleTxt.Text = "Pizza";
            this.PizzaTitleTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PizzaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(623, 407);
            this.Controls.Add(this.PizzaPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PizzaForm";
            this.Text = "Pizza";
            this.Load += new System.EventHandler(this.PizzaForm_Load);
            this.PizzaPanel.ResumeLayout(false);
            this.PizzaTitlePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PizzaPanel;
        private System.Windows.Forms.FlowLayoutPanel PizzaMenuPanel;
        private System.Windows.Forms.Panel PizzaTitlePanel;
        private System.Windows.Forms.Label PizzaTitleTxt;
    }
}
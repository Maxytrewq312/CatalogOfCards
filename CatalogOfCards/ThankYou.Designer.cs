namespace CatalogOfCards
{
    partial class ThankYou
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
            this.labelThnx = new System.Windows.Forms.Label();
            this.labelTiming = new System.Windows.Forms.Label();
            this.BtnMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelThnx
            // 
            this.labelThnx.AutoSize = true;
            this.labelThnx.BackColor = System.Drawing.Color.Transparent;
            this.labelThnx.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelThnx.ForeColor = System.Drawing.Color.White;
            this.labelThnx.Location = new System.Drawing.Point(135, 67);
            this.labelThnx.Name = "labelThnx";
            this.labelThnx.Size = new System.Drawing.Size(343, 33);
            this.labelThnx.TabIndex = 0;
            this.labelThnx.Text = "СПАСИБО ЗА ОТПРАВКУ!";
            // 
            // labelTiming
            // 
            this.labelTiming.AutoSize = true;
            this.labelTiming.BackColor = System.Drawing.Color.Transparent;
            this.labelTiming.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTiming.ForeColor = System.Drawing.Color.White;
            this.labelTiming.Location = new System.Drawing.Point(16, 158);
            this.labelTiming.Name = "labelTiming";
            this.labelTiming.Size = new System.Drawing.Size(573, 52);
            this.labelTiming.TabIndex = 1;
            this.labelTiming.Text = "В ближайшее время мы с вами обязательно свяжемся\r\n и обсудим волнующие вас вопрос" +
    "ы!";
            this.labelTiming.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnMenu
            // 
            this.BtnMenu.BackColor = System.Drawing.Color.Red;
            this.BtnMenu.FlatAppearance.BorderSize = 0;
            this.BtnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMenu.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMenu.ForeColor = System.Drawing.Color.White;
            this.BtnMenu.Location = new System.Drawing.Point(13, 310);
            this.BtnMenu.Name = "BtnMenu";
            this.BtnMenu.Size = new System.Drawing.Size(145, 47);
            this.BtnMenu.TabIndex = 2;
            this.BtnMenu.Text = "В меню";
            this.BtnMenu.UseVisualStyleBackColor = false;
            this.BtnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // ThankYou
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CatalogOfCards.Properties.Resources.gettyimages_622803666_612x612;
            this.ClientSize = new System.Drawing.Size(596, 369);
            this.Controls.Add(this.BtnMenu);
            this.Controls.Add(this.labelTiming);
            this.Controls.Add(this.labelThnx);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ThankYou";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThankYou";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelThnx;
        private System.Windows.Forms.Label labelTiming;
        private System.Windows.Forms.Button BtnMenu;
    }
}
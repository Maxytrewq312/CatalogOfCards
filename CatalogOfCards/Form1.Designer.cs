namespace CatalogOfCards
{
    partial class FormCatalog
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelCat = new System.Windows.Forms.Label();
            this.BtnSpisok = new System.Windows.Forms.Button();
            this.BtnZapros = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelCat
            // 
            this.labelCat.AutoSize = true;
            this.labelCat.BackColor = System.Drawing.Color.Transparent;
            this.labelCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelCat.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCat.ForeColor = System.Drawing.Color.White;
            this.labelCat.Location = new System.Drawing.Point(179, 19);
            this.labelCat.Name = "labelCat";
            this.labelCat.Size = new System.Drawing.Size(232, 33);
            this.labelCat.TabIndex = 0;
            this.labelCat.Text = "ГЛАВНОЕ МЕНЮ";
            // 
            // BtnSpisok
            // 
            this.BtnSpisok.BackColor = System.Drawing.Color.Red;
            this.BtnSpisok.FlatAppearance.BorderSize = 0;
            this.BtnSpisok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSpisok.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnSpisok.ForeColor = System.Drawing.Color.White;
            this.BtnSpisok.Location = new System.Drawing.Point(115, 123);
            this.BtnSpisok.Name = "BtnSpisok";
            this.BtnSpisok.Size = new System.Drawing.Size(353, 59);
            this.BtnSpisok.TabIndex = 1;
            this.BtnSpisok.Text = "Список медицинских карт";
            this.BtnSpisok.UseVisualStyleBackColor = false;
            this.BtnSpisok.Click += new System.EventHandler(this.BtnSpisok_Click);
            // 
            // BtnZapros
            // 
            this.BtnZapros.BackColor = System.Drawing.Color.Red;
            this.BtnZapros.FlatAppearance.BorderSize = 0;
            this.BtnZapros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnZapros.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnZapros.ForeColor = System.Drawing.Color.White;
            this.BtnZapros.Location = new System.Drawing.Point(115, 209);
            this.BtnZapros.Name = "BtnZapros";
            this.BtnZapros.Size = new System.Drawing.Size(353, 59);
            this.BtnZapros.TabIndex = 2;
            this.BtnZapros.Text = "Запросить консультацию";
            this.BtnZapros.UseVisualStyleBackColor = false;
            this.BtnZapros.Click += new System.EventHandler(this.BtnZapros_Click);
            // 
            // FormCatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CatalogOfCards.Properties.Resources.gettyimages_622803666_612x612;
            this.ClientSize = new System.Drawing.Size(596, 369);
            this.Controls.Add(this.BtnZapros);
            this.Controls.Add(this.BtnSpisok);
            this.Controls.Add(this.labelCat);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormCatalog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное меню";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCat;
        private System.Windows.Forms.Button BtnSpisok;
        private System.Windows.Forms.Button BtnZapros;
    }
}


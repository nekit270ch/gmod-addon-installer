namespace GmodAddonInstaller
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.TbGmodPath = new System.Windows.Forms.TextBox();
            this.BtnSelectPath = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TbAddonName = new System.Windows.Forms.TextBox();
            this.BtnInstall = new System.Windows.Forms.Button();
            this.BtnOpenAddons = new System.Windows.Forms.Button();
            this.BtnAbout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Путь к Garry\'s Mod";
            // 
            // TbGmodPath
            // 
            this.TbGmodPath.Location = new System.Drawing.Point(182, 7);
            this.TbGmodPath.Name = "TbGmodPath";
            this.TbGmodPath.Size = new System.Drawing.Size(498, 34);
            this.TbGmodPath.TabIndex = 1;
            // 
            // BtnSelectPath
            // 
            this.BtnSelectPath.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnSelectPath.Location = new System.Drawing.Point(686, 7);
            this.BtnSelectPath.Name = "BtnSelectPath";
            this.BtnSelectPath.Size = new System.Drawing.Size(84, 28);
            this.BtnSelectPath.TabIndex = 2;
            this.BtnSelectPath.Text = "Выбрать";
            this.BtnSelectPath.UseVisualStyleBackColor = true;
            this.BtnSelectPath.Click += new System.EventHandler(this.BtnSelectPath_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(14, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ссылка на аддон";
            // 
            // TbAddonName
            // 
            this.TbAddonName.Location = new System.Drawing.Point(182, 53);
            this.TbAddonName.Name = "TbAddonName";
            this.TbAddonName.Size = new System.Drawing.Size(588, 34);
            this.TbAddonName.TabIndex = 4;
            // 
            // BtnInstall
            // 
            this.BtnInstall.Location = new System.Drawing.Point(12, 110);
            this.BtnInstall.Name = "BtnInstall";
            this.BtnInstall.Size = new System.Drawing.Size(383, 75);
            this.BtnInstall.TabIndex = 5;
            this.BtnInstall.Text = "Установить";
            this.BtnInstall.UseVisualStyleBackColor = true;
            this.BtnInstall.Click += new System.EventHandler(this.BtnInstall_Click);
            // 
            // BtnOpenAddons
            // 
            this.BtnOpenAddons.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnOpenAddons.Location = new System.Drawing.Point(423, 110);
            this.BtnOpenAddons.Name = "BtnOpenAddons";
            this.BtnOpenAddons.Size = new System.Drawing.Size(347, 31);
            this.BtnOpenAddons.TabIndex = 6;
            this.BtnOpenAddons.Text = "Открыть папку аддонов";
            this.BtnOpenAddons.UseVisualStyleBackColor = true;
            this.BtnOpenAddons.Click += new System.EventHandler(this.BtnOpenAddons_Click);
            // 
            // BtnAbout
            // 
            this.BtnAbout.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnAbout.Location = new System.Drawing.Point(423, 154);
            this.BtnAbout.Name = "BtnAbout";
            this.BtnAbout.Size = new System.Drawing.Size(347, 31);
            this.BtnAbout.TabIndex = 7;
            this.BtnAbout.Text = "О программе";
            this.BtnAbout.UseVisualStyleBackColor = true;
            this.BtnAbout.Click += new System.EventHandler(this.BtnAbout_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 201);
            this.Controls.Add(this.BtnAbout);
            this.Controls.Add(this.BtnOpenAddons);
            this.Controls.Add(this.BtnInstall);
            this.Controls.Add(this.TbAddonName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnSelectPath);
            this.Controls.Add(this.TbGmodPath);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Gmod Addon Installer";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbGmodPath;
        private System.Windows.Forms.Button BtnSelectPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbAddonName;
        private System.Windows.Forms.Button BtnInstall;
        private System.Windows.Forms.Button BtnOpenAddons;
        private System.Windows.Forms.Button BtnAbout;
    }
}


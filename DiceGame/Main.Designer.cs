namespace DiceGame
{
    partial class Main
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.mainMenuPage = new System.Windows.Forms.TabPage();
            this.paramsPage = new System.Windows.Forms.TabPage();
            this.gamePage = new System.Windows.Forms.TabPage();
            this.statisticPage = new System.Windows.Forms.TabPage();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.mainMenuPage);
            this.tabControl.Controls.Add(this.paramsPage);
            this.tabControl.Controls.Add(this.gamePage);
            this.tabControl.Controls.Add(this.statisticPage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(894, 500);
            this.tabControl.TabIndex = 0;
            // 
            // mainMenuPage
            // 
            this.mainMenuPage.Location = new System.Drawing.Point(4, 22);
            this.mainMenuPage.Name = "mainMenuPage";
            this.mainMenuPage.Padding = new System.Windows.Forms.Padding(3);
            this.mainMenuPage.Size = new System.Drawing.Size(886, 474);
            this.mainMenuPage.TabIndex = 0;
            this.mainMenuPage.UseVisualStyleBackColor = true;
            // 
            // paramsPage
            // 
            this.paramsPage.Location = new System.Drawing.Point(4, 22);
            this.paramsPage.Name = "paramsPage";
            this.paramsPage.Padding = new System.Windows.Forms.Padding(3);
            this.paramsPage.Size = new System.Drawing.Size(886, 474);
            this.paramsPage.TabIndex = 1;
            this.paramsPage.UseVisualStyleBackColor = true;
            // 
            // gamePage
            // 
            this.gamePage.Location = new System.Drawing.Point(4, 22);
            this.gamePage.Name = "gamePage";
            this.gamePage.Size = new System.Drawing.Size(886, 474);
            this.gamePage.TabIndex = 2;
            this.gamePage.UseVisualStyleBackColor = true;
            // 
            // statisticPage
            // 
            this.statisticPage.Location = new System.Drawing.Point(4, 22);
            this.statisticPage.Name = "statisticPage";
            this.statisticPage.Size = new System.Drawing.Size(886, 474);
            this.statisticPage.TabIndex = 3;
            this.statisticPage.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 500);
            this.Controls.Add(this.tabControl);
            this.Name = "Main";
            this.Text = "Главное меню";
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage mainMenuPage;
        private System.Windows.Forms.TabPage paramsPage;
        private System.Windows.Forms.TabPage gamePage;
        private System.Windows.Forms.TabPage statisticPage;
    }
}


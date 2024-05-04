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
            this.paramsButton = new System.Windows.Forms.Button();
            this.paramsPage = new System.Windows.Forms.TabPage();
            this.minNumToPassLabel = new System.Windows.Forms.Label();
            this.minNumToPassUpDown = new System.Windows.Forms.NumericUpDown();
            this.startGameButton = new System.Windows.Forms.Button();
            this.chipsLabel = new System.Windows.Forms.Label();
            this.chipsUpDown = new System.Windows.Forms.NumericUpDown();
            this.bumberOfPlayersLabel = new System.Windows.Forms.Label();
            this.numberOfPlayersUpDown = new System.Windows.Forms.NumericUpDown();
            this.gamePage = new System.Windows.Forms.TabPage();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.playerInfoLabel = new System.Windows.Forms.Label();
            this.passButton = new System.Windows.Forms.Button();
            this.rollDiceButton = new System.Windows.Forms.Button();
            this.winnersPage = new System.Windows.Forms.TabPage();
            this.winnersLabelStatic = new System.Windows.Forms.Label();
            this.winnersListBox = new System.Windows.Forms.ListBox();
            this.newRoundButton = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.mainMenuPage.SuspendLayout();
            this.paramsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minNumToPassUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chipsUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfPlayersUpDown)).BeginInit();
            this.gamePage.SuspendLayout();
            this.winnersPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.mainMenuPage);
            this.tabControl.Controls.Add(this.paramsPage);
            this.tabControl.Controls.Add(this.gamePage);
            this.tabControl.Controls.Add(this.winnersPage);
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
            this.mainMenuPage.Controls.Add(this.paramsButton);
            this.mainMenuPage.Location = new System.Drawing.Point(4, 22);
            this.mainMenuPage.Name = "mainMenuPage";
            this.mainMenuPage.Padding = new System.Windows.Forms.Padding(3);
            this.mainMenuPage.Size = new System.Drawing.Size(886, 474);
            this.mainMenuPage.TabIndex = 0;
            this.mainMenuPage.UseVisualStyleBackColor = true;
            // 
            // paramsButton
            // 
            this.paramsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.paramsButton.Location = new System.Drawing.Point(352, 208);
            this.paramsButton.Name = "paramsButton";
            this.paramsButton.Size = new System.Drawing.Size(182, 58);
            this.paramsButton.TabIndex = 0;
            this.paramsButton.Text = "Новая игра";
            this.paramsButton.UseVisualStyleBackColor = true;
            this.paramsButton.Click += new System.EventHandler(this.paramsButton_Click);
            // 
            // paramsPage
            // 
            this.paramsPage.Controls.Add(this.minNumToPassLabel);
            this.paramsPage.Controls.Add(this.minNumToPassUpDown);
            this.paramsPage.Controls.Add(this.startGameButton);
            this.paramsPage.Controls.Add(this.chipsLabel);
            this.paramsPage.Controls.Add(this.chipsUpDown);
            this.paramsPage.Controls.Add(this.bumberOfPlayersLabel);
            this.paramsPage.Controls.Add(this.numberOfPlayersUpDown);
            this.paramsPage.Location = new System.Drawing.Point(4, 22);
            this.paramsPage.Name = "paramsPage";
            this.paramsPage.Padding = new System.Windows.Forms.Padding(3);
            this.paramsPage.Size = new System.Drawing.Size(886, 474);
            this.paramsPage.TabIndex = 1;
            this.paramsPage.UseVisualStyleBackColor = true;
            // 
            // minNumToPassLabel
            // 
            this.minNumToPassLabel.AutoSize = true;
            this.minNumToPassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minNumToPassLabel.Location = new System.Drawing.Point(216, 280);
            this.minNumToPassLabel.Name = "minNumToPassLabel";
            this.minNumToPassLabel.Size = new System.Drawing.Size(333, 24);
            this.minNumToPassLabel.TabIndex = 6;
            this.minNumToPassLabel.Text = "Минимальное число очков для паса";
            // 
            // minNumToPassUpDown
            // 
            this.minNumToPassUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minNumToPassUpDown.Location = new System.Drawing.Point(555, 278);
            this.minNumToPassUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.minNumToPassUpDown.Name = "minNumToPassUpDown";
            this.minNumToPassUpDown.Size = new System.Drawing.Size(60, 29);
            this.minNumToPassUpDown.TabIndex = 5;
            this.minNumToPassUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // startGameButton
            // 
            this.startGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startGameButton.Location = new System.Drawing.Point(367, 368);
            this.startGameButton.Name = "startGameButton";
            this.startGameButton.Size = new System.Drawing.Size(182, 58);
            this.startGameButton.TabIndex = 4;
            this.startGameButton.Text = "Продолжить";
            this.startGameButton.UseVisualStyleBackColor = true;
            this.startGameButton.Click += new System.EventHandler(this.startGameButton_Click);
            // 
            // chipsLabel
            // 
            this.chipsLabel.AutoSize = true;
            this.chipsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chipsLabel.Location = new System.Drawing.Point(271, 225);
            this.chipsLabel.Name = "chipsLabel";
            this.chipsLabel.Size = new System.Drawing.Size(278, 24);
            this.chipsLabel.TabIndex = 3;
            this.chipsLabel.Text = "Количество фишек на игрока:";
            // 
            // chipsUpDown
            // 
            this.chipsUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chipsUpDown.Location = new System.Drawing.Point(555, 223);
            this.chipsUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.chipsUpDown.Name = "chipsUpDown";
            this.chipsUpDown.Size = new System.Drawing.Size(60, 29);
            this.chipsUpDown.TabIndex = 2;
            this.chipsUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // bumberOfPlayersLabel
            // 
            this.bumberOfPlayersLabel.AutoSize = true;
            this.bumberOfPlayersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bumberOfPlayersLabel.Location = new System.Drawing.Point(349, 169);
            this.bumberOfPlayersLabel.Name = "bumberOfPlayersLabel";
            this.bumberOfPlayersLabel.Size = new System.Drawing.Size(200, 24);
            this.bumberOfPlayersLabel.TabIndex = 1;
            this.bumberOfPlayersLabel.Text = "Количество игроков:";
            // 
            // numberOfPlayersUpDown
            // 
            this.numberOfPlayersUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberOfPlayersUpDown.Location = new System.Drawing.Point(555, 167);
            this.numberOfPlayersUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberOfPlayersUpDown.Name = "numberOfPlayersUpDown";
            this.numberOfPlayersUpDown.Size = new System.Drawing.Size(60, 29);
            this.numberOfPlayersUpDown.TabIndex = 0;
            this.numberOfPlayersUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // gamePage
            // 
            this.gamePage.Controls.Add(this.scoreLabel);
            this.gamePage.Controls.Add(this.label1);
            this.gamePage.Controls.Add(this.idLabel);
            this.gamePage.Controls.Add(this.playerInfoLabel);
            this.gamePage.Controls.Add(this.passButton);
            this.gamePage.Controls.Add(this.rollDiceButton);
            this.gamePage.Location = new System.Drawing.Point(4, 22);
            this.gamePage.Name = "gamePage";
            this.gamePage.Size = new System.Drawing.Size(886, 474);
            this.gamePage.TabIndex = 2;
            this.gamePage.UseVisualStyleBackColor = true;
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scoreLabel.Location = new System.Drawing.Point(514, 185);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(20, 24);
            this.scoreLabel.TabIndex = 6;
            this.scoreLabel.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(329, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Количество очков:";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idLabel.Location = new System.Drawing.Point(97, 17);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(20, 24);
            this.idLabel.TabIndex = 4;
            this.idLabel.Text = "0";
            // 
            // playerInfoLabel
            // 
            this.playerInfoLabel.AutoSize = true;
            this.playerInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.playerInfoLabel.Location = new System.Drawing.Point(18, 17);
            this.playerInfoLabel.Name = "playerInfoLabel";
            this.playerInfoLabel.Size = new System.Drawing.Size(73, 24);
            this.playerInfoLabel.TabIndex = 2;
            this.playerInfoLabel.Text = "Игрок: ";
            // 
            // passButton
            // 
            this.passButton.Enabled = false;
            this.passButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passButton.Location = new System.Drawing.Point(317, 291);
            this.passButton.Name = "passButton";
            this.passButton.Size = new System.Drawing.Size(242, 49);
            this.passButton.TabIndex = 1;
            this.passButton.Text = "Спасовать";
            this.passButton.UseVisualStyleBackColor = true;
            this.passButton.Click += new System.EventHandler(this.passButton_Click);
            // 
            // rollDiceButton
            // 
            this.rollDiceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rollDiceButton.Location = new System.Drawing.Point(317, 225);
            this.rollDiceButton.Name = "rollDiceButton";
            this.rollDiceButton.Size = new System.Drawing.Size(242, 49);
            this.rollDiceButton.TabIndex = 0;
            this.rollDiceButton.Text = "Бросить кость";
            this.rollDiceButton.UseVisualStyleBackColor = true;
            this.rollDiceButton.Click += new System.EventHandler(this.rollDiceButton_Click);
            // 
            // winnersPage
            // 
            this.winnersPage.Controls.Add(this.newRoundButton);
            this.winnersPage.Controls.Add(this.winnersListBox);
            this.winnersPage.Controls.Add(this.winnersLabelStatic);
            this.winnersPage.Location = new System.Drawing.Point(4, 22);
            this.winnersPage.Name = "winnersPage";
            this.winnersPage.Size = new System.Drawing.Size(886, 474);
            this.winnersPage.TabIndex = 3;
            this.winnersPage.UseVisualStyleBackColor = true;
            // 
            // winnersLabelStatic
            // 
            this.winnersLabelStatic.AutoSize = true;
            this.winnersLabelStatic.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.winnersLabelStatic.Location = new System.Drawing.Point(346, 70);
            this.winnersLabelStatic.Name = "winnersLabelStatic";
            this.winnersLabelStatic.Size = new System.Drawing.Size(194, 24);
            this.winnersLabelStatic.TabIndex = 0;
            this.winnersLabelStatic.Text = "Победители раунда:";
            // 
            // winnersListBox
            // 
            this.winnersListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.winnersListBox.FormattingEnabled = true;
            this.winnersListBox.ItemHeight = 24;
            this.winnersListBox.Location = new System.Drawing.Point(350, 112);
            this.winnersListBox.Name = "winnersListBox";
            this.winnersListBox.Size = new System.Drawing.Size(190, 172);
            this.winnersListBox.TabIndex = 1;
            // 
            // newRoundButton
            // 
            this.newRoundButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newRoundButton.Location = new System.Drawing.Point(348, 339);
            this.newRoundButton.Name = "newRoundButton";
            this.newRoundButton.Size = new System.Drawing.Size(190, 49);
            this.newRoundButton.TabIndex = 2;
            this.newRoundButton.Text = "Новый раунд";
            this.newRoundButton.UseVisualStyleBackColor = true;
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
            this.mainMenuPage.ResumeLayout(false);
            this.paramsPage.ResumeLayout(false);
            this.paramsPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minNumToPassUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chipsUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfPlayersUpDown)).EndInit();
            this.gamePage.ResumeLayout(false);
            this.gamePage.PerformLayout();
            this.winnersPage.ResumeLayout(false);
            this.winnersPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage mainMenuPage;
        private System.Windows.Forms.TabPage paramsPage;
        private System.Windows.Forms.TabPage gamePage;
        private System.Windows.Forms.TabPage winnersPage;
        private System.Windows.Forms.Button paramsButton;
        private System.Windows.Forms.Label bumberOfPlayersLabel;
        private System.Windows.Forms.NumericUpDown numberOfPlayersUpDown;
        private System.Windows.Forms.Label chipsLabel;
        private System.Windows.Forms.NumericUpDown chipsUpDown;
        private System.Windows.Forms.Button startGameButton;
        private System.Windows.Forms.Button rollDiceButton;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label playerInfoLabel;
        private System.Windows.Forms.Button passButton;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label minNumToPassLabel;
        private System.Windows.Forms.NumericUpDown minNumToPassUpDown;
        private System.Windows.Forms.Label winnersLabelStatic;
        private System.Windows.Forms.ListBox winnersListBox;
        private System.Windows.Forms.Button newRoundButton;
    }
}


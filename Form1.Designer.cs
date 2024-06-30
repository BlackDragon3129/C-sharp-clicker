
namespace Clicker
{
    partial class Window
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Window));
            this.MoneyLabel = new System.Windows.Forms.Label();
            this.PerClickLabel = new System.Windows.Forms.Label();
            this.PerSecondLabel = new System.Windows.Forms.Label();
            this.ClickCostLabel = new System.Windows.Forms.Label();
            this.SecCostLabel = new System.Windows.Forms.Label();
            this.XLabel = new System.Windows.Forms.Label();
            this.ClickButton = new System.Windows.Forms.Button();
            this.ClickUpgrade = new System.Windows.Forms.Button();
            this.SecUpgrade = new System.Windows.Forms.Button();
            this.ProgressDropButton = new System.Windows.Forms.Button();
            this.NewGameButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SecondTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // MoneyLabel
            // 
            this.MoneyLabel.AutoSize = true;
            this.MoneyLabel.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MoneyLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MoneyLabel.Location = new System.Drawing.Point(35, 25);
            this.MoneyLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.MoneyLabel.Name = "MoneyLabel";
            this.MoneyLabel.Size = new System.Drawing.Size(54, 38);
            this.MoneyLabel.TabIndex = 0;
            this.MoneyLabel.Text = "☺";
            // 
            // PerClickLabel
            // 
            this.PerClickLabel.AutoSize = true;
            this.PerClickLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.PerClickLabel.Location = new System.Drawing.Point(35, 100);
            this.PerClickLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.PerClickLabel.Name = "PerClickLabel";
            this.PerClickLabel.Size = new System.Drawing.Size(168, 38);
            this.PerClickLabel.TabIndex = 1;
            this.PerClickLabel.Text = "За клик: ☺";
            // 
            // PerSecondLabel
            // 
            this.PerSecondLabel.AutoSize = true;
            this.PerSecondLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.PerSecondLabel.Location = new System.Drawing.Point(35, 225);
            this.PerSecondLabel.Name = "PerSecondLabel";
            this.PerSecondLabel.Size = new System.Drawing.Size(204, 38);
            this.PerSecondLabel.TabIndex = 2;
            this.PerSecondLabel.Text = "В секунду:  ☺";
            // 
            // ClickCostLabel
            // 
            this.ClickCostLabel.AutoSize = true;
            this.ClickCostLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClickCostLabel.Location = new System.Drawing.Point(35, 150);
            this.ClickCostLabel.Name = "ClickCostLabel";
            this.ClickCostLabel.Size = new System.Drawing.Size(329, 38);
            this.ClickCostLabel.TabIndex = 3;
            this.ClickCostLabel.Text = "Цена улучшения клика: ";
            // 
            // SecCostLabel
            // 
            this.SecCostLabel.AutoSize = true;
            this.SecCostLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SecCostLabel.Location = new System.Drawing.Point(35, 275);
            this.SecCostLabel.Name = "SecCostLabel";
            this.SecCostLabel.Size = new System.Drawing.Size(423, 38);
            this.SecCostLabel.TabIndex = 4;
            this.SecCostLabel.Text = "Цена улучшения ☺ в секунду: ";
            // 
            // XLabel
            // 
            this.XLabel.AutoSize = true;
            this.XLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.XLabel.Location = new System.Drawing.Point(35, 350);
            this.XLabel.Name = "XLabel";
            this.XLabel.Size = new System.Drawing.Size(208, 38);
            this.XLabel.TabIndex = 5;
            this.XLabel.Text = "Множитель: x1";
            // 
            // ClickButton
            // 
            this.ClickButton.BackColor = System.Drawing.Color.Black;
            this.ClickButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.ClickButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClickButton.Location = new System.Drawing.Point(35, 425);
            this.ClickButton.Name = "ClickButton";
            this.ClickButton.Size = new System.Drawing.Size(150, 50);
            this.ClickButton.TabIndex = 6;
            this.ClickButton.Text = "Кликай!";
            this.ClickButton.UseVisualStyleBackColor = false;
            this.ClickButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ClickButton_MouseClick);
            // 
            // ClickUpgrade
            // 
            this.ClickUpgrade.BackColor = System.Drawing.Color.Black;
            this.ClickUpgrade.Font = new System.Drawing.Font("Comic Sans MS", 12.25F);
            this.ClickUpgrade.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClickUpgrade.Location = new System.Drawing.Point(215, 425);
            this.ClickUpgrade.Name = "ClickUpgrade";
            this.ClickUpgrade.Size = new System.Drawing.Size(150, 50);
            this.ClickUpgrade.TabIndex = 7;
            this.ClickUpgrade.Text = "Улучшить клик";
            this.ClickUpgrade.UseVisualStyleBackColor = false;
            this.ClickUpgrade.Click += new System.EventHandler(this.ClickUpgrade_Click);
            // 
            // SecUpgrade
            // 
            this.SecUpgrade.BackColor = System.Drawing.Color.Black;
            this.SecUpgrade.Font = new System.Drawing.Font("Comic Sans MS", 11.25F);
            this.SecUpgrade.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SecUpgrade.Location = new System.Drawing.Point(395, 425);
            this.SecUpgrade.Name = "SecUpgrade";
            this.SecUpgrade.Size = new System.Drawing.Size(150, 50);
            this.SecUpgrade.TabIndex = 8;
            this.SecUpgrade.Text = "Улучшить секунду";
            this.SecUpgrade.UseVisualStyleBackColor = false;
            this.SecUpgrade.Click += new System.EventHandler(this.SecUpgrade_Click);
            // 
            // ProgressDropButton
            // 
            this.ProgressDropButton.BackColor = System.Drawing.Color.Black;
            this.ProgressDropButton.Enabled = false;
            this.ProgressDropButton.Font = new System.Drawing.Font("Comic Sans MS", 11.25F);
            this.ProgressDropButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ProgressDropButton.Location = new System.Drawing.Point(35, 500);
            this.ProgressDropButton.Name = "ProgressDropButton";
            this.ProgressDropButton.Size = new System.Drawing.Size(150, 50);
            this.ProgressDropButton.TabIndex = 9;
            this.ProgressDropButton.Text = "Сбросить прогресс";
            this.ProgressDropButton.UseVisualStyleBackColor = false;
            this.ProgressDropButton.Click += new System.EventHandler(this.ProgressDropButton_Click);
            // 
            // NewGameButton
            // 
            this.NewGameButton.BackColor = System.Drawing.Color.Black;
            this.NewGameButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.NewGameButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.NewGameButton.Location = new System.Drawing.Point(215, 500);
            this.NewGameButton.Name = "NewGameButton";
            this.NewGameButton.Size = new System.Drawing.Size(150, 50);
            this.NewGameButton.TabIndex = 10;
            this.NewGameButton.Text = "Новая игра";
            this.NewGameButton.UseVisualStyleBackColor = false;
            this.NewGameButton.Click += new System.EventHandler(this.NewGameButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Black;
            this.ExitButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.ExitButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ExitButton.Location = new System.Drawing.Point(395, 500);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(150, 50);
            this.ExitButton.TabIndex = 11;
            this.ExitButton.Text = "Выход";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // SecondTimer
            // 
            this.SecondTimer.Enabled = true;
            this.SecondTimer.Interval = 1000;
            this.SecondTimer.Tick += new System.EventHandler(this.SecondTimer_Tick);
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.NewGameButton);
            this.Controls.Add(this.ProgressDropButton);
            this.Controls.Add(this.SecUpgrade);
            this.Controls.Add(this.ClickUpgrade);
            this.Controls.Add(this.ClickButton);
            this.Controls.Add(this.XLabel);
            this.Controls.Add(this.SecCostLabel);
            this.Controls.Add(this.ClickCostLabel);
            this.Controls.Add(this.PerSecondLabel);
            this.Controls.Add(this.PerClickLabel);
            this.Controls.Add(this.MoneyLabel);
            this.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.Name = "Window";
            this.Text = "Clicker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Window_FormClosing);
            this.Load += new System.EventHandler(this.Window_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MoneyLabel;
        private System.Windows.Forms.Label PerClickLabel;
        private System.Windows.Forms.Label PerSecondLabel;
        private System.Windows.Forms.Label ClickCostLabel;
        private System.Windows.Forms.Label SecCostLabel;
        private System.Windows.Forms.Label XLabel;
        private System.Windows.Forms.Button ClickButton;
        private System.Windows.Forms.Button ClickUpgrade;
        private System.Windows.Forms.Button SecUpgrade;
        private System.Windows.Forms.Button ProgressDropButton;
        private System.Windows.Forms.Button NewGameButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Timer SecondTimer;
    }
}


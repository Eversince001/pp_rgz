namespace vkr
{
    partial class solution
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(solution));
            this.SolutionButton = new System.Windows.Forms.Button();
            this.ButtonR = new System.Windows.Forms.Button();
            this.ButtonS = new System.Windows.Forms.Button();
            this.textBoxR = new System.Windows.Forms.TextBox();
            this.textBoxS = new System.Windows.Forms.TextBox();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.textBoxD = new System.Windows.Forms.TextBox();
            this.textBoxV = new System.Windows.Forms.TextBox();
            this.labelR = new System.Windows.Forms.Label();
            this.labelS = new System.Windows.Forms.Label();
            this.labelN = new System.Windows.Forms.Label();
            this.labelD = new System.Windows.Forms.Label();
            this.labelV = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonTime = new System.Windows.Forms.Button();
            this.инфоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SolutionButton
            // 
            this.SolutionButton.Location = new System.Drawing.Point(620, 426);
            this.SolutionButton.Name = "SolutionButton";
            this.SolutionButton.Size = new System.Drawing.Size(114, 40);
            this.SolutionButton.TabIndex = 7;
            this.SolutionButton.Text = "Вычислить";
            this.SolutionButton.UseVisualStyleBackColor = true;
            this.SolutionButton.Click += new System.EventHandler(this.buttonSolution_Click_1);
            // 
            // ButtonR
            // 
            this.ButtonR.Location = new System.Drawing.Point(12, 426);
            this.ButtonR.Name = "ButtonR";
            this.ButtonR.Size = new System.Drawing.Size(114, 40);
            this.ButtonR.TabIndex = 8;
            this.ButtonR.Text = "Машины разгрузки";
            this.ButtonR.UseVisualStyleBackColor = true;
            this.ButtonR.Click += new System.EventHandler(this.ButtonR_Click);
            // 
            // ButtonS
            // 
            this.ButtonS.Location = new System.Drawing.Point(132, 426);
            this.ButtonS.Name = "ButtonS";
            this.ButtonS.Size = new System.Drawing.Size(114, 40);
            this.ButtonS.TabIndex = 9;
            this.ButtonS.Text = "Машины погрузки";
            this.ButtonS.UseVisualStyleBackColor = true;
            this.ButtonS.Click += new System.EventHandler(this.ButtonS_Click);
            // 
            // textBoxR
            // 
            this.textBoxR.Location = new System.Drawing.Point(533, 271);
            this.textBoxR.Name = "textBoxR";
            this.textBoxR.Size = new System.Drawing.Size(201, 20);
            this.textBoxR.TabIndex = 10;
            // 
            // textBoxS
            // 
            this.textBoxS.Location = new System.Drawing.Point(533, 297);
            this.textBoxS.Name = "textBoxS";
            this.textBoxS.Size = new System.Drawing.Size(201, 20);
            this.textBoxS.TabIndex = 11;
            // 
            // textBoxN
            // 
            this.textBoxN.Location = new System.Drawing.Point(533, 323);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(201, 20);
            this.textBoxN.TabIndex = 12;
            // 
            // textBoxD
            // 
            this.textBoxD.Location = new System.Drawing.Point(533, 349);
            this.textBoxD.Name = "textBoxD";
            this.textBoxD.Size = new System.Drawing.Size(201, 20);
            this.textBoxD.TabIndex = 13;
            // 
            // textBoxV
            // 
            this.textBoxV.Location = new System.Drawing.Point(533, 375);
            this.textBoxV.Name = "textBoxV";
            this.textBoxV.Size = new System.Drawing.Size(201, 20);
            this.textBoxV.TabIndex = 14;
            // 
            // labelR
            // 
            this.labelR.AutoSize = true;
            this.labelR.Location = new System.Drawing.Point(369, 278);
            this.labelR.Name = "labelR";
            this.labelR.Size = new System.Drawing.Size(158, 13);
            this.labelR.TabIndex = 15;
            this.labelR.Text = "Количество машин разгрузки";
            // 
            // labelS
            // 
            this.labelS.AutoSize = true;
            this.labelS.Location = new System.Drawing.Point(375, 304);
            this.labelS.Name = "labelS";
            this.labelS.Size = new System.Drawing.Size(152, 13);
            this.labelS.TabIndex = 16;
            this.labelS.Text = "Количество машин погрузки";
            // 
            // labelN
            // 
            this.labelN.AutoSize = true;
            this.labelN.Location = new System.Drawing.Point(385, 330);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(142, 13);
            this.labelN.TabIndex = 17;
            this.labelN.Text = "Количество типов товаров";
            // 
            // labelD
            // 
            this.labelD.AutoSize = true;
            this.labelD.Location = new System.Drawing.Point(399, 356);
            this.labelD.Name = "labelD";
            this.labelD.Size = new System.Drawing.Size(128, 13);
            this.labelD.TabIndex = 18;
            this.labelD.Text = "Время замены машины";
            // 
            // labelV
            // 
            this.labelV.Location = new System.Drawing.Point(243, 378);
            this.labelV.Name = "labelV";
            this.labelV.Size = new System.Drawing.Size(284, 20);
            this.labelV.TabIndex = 19;
            this.labelV.Text = "Время перемещения товара от выгрузки то погрузки";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.инфоToolStripMenuItem,
            this.помощьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(746, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // ButtonTime
            // 
            this.ButtonTime.Location = new System.Drawing.Point(252, 426);
            this.ButtonTime.Name = "ButtonTime";
            this.ButtonTime.Size = new System.Drawing.Size(114, 40);
            this.ButtonTime.TabIndex = 21;
            this.ButtonTime.Text = "Время переноса товаров на складе";
            this.ButtonTime.UseVisualStyleBackColor = true;
            this.ButtonTime.Click += new System.EventHandler(this.ButtonTime_Click);
            // 
            // инфоToolStripMenuItem
            // 
            this.инфоToolStripMenuItem.Name = "инфоToolStripMenuItem";
            this.инфоToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.инфоToolStripMenuItem.Text = "Инфо";
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.помощьToolStripMenuItem.Text = "Помощь";
            // 
            // solution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(746, 478);
            this.Controls.Add(this.ButtonTime);
            this.Controls.Add(this.labelV);
            this.Controls.Add(this.labelD);
            this.Controls.Add(this.labelN);
            this.Controls.Add(this.labelS);
            this.Controls.Add(this.labelR);
            this.Controls.Add(this.textBoxV);
            this.Controls.Add(this.textBoxD);
            this.Controls.Add(this.textBoxN);
            this.Controls.Add(this.textBoxS);
            this.Controls.Add(this.textBoxR);
            this.Controls.Add(this.ButtonS);
            this.Controls.Add(this.ButtonR);
            this.Controls.Add(this.SolutionButton);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "solution";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SolutionButton;
        private System.Windows.Forms.Button ButtonR;
        private System.Windows.Forms.Button ButtonS;
        private System.Windows.Forms.TextBox textBoxR;
        private System.Windows.Forms.TextBox textBoxS;
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.TextBox textBoxD;
        private System.Windows.Forms.TextBox textBoxV;
        private System.Windows.Forms.Label labelR;
        private System.Windows.Forms.Label labelS;
        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.Label labelD;
        private System.Windows.Forms.Label labelV;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.Button ButtonTime;
        private System.Windows.Forms.ToolStripMenuItem инфоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
    }
}


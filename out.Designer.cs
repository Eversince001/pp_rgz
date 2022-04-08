namespace vkr
{
    partial class @out
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(@out));
            this.dataGridViewS = new System.Windows.Forms.DataGridView();
            this.ButtonSaveS = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewS)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewS
            // 
            this.dataGridViewS.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewS.Location = new System.Drawing.Point(2, 29);
            this.dataGridViewS.Name = "dataGridViewS";
            this.dataGridViewS.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewS.RowHeadersVisible = false;
            this.dataGridViewS.Size = new System.Drawing.Size(261, 195);
            this.dataGridViewS.TabIndex = 0;
            // 
            // ButtonSaveS
            // 
            this.ButtonSaveS.Location = new System.Drawing.Point(2, 0);
            this.ButtonSaveS.Name = "ButtonSaveS";
            this.ButtonSaveS.Size = new System.Drawing.Size(75, 23);
            this.ButtonSaveS.TabIndex = 1;
            this.ButtonSaveS.Text = "Сохранить";
            this.ButtonSaveS.UseVisualStyleBackColor = true;
            this.ButtonSaveS.Click += new System.EventHandler(this.ButtonSaveS_Click);
            // 
            // @out
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 273);
            this.Controls.Add(this.ButtonSaveS);
            this.Controls.Add(this.dataGridViewS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "@out";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Машины погрузки";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewS;
        private System.Windows.Forms.Button ButtonSaveS;
    }
}
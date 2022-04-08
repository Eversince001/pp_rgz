namespace vkr
{
    partial class @in
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(@in));
            this.dataGridViewR = new System.Windows.Forms.DataGridView();
            this.ButtonSaveR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewR)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewR
            // 
            this.dataGridViewR.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewR.Location = new System.Drawing.Point(1, 33);
            this.dataGridViewR.Name = "dataGridViewR";
            this.dataGridViewR.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewR.RowHeadersVisible = false;
            this.dataGridViewR.Size = new System.Drawing.Size(443, 181);
            this.dataGridViewR.TabIndex = 0;
            // 
            // ButtonSaveR
            // 
            this.ButtonSaveR.Location = new System.Drawing.Point(1, 6);
            this.ButtonSaveR.Name = "ButtonSaveR";
            this.ButtonSaveR.Size = new System.Drawing.Size(75, 23);
            this.ButtonSaveR.TabIndex = 1;
            this.ButtonSaveR.Text = "Сохранить";
            this.ButtonSaveR.UseVisualStyleBackColor = true;
            this.ButtonSaveR.Click += new System.EventHandler(this.ButtonSaveR_Click);
            // 
            // @in
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 257);
            this.Controls.Add(this.ButtonSaveR);
            this.Controls.Add(this.dataGridViewR);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "@in";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Машины разгрузки";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewR;
        private System.Windows.Forms.Button ButtonSaveR;
    }
}
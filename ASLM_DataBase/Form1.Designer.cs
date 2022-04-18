namespace ASLM_DataBase
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.DataFromBaseGridView = new System.Windows.Forms.DataGridView();
            this.GetDataButton = new System.Windows.Forms.Button();
            this.GetCellInfoButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataFromBaseGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DataFromBaseGridView
            // 
            this.DataFromBaseGridView.AllowUserToAddRows = false;
            this.DataFromBaseGridView.AllowUserToDeleteRows = false;
            this.DataFromBaseGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataFromBaseGridView.Location = new System.Drawing.Point(236, 14);
            this.DataFromBaseGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DataFromBaseGridView.Name = "DataFromBaseGridView";
            this.DataFromBaseGridView.ReadOnly = true;
            this.DataFromBaseGridView.RowHeadersVisible = false;
            this.DataFromBaseGridView.RowHeadersWidth = 51;
            this.DataFromBaseGridView.RowTemplate.Height = 29;
            this.DataFromBaseGridView.Size = new System.Drawing.Size(915, 550);
            this.DataFromBaseGridView.TabIndex = 0;
            // 
            // GetDataButton
            // 
            this.GetDataButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GetDataButton.Location = new System.Drawing.Point(13, 14);
            this.GetDataButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GetDataButton.Name = "GetDataButton";
            this.GetDataButton.Size = new System.Drawing.Size(215, 111);
            this.GetDataButton.TabIndex = 1;
            this.GetDataButton.Text = "Отобразить данные о деталях";
            this.GetDataButton.UseVisualStyleBackColor = true;
            this.GetDataButton.Click += new System.EventHandler(this.GetDataButton_Click);
            // 
            // GetCellInfoButton
            // 
            this.GetCellInfoButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GetCellInfoButton.Location = new System.Drawing.Point(13, 135);
            this.GetCellInfoButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GetCellInfoButton.Name = "GetCellInfoButton";
            this.GetCellInfoButton.Size = new System.Drawing.Size(215, 120);
            this.GetCellInfoButton.TabIndex = 2;
            this.GetCellInfoButton.Text = "Отобразить данные о состоянии ячеек";
            this.GetCellInfoButton.UseVisualStyleBackColor = true;
            this.GetCellInfoButton.Click += new System.EventHandler(this.GetCellInfoButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ASLM_DataBase.Properties.Resources.Lightning;
            this.pictureBox1.Location = new System.Drawing.Point(13, 263);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(215, 174);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 573);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.GetCellInfoButton);
            this.Controls.Add(this.GetDataButton);
            this.Controls.Add(this.DataFromBaseGridView);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "ASLM DataBase";
            ((System.ComponentModel.ISupportInitialize)(this.DataFromBaseGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataFromBaseGridView;
        private System.Windows.Forms.Button GetDataButton;
        private System.Windows.Forms.Button GetCellInfoButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

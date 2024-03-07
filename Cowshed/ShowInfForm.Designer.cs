namespace Cowshed
{
    partial class ShowInfForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowInfForm));
            this.ShowInfDataGridView = new System.Windows.Forms.DataGridView();
            this.CowBtn = new System.Windows.Forms.Button();
            this.FarmerBtn = new System.Windows.Forms.Button();
            this.ShedBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ShowInfDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ShowInfDataGridView
            // 
            this.ShowInfDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowInfDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ShowInfDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ShowInfDataGridView.Location = new System.Drawing.Point(164, 12);
            this.ShowInfDataGridView.Name = "ShowInfDataGridView";
            this.ShowInfDataGridView.RowHeadersWidth = 51;
            this.ShowInfDataGridView.RowTemplate.Height = 24;
            this.ShowInfDataGridView.Size = new System.Drawing.Size(641, 446);
            this.ShowInfDataGridView.TabIndex = 0;
            // 
            // CowBtn
            // 
            this.CowBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CowBtn.Location = new System.Drawing.Point(12, 12);
            this.CowBtn.Name = "CowBtn";
            this.CowBtn.Size = new System.Drawing.Size(146, 43);
            this.CowBtn.TabIndex = 1;
            this.CowBtn.Text = "Cows";
            this.CowBtn.UseVisualStyleBackColor = true;
            this.CowBtn.Click += new System.EventHandler(this.CowBtn_Click);
            // 
            // FarmerBtn
            // 
            this.FarmerBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FarmerBtn.Location = new System.Drawing.Point(13, 62);
            this.FarmerBtn.Name = "FarmerBtn";
            this.FarmerBtn.Size = new System.Drawing.Size(145, 45);
            this.FarmerBtn.TabIndex = 2;
            this.FarmerBtn.Text = "Farmers";
            this.FarmerBtn.UseVisualStyleBackColor = true;
            this.FarmerBtn.Click += new System.EventHandler(this.FarmerBtn_Click);
            // 
            // ShedBtn
            // 
            this.ShedBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShedBtn.Location = new System.Drawing.Point(13, 114);
            this.ShedBtn.Name = "ShedBtn";
            this.ShedBtn.Size = new System.Drawing.Size(145, 44);
            this.ShedBtn.TabIndex = 3;
            this.ShedBtn.Text = "Sheds";
            this.ShedBtn.UseVisualStyleBackColor = true;
            this.ShedBtn.Click += new System.EventHandler(this.ShedBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseBtn.Location = new System.Drawing.Point(12, 400);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(146, 38);
            this.CloseBtn.TabIndex = 4;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // ShowInfForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.ShedBtn);
            this.Controls.Add(this.FarmerBtn);
            this.Controls.Add(this.CowBtn);
            this.Controls.Add(this.ShowInfDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ShowInfForm";
            this.Text = "Information";
            ((System.ComponentModel.ISupportInitialize)(this.ShowInfDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ShowInfDataGridView;
        private System.Windows.Forms.Button CowBtn;
        private System.Windows.Forms.Button FarmerBtn;
        private System.Windows.Forms.Button ShedBtn;
        private System.Windows.Forms.Button CloseBtn;
    }
}
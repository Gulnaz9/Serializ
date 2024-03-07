namespace Cowshed
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.SerBtn = new System.Windows.Forms.Button();
            this.DeserBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.shedPicBox = new System.Windows.Forms.PictureBox();
            this.treeView = new System.Windows.Forms.TreeView();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.cowBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.shedPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cowBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // SerBtn
            // 
            this.SerBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SerBtn.Location = new System.Drawing.Point(182, 12);
            this.SerBtn.Name = "SerBtn";
            this.SerBtn.Size = new System.Drawing.Size(134, 73);
            this.SerBtn.TabIndex = 0;
            this.SerBtn.Text = "Download";
            this.SerBtn.UseVisualStyleBackColor = true;
            this.SerBtn.Click += new System.EventHandler(this.SerBtn_Click);
            // 
            // DeserBtn
            // 
            this.DeserBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeserBtn.Location = new System.Drawing.Point(322, 12);
            this.DeserBtn.Name = "DeserBtn";
            this.DeserBtn.Size = new System.Drawing.Size(137, 73);
            this.DeserBtn.TabIndex = 1;
            this.DeserBtn.Text = "Show";
            this.DeserBtn.UseVisualStyleBackColor = true;
            this.DeserBtn.Click += new System.EventHandler(this.DeserBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseBtn.Location = new System.Drawing.Point(465, 12);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(134, 73);
            this.CloseBtn.TabIndex = 2;
            this.CloseBtn.Text = "Clolse";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // shedPicBox
            // 
            this.shedPicBox.Image = global::Cowshed.Properties.Resources.Shed;
            this.shedPicBox.Location = new System.Drawing.Point(12, 12);
            this.shedPicBox.Name = "shedPicBox";
            this.shedPicBox.Size = new System.Drawing.Size(164, 146);
            this.shedPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.shedPicBox.TabIndex = 8;
            this.shedPicBox.TabStop = false;
            // 
            // treeView
            // 
            this.treeView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.treeView.Location = new System.Drawing.Point(-2, 164);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(185, 295);
            this.treeView.TabIndex = 9;
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(182, 91);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(619, 368);
            this.dataGridView.TabIndex = 10;
            // 
            // cowBindingSource
            // 
            this.cowBindingSource.DataSource = typeof(Cowshed.Cow);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.shedPicBox);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.DeserBtn);
            this.Controls.Add(this.SerBtn);
            this.Controls.Add(this.treeView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Cowshed";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.shedPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cowBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SerBtn;
        private System.Windows.Forms.Button DeserBtn;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.PictureBox shedPicBox;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.BindingSource cowBindingSource;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}


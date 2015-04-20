namespace CompressBMPx4
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.visualStyler1 = new SkinSoft.VisualStyler.VisualStyler(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.OpenFile_btn = new System.Windows.Forms.Button();
            this.OpenText_txtbox = new System.Windows.Forms.TextBox();
            this.Compress_btn = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.visualStyler1)).BeginInit();
            this.SuspendLayout();
            // 
            // visualStyler1
            // 
            this.visualStyler1.HostForm = this;
            this.visualStyler1.License = ((SkinSoft.VisualStyler.Licensing.VisualStylerLicense)(resources.GetObject("visualStyler1.License")));
            this.visualStyler1.LoadVisualStyle(null, "CORE (BLACK2).vssf");
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // OpenFile_btn
            // 
            this.OpenFile_btn.Location = new System.Drawing.Point(12, 12);
            this.OpenFile_btn.Name = "OpenFile_btn";
            this.OpenFile_btn.Size = new System.Drawing.Size(75, 23);
            this.OpenFile_btn.TabIndex = 0;
            this.OpenFile_btn.Text = "Open File";
            this.OpenFile_btn.UseVisualStyleBackColor = true;
            this.OpenFile_btn.Click += new System.EventHandler(this.OpenFile_btn_Click);
            // 
            // OpenText_txtbox
            // 
            this.OpenText_txtbox.Location = new System.Drawing.Point(93, 15);
            this.OpenText_txtbox.Name = "OpenText_txtbox";
            this.OpenText_txtbox.ReadOnly = true;
            this.OpenText_txtbox.Size = new System.Drawing.Size(313, 20);
            this.OpenText_txtbox.TabIndex = 1;
            // 
            // Compress_btn
            // 
            this.Compress_btn.Location = new System.Drawing.Point(12, 41);
            this.Compress_btn.Name = "Compress_btn";
            this.Compress_btn.Size = new System.Drawing.Size(75, 23);
            this.Compress_btn.TabIndex = 2;
            this.Compress_btn.Text = "Compress";
            this.Compress_btn.UseVisualStyleBackColor = true;
            this.Compress_btn.Click += new System.EventHandler(this.Compress_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Compress image x4";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 102);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Compress_btn);
            this.Controls.Add(this.OpenText_txtbox);
            this.Controls.Add(this.OpenFile_btn);
            this.Name = "MainForm";
            this.Text = "CompressImage";
            ((System.ComponentModel.ISupportInitialize)(this.visualStyler1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SkinSoft.VisualStyler.VisualStyler visualStyler1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox OpenText_txtbox;
        private System.Windows.Forms.Button OpenFile_btn;
        private System.Windows.Forms.Button Compress_btn;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label1;
    }
}


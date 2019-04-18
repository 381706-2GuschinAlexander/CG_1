namespace ColorInversion
{
    partial class Form1
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
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
      this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.compareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.filtersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.inversionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.blackAndWhiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.averToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.lightnessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.blurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.standartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.binarizationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.adaptiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // pictureBox1
      // 
      this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
      this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.pictureBox1.Location = new System.Drawing.Point(0, 27);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(869, 567);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pictureBox1.TabIndex = 1;
      this.pictureBox1.TabStop = false;
      // 
      // openFileDialog1
      // 
      this.openFileDialog1.FileName = "openFileDialog1";
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.filtersToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(869, 24);
      this.menuStrip1.TabIndex = 4;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // fileToolStripMenuItem
      // 
      this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.compareToolStripMenuItem});
      this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
      this.fileToolStripMenuItem.Text = "File";
      // 
      // loadToolStripMenuItem
      // 
      this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
      this.loadToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
      this.loadToolStripMenuItem.Text = "Load";
      this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
      // 
      // saveToolStripMenuItem
      // 
      this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
      this.saveToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
      this.saveToolStripMenuItem.Text = "Save";
      this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
      // 
      // compareToolStripMenuItem
      // 
      this.compareToolStripMenuItem.Name = "compareToolStripMenuItem";
      this.compareToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
      this.compareToolStripMenuItem.Text = "Compare";
      this.compareToolStripMenuItem.Click += new System.EventHandler(this.compareToolStripMenuItem_Click);
      // 
      // filtersToolStripMenuItem
      // 
      this.filtersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inversionToolStripMenuItem,
            this.blackAndWhiteToolStripMenuItem,
            this.blurToolStripMenuItem,
            this.binarizationToolStripMenuItem});
      this.filtersToolStripMenuItem.Name = "filtersToolStripMenuItem";
      this.filtersToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
      this.filtersToolStripMenuItem.Text = "Filters";
      // 
      // inversionToolStripMenuItem
      // 
      this.inversionToolStripMenuItem.Name = "inversionToolStripMenuItem";
      this.inversionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.inversionToolStripMenuItem.Text = "Inversion";
      this.inversionToolStripMenuItem.Click += new System.EventHandler(this.inversionToolStripMenuItem_Click);
      // 
      // blackAndWhiteToolStripMenuItem
      // 
      this.blackAndWhiteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.averToolStripMenuItem,
            this.lightnessToolStripMenuItem});
      this.blackAndWhiteToolStripMenuItem.Name = "blackAndWhiteToolStripMenuItem";
      this.blackAndWhiteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.blackAndWhiteToolStripMenuItem.Text = "Black and White";
      // 
      // averToolStripMenuItem
      // 
      this.averToolStripMenuItem.Name = "averToolStripMenuItem";
      this.averToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
      this.averToolStripMenuItem.Text = "Average";
      this.averToolStripMenuItem.Click += new System.EventHandler(this.averToolStripMenuItem_Click);
      // 
      // lightnessToolStripMenuItem
      // 
      this.lightnessToolStripMenuItem.Name = "lightnessToolStripMenuItem";
      this.lightnessToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
      this.lightnessToolStripMenuItem.Text = "Lightness";
      this.lightnessToolStripMenuItem.Click += new System.EventHandler(this.lightnessToolStripMenuItem_Click);
      // 
      // blurToolStripMenuItem
      // 
      this.blurToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.standartToolStripMenuItem});
      this.blurToolStripMenuItem.Name = "blurToolStripMenuItem";
      this.blurToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.blurToolStripMenuItem.Text = "Blur";
      // 
      // standartToolStripMenuItem
      // 
      this.standartToolStripMenuItem.Name = "standartToolStripMenuItem";
      this.standartToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.standartToolStripMenuItem.Text = "Standart";
      this.standartToolStripMenuItem.Click += new System.EventHandler(this.standartToolStripMenuItem_Click);
      // 
      // binarizationToolStripMenuItem
      // 
      this.binarizationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaptiveToolStripMenuItem});
      this.binarizationToolStripMenuItem.Name = "binarizationToolStripMenuItem";
      this.binarizationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.binarizationToolStripMenuItem.Text = "Binarization";
      // 
      // adaptiveToolStripMenuItem
      // 
      this.adaptiveToolStripMenuItem.Name = "adaptiveToolStripMenuItem";
      this.adaptiveToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
      this.adaptiveToolStripMenuItem.Text = "Adaptive";
      this.adaptiveToolStripMenuItem.Click += new System.EventHandler(this.adaptiveToolStripMenuItem_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSize = true;
      this.ClientSize = new System.Drawing.Size(869, 594);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.menuStrip1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MainMenuStrip = this.menuStrip1;
      this.MaximizeBox = false;
      this.Name = "Form1";
      this.Text = "Инвертирование цвета картинки";
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem filtersToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem inversionToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem blackAndWhiteToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem averToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem lightnessToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem blurToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem standartToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem compareToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem binarizationToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem adaptiveToolStripMenuItem;
  }
}


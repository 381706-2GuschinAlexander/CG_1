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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.коррекцияЦветаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.инверсияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.размытиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.размытиеГаусаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.чернобкедлыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.averageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lightnessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.luminosityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.photoshopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iTURBT709ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maxRGBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minRGBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.somethingAlseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сепияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.шумоподавлениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.чернобелоеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.стандартToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.адаптивныйФильтрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.информацияОбИзображенииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.гистограммаИзображенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button4 = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.медианныйФильтрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Location = new System.Drawing.Point(0, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1159, 542);
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
            this.toolStripMenuItem1,
            this.коррекцияЦветаToolStripMenuItem,
            this.информацияОбИзображенииToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1159, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.загрузитьToolStripMenuItem,
            this.сохранитьToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(48, 20);
            this.toolStripMenuItem1.Text = "Файл";
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.загрузитьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // коррекцияЦветаToolStripMenuItem
            // 
            this.коррекцияЦветаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.инверсияToolStripMenuItem,
            this.размытиеToolStripMenuItem,
            this.размытиеГаусаToolStripMenuItem,
            this.чернобкедлыйToolStripMenuItem,
            this.сепияToolStripMenuItem,
            this.шумоподавлениеToolStripMenuItem,
            this.чернобелоеToolStripMenuItem});
            this.коррекцияЦветаToolStripMenuItem.Name = "коррекцияЦветаToolStripMenuItem";
            this.коррекцияЦветаToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.коррекцияЦветаToolStripMenuItem.Text = "Фильтры";
            // 
            // инверсияToolStripMenuItem
            // 
            this.инверсияToolStripMenuItem.Name = "инверсияToolStripMenuItem";
            this.инверсияToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.инверсияToolStripMenuItem.Text = "Инверсия";
            this.инверсияToolStripMenuItem.Click += new System.EventHandler(this.инверсияToolStripMenuItem_Click);
            // 
            // размытиеToolStripMenuItem
            // 
            this.размытиеToolStripMenuItem.Name = "размытиеToolStripMenuItem";
            this.размытиеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.размытиеToolStripMenuItem.Text = "Размытие";
            this.размытиеToolStripMenuItem.Click += new System.EventHandler(this.размытиеToolStripMenuItem_Click);
            // 
            // размытиеГаусаToolStripMenuItem
            // 
            this.размытиеГаусаToolStripMenuItem.Name = "размытиеГаусаToolStripMenuItem";
            this.размытиеГаусаToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.размытиеГаусаToolStripMenuItem.Text = "Размытие Гауса";
            this.размытиеГаусаToolStripMenuItem.Click += new System.EventHandler(this.размытиеГаусаToolStripMenuItem_Click);
            // 
            // чернобкедлыйToolStripMenuItem
            // 
            this.чернобкедлыйToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.averageToolStripMenuItem,
            this.lightnessToolStripMenuItem,
            this.luminosityToolStripMenuItem,
            this.photoshopToolStripMenuItem,
            this.iTURBT709ToolStripMenuItem,
            this.maxRGBToolStripMenuItem,
            this.minRGBToolStripMenuItem,
            this.somethingAlseToolStripMenuItem});
            this.чернобкедлыйToolStripMenuItem.Name = "чернобкедлыйToolStripMenuItem";
            this.чернобкедлыйToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.чернобкедлыйToolStripMenuItem.Text = "Оттенки серого";
            // 
            // averageToolStripMenuItem
            // 
            this.averageToolStripMenuItem.Name = "averageToolStripMenuItem";
            this.averageToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.averageToolStripMenuItem.Text = "Average";
            this.averageToolStripMenuItem.Click += new System.EventHandler(this.averageToolStripMenuItem_Click);
            // 
            // lightnessToolStripMenuItem
            // 
            this.lightnessToolStripMenuItem.Name = "lightnessToolStripMenuItem";
            this.lightnessToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.lightnessToolStripMenuItem.Text = "Lightness";
            this.lightnessToolStripMenuItem.Click += new System.EventHandler(this.lightnessToolStripMenuItem_Click);
            // 
            // luminosityToolStripMenuItem
            // 
            this.luminosityToolStripMenuItem.Name = "luminosityToolStripMenuItem";
            this.luminosityToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.luminosityToolStripMenuItem.Text = "Luminosity";
            this.luminosityToolStripMenuItem.Click += new System.EventHandler(this.luminosityToolStripMenuItem_Click);
            // 
            // photoshopToolStripMenuItem
            // 
            this.photoshopToolStripMenuItem.Name = "photoshopToolStripMenuItem";
            this.photoshopToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.photoshopToolStripMenuItem.Text = "Photoshop, GIMP";
            this.photoshopToolStripMenuItem.Click += new System.EventHandler(this.photoshopToolStripMenuItem_Click);
            // 
            // iTURBT709ToolStripMenuItem
            // 
            this.iTURBT709ToolStripMenuItem.Name = "iTURBT709ToolStripMenuItem";
            this.iTURBT709ToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.iTURBT709ToolStripMenuItem.Text = "ITU-R, BT.709";
            this.iTURBT709ToolStripMenuItem.Click += new System.EventHandler(this.iTURBT709ToolStripMenuItem_Click);
            // 
            // maxRGBToolStripMenuItem
            // 
            this.maxRGBToolStripMenuItem.Name = "maxRGBToolStripMenuItem";
            this.maxRGBToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.maxRGBToolStripMenuItem.Text = "Max RGB";
            this.maxRGBToolStripMenuItem.Click += new System.EventHandler(this.maxRGBToolStripMenuItem_Click);
            // 
            // minRGBToolStripMenuItem
            // 
            this.minRGBToolStripMenuItem.Name = "minRGBToolStripMenuItem";
            this.minRGBToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.minRGBToolStripMenuItem.Text = "Min RGB";
            this.minRGBToolStripMenuItem.Click += new System.EventHandler(this.minRGBToolStripMenuItem_Click);
            // 
            // somethingAlseToolStripMenuItem
            // 
            this.somethingAlseToolStripMenuItem.Name = "somethingAlseToolStripMenuItem";
            this.somethingAlseToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.somethingAlseToolStripMenuItem.Text = "Something else";
            this.somethingAlseToolStripMenuItem.Click += new System.EventHandler(this.somethingAlseToolStripMenuItem_Click);
            // 
            // сепияToolStripMenuItem
            // 
            this.сепияToolStripMenuItem.Name = "сепияToolStripMenuItem";
            this.сепияToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сепияToolStripMenuItem.Text = "Сепия";
            this.сепияToolStripMenuItem.Click += new System.EventHandler(this.сепияToolStripMenuItem_Click);
            // 
            // шумоподавлениеToolStripMenuItem
            // 
            this.шумоподавлениеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.медианныйФильтрToolStripMenuItem});
            this.шумоподавлениеToolStripMenuItem.Name = "шумоподавлениеToolStripMenuItem";
            this.шумоподавлениеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.шумоподавлениеToolStripMenuItem.Text = "Шумоподавление";
            // 
            // чернобелоеToolStripMenuItem
            // 
            this.чернобелоеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.стандартToolStripMenuItem,
            this.адаптивныйФильтрToolStripMenuItem});
            this.чернобелоеToolStripMenuItem.Name = "чернобелоеToolStripMenuItem";
            this.чернобелоеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.чернобелоеToolStripMenuItem.Text = "Черно-белое";
            // 
            // стандартToolStripMenuItem
            // 
            this.стандартToolStripMenuItem.Name = "стандартToolStripMenuItem";
            this.стандартToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.стандартToolStripMenuItem.Text = "Стандарт";
            this.стандартToolStripMenuItem.Click += new System.EventHandler(this.стандартToolStripMenuItem_Click);
            // 
            // адаптивныйФильтрToolStripMenuItem
            // 
            this.адаптивныйФильтрToolStripMenuItem.Name = "адаптивныйФильтрToolStripMenuItem";
            this.адаптивныйФильтрToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.адаптивныйФильтрToolStripMenuItem.Text = "Адаптивный фильтр";
            // 
            // информацияОбИзображенииToolStripMenuItem
            // 
            this.информацияОбИзображенииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.гистограммаИзображенияToolStripMenuItem});
            this.информацияОбИзображенииToolStripMenuItem.Name = "информацияОбИзображенииToolStripMenuItem";
            this.информацияОбИзображенииToolStripMenuItem.Size = new System.Drawing.Size(188, 20);
            this.информацияОбИзображенииToolStripMenuItem.Text = "Информация об изображении";
            // 
            // гистограммаИзображенияToolStripMenuItem
            // 
            this.гистограммаИзображенияToolStripMenuItem.Name = "гистограммаИзображенияToolStripMenuItem";
            this.гистограммаИзображенияToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.гистограммаИзображенияToolStripMenuItem.Text = "Гистограмма изображения";
            this.гистограммаИзображенияToolStripMenuItem.Click += new System.EventHandler(this.гистограммаИзображенияToolStripMenuItem_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 601);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1054, 23);
            this.progressBar1.TabIndex = 5;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1072, 601);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Отмена";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1159, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Отмена";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Исходное изображение";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // медианныйФильтрToolStripMenuItem
            // 
            this.медианныйФильтрToolStripMenuItem.Name = "медианныйФильтрToolStripMenuItem";
            this.медианныйФильтрToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.медианныйФильтрToolStripMenuItem.Text = "Медианный фильтр";
            this.медианныйФильтрToolStripMenuItem.Click += new System.EventHandler(this.медианныйФильтрToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 636);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.progressBar1);
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
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem коррекцияЦветаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem инверсияToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ToolStripMenuItem размытиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem размытиеГаусаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem чернобкедлыйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сепияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem информацияОбИзображенииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem гистограммаИзображенияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem шумоподавлениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem averageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lightnessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem luminosityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem photoshopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iTURBT709ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maxRGBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minRGBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem somethingAlseToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripMenuItem чернобелоеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem стандартToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem адаптивныйФильтрToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem медианныйФильтрToolStripMenuItem;
    }
}


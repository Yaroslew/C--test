namespace Windows_Text_Search
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
            this.btn_file = new System.Windows.Forms.Button();
            this.mainBox = new System.Windows.Forms.TextBox();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.comboBoxA = new System.Windows.Forms.ComboBox();
            this.comboBoxC = new System.Windows.Forms.ComboBox();
            this.comboBoxB = new System.Windows.Forms.ComboBox();
            this.comboBoxD = new System.Windows.Forms.ComboBox();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxC = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.textBoxD = new System.Windows.Forms.TextBox();
            this.btn_apply = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_file
            // 
            this.btn_file.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_file.Location = new System.Drawing.Point(23, 12);
            this.btn_file.Name = "btn_file";
            this.btn_file.Size = new System.Drawing.Size(97, 51);
            this.btn_file.TabIndex = 0;
            this.btn_file.Text = "Файл";
            this.btn_file.UseVisualStyleBackColor = true;
            this.btn_file.Click += new System.EventHandler(this.Btn_file_Click);
            // 
            // mainBox
            // 
            this.mainBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainBox.Location = new System.Drawing.Point(23, 133);
            this.mainBox.Multiline = true;
            this.mainBox.Name = "mainBox";
            this.mainBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.mainBox.Size = new System.Drawing.Size(749, 305);
            this.mainBox.TabIndex = 1;
            this.mainBox.WordWrap = false;
            // 
            // openFile
            // 
            this.openFile.FileName = "openFile";
            // 
            // comboBoxA
            // 
            this.comboBoxA.FormattingEnabled = true;
            this.comboBoxA.Items.AddRange(new object[] {
            "(нет)",
            "И",
            "ИЛИ"});
            this.comboBoxA.Location = new System.Drawing.Point(163, 28);
            this.comboBoxA.Name = "comboBoxA";
            this.comboBoxA.Size = new System.Drawing.Size(75, 21);
            this.comboBoxA.TabIndex = 2;
            this.comboBoxA.SelectedIndex = 0;
            // 
            // comboBoxC
            // 
            this.comboBoxC.FormattingEnabled = true;
            this.comboBoxC.Items.AddRange(new object[] {
            "(нет)",
            "И",
            "ИЛИ"});
            this.comboBoxC.Location = new System.Drawing.Point(163, 89);
            this.comboBoxC.Name = "comboBoxC";
            this.comboBoxC.Size = new System.Drawing.Size(75, 21);
            this.comboBoxC.TabIndex = 3;
            this.comboBoxC.SelectedIndex = 0;
            // 
            // comboBoxB
            // 
            this.comboBoxB.FormattingEnabled = true;
            this.comboBoxB.Items.AddRange(new object[] {
            "(нет)",
            "И",
            "ИЛИ"});
            this.comboBoxB.Location = new System.Drawing.Point(481, 27);
            this.comboBoxB.Name = "comboBoxB";
            this.comboBoxB.Size = new System.Drawing.Size(77, 21);
            this.comboBoxB.TabIndex = 4;
            this.comboBoxB.SelectedIndex = 0;
            // 
            // comboBoxD
            // 
            this.comboBoxD.FormattingEnabled = true;
            this.comboBoxD.Items.AddRange(new object[] {
            "(нет)",
            "И",
            "ИЛИ"});
            this.comboBoxD.Location = new System.Drawing.Point(481, 88);
            this.comboBoxD.Name = "comboBoxD";
            this.comboBoxD.Size = new System.Drawing.Size(77, 21);
            this.comboBoxD.TabIndex = 5;
            this.comboBoxD.SelectedIndex = 0;
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(274, 28);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(166, 20);
            this.textBoxA.TabIndex = 6;
            // 
            // textBoxC
            // 
            this.textBoxC.Location = new System.Drawing.Point(274, 89);
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.Size = new System.Drawing.Size(166, 20);
            this.textBoxC.TabIndex = 7;
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(590, 27);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(182, 20);
            this.textBoxB.TabIndex = 8;
            // 
            // textBoxD
            // 
            this.textBoxD.Location = new System.Drawing.Point(590, 88);
            this.textBoxD.Name = "textBoxD";
            this.textBoxD.Size = new System.Drawing.Size(182, 20);
            this.textBoxD.TabIndex = 9;
            // 
            // btn_apply
            // 
            this.btn_apply.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_apply.Location = new System.Drawing.Point(23, 69);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(97, 58);
            this.btn_apply.TabIndex = 10;
            this.btn_apply.Text = "Применить";
            this.btn_apply.UseVisualStyleBackColor = true;
            this.btn_apply.Click += new System.EventHandler(this.Btn_apply_Click);
            // 
            // Window
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_apply);
            this.Controls.Add(this.textBoxD);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.textBoxC);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.comboBoxD);
            this.Controls.Add(this.comboBoxB);
            this.Controls.Add(this.comboBoxC);
            this.Controls.Add(this.comboBoxA);
            this.Controls.Add(this.mainBox);
            this.Controls.Add(this.btn_file);
            this.Name = "Window";
            this.Text = "Window Text Search";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Window_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Window_DragEnter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_file;
        public System.Windows.Forms.TextBox mainBox;
        internal System.Windows.Forms.OpenFileDialog openFile;
        internal System.Windows.Forms.ComboBox comboBoxA;
        internal System.Windows.Forms.ComboBox comboBoxC;
        internal System.Windows.Forms.ComboBox comboBoxB;
        internal System.Windows.Forms.ComboBox comboBoxD;
        internal System.Windows.Forms.TextBox textBoxA;
        internal System.Windows.Forms.TextBox textBoxC;
        internal System.Windows.Forms.TextBox textBoxB;
        internal System.Windows.Forms.TextBox textBoxD;
        private System.Windows.Forms.Button btn_apply;
    }
}


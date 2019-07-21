namespace Window_Title
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
            this.btnFile = new System.Windows.Forms.Button();
            this.mainTextBox = new System.Windows.Forms.TextBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxC = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.textBoxD = new System.Windows.Forms.TextBox();
            this.comboBoxA = new System.Windows.Forms.ComboBox();
            this.comboBoxB = new System.Windows.Forms.ComboBox();
            this.comboBoxC = new System.Windows.Forms.ComboBox();
            this.comboBoxD = new System.Windows.Forms.ComboBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btnFile
            // 
            this.btnFile.Location = new System.Drawing.Point(12, 12);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(98, 52);
            this.btnFile.TabIndex = 0;
            this.btnFile.Text = "Файл";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.BtnFile_Click);
            // 
            // mainTextBox
            // 
            this.mainTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainTextBox.Location = new System.Drawing.Point(12, 136);
            this.mainTextBox.Multiline = true;
            this.mainTextBox.Name = "mainTextBox";
            this.mainTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.mainTextBox.Size = new System.Drawing.Size(776, 302);
            this.mainTextBox.TabIndex = 1;
            this.mainTextBox.WordWrap = false;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(12, 79);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(98, 51);
            this.btnApply.TabIndex = 2;
            this.btnApply.Text = "Применить";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.BtnApply_Click);
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(230, 29);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(203, 20);
            this.textBoxA.TabIndex = 3;
            // 
            // textBoxC
            // 
            this.textBoxC.Location = new System.Drawing.Point(230, 95);
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.Size = new System.Drawing.Size(203, 20);
            this.textBoxC.TabIndex = 4;
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(548, 29);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(204, 20);
            this.textBoxB.TabIndex = 5;
            // 
            // textBoxD
            // 
            this.textBoxD.Location = new System.Drawing.Point(548, 95);
            this.textBoxD.Name = "textBoxD";
            this.textBoxD.Size = new System.Drawing.Size(204, 20);
            this.textBoxD.TabIndex = 6;
            // 
            // comboBoxA
            // 
            this.comboBoxA.FormattingEnabled = true;
            this.comboBoxA.Items.AddRange(new object[] {
            "И"});
            this.comboBoxA.Location = new System.Drawing.Point(149, 29);
            this.comboBoxA.Name = "comboBoxA";
            this.comboBoxA.Size = new System.Drawing.Size(75, 21);
            this.comboBoxA.TabIndex = 7;
            this.comboBoxA.SelectedIndex = 0;
            // 
            // comboBoxB
            // 
            this.comboBoxB.FormattingEnabled = true;
            this.comboBoxB.Items.AddRange(new object[] {
            "И",
            "ИЛИ"});
            this.comboBoxB.Location = new System.Drawing.Point(454, 29);
            this.comboBoxB.Name = "comboBoxB";
            this.comboBoxB.Size = new System.Drawing.Size(88, 21);
            this.comboBoxB.TabIndex = 8;
            this.comboBoxB.SelectedIndex = 0;
            // 
            // comboBoxC
            // 
            this.comboBoxC.FormattingEnabled = true;
            this.comboBoxC.Items.AddRange(new object[] {
            "И",
            "ИЛИ"});
            this.comboBoxC.Location = new System.Drawing.Point(149, 95);
            this.comboBoxC.Name = "comboBoxC";
            this.comboBoxC.Size = new System.Drawing.Size(75, 21);
            this.comboBoxC.TabIndex = 9;
            this.comboBoxC.SelectedIndex = 0;
            // 
            // comboBoxD
            // 
            this.comboBoxD.FormattingEnabled = true;
            this.comboBoxD.Items.AddRange(new object[] {
            "И",
            "ИЛИ"});
            this.comboBoxD.Location = new System.Drawing.Point(454, 95);
            this.comboBoxD.Name = "comboBoxD";
            this.comboBoxD.Size = new System.Drawing.Size(88, 21);
            this.comboBoxD.TabIndex = 10;
            this.comboBoxD.SelectedIndex = 0;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // Window
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxD);
            this.Controls.Add(this.comboBoxC);
            this.Controls.Add(this.comboBoxB);
            this.Controls.Add(this.comboBoxA);
            this.Controls.Add(this.textBoxD);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.textBoxC);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.mainTextBox);
            this.Controls.Add(this.btnFile);
            this.Name = "Window";
            this.Text = "Window Title";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Window_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Window_DragEnter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.TextBox mainTextBox;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.TextBox textBoxC;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.TextBox textBoxD;
        private System.Windows.Forms.ComboBox comboBoxA;
        private System.Windows.Forms.ComboBox comboBoxB;
        private System.Windows.Forms.ComboBox comboBoxC;
        private System.Windows.Forms.ComboBox comboBoxD;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}


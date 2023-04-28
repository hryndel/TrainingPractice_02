namespace example
{
    partial class FormMain
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
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.labelInput = new System.Windows.Forms.Label();
            this.labelOutput = new System.Windows.Forms.Label();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonDeshifr = new System.Windows.Forms.RadioButton();
            this.radioButtonShifr = new System.Windows.Forms.RadioButton();
            this.buttonImport = new System.Windows.Forms.Button();
            this.buttonExport = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonEn = new System.Windows.Forms.RadioButton();
            this.radioButtonRu = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(353, 15);
            this.textBoxInput.Multiline = true;
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInput.Size = new System.Drawing.Size(232, 140);
            this.textBoxInput.TabIndex = 0;
            this.textBoxInput.TextChanged += new System.EventHandler(this.textBoxInput_TextChanged);
            // 
            // buttonAccept
            // 
            this.buttonAccept.Enabled = false;
            this.buttonAccept.Location = new System.Drawing.Point(12, 174);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(246, 23);
            this.buttonAccept.TabIndex = 2;
            this.buttonAccept.Text = "Выполнить";
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.Location = new System.Drawing.Point(267, 15);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(80, 13);
            this.labelInput.TabIndex = 6;
            this.labelInput.Text = "Введите текст";
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Location = new System.Drawing.Point(601, 15);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(59, 13);
            this.labelOutput.TabIndex = 7;
            this.labelOutput.Text = "Результат";
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Location = new System.Drawing.Point(666, 12);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.ReadOnly = true;
            this.textBoxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutput.Size = new System.Drawing.Size(232, 140);
            this.textBoxOutput.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonDeshifr);
            this.groupBox1.Controls.Add(this.radioButtonShifr);
            this.groupBox1.Location = new System.Drawing.Point(12, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(120, 140);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выбрите действие";
            // 
            // radioButtonDeshifr
            // 
            this.radioButtonDeshifr.AutoSize = true;
            this.radioButtonDeshifr.Location = new System.Drawing.Point(6, 69);
            this.radioButtonDeshifr.Name = "radioButtonDeshifr";
            this.radioButtonDeshifr.Size = new System.Drawing.Size(104, 17);
            this.radioButtonDeshifr.TabIndex = 1;
            this.radioButtonDeshifr.TabStop = true;
            this.radioButtonDeshifr.Text = "Дешифрование";
            this.radioButtonDeshifr.UseVisualStyleBackColor = true;
            // 
            // radioButtonShifr
            // 
            this.radioButtonShifr.AutoSize = true;
            this.radioButtonShifr.Checked = true;
            this.radioButtonShifr.Location = new System.Drawing.Point(6, 30);
            this.radioButtonShifr.Name = "radioButtonShifr";
            this.radioButtonShifr.Size = new System.Drawing.Size(90, 17);
            this.radioButtonShifr.TabIndex = 0;
            this.radioButtonShifr.TabStop = true;
            this.radioButtonShifr.Text = "Шифрование";
            this.radioButtonShifr.UseVisualStyleBackColor = true;
            // 
            // buttonImport
            // 
            this.buttonImport.Location = new System.Drawing.Point(353, 174);
            this.buttonImport.Name = "buttonImport";
            this.buttonImport.Size = new System.Drawing.Size(232, 23);
            this.buttonImport.TabIndex = 10;
            this.buttonImport.Text = "Импоритровать файл";
            this.buttonImport.UseVisualStyleBackColor = true;
            this.buttonImport.Click += new System.EventHandler(this.buttonImport_Click);
            // 
            // buttonExport
            // 
            this.buttonExport.Enabled = false;
            this.buttonExport.Location = new System.Drawing.Point(666, 174);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(232, 23);
            this.buttonExport.TabIndex = 11;
            this.buttonExport.Text = "Экспортировать файл";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "txt";
            this.openFileDialog.FileName = ".txt";
            this.openFileDialog.Filter = "Text|*.txt";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "txt";
            this.saveFileDialog.FileName = "Result.txt";
            this.saveFileDialog.Filter = "Text|*.txt";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonEn);
            this.groupBox2.Controls.Add(this.radioButtonRu);
            this.groupBox2.Location = new System.Drawing.Point(138, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(120, 140);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Выбрите язык";
            // 
            // radioButtonEn
            // 
            this.radioButtonEn.AutoSize = true;
            this.radioButtonEn.Location = new System.Drawing.Point(6, 69);
            this.radioButtonEn.Name = "radioButtonEn";
            this.radioButtonEn.Size = new System.Drawing.Size(85, 17);
            this.radioButtonEn.TabIndex = 1;
            this.radioButtonEn.TabStop = true;
            this.radioButtonEn.Text = "Английский";
            this.radioButtonEn.UseVisualStyleBackColor = true;
            // 
            // radioButtonRu
            // 
            this.radioButtonRu.AutoSize = true;
            this.radioButtonRu.Checked = true;
            this.radioButtonRu.Location = new System.Drawing.Point(6, 30);
            this.radioButtonRu.Name = "radioButtonRu";
            this.radioButtonRu.Size = new System.Drawing.Size(67, 17);
            this.radioButtonRu.TabIndex = 0;
            this.radioButtonRu.TabStop = true;
            this.radioButtonRu.Text = "Русский";
            this.radioButtonRu.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 214);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonExport);
            this.Controls.Add(this.buttonImport);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.labelInput);
            this.Controls.Add(this.buttonAccept);
            this.Controls.Add(this.textBoxInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Шифрование методом Омофонов";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Button buttonAccept;
        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonDeshifr;
        private System.Windows.Forms.RadioButton radioButtonShifr;
        private System.Windows.Forms.Button buttonImport;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonEn;
        private System.Windows.Forms.RadioButton radioButtonRu;
    }
}


namespace Termo_Ural_Weight_Calculation
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
            this.richTextBoxDpipe = new System.Windows.Forms.RichTextBox();
            this.richTextBoxDout = new System.Windows.Forms.RichTextBox();
            this.richTextBoxSizePipe = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.richTextBoxM = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBoxDpipe
            // 
            this.richTextBoxDpipe.Location = new System.Drawing.Point(352, 76);
            this.richTextBoxDpipe.Name = "richTextBoxDpipe";
            this.richTextBoxDpipe.Size = new System.Drawing.Size(100, 27);
            this.richTextBoxDpipe.TabIndex = 0;
            this.richTextBoxDpipe.Text = "";
            // 
            // richTextBoxDout
            // 
            this.richTextBoxDout.Location = new System.Drawing.Point(352, 120);
            this.richTextBoxDout.Name = "richTextBoxDout";
            this.richTextBoxDout.Size = new System.Drawing.Size(100, 25);
            this.richTextBoxDout.TabIndex = 1;
            this.richTextBoxDout.Text = "";
            // 
            // richTextBoxSizePipe
            // 
            this.richTextBoxSizePipe.Location = new System.Drawing.Point(352, 166);
            this.richTextBoxSizePipe.Name = "richTextBoxSizePipe";
            this.richTextBoxSizePipe.Size = new System.Drawing.Size(100, 25);
            this.richTextBoxSizePipe.TabIndex = 2;
            this.richTextBoxSizePipe.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "РАСЧЕТ ОБЩЕГО ЗАЛИВОЧНОГО ВЕСА , кг";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "ВВЕДИТЕ ДИАМЕТР ОБОЛОЧКИ (Dout), мм";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "ВВЕДИТЕ ДИАМЕТР  ТРУБЫ (Dpipe), мм";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(232, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "ВВЕДИТЕ ДЛИНУ ОБОЛОЧКИ (SizePipe), м";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(86, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(247, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "ОБЩИЙ ЗАЛИВОЧНЫЙ ВЕС ИЗДЕЛИЯ (M), кг";
            // 
            // richTextBoxM
            // 
            this.richTextBoxM.Location = new System.Drawing.Point(352, 327);
            this.richTextBoxM.Name = "richTextBoxM";
            this.richTextBoxM.Size = new System.Drawing.Size(100, 27);
            this.richTextBoxM.TabIndex = 8;
            this.richTextBoxM.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(352, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.TabIndex = 9;
            this.button1.Text = "ENTER";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBoxM);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBoxSizePipe);
            this.Controls.Add(this.richTextBoxDout);
            this.Controls.Add(this.richTextBoxDpipe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxDpipe;
        private System.Windows.Forms.RichTextBox richTextBoxDout;
        private System.Windows.Forms.RichTextBox richTextBoxSizePipe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextBoxM;
        private System.Windows.Forms.Button button1;
    }
}


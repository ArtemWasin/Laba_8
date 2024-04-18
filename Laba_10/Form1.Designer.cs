namespace Laba_10
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
            button1 = new Button();
            areaTextBox = new TextBox();
            volumeTextBox = new TextBox();
            heightLabel = new Label();
            label2 = new Label();
            label1 = new Label();
            areaErorLable = new Label();
            valumeErorLable = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 80);
            button1.Name = "button1";
            button1.Size = new Size(90, 26);
            button1.TabIndex = 0;
            button1.Text = "Вычислить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // areaTextBox
            // 
            areaTextBox.Location = new Point(241, 43);
            areaTextBox.Name = "areaTextBox";
            areaTextBox.Size = new Size(100, 23);
            areaTextBox.TabIndex = 1;
            // 
            // volumeTextBox
            // 
            volumeTextBox.Location = new Point(167, 6);
            volumeTextBox.Name = "volumeTextBox";
            volumeTextBox.Size = new Size(100, 23);
            volumeTextBox.TabIndex = 3;
            // 
            // heightLabel
            // 
            heightLabel.AutoSize = true;
            heightLabel.Location = new Point(108, 86);
            heightLabel.Name = "heightLabel";
            heightLabel.Size = new Size(0, 15);
            heightLabel.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 46);
            label2.Name = "label2";
            label2.Size = new Size(225, 15);
            label2.TabIndex = 6;
            label2.Text = "Введите площадь основания цилиндра:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(149, 15);
            label1.TabIndex = 7;
            label1.Text = "Введите объём цилиндра:";
            // 
            // areaErorLable
            // 
            areaErorLable.AutoSize = true;
            areaErorLable.Location = new Point(347, 46);
            areaErorLable.Name = "areaErorLable";
            areaErorLable.Size = new Size(0, 15);
            areaErorLable.TabIndex = 9;
            // 
            // valumeErorLable
            // 
            valumeErorLable.AutoSize = true;
            valumeErorLable.Location = new Point(273, 9);
            valumeErorLable.Name = "valumeErorLable";
            valumeErorLable.Size = new Size(0, 15);
            valumeErorLable.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(644, 122);
            Controls.Add(valumeErorLable);
            Controls.Add(areaErorLable);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(heightLabel);
            Controls.Add(volumeTextBox);
            Controls.Add(areaTextBox);
            Controls.Add(button1);
            ForeColor = SystemColors.ControlText;
            Name = "Form1";
            Text = "Калькулятор высоты цилиндра";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox areaTextBox;
        private TextBox volumeTextBox;
        private Label heightLabel;
        private Label label2;
        private Label label1;
        private Label areaErorLable;
        private Label valumeErorLable;
    }
}

namespace Laba_10._2
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
            sr_aref_button = new Button();
            sr_geom_button = new Button();
            value1_textBox = new TextBox();
            value2_textBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            sr_aref_label = new Label();
            sr_geom_label = new Label();
            value2ErorLable = new Label();
            value1ErorLable = new Label();
            SuspendLayout();
            // 
            // sr_aref_button
            // 
            sr_aref_button.Location = new Point(9, 90);
            sr_aref_button.Name = "sr_aref_button";
            sr_aref_button.Size = new Size(96, 23);
            sr_aref_button.TabIndex = 0;
            sr_aref_button.Text = "Вычеслить СА";
            sr_aref_button.UseVisualStyleBackColor = true;
            sr_aref_button.Click += sr_aref_button_Click;
            // 
            // sr_geom_button
            // 
            sr_geom_button.Location = new Point(9, 119);
            sr_geom_button.Name = "sr_geom_button";
            sr_geom_button.Size = new Size(96, 23);
            sr_geom_button.TabIndex = 1;
            sr_geom_button.Text = "Вычеслить СГ";
            sr_geom_button.UseVisualStyleBackColor = true;
            sr_geom_button.Click += sr_geom_button_Click;
            // 
            // value1_textBox
            // 
            value1_textBox.Location = new Point(114, 6);
            value1_textBox.Name = "value1_textBox";
            value1_textBox.Size = new Size(100, 23);
            value1_textBox.TabIndex = 2;
            // 
            // value2_textBox
            // 
            value2_textBox.Location = new Point(114, 45);
            value2_textBox.Name = "value2_textBox";
            value2_textBox.Size = new Size(100, 23);
            value2_textBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 48);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 5;
            label2.Text = "Введите число 2:\r\n";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 9);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 6;
            label1.Text = "Введите число 1:\r\n";
            // 
            // sr_aref_label
            // 
            sr_aref_label.AutoSize = true;
            sr_aref_label.Location = new Point(111, 94);
            sr_aref_label.Name = "sr_aref_label";
            sr_aref_label.Size = new Size(0, 15);
            sr_aref_label.TabIndex = 7;
            // 
            // sr_geom_label
            // 
            sr_geom_label.AutoSize = true;
            sr_geom_label.Location = new Point(111, 123);
            sr_geom_label.Name = "sr_geom_label";
            sr_geom_label.Size = new Size(0, 15);
            sr_geom_label.TabIndex = 8;
            // 
            // value2ErorLable
            // 
            value2ErorLable.AutoSize = true;
            value2ErorLable.Location = new Point(220, 48);
            value2ErorLable.Name = "value2ErorLable";
            value2ErorLable.Size = new Size(0, 15);
            value2ErorLable.TabIndex = 9;
            // 
            // value1ErorLable
            // 
            value1ErorLable.AutoSize = true;
            value1ErorLable.Location = new Point(220, 9);
            value1ErorLable.Name = "value1ErorLable";
            value1ErorLable.Size = new Size(0, 15);
            value1ErorLable.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(428, 157);
            Controls.Add(value1ErorLable);
            Controls.Add(value2ErorLable);
            Controls.Add(sr_geom_label);
            Controls.Add(sr_aref_label);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(value2_textBox);
            Controls.Add(value1_textBox);
            Controls.Add(sr_geom_button);
            Controls.Add(sr_aref_button);
            Name = "Form1";
            Text = "Калькулятор";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button sr_aref_button;
        private Button sr_geom_button;
        private TextBox value1_textBox;
        private TextBox value2_textBox;
        private Label label2;
        private Label label1;
        private Label sr_aref_label;
        private Label sr_geom_label;
        private Label value2ErorLable;
        private Label value1ErorLable;
    }
}

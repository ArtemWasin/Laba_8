namespace Laba_11._2
{
    partial class AEROFLOT
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.gen_button = new System.Windows.Forms.Button();
            this.open_button = new System.Windows.Forms.Button();
            this.filtr_button = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(389, 326);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(407, 12);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(381, 326);
            this.textBox2.TabIndex = 1;
            // 
            // gen_button
            // 
            this.gen_button.Location = new System.Drawing.Point(286, 378);
            this.gen_button.Name = "gen_button";
            this.gen_button.Size = new System.Drawing.Size(75, 23);
            this.gen_button.TabIndex = 2;
            this.gen_button.Text = "Генерация";
            this.gen_button.UseVisualStyleBackColor = true;
            this.gen_button.Click += new System.EventHandler(this.gen_button_Click);
            // 
            // open_button
            // 
            this.open_button.Location = new System.Drawing.Point(398, 378);
            this.open_button.Name = "open_button";
            this.open_button.Size = new System.Drawing.Size(75, 23);
            this.open_button.TabIndex = 3;
            this.open_button.Text = "Открыть";
            this.open_button.UseVisualStyleBackColor = true;
            this.open_button.Click += new System.EventHandler(this.open_button_Click);
            // 
            // filtr_button
            // 
            this.filtr_button.Location = new System.Drawing.Point(532, 378);
            this.filtr_button.Name = "filtr_button";
            this.filtr_button.Size = new System.Drawing.Size(87, 23);
            this.filtr_button.TabIndex = 4;
            this.filtr_button.Text = "Фильтрация";
            this.filtr_button.UseVisualStyleBackColor = true;
            this.filtr_button.Click += new System.EventHandler(this.filtr_button_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(136, 378);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 378);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Тип самолёта:";
            // 
            // AEROFLOT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.filtr_button);
            this.Controls.Add(this.open_button);
            this.Controls.Add(this.gen_button);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "AEROFLOT";
            this.Text = "AEROFLOT";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button gen_button;
        private System.Windows.Forms.Button open_button;
        private System.Windows.Forms.Button filtr_button;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
    }
}


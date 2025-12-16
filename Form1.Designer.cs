namespace AdminManagerApp
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ApplicationButton = new System.Windows.Forms.Button();
            this.NoApplicationButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.InvoiceButton = new System.Windows.Forms.Button();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(327, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(729, 337);
            this.dataGridView1.TabIndex = 0;
            // 
            // ApplicationButton
            // 
            this.ApplicationButton.Location = new System.Drawing.Point(42, 27);
            this.ApplicationButton.Name = "ApplicationButton";
            this.ApplicationButton.Size = new System.Drawing.Size(136, 23);
            this.ApplicationButton.TabIndex = 1;
            this.ApplicationButton.Text = "Одобрить заявку";
            this.ApplicationButton.UseVisualStyleBackColor = true;
            this.ApplicationButton.Click += new System.EventHandler(this.ApplicationButton_Click);
            // 
            // NoApplicationButton
            // 
            this.NoApplicationButton.Location = new System.Drawing.Point(42, 56);
            this.NoApplicationButton.Name = "NoApplicationButton";
            this.NoApplicationButton.Size = new System.Drawing.Size(136, 23);
            this.NoApplicationButton.TabIndex = 2;
            this.NoApplicationButton.Text = "Отклонить заявку";
            this.NoApplicationButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(228, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Удалить информацию о госте";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(26, 276);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Удалить номер";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(26, 247);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(164, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Удалить класс номера";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // InvoiceButton
            // 
            this.InvoiceButton.Location = new System.Drawing.Point(26, 85);
            this.InvoiceButton.Name = "InvoiceButton";
            this.InvoiceButton.Size = new System.Drawing.Size(164, 23);
            this.InvoiceButton.TabIndex = 6;
            this.InvoiceButton.Text = "Выдать чек на оплату";
            this.InvoiceButton.UseVisualStyleBackColor = true;
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Location = new System.Drawing.Point(66, 114);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(87, 23);
            this.ConfirmButton.TabIndex = 7;
            this.ConfirmButton.Text = "Заселить";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(513, 383);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(87, 55);
            this.button4.TabIndex = 8;
            this.button4.Text = "Пользователь";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(327, 383);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(87, 55);
            this.button5.TabIndex = 9;
            this.button5.Text = "Проживание";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(699, 383);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(87, 55);
            this.button6.TabIndex = 10;
            this.button6.Text = "Комната";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(606, 383);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(87, 55);
            this.button7.TabIndex = 11;
            this.button7.Text = "Класс";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(420, 383);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(87, 55);
            this.button8.TabIndex = 12;
            this.button8.Text = "Оплата";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 450);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.InvoiceButton);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NoApplicationButton);
            this.Controls.Add(this.ApplicationButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Hotel Prima";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ApplicationButton;
        private System.Windows.Forms.Button NoApplicationButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button InvoiceButton;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
    }
}


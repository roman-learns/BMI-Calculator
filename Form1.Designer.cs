namespace BMI_Calculator
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
            this.heightbox = new System.Windows.Forms.TextBox();
            this.weightbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.exitbutton = new System.Windows.Forms.Button();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.bmilbl = new System.Windows.Forms.Label();
            this.bmirslt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // heightbox
            // 
            this.heightbox.Location = new System.Drawing.Point(287, 125);
            this.heightbox.Name = "heightbox";
            this.heightbox.Size = new System.Drawing.Size(143, 26);
            this.heightbox.TabIndex = 0;
            // 
            // weightbox
            // 
            this.weightbox.Location = new System.Drawing.Point(287, 208);
            this.weightbox.Name = "weightbox";
            this.weightbox.Size = new System.Drawing.Size(143, 26);
            this.weightbox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Your Height:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(481, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "cm";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(167, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Your Weight:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(481, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "kg";
            // 
            // exitbutton
            // 
            this.exitbutton.Location = new System.Drawing.Point(701, 12);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(87, 36);
            this.exitbutton.TabIndex = 6;
            this.exitbutton.Text = "Exit";
            this.exitbutton.UseVisualStyleBackColor = true;
            this.exitbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(287, 279);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(109, 29);
            this.CalculateButton.TabIndex = 7;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // bmilbl
            // 
            this.bmilbl.AutoSize = true;
            this.bmilbl.Location = new System.Drawing.Point(170, 328);
            this.bmilbl.Name = "bmilbl";
            this.bmilbl.Size = new System.Drawing.Size(95, 20);
            this.bmilbl.TabIndex = 8;
            this.bmilbl.Text = "Your BMI is:";
            // 
            // bmirslt
            // 
            this.bmirslt.AutoSize = true;
            this.bmirslt.Location = new System.Drawing.Point(412, 328);
            this.bmirslt.Name = "bmirslt";
            this.bmirslt.Size = new System.Drawing.Size(21, 20);
            this.bmirslt.TabIndex = 9;
            this.bmirslt.Text = "**";
            this.bmirslt.Click += new System.EventHandler(this.bmiresult_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bmirslt);
            this.Controls.Add(this.bmilbl);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.weightbox);
            this.Controls.Add(this.heightbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox heightbox;
        private System.Windows.Forms.TextBox weightbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button exitbutton;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Label bmilbl;
        private System.Windows.Forms.Label bmirslt;
    }
}


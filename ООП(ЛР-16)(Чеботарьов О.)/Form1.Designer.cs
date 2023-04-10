namespace ООП_ЛР_16__Чеботарьов_О._
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.lbltxt1 = new System.Windows.Forms.Label();
            this.lbltxt2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRem = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnComp = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblResultHex = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "HexNumber1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "HexNumber2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(389, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "(в 10-ій системі:)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(389, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "(в 10-ій системі:)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(201, 349);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Результат:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(204, 52);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(100, 20);
            this.txt1.TabIndex = 12;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(204, 88);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(100, 20);
            this.txt2.TabIndex = 13;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(269, 349);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(35, 13);
            this.lblResult.TabIndex = 14;
            this.lblResult.Text = "label5";
            // 
            // lbltxt1
            // 
            this.lbltxt1.AutoSize = true;
            this.lbltxt1.Location = new System.Drawing.Point(510, 55);
            this.lbltxt1.Name = "lbltxt1";
            this.lbltxt1.Size = new System.Drawing.Size(35, 13);
            this.lbltxt1.TabIndex = 15;
            this.lbltxt1.Text = "label5";
            // 
            // lbltxt2
            // 
            this.lbltxt2.AutoSize = true;
            this.lbltxt2.Location = new System.Drawing.Point(510, 91);
            this.lbltxt2.Name = "lbltxt2";
            this.lbltxt2.Size = new System.Drawing.Size(35, 13);
            this.lbltxt2.TabIndex = 16;
            this.lbltxt2.Text = "label6";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(204, 171);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(103, 68);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Додавання";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRem
            // 
            this.btnRem.Location = new System.Drawing.Point(313, 171);
            this.btnRem.Name = "btnRem";
            this.btnRem.Size = new System.Drawing.Size(71, 68);
            this.btnRem.TabIndex = 18;
            this.btnRem.Text = "Віднімання";
            this.btnRem.UseVisualStyleBackColor = true;
            this.btnRem.Click += new System.EventHandler(this.btnRem_Click);
            // 
            // btnMult
            // 
            this.btnMult.Location = new System.Drawing.Point(392, 171);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(71, 68);
            this.btnMult.TabIndex = 19;
            this.btnMult.Text = "Множення";
            this.btnMult.UseVisualStyleBackColor = true;
            this.btnMult.Click += new System.EventHandler(this.btnMult_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(469, 171);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(71, 68);
            this.btnDiv.TabIndex = 20;
            this.btnDiv.Text = "Ділення";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // btnComp
            // 
            this.btnComp.Location = new System.Drawing.Point(546, 171);
            this.btnComp.Name = "btnComp";
            this.btnComp.Size = new System.Drawing.Size(106, 68);
            this.btnComp.TabIndex = 21;
            this.btnComp.Text = "Порівняння";
            this.btnComp.UseVisualStyleBackColor = true;
            this.btnComp.Click += new System.EventHandler(this.btnComp_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(124, 373);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Результат в 16-ій системі:";
            // 
            // lblResultHex
            // 
            this.lblResultHex.AutoSize = true;
            this.lblResultHex.Location = new System.Drawing.Point(269, 373);
            this.lblResultHex.Name = "lblResultHex";
            this.lblResultHex.Size = new System.Drawing.Size(35, 13);
            this.lblResultHex.TabIndex = 23;
            this.lblResultHex.Text = "label6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResultHex);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnComp);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.btnRem);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbltxt2);
            this.Controls.Add(this.lbltxt1);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lbltxt1;
        private System.Windows.Forms.Label lbltxt2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRem;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnComp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblResultHex;
    }
}


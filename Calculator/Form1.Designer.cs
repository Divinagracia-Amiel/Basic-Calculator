
namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.btn_dot = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.neg = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.mult = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.backspace = new System.Windows.Forms.Button();
            this.ans = new System.Windows.Forms.Button();
            this.ioScreen = new System.Windows.Forms.RichTextBox();
            this.reciprocal = new System.Windows.Forms.Button();
            this.sqr_function = new System.Windows.Forms.Button();
            this.sqrt_function = new System.Windows.Forms.Button();
            this.percent = new System.Windows.Forms.Button();
            this.hist_mem = new System.Windows.Forms.TabControl();
            this.hist_page = new System.Windows.Forms.TabPage();
            this.mem_page = new System.Windows.Forms.TabPage();
            this.m_add = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.m_recall = new System.Windows.Forms.Button();
            this.m_clear = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.hist_mem.SuspendLayout();
            this.hist_page.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(7, 360);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(59, 58);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "1\r\n";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(72, 360);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(59, 58);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(137, 360);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(59, 58);
            this.btn3.TabIndex = 2;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // equal
            // 
            this.equal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equal.Location = new System.Drawing.Point(267, 360);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(59, 122);
            this.equal.TabIndex = 3;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = true;
            this.equal.Click += new System.EventHandler(this.equal_Click);
            // 
            // btn_dot
            // 
            this.btn_dot.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dot.Location = new System.Drawing.Point(7, 424);
            this.btn_dot.Name = "btn_dot";
            this.btn_dot.Size = new System.Drawing.Size(59, 58);
            this.btn_dot.TabIndex = 4;
            this.btn_dot.Text = ".";
            this.btn_dot.UseVisualStyleBackColor = true;
            this.btn_dot.Click += new System.EventHandler(this.btn_dot_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(72, 424);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(59, 58);
            this.btn0.TabIndex = 5;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(7, 296);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(59, 58);
            this.btn4.TabIndex = 6;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(72, 296);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(59, 58);
            this.btn5.TabIndex = 7;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(137, 296);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(59, 58);
            this.btn6.TabIndex = 8;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(7, 232);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(59, 58);
            this.btn7.TabIndex = 9;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(72, 232);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(59, 58);
            this.btn8.TabIndex = 10;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(137, 232);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(59, 58);
            this.btn9.TabIndex = 11;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // neg
            // 
            this.neg.Location = new System.Drawing.Point(137, 424);
            this.neg.Name = "neg";
            this.neg.Size = new System.Drawing.Size(59, 58);
            this.neg.TabIndex = 12;
            this.neg.Text = "neg";
            this.neg.UseVisualStyleBackColor = true;
            this.neg.Click += new System.EventHandler(this.neg_Click);
            // 
            // plus
            // 
            this.plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plus.Location = new System.Drawing.Point(202, 296);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(59, 58);
            this.plus.TabIndex = 13;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // minus
            // 
            this.minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minus.Location = new System.Drawing.Point(202, 360);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(59, 58);
            this.minus.TabIndex = 14;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // mult
            // 
            this.mult.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mult.Location = new System.Drawing.Point(202, 232);
            this.mult.Name = "mult";
            this.mult.Size = new System.Drawing.Size(59, 58);
            this.mult.TabIndex = 15;
            this.mult.Text = "×";
            this.mult.UseVisualStyleBackColor = true;
            this.mult.Click += new System.EventHandler(this.mult_Click);
            // 
            // div
            // 
            this.div.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.div.Location = new System.Drawing.Point(202, 424);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(59, 58);
            this.div.TabIndex = 16;
            this.div.Text = "÷";
            this.div.UseVisualStyleBackColor = true;
            this.div.Click += new System.EventHandler(this.div_Click);
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(267, 234);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(59, 58);
            this.clear.TabIndex = 17;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // backspace
            // 
            this.backspace.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backspace.Location = new System.Drawing.Point(267, 168);
            this.backspace.Name = "backspace";
            this.backspace.Size = new System.Drawing.Size(59, 58);
            this.backspace.TabIndex = 18;
            this.backspace.Text = "⌫";
            this.backspace.UseVisualStyleBackColor = true;
            this.backspace.Click += new System.EventHandler(this.backspace_Click);
            // 
            // ans
            // 
            this.ans.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ans.Location = new System.Drawing.Point(267, 296);
            this.ans.Name = "ans";
            this.ans.Size = new System.Drawing.Size(59, 58);
            this.ans.TabIndex = 19;
            this.ans.Text = "ans";
            this.ans.UseVisualStyleBackColor = true;
            this.ans.Click += new System.EventHandler(this.ans_Click);
            // 
            // ioScreen
            // 
            this.ioScreen.Location = new System.Drawing.Point(8, 12);
            this.ioScreen.Name = "ioScreen";
            this.ioScreen.Size = new System.Drawing.Size(319, 86);
            this.ioScreen.TabIndex = 23;
            this.ioScreen.Text = "";
            this.ioScreen.TextChanged += new System.EventHandler(this.ioScreen_TextChanged);
            // 
            // reciprocal
            // 
            this.reciprocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reciprocal.Location = new System.Drawing.Point(7, 168);
            this.reciprocal.Name = "reciprocal";
            this.reciprocal.Size = new System.Drawing.Size(59, 58);
            this.reciprocal.TabIndex = 24;
            this.reciprocal.Text = "1/x";
            this.reciprocal.UseVisualStyleBackColor = true;
            // 
            // sqr_function
            // 
            this.sqr_function.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sqr_function.Location = new System.Drawing.Point(72, 168);
            this.sqr_function.Name = "sqr_function";
            this.sqr_function.Size = new System.Drawing.Size(59, 58);
            this.sqr_function.TabIndex = 25;
            this.sqr_function.Text = "x²";
            this.sqr_function.UseVisualStyleBackColor = true;
            this.sqr_function.Click += new System.EventHandler(this.sqr_function_Click);
            // 
            // sqrt_function
            // 
            this.sqrt_function.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sqrt_function.Location = new System.Drawing.Point(202, 168);
            this.sqrt_function.Name = "sqrt_function";
            this.sqrt_function.Size = new System.Drawing.Size(59, 58);
            this.sqrt_function.TabIndex = 26;
            this.sqrt_function.Text = "√x";
            this.sqrt_function.UseVisualStyleBackColor = true;
            // 
            // percent
            // 
            this.percent.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percent.Location = new System.Drawing.Point(137, 168);
            this.percent.Name = "percent";
            this.percent.Size = new System.Drawing.Size(59, 58);
            this.percent.TabIndex = 27;
            this.percent.Text = "%";
            this.percent.UseVisualStyleBackColor = true;
            // 
            // hist_mem
            // 
            this.hist_mem.Controls.Add(this.hist_page);
            this.hist_mem.Controls.Add(this.mem_page);
            this.hist_mem.Location = new System.Drawing.Point(333, 12);
            this.hist_mem.Name = "hist_mem";
            this.hist_mem.SelectedIndex = 0;
            this.hist_mem.Size = new System.Drawing.Size(223, 470);
            this.hist_mem.TabIndex = 28;
            // 
            // hist_page
            // 
            this.hist_page.Controls.Add(this.listBox1);
            this.hist_page.Location = new System.Drawing.Point(4, 22);
            this.hist_page.Name = "hist_page";
            this.hist_page.Padding = new System.Windows.Forms.Padding(3);
            this.hist_page.Size = new System.Drawing.Size(215, 444);
            this.hist_page.TabIndex = 0;
            this.hist_page.Text = "History";
            this.hist_page.UseVisualStyleBackColor = true;
            // 
            // mem_page
            // 
            this.mem_page.Location = new System.Drawing.Point(4, 22);
            this.mem_page.Name = "mem_page";
            this.mem_page.Padding = new System.Windows.Forms.Padding(3);
            this.mem_page.Size = new System.Drawing.Size(215, 444);
            this.mem_page.TabIndex = 1;
            this.mem_page.Text = "Memory";
            this.mem_page.UseVisualStyleBackColor = true;
            // 
            // m_add
            // 
            this.m_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_add.Location = new System.Drawing.Point(137, 104);
            this.m_add.Name = "m_add";
            this.m_add.Size = new System.Drawing.Size(59, 58);
            this.m_add.TabIndex = 33;
            this.m_add.Text = "M+";
            this.m_add.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(202, 104);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(59, 58);
            this.button2.TabIndex = 32;
            this.button2.Text = "M-";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // m_recall
            // 
            this.m_recall.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_recall.Location = new System.Drawing.Point(72, 104);
            this.m_recall.Name = "m_recall";
            this.m_recall.Size = new System.Drawing.Size(59, 58);
            this.m_recall.TabIndex = 31;
            this.m_recall.Text = "MR";
            this.m_recall.UseVisualStyleBackColor = true;
            // 
            // m_clear
            // 
            this.m_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_clear.Location = new System.Drawing.Point(7, 104);
            this.m_clear.Name = "m_clear";
            this.m_clear.Size = new System.Drawing.Size(59, 58);
            this.m_clear.TabIndex = 30;
            this.m_clear.Text = "MC";
            this.m_clear.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(267, 104);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(59, 58);
            this.button5.TabIndex = 29;
            this.button5.Text = "MS";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(215, 446);
            this.listBox1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 491);
            this.Controls.Add(this.m_add);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.m_recall);
            this.Controls.Add(this.m_clear);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.hist_mem);
            this.Controls.Add(this.percent);
            this.Controls.Add(this.sqrt_function);
            this.Controls.Add(this.sqr_function);
            this.Controls.Add(this.reciprocal);
            this.Controls.Add(this.ioScreen);
            this.Controls.Add(this.ans);
            this.Controls.Add(this.backspace);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.div);
            this.Controls.Add(this.mult);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.neg);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn_dot);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.hist_mem.ResumeLayout(false);
            this.hist_page.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.Button btn_dot;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button neg;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button mult;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button backspace;
        private System.Windows.Forms.Button ans;
        private System.Windows.Forms.RichTextBox ioScreen;
        private System.Windows.Forms.Button reciprocal;
        private System.Windows.Forms.Button sqr_function;
        private System.Windows.Forms.Button sqrt_function;
        private System.Windows.Forms.Button percent;
        private System.Windows.Forms.TabControl hist_mem;
        private System.Windows.Forms.TabPage hist_page;
        private System.Windows.Forms.TabPage mem_page;
        private System.Windows.Forms.Button m_add;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button m_recall;
        private System.Windows.Forms.Button m_clear;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ListBox listBox1;
    }
}


namespace GradeSummary
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
            this.tabControlMainPage = new System.Windows.Forms.TabControl();
            this.MainPage = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonSummary = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textEntry = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SummaryPage = new System.Windows.Forms.TabPage();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxLowestMark = new System.Windows.Forms.TextBox();
            this.textBoxHighestMark = new System.Windows.Forms.TextBox();
            this.textBoxAverageMark = new System.Windows.Forms.TextBox();
            this.textBoxTotalMarks = new System.Windows.Forms.TextBox();
            this.buttonMainPage = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNumberOfMarks = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.tabControlMainPage.SuspendLayout();
            this.MainPage.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SummaryPage.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMainPage
            // 
            this.tabControlMainPage.Controls.Add(this.MainPage);
            this.tabControlMainPage.Controls.Add(this.SummaryPage);
            this.tabControlMainPage.Location = new System.Drawing.Point(0, 3);
            this.tabControlMainPage.Name = "tabControlMainPage";
            this.tabControlMainPage.SelectedIndex = 0;
            this.tabControlMainPage.Size = new System.Drawing.Size(338, 531);
            this.tabControlMainPage.TabIndex = 0;
            // 
            // MainPage
            // 
            this.MainPage.BackColor = System.Drawing.Color.Black;
            this.MainPage.Controls.Add(this.textBox1);
            this.MainPage.Controls.Add(this.panel1);
            this.MainPage.Location = new System.Drawing.Point(4, 22);
            this.MainPage.Name = "MainPage";
            this.MainPage.Padding = new System.Windows.Forms.Padding(3);
            this.MainPage.Size = new System.Drawing.Size(330, 505);
            this.MainPage.TabIndex = 0;
            this.MainPage.Text = "Main Page";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(27, -1);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(237, 17);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Grade Summary App";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.buttonQuit);
            this.panel1.Controls.Add(this.buttonClear);
            this.panel1.Controls.Add(this.buttonSummary);
            this.panel1.Controls.Add(this.buttonAdd);
            this.panel1.Controls.Add(this.textEntry);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Location = new System.Drawing.Point(27, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(276, 483);
            this.panel1.TabIndex = 2;
            // 
            // buttonQuit
            // 
            this.buttonQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuit.Location = new System.Drawing.Point(123, 411);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(129, 29);
            this.buttonQuit.TabIndex = 7;
            this.buttonQuit.Text = "Quit";
            this.buttonQuit.UseVisualStyleBackColor = true;
            this.buttonQuit.Click += new System.EventHandler(this.buttonQuit_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(123, 307);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(129, 29);
            this.buttonClear.TabIndex = 6;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonSummary
            // 
            this.buttonSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSummary.Location = new System.Drawing.Point(123, 208);
            this.buttonSummary.Name = "buttonSummary";
            this.buttonSummary.Size = new System.Drawing.Size(129, 29);
            this.buttonSummary.TabIndex = 5;
            this.buttonSummary.Text = "Show Summary";
            this.buttonSummary.UseVisualStyleBackColor = true;
            this.buttonSummary.Click += new System.EventHandler(this.buttonSummary_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(163, 92);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(89, 29);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textEntry
            // 
            this.textEntry.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEntry.Location = new System.Drawing.Point(11, 93);
            this.textEntry.Name = "textEntry";
            this.textEntry.Size = new System.Drawing.Size(100, 26);
            this.textEntry.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox2.Location = new System.Drawing.Point(0, 14);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(276, 40);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "Enter Grades";
            // 
            // SummaryPage
            // 
            this.SummaryPage.BackColor = System.Drawing.Color.Black;
            this.SummaryPage.Controls.Add(this.textBox3);
            this.SummaryPage.Controls.Add(this.panel2);
            this.SummaryPage.Location = new System.Drawing.Point(4, 22);
            this.SummaryPage.Name = "SummaryPage";
            this.SummaryPage.Padding = new System.Windows.Forms.Padding(3);
            this.SummaryPage.Size = new System.Drawing.Size(330, 505);
            this.SummaryPage.TabIndex = 1;
            this.SummaryPage.Text = "Summary Page";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox3.Location = new System.Drawing.Point(27, -1);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(237, 17);
            this.textBox3.TabIndex = 3;
            this.textBox3.Text = "Grade Summary App";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Controls.Add(this.textBoxLowestMark);
            this.panel2.Controls.Add(this.textBoxHighestMark);
            this.panel2.Controls.Add(this.textBoxAverageMark);
            this.panel2.Controls.Add(this.textBoxTotalMarks);
            this.panel2.Controls.Add(this.buttonMainPage);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBoxNumberOfMarks);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.textBox5);
            this.panel2.Location = new System.Drawing.Point(27, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(276, 483);
            this.panel2.TabIndex = 2;
            // 
            // textBoxLowestMark
            // 
            this.textBoxLowestMark.BackColor = System.Drawing.Color.RoyalBlue;
            this.textBoxLowestMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLowestMark.Location = new System.Drawing.Point(153, 318);
            this.textBoxLowestMark.Name = "textBoxLowestMark";
            this.textBoxLowestMark.ReadOnly = true;
            this.textBoxLowestMark.Size = new System.Drawing.Size(100, 26);
            this.textBoxLowestMark.TabIndex = 13;
            // 
            // textBoxHighestMark
            // 
            this.textBoxHighestMark.BackColor = System.Drawing.Color.RoyalBlue;
            this.textBoxHighestMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHighestMark.Location = new System.Drawing.Point(153, 259);
            this.textBoxHighestMark.Name = "textBoxHighestMark";
            this.textBoxHighestMark.ReadOnly = true;
            this.textBoxHighestMark.Size = new System.Drawing.Size(100, 26);
            this.textBoxHighestMark.TabIndex = 12;

            // 
            // textBoxAverageMark
            // 
            this.textBoxAverageMark.BackColor = System.Drawing.Color.RoyalBlue;
            this.textBoxAverageMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAverageMark.Location = new System.Drawing.Point(153, 198);
            this.textBoxAverageMark.Name = "textBoxAverageMark";
            this.textBoxAverageMark.ReadOnly = true;
            this.textBoxAverageMark.Size = new System.Drawing.Size(100, 26);
            this.textBoxAverageMark.TabIndex = 11;
            // 
            // textBoxTotalMarks
            // 
            this.textBoxTotalMarks.BackColor = System.Drawing.Color.RoyalBlue;
            this.textBoxTotalMarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotalMarks.Location = new System.Drawing.Point(153, 133);
            this.textBoxTotalMarks.Name = "textBoxTotalMarks";
            this.textBoxTotalMarks.ReadOnly = true;
            this.textBoxTotalMarks.Size = new System.Drawing.Size(100, 26);
            this.textBoxTotalMarks.TabIndex = 10;
            // 
            // buttonMainPage
            // 
            this.buttonMainPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMainPage.Location = new System.Drawing.Point(74, 398);
            this.buttonMainPage.Name = "buttonMainPage";
            this.buttonMainPage.Size = new System.Drawing.Size(129, 29);
            this.buttonMainPage.TabIndex = 9;
            this.buttonMainPage.Text = "Main Page";
            this.buttonMainPage.UseVisualStyleBackColor = true;
            this.buttonMainPage.Click += new System.EventHandler(this.buttonMainPage_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(10, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Lowest";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(10, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Highest";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(10, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Average Mark";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(10, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Total Marks";
            // 
            // textBoxNumberOfMarks
            // 
            this.textBoxNumberOfMarks.BackColor = System.Drawing.Color.RoyalBlue;
            this.textBoxNumberOfMarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNumberOfMarks.ForeColor = System.Drawing.Color.Lavender;
            this.textBoxNumberOfMarks.Location = new System.Drawing.Point(153, 76);
            this.textBoxNumberOfMarks.Name = "textBoxNumberOfMarks";
            this.textBoxNumberOfMarks.ReadOnly = true;
            this.textBoxNumberOfMarks.Size = new System.Drawing.Size(100, 26);
            this.textBoxNumberOfMarks.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(10, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Number Marks";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox5.Location = new System.Drawing.Point(0, 14);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(276, 40);
            this.textBox5.TabIndex = 2;
            this.textBox5.Text = "Summary";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(357, 538);
            this.Controls.Add(this.tabControlMainPage);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControlMainPage.ResumeLayout(false);
            this.MainPage.ResumeLayout(false);
            this.MainPage.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.SummaryPage.ResumeLayout(false);
            this.SummaryPage.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMainPage;
        private System.Windows.Forms.TabPage MainPage;
        private System.Windows.Forms.TabPage SummaryPage;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonSummary;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textEntry;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button buttonQuit;
        private System.Windows.Forms.TextBox textBoxNumberOfMarks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonMainPage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTotalMarks;
        private System.Windows.Forms.TextBox textBoxLowestMark;
        private System.Windows.Forms.TextBox textBoxHighestMark;
        private System.Windows.Forms.TextBox textBoxAverageMark;
    }
}


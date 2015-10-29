namespace _8Ball_Anwendung
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
            this.hit = new System.Windows.Forms.Button();
            this.elmBalls = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.touchedBalls = new System.Windows.Forms.TextBox();
            this.lb_ansage = new System.Windows.Forms.Label();
            this.cb_ansage = new System.Windows.Forms.ComboBox();
            this.lb_count = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_Ausgabe = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // hit
            // 
            this.hit.Location = new System.Drawing.Point(355, 254);
            this.hit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hit.Name = "hit";
            this.hit.Size = new System.Drawing.Size(132, 38);
            this.hit.TabIndex = 0;
            this.hit.Text = "Stoß";
            this.hit.UseVisualStyleBackColor = true;
            this.hit.Click += new System.EventHandler(this.hit_Click);
            // 
            // elmBalls
            // 
            this.elmBalls.Location = new System.Drawing.Point(353, 105);
            this.elmBalls.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.elmBalls.Name = "elmBalls";
            this.elmBalls.Size = new System.Drawing.Size(132, 22);
            this.elmBalls.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 108);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Versenkte Bälle:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Anzahl der Bälle die die Bande berührt haben:";
            // 
            // touchedBalls
            // 
            this.touchedBalls.Location = new System.Drawing.Point(353, 41);
            this.touchedBalls.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.touchedBalls.Name = "touchedBalls";
            this.touchedBalls.Size = new System.Drawing.Size(132, 22);
            this.touchedBalls.TabIndex = 6;
            // 
            // lb_ansage
            // 
            this.lb_ansage.AutoSize = true;
            this.lb_ansage.Location = new System.Drawing.Point(56, 182);
            this.lb_ansage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_ansage.Name = "lb_ansage";
            this.lb_ansage.Size = new System.Drawing.Size(60, 17);
            this.lb_ansage.TabIndex = 7;
            this.lb_ansage.Text = "Ansage:";
            this.lb_ansage.Visible = false;
            // 
            // cb_ansage
            // 
            this.cb_ansage.FormattingEnabled = true;
            this.cb_ansage.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.cb_ansage.Location = new System.Drawing.Point(353, 171);
            this.cb_ansage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_ansage.Name = "cb_ansage";
            this.cb_ansage.Size = new System.Drawing.Size(132, 24);
            this.cb_ansage.TabIndex = 8;
            this.cb_ansage.Visible = false;
            // 
            // lb_count
            // 
            this.lb_count.AutoSize = true;
            this.lb_count.Location = new System.Drawing.Point(149, 254);
            this.lb_count.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_count.Name = "lb_count";
            this.lb_count.Size = new System.Drawing.Size(16, 17);
            this.lb_count.TabIndex = 10;
            this.lb_count.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 254);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Spielzüge:";
            // 
            // tb_Ausgabe
            // 
            this.tb_Ausgabe.Location = new System.Drawing.Point(56, 337);
            this.tb_Ausgabe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_Ausgabe.Multiline = true;
            this.tb_Ausgabe.Name = "tb_Ausgabe";
            this.tb_Ausgabe.ReadOnly = true;
            this.tb_Ausgabe.Size = new System.Drawing.Size(429, 195);
            this.tb_Ausgabe.TabIndex = 12;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(140, 539);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(106, 21);
            this.radioButton1.TabIndex = 13;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "1. Bibliothek";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(274, 539);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(106, 21);
            this.radioButton2.TabIndex = 14;
            this.radioButton2.Text = "2. Bibliothek";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 571);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.tb_Ausgabe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_count);
            this.Controls.Add(this.cb_ansage);
            this.Controls.Add(this.lb_ansage);
            this.Controls.Add(this.touchedBalls);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.elmBalls);
            this.Controls.Add(this.hit);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "8 Ball";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button hit;
        private System.Windows.Forms.TextBox elmBalls;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox touchedBalls;
        private System.Windows.Forms.Label lb_ansage;
        private System.Windows.Forms.ComboBox cb_ansage;
        private System.Windows.Forms.Label lb_count;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_Ausgabe;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}


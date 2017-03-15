namespace Kalkulator
{
    partial class Kalkulator
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
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.buttDot = new System.Windows.Forms.Button();
            this.butt0 = new System.Windows.Forms.Button();
            this.buttCalc = new System.Windows.Forms.Button();
            this.butt1 = new System.Windows.Forms.Button();
            this.butt2 = new System.Windows.Forms.Button();
            this.butt3 = new System.Windows.Forms.Button();
            this.butt4 = new System.Windows.Forms.Button();
            this.butt5 = new System.Windows.Forms.Button();
            this.butt6 = new System.Windows.Forms.Button();
            this.butt7 = new System.Windows.Forms.Button();
            this.butt8 = new System.Windows.Forms.Button();
            this.butt9 = new System.Windows.Forms.Button();
            this.buttC = new System.Windows.Forms.Button();
            this.buttMR = new System.Windows.Forms.Button();
            this.buttSign = new System.Windows.Forms.Button();
            this.buttM = new System.Windows.Forms.Button();
            this.buttMinus = new System.Windows.Forms.Button();
            this.buttPlus = new System.Windows.Forms.Button();
            this.buttDivide = new System.Windows.Forms.Button();
            this.buttMult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDisplay
            // 
            this.txtDisplay.BackColor = System.Drawing.Color.Black;
            this.txtDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDisplay.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtDisplay.ForeColor = System.Drawing.Color.Lime;
            this.txtDisplay.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtDisplay.Location = new System.Drawing.Point(12, 12);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.ReadOnly = true;
            this.txtDisplay.Size = new System.Drawing.Size(260, 22);
            this.txtDisplay.TabIndex = 0;
            this.txtDisplay.Text = "0";
            this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDisplay.WordWrap = false;
            // 
            // buttDot
            // 
            this.buttDot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttDot.ForeColor = System.Drawing.Color.White;
            this.buttDot.Location = new System.Drawing.Point(12, 209);
            this.buttDot.Name = "buttDot";
            this.buttDot.Size = new System.Drawing.Size(35, 35);
            this.buttDot.TabIndex = 1;
            this.buttDot.Text = ".";
            this.buttDot.UseVisualStyleBackColor = false;
            this.buttDot.Click += new System.EventHandler(this.buttDot_Click);
            // 
            // butt0
            // 
            this.butt0.BackColor = System.Drawing.Color.Black;
            this.butt0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.butt0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.butt0.Location = new System.Drawing.Point(62, 209);
            this.butt0.Name = "butt0";
            this.butt0.Size = new System.Drawing.Size(35, 35);
            this.butt0.TabIndex = 2;
            this.butt0.Text = "0";
            this.butt0.UseVisualStyleBackColor = false;
            this.butt0.Click += new System.EventHandler(this.buttNum_Click);
            // 
            // buttCalc
            // 
            this.buttCalc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttCalc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttCalc.Location = new System.Drawing.Point(112, 209);
            this.buttCalc.Name = "buttCalc";
            this.buttCalc.Size = new System.Drawing.Size(35, 35);
            this.buttCalc.TabIndex = 3;
            this.buttCalc.Text = "=";
            this.buttCalc.UseVisualStyleBackColor = false;
            this.buttCalc.Click += new System.EventHandler(this.buttCalc_Click);
            // 
            // butt1
            // 
            this.butt1.BackColor = System.Drawing.Color.Black;
            this.butt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.butt1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.butt1.Location = new System.Drawing.Point(12, 159);
            this.butt1.Name = "butt1";
            this.butt1.Size = new System.Drawing.Size(35, 35);
            this.butt1.TabIndex = 4;
            this.butt1.Text = "1";
            this.butt1.UseVisualStyleBackColor = false;
            this.butt1.Click += new System.EventHandler(this.buttNum_Click);
            // 
            // butt2
            // 
            this.butt2.BackColor = System.Drawing.Color.Black;
            this.butt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.butt2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.butt2.Location = new System.Drawing.Point(62, 159);
            this.butt2.Name = "butt2";
            this.butt2.Size = new System.Drawing.Size(35, 35);
            this.butt2.TabIndex = 5;
            this.butt2.Text = "2";
            this.butt2.UseVisualStyleBackColor = false;
            this.butt2.Click += new System.EventHandler(this.buttNum_Click);
            // 
            // butt3
            // 
            this.butt3.BackColor = System.Drawing.Color.Black;
            this.butt3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.butt3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.butt3.Location = new System.Drawing.Point(112, 159);
            this.butt3.Name = "butt3";
            this.butt3.Size = new System.Drawing.Size(35, 35);
            this.butt3.TabIndex = 6;
            this.butt3.Text = "3";
            this.butt3.UseVisualStyleBackColor = false;
            this.butt3.Click += new System.EventHandler(this.buttNum_Click);
            // 
            // butt4
            // 
            this.butt4.BackColor = System.Drawing.Color.Black;
            this.butt4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.butt4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.butt4.Location = new System.Drawing.Point(12, 108);
            this.butt4.Name = "butt4";
            this.butt4.Size = new System.Drawing.Size(35, 35);
            this.butt4.TabIndex = 7;
            this.butt4.Text = "4";
            this.butt4.UseVisualStyleBackColor = false;
            this.butt4.Click += new System.EventHandler(this.buttNum_Click);
            // 
            // butt5
            // 
            this.butt5.BackColor = System.Drawing.Color.Black;
            this.butt5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.butt5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.butt5.Location = new System.Drawing.Point(62, 108);
            this.butt5.Name = "butt5";
            this.butt5.Size = new System.Drawing.Size(35, 35);
            this.butt5.TabIndex = 8;
            this.butt5.Text = "5";
            this.butt5.UseVisualStyleBackColor = false;
            this.butt5.Click += new System.EventHandler(this.buttNum_Click);
            // 
            // butt6
            // 
            this.butt6.BackColor = System.Drawing.Color.Black;
            this.butt6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.butt6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.butt6.Location = new System.Drawing.Point(112, 108);
            this.butt6.Name = "butt6";
            this.butt6.Size = new System.Drawing.Size(35, 35);
            this.butt6.TabIndex = 9;
            this.butt6.Text = "6";
            this.butt6.UseVisualStyleBackColor = false;
            this.butt6.Click += new System.EventHandler(this.buttNum_Click);
            // 
            // butt7
            // 
            this.butt7.BackColor = System.Drawing.Color.Black;
            this.butt7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.butt7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.butt7.Location = new System.Drawing.Point(12, 57);
            this.butt7.Name = "butt7";
            this.butt7.Size = new System.Drawing.Size(35, 35);
            this.butt7.TabIndex = 10;
            this.butt7.Text = "7";
            this.butt7.UseVisualStyleBackColor = false;
            this.butt7.Click += new System.EventHandler(this.buttNum_Click);
            // 
            // butt8
            // 
            this.butt8.BackColor = System.Drawing.Color.Black;
            this.butt8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.butt8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.butt8.Location = new System.Drawing.Point(62, 57);
            this.butt8.Name = "butt8";
            this.butt8.Size = new System.Drawing.Size(35, 35);
            this.butt8.TabIndex = 11;
            this.butt8.Text = "8";
            this.butt8.UseVisualStyleBackColor = false;
            this.butt8.Click += new System.EventHandler(this.buttNum_Click);
            // 
            // butt9
            // 
            this.butt9.BackColor = System.Drawing.Color.Black;
            this.butt9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.butt9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.butt9.Location = new System.Drawing.Point(112, 57);
            this.butt9.Name = "butt9";
            this.butt9.Size = new System.Drawing.Size(35, 35);
            this.butt9.TabIndex = 12;
            this.butt9.Text = "9";
            this.butt9.UseVisualStyleBackColor = false;
            this.butt9.Click += new System.EventHandler(this.buttNum_Click);
            // 
            // buttC
            // 
            this.buttC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttC.Location = new System.Drawing.Point(225, 57);
            this.buttC.Name = "buttC";
            this.buttC.Size = new System.Drawing.Size(35, 35);
            this.buttC.TabIndex = 20;
            this.buttC.Text = "C";
            this.buttC.UseVisualStyleBackColor = false;
            this.buttC.Click += new System.EventHandler(this.buttC_Click);
            // 
            // buttMR
            // 
            this.buttMR.BackColor = System.Drawing.Color.Green;
            this.buttMR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttMR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttMR.Location = new System.Drawing.Point(175, 57);
            this.buttMR.Name = "buttMR";
            this.buttMR.Size = new System.Drawing.Size(35, 35);
            this.buttMR.TabIndex = 19;
            this.buttMR.Text = "MR";
            this.buttMR.UseVisualStyleBackColor = false;
            this.buttMR.Click += new System.EventHandler(this.buttMR_Click);
            // 
            // buttSign
            // 
            this.buttSign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttSign.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttSign.Location = new System.Drawing.Point(225, 108);
            this.buttSign.Name = "buttSign";
            this.buttSign.Size = new System.Drawing.Size(35, 35);
            this.buttSign.TabIndex = 18;
            this.buttSign.Text = "+/-";
            this.buttSign.UseVisualStyleBackColor = false;
            this.buttSign.Click += new System.EventHandler(this.buttSign_Click);
            // 
            // buttM
            // 
            this.buttM.BackColor = System.Drawing.Color.Green;
            this.buttM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttM.Location = new System.Drawing.Point(175, 108);
            this.buttM.Name = "buttM";
            this.buttM.Size = new System.Drawing.Size(35, 35);
            this.buttM.TabIndex = 17;
            this.buttM.Text = "M";
            this.buttM.UseVisualStyleBackColor = false;
            this.buttM.Click += new System.EventHandler(this.buttM_Click);
            // 
            // buttMinus
            // 
            this.buttMinus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttMinus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttMinus.Location = new System.Drawing.Point(225, 159);
            this.buttMinus.Name = "buttMinus";
            this.buttMinus.Size = new System.Drawing.Size(35, 35);
            this.buttMinus.TabIndex = 16;
            this.buttMinus.Text = "-";
            this.buttMinus.UseVisualStyleBackColor = false;
            this.buttMinus.Click += new System.EventHandler(this.buttMinus_Click);
            // 
            // buttPlus
            // 
            this.buttPlus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttPlus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttPlus.Location = new System.Drawing.Point(175, 159);
            this.buttPlus.Name = "buttPlus";
            this.buttPlus.Size = new System.Drawing.Size(35, 35);
            this.buttPlus.TabIndex = 15;
            this.buttPlus.Text = "+";
            this.buttPlus.UseVisualStyleBackColor = false;
            this.buttPlus.Click += new System.EventHandler(this.buttPlus_Click);
            // 
            // buttDivide
            // 
            this.buttDivide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttDivide.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttDivide.Location = new System.Drawing.Point(225, 209);
            this.buttDivide.Name = "buttDivide";
            this.buttDivide.Size = new System.Drawing.Size(35, 35);
            this.buttDivide.TabIndex = 14;
            this.buttDivide.Text = "/";
            this.buttDivide.UseVisualStyleBackColor = false;
            this.buttDivide.Click += new System.EventHandler(this.buttDivide_Click);
            // 
            // buttMult
            // 
            this.buttMult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttMult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttMult.Location = new System.Drawing.Point(175, 209);
            this.buttMult.Name = "buttMult";
            this.buttMult.Size = new System.Drawing.Size(35, 35);
            this.buttMult.TabIndex = 13;
            this.buttMult.Text = "x";
            this.buttMult.UseVisualStyleBackColor = false;
            this.buttMult.Click += new System.EventHandler(this.buttMult_Click);
            // 
            // Kalkulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.buttC);
            this.Controls.Add(this.buttMR);
            this.Controls.Add(this.buttSign);
            this.Controls.Add(this.buttM);
            this.Controls.Add(this.buttMinus);
            this.Controls.Add(this.buttPlus);
            this.Controls.Add(this.buttDivide);
            this.Controls.Add(this.buttMult);
            this.Controls.Add(this.butt9);
            this.Controls.Add(this.butt8);
            this.Controls.Add(this.butt7);
            this.Controls.Add(this.butt6);
            this.Controls.Add(this.butt5);
            this.Controls.Add(this.butt4);
            this.Controls.Add(this.butt3);
            this.Controls.Add(this.butt2);
            this.Controls.Add(this.butt1);
            this.Controls.Add(this.buttCalc);
            this.Controls.Add(this.butt0);
            this.Controls.Add(this.buttDot);
            this.Controls.Add(this.txtDisplay);
            this.Name = "Kalkulator";
            this.Text = "Kalkulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Button buttDot;
        private System.Windows.Forms.Button butt0;
        private System.Windows.Forms.Button buttCalc;
        private System.Windows.Forms.Button butt1;
        private System.Windows.Forms.Button butt2;
        private System.Windows.Forms.Button butt3;
        private System.Windows.Forms.Button butt4;
        private System.Windows.Forms.Button butt5;
        private System.Windows.Forms.Button butt6;
        private System.Windows.Forms.Button butt7;
        private System.Windows.Forms.Button butt8;
        private System.Windows.Forms.Button butt9;
        private System.Windows.Forms.Button buttC;
        private System.Windows.Forms.Button buttMR;
        private System.Windows.Forms.Button buttSign;
        private System.Windows.Forms.Button buttM;
        private System.Windows.Forms.Button buttMinus;
        private System.Windows.Forms.Button buttPlus;
        private System.Windows.Forms.Button buttDivide;
        private System.Windows.Forms.Button buttMult;
    }
}
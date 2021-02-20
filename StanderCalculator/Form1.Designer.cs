
namespace StanderCalculator
{
    partial class homepage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(homepage));
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Number1 = new System.Windows.Forms.Label();
            this.txt_Number1 = new System.Windows.Forms.TextBox();
            this.txt_Number2 = new System.Windows.Forms.TextBox();
            this.lbl_Number2 = new System.Windows.Forms.Label();
            this.bttn_Clear = new System.Windows.Forms.Button();
            this.bttn_Add = new System.Windows.Forms.Button();
            this.bttn_Sub = new System.Windows.Forms.Button();
            this.bttn_Per = new System.Windows.Forms.Button();
            this.bttn_Div = new System.Windows.Forms.Button();
            this.bttn_Mul = new System.Windows.Forms.Button();
            this.lbl_answer = new System.Windows.Forms.Label();
            this.lbl_AnswerShow = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(148, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stander Calculator";
            // 
            // lbl_Number1
            // 
            this.lbl_Number1.AutoSize = true;
            this.lbl_Number1.Location = new System.Drawing.Point(13, 85);
            this.lbl_Number1.Name = "lbl_Number1";
            this.lbl_Number1.Size = new System.Drawing.Size(94, 24);
            this.lbl_Number1.TabIndex = 1;
            this.lbl_Number1.Text = "Number 1";
            // 
            // txt_Number1
            // 
            this.txt_Number1.Location = new System.Drawing.Point(126, 85);
            this.txt_Number1.Name = "txt_Number1";
            this.txt_Number1.Size = new System.Drawing.Size(189, 29);
            this.txt_Number1.TabIndex = 1;
            // 
            // txt_Number2
            // 
            this.txt_Number2.Location = new System.Drawing.Point(126, 143);
            this.txt_Number2.Name = "txt_Number2";
            this.txt_Number2.Size = new System.Drawing.Size(189, 29);
            this.txt_Number2.TabIndex = 2;
            // 
            // lbl_Number2
            // 
            this.lbl_Number2.AutoSize = true;
            this.lbl_Number2.Location = new System.Drawing.Point(13, 143);
            this.lbl_Number2.Name = "lbl_Number2";
            this.lbl_Number2.Size = new System.Drawing.Size(94, 24);
            this.lbl_Number2.TabIndex = 3;
            this.lbl_Number2.Text = "Number 2";
            // 
            // bttn_Clear
            // 
            this.bttn_Clear.Location = new System.Drawing.Point(361, 85);
            this.bttn_Clear.Name = "bttn_Clear";
            this.bttn_Clear.Size = new System.Drawing.Size(82, 33);
            this.bttn_Clear.TabIndex = 8;
            this.bttn_Clear.Text = "CE";
            this.bttn_Clear.UseVisualStyleBackColor = true;
            this.bttn_Clear.Click += new System.EventHandler(this.bttn_Clear_Click);
            // 
            // bttn_Add
            // 
            this.bttn_Add.Location = new System.Drawing.Point(361, 143);
            this.bttn_Add.Name = "bttn_Add";
            this.bttn_Add.Size = new System.Drawing.Size(82, 33);
            this.bttn_Add.TabIndex = 3;
            this.bttn_Add.Text = "+";
            this.bttn_Add.UseVisualStyleBackColor = true;
            this.bttn_Add.Click += new System.EventHandler(this.bttn_Add_Click);
            // 
            // bttn_Sub
            // 
            this.bttn_Sub.Location = new System.Drawing.Point(463, 143);
            this.bttn_Sub.Name = "bttn_Sub";
            this.bttn_Sub.Size = new System.Drawing.Size(82, 33);
            this.bttn_Sub.TabIndex = 4;
            this.bttn_Sub.Text = "-";
            this.bttn_Sub.UseVisualStyleBackColor = true;
            this.bttn_Sub.Click += new System.EventHandler(this.bttn_Sub_Click);
            // 
            // bttn_Per
            // 
            this.bttn_Per.Location = new System.Drawing.Point(463, 85);
            this.bttn_Per.Name = "bttn_Per";
            this.bttn_Per.Size = new System.Drawing.Size(82, 33);
            this.bttn_Per.TabIndex = 7;
            this.bttn_Per.Text = "%";
            this.bttn_Per.UseVisualStyleBackColor = true;
            this.bttn_Per.Click += new System.EventHandler(this.bttn_Per_Click);
            // 
            // bttn_Div
            // 
            this.bttn_Div.Location = new System.Drawing.Point(463, 206);
            this.bttn_Div.Name = "bttn_Div";
            this.bttn_Div.Size = new System.Drawing.Size(82, 33);
            this.bttn_Div.TabIndex = 6;
            this.bttn_Div.Text = "/";
            this.bttn_Div.UseVisualStyleBackColor = true;
            this.bttn_Div.Click += new System.EventHandler(this.bttn_Div_Click);
            // 
            // bttn_Mul
            // 
            this.bttn_Mul.Location = new System.Drawing.Point(361, 206);
            this.bttn_Mul.Name = "bttn_Mul";
            this.bttn_Mul.Size = new System.Drawing.Size(82, 33);
            this.bttn_Mul.TabIndex = 5;
            this.bttn_Mul.Text = "*";
            this.bttn_Mul.UseVisualStyleBackColor = true;
            this.bttn_Mul.Click += new System.EventHandler(this.bttn_Mul_Click);
            // 
            // lbl_answer
            // 
            this.lbl_answer.AutoSize = true;
            this.lbl_answer.Location = new System.Drawing.Point(17, 206);
            this.lbl_answer.Name = "lbl_answer";
            this.lbl_answer.Size = new System.Drawing.Size(74, 24);
            this.lbl_answer.TabIndex = 11;
            this.lbl_answer.Text = "Answer";
            // 
            // lbl_AnswerShow
            // 
            this.lbl_AnswerShow.AutoSize = true;
            this.lbl_AnswerShow.Location = new System.Drawing.Point(126, 206);
            this.lbl_AnswerShow.Name = "lbl_AnswerShow";
            this.lbl_AnswerShow.Size = new System.Drawing.Size(170, 24);
            this.lbl_AnswerShow.TabIndex = 12;
            this.lbl_AnswerShow.Text = "                                ";
            this.lbl_AnswerShow.Visible = false;
            // 
            // homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 275);
            this.Controls.Add(this.lbl_AnswerShow);
            this.Controls.Add(this.lbl_answer);
            this.Controls.Add(this.bttn_Div);
            this.Controls.Add(this.bttn_Mul);
            this.Controls.Add(this.bttn_Per);
            this.Controls.Add(this.bttn_Sub);
            this.Controls.Add(this.bttn_Add);
            this.Controls.Add(this.bttn_Clear);
            this.Controls.Add(this.txt_Number2);
            this.Controls.Add(this.lbl_Number2);
            this.Controls.Add(this.txt_Number1);
            this.Controls.Add(this.lbl_Number1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "homepage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stander Calculator";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.homepage_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Number1;
        private System.Windows.Forms.TextBox txt_Number1;
        private System.Windows.Forms.TextBox txt_Number2;
        private System.Windows.Forms.Label lbl_Number2;
        private System.Windows.Forms.Button bttn_Clear;
        private System.Windows.Forms.Button bttn_Add;
        private System.Windows.Forms.Button bttn_Sub;
        private System.Windows.Forms.Button bttn_Per;
        private System.Windows.Forms.Button bttn_Div;
        private System.Windows.Forms.Button bttn_Mul;
        private System.Windows.Forms.Label lbl_answer;
        private System.Windows.Forms.Label lbl_AnswerShow;
    }
}


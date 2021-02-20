using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StanderCalculator
{
    public partial class homepage : Form
    {
        float no1, no2, ans = 0.0f;

        private void bttn_Add_Click(object sender, EventArgs e)
        {
            no1 = Convert.ToSingle(txt_Number1.Text);
            no2 = Convert.ToSingle(txt_Number2.Text);
            ans = no1 + no2;
            lbl_AnswerShow.Text = ans.ToString();
            lbl_AnswerShow.Visible = true;
        }

        private void bttn_Sub_Click(object sender, EventArgs e)
        {
            no1 = Convert.ToSingle(txt_Number1.Text);
            no2 = Convert.ToSingle(txt_Number2.Text);
            ans = no1 - no2;
            lbl_AnswerShow.Text = ans.ToString();
            lbl_AnswerShow.Visible = true;
        }

        private void bttn_Mul_Click(object sender, EventArgs e)
        {
            no1 = Convert.ToSingle(txt_Number1.Text);
            no2 = Convert.ToSingle(txt_Number2.Text);
            ans = no1 * no2;
            lbl_AnswerShow.Text = ans.ToString();
            lbl_AnswerShow.Visible = true;
        }

        private void bttn_Div_Click(object sender, EventArgs e)
        {
            no1 = Convert.ToSingle(txt_Number1.Text);
            no2 = Convert.ToSingle(txt_Number2.Text);
            ans = no1 / no2;
            lbl_AnswerShow.Text = ans.ToString();
            lbl_AnswerShow.Visible = true;
        }

        private void bttn_Per_Click(object sender, EventArgs e)
        {
            double per;
            no1 = Convert.ToSingle(txt_Number1.Text);
            no2 = Convert.ToSingle(txt_Number2.Text);
            per = no1 + no2 * 100f / 200;
            lbl_AnswerShow.Text = per.ToString() + " %";
            lbl_AnswerShow.Visible = true;
        }

        private void homepage_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Have Nice Day!");
        }

        public homepage()
        {
            InitializeComponent();
        }

        private void bttn_Clear_Click(object sender, EventArgs e)
        {
            txt_Number1.Text = null;
            txt_Number2.Text = null;            
        }
    }
}

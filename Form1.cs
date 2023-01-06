using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace درجات_الطلاب
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tx_a.Text == "" || tx_f.Text == "" || tx_m.Text == "" || tx_1.Text == "" || tx_2.Text == "" || tx_3.Text == "" || tx_4.Text == "")
            {
                MessageBox.Show("يجب عدم ترك حقول الدرجات فارغة");
            }
            else
            {
                int inatt, finalatt, mid, final, total, percentage, quizsum = 0;

                inatt = int.Parse(tx_a.Text);
                finalatt = (inatt * 30) / 28;
                lb_a.Text = finalatt.ToString() + "/30";
                lb_a.Visible = true;




                mid = int.Parse(tx_m.Text);
                lb_m.Text = mid.ToString() + "/75";
                lb_m.Visible = true;



                final = int.Parse(tx_f.Text);
                lb_f.Text = final.ToString() + "/150";
                lb_f.Visible = true;

                int quiz1, quiz2, quiz3, quiz4;

                quiz1 = int.Parse(tx_1.Text);
                quiz2 = int.Parse(tx_2.Text);
                quiz3 = int.Parse(tx_3.Text);
                quiz4 = int.Parse(tx_4.Text);


                int[] array = { quiz1, quiz2, quiz3, quiz4 };
                for (int i = 0; i <= 2; i++)
                {
                    Array.Sort(array);
                    Array.Reverse(array);
                    quizsum += array[i];
                }
                lb_q.Text = quizsum.ToString() + "/45";
                lb_q.Visible = true;




                total = finalatt + mid + quizsum + final;
                lb_t.Text = total.ToString() + "/300";
                lb_t.Visible = true;
                percentage = (total * 100) / 300;


                if (percentage >= 80)
                    lb_g.Text = "A+";
                else if (percentage >= 75 && percentage <= 79)
                    lb_g.Text = "A";
                else if (percentage >= 70 && percentage <= 74)
                    lb_g.Text = "A-";
                else if (percentage >= 65 && percentage <= 69)
                    lb_g.Text = "B+";
                else if (percentage >= 64 && percentage <= 60)
                    lb_g.Text = "B";
                else if (percentage >= 55 && percentage <= 59)
                    lb_g.Text = "B-";
                else if (percentage >= 50 && percentage <= 54)
                    lb_g.Text = "C+";
                else if (percentage >= 45 && percentage <= 49)
                    lb_g.Text = "C";
                else if (percentage >= 40 && percentage <= 44)
                    lb_g.Text = "D";
                else 
                    lb_g.Text = "F";

                lb_g.Visible = true;



                lb_r.Text = tx_name.Text + "   الذي رقمه التعريفي "+ tx_id.Text + "  مجموعه   " + percentage.ToString() + " في الترم    "+ tx_semstar.Text ;
                lb_r.Visible = true;
            }


            }

        private void button2_Click(object sender, EventArgs e)
        {
            tx_a.Text = "";
            tx_f.Text = "";
            tx_m.Text = "";
            tx_name.Text = "";
            tx_1.Text = "";
            tx_2.Text = "";
            tx_3.Text = "";
            tx_4.Text = "";
            tx_semstar.Text = "";
            tx_id.Text = "";
            lb_a.Text = "";
            lb_r.Text = "";
            lb_f.Text = "";
            lb_g.Text = "";
            lb_m.Text = "";
            lb_q.Text = "";
            lb_t.Text = "";
        }
    }
    }


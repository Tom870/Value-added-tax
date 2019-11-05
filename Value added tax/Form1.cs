using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Value_added_tax
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //購入のイベントハンドラ
        private void Purchase_Click(object sender, EventArgs e)
        {
            //購入した時間を表示
            DateLabel.Text = DateTime.Now + "";

            
                //入力された金額を数値型に変換
                int money0 = int.Parse(AppleMoney.Text);
                int money1 = int.Parse(BananaMoney.Text);
                int money2 = int.Parse(MixedMoney.Text);
                int money3 = int.Parse(DrinkMoney.Text);


                //税込金額算出
                money0 = addVAT(money0);
                money1 = addVAT(money1);
                money2 = addVAT(money2);
                money3 = addVAT(money3);

                //軽減税率適用
                if (checkBox0.Checked == true)
                {
                    money0 = money0 * 100 / 110;
                    money0 = addVAT8(money0);
                }

                if (checkBox1.Checked == true)
                {
                    money1 = money1 * 100 / 110;
                    money1 = addVAT8(money1);
                }

                if (checkBox2.Checked == true)
                {
                    money2 = money2 * 100 / 110;
                    money2 = addVAT8(money2);
                }

                if (checkBox3.Checked == true)
                {
                    money3 = money3 * 100 / 110;
                    money3 = addVAT8(money3);
                }


                //合計を表示
                int[] total = new int[] { money0, money1, money2, money3 };
                int sum = 0;
                for (int i = 0; i < total.Length; i++)
                {
                    sum += total[i];
                }


                SumResult.Text = sum + "円";


                //購入したものを表示
                label1.Text = textBox1.Text;
                label2.Text = textBox2.Text;
                label3.Text = textBox3.Text;
                label4.Text = textBox4.Text;

                //支払い方法
                //キャッシュレス還元
                if (CardCheck.Checked == true || EmoneyCheck.Checked == true)
                {
                    double C = (double)sum * 0.02;
                    double cashback = Math.Floor(C);
                    label5.Text = cashback + "円";

                    //カード支払い額
                    double cashlessPay = (double)sum - cashback;
                    label6.Text = cashlessPay + "円";
                }
            else
            {
                label5.Text = "";
                label6.Text = "";
                CashCheck.Checked = true;
            }

        }



        //税込金額(10%)算出メソッド
        private int addVAT(int m)
        {
            const double tax = 0.10; //消費税率10％

            return (int)(m * (1 + tax));
        }

        //税込金額(8%)算出メソッド
        private int addVAT8(int n)
        {
            const double tax = 0.08; //消費税率8％

            return (int)(n * (1 + tax));
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

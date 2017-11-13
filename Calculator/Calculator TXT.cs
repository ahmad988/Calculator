using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        //string tb_n = "0";
        string temp="";
        //string tempPlus;
        //int cal = 0;
        //int k = 0;
        //int z = 0;
        //int t = 0;
        int var1=-9999;
        int var2;
        string m;
        bool a = true;
        int result;
        
        //int var3;
        List<int> TotalList= new List<int>();
        List<int> VarList = new List<int>();
        
        static int pro(int Number1,int Number2,string method)
        {
            int result = 0;
            if (method == null)
            {

            }
            else
            {
                if (method == "+")
                {
                    result = Number1 + Number2;
                    method = null;
                    

                }
                else
                {
                    if (method == "-")
                    {
                        result = Number1 - Number2;
                        method = null;
                    }
                    else
                    {
                        if (method == "*")
                        {
                            result = Number1 * Number2;
                            method = null;

                        }
                        else
                        {
                            if (method == "/")
                            {
                                result = Number1 / Number2;
                                method = null;
                            }
                            else
                            {

                            }

                        }

                    }
                }

            }
                return (result);
            
        }
        

        public Form1()
        {
            InitializeComponent();
            TB_Normal.Text ="0";
            TotalList.Add(0);
            VarList.Add(0);
           

        }

        private void BT_1_Click(object sender, EventArgs e)
        {
            
            temp = temp + "1";
            TB_Normal.Text = temp;
        }

        private void BT_2_Click(object sender, EventArgs e)
        {
            temp = temp + "2";
            TB_Normal.Text = temp;

        }

        private void BT_3_Click(object sender, EventArgs e)
        {
            
            temp = temp + "3";
            TB_Normal.Text = temp;
        }

        private void BT_4_Click(object sender, EventArgs e)
        {
            
            temp = temp + "4";
            TB_Normal.Text = temp;
        }

        private void BT_5_Click(object sender, EventArgs e)
        {

           
            temp = temp + "5";
            
            TB_Normal.Text = temp;
        }

        private void BT_6_Click(object sender, EventArgs e)
        {
           
            temp = temp + "6";
            TB_Normal.Text = temp;
        }

        private void BT_7_Click(object sender, EventArgs e)
        {
           
            temp = temp + "7";
            TB_Normal.Text = temp;
        }

        private void BT_8_Click(object sender, EventArgs e)
        {
           
            temp = temp + "8";
            TB_Normal.Text = temp;
        }

        private void BT_9_Click(object sender, EventArgs e)
        {
            
            temp = temp + "9";
            TB_Normal.Text = temp;
        }

        private void BT_0_Click(object sender, EventArgs e)
        {
           
            temp = temp + "0";
            TB_Normal.Text = temp;
        }

        private void BT_Clear_Click(object sender, EventArgs e)
        {
            temp = "";
            TB_Normal.Text = "0";
            TB_small.Text = "";
            var1 = -9999;
            var2 = 0;
            result = 0;
            m = null;
            //tempPlus = "";
        }

        private void BT_Plus_Click(object sender, EventArgs e)
        {
            //try another method
            if (m != null)
            {
                var2 = int.Parse(TB_Normal.Text);
                result = pro(var1, var2, m);
                var1 = result;
                m = null;
                TB_Normal.Text = result + "";
                temp = "";
                TB_small.Text = var1 + "";
                a = false;
            }
            m = "+";
            if (var1==-9999)
            {
                var1 = int.Parse(TB_Normal.Text);
                TB_Normal.Text = result + "";
                temp = "";
            }
            else
            {
                if (a == false)
                {

                }
                else
                {
                    var2 = int.Parse(TB_Normal.Text);
                    result = pro(var1, var2, m);
                    var1 = result;
                    TB_Normal.Text = result + "";
                    temp = "";
                    TB_small.Text = var1 + "";
                    a = true;
                }
            }
            //TotalList.Add(int.Parse(TB_Normal.Text));
            /*foreach (int n in TotalList)
            {
                total = n;
            }
            total = total + int.Parse(TB_Normal.Text);
            TotalList.Add(total);
            VarList.Add(int.Parse(TB_Normal.Text));
            TB_small.Text = total + "";
            TB_Normal.Text = "0";
            temp = "";
            /*
            if (var1==0)
            {
                var1 = int.Parse(TB_Normal.Text);
            }
            else
            {
                var2 = int.Parse(TB_Normal.Text);
                var1=pro(var1, var2, m);
                
                
            }

            //pro(var1, var2, m);
            var2 = 0;
            TB_small.Text = var1 + "";
            //TB_Normal.Text = "0";
            temp = "";
            //m = null;
            */
            
            //
            /*var3 = int.Parse(var1) + int.Parse(var2);
            var1=var3+"";

            tempPlus =tempPlus+ temp +"+";
            k = int.Parse(TB_Normal.Text);
            TB_small.Text = tempPlus;
            //try catch
            if (temp=="")
            {

            }
            else
            {
                cal = cal + int.Parse(temp);
                temp = "";
                TB_Normal.Text = cal + "";
                t = cal;
            }*/


        }

        private void BT_min_Click(object sender, EventArgs e)
        {
            
            if (m!=null)
            {
                var2 = int.Parse(TB_Normal.Text);
                result = pro(var1, var2, m);
                var1 = result;
                m = null;
                TB_Normal.Text = result + "";
                temp = "";
                TB_small.Text = var1 + "";
                a = false;
            }
            m = "-";
            
            if (var1 == -9999)
            {
                var1 = int.Parse(TB_Normal.Text);
                TB_Normal.Text = result + "";
                temp = "";
            }
            else
            {
                if (a==false)
                {

                }
                else
                {
                    var2 = int.Parse(TB_Normal.Text);
                    result = pro(var1, var2, m);
                    var1 = result;
                    TB_Normal.Text = result + "";
                    temp = "";
                    TB_small.Text = var1 + "";
                    a = true;
                }
                

            }
            /*
            if (var1 == 0)
            {
                var1 = int.Parse(TB_Normal.Text);
            }
            else
            {
                var2 = int.Parse(TB_Normal.Text);
                var1 = pro(var1, var2, m);


            }

            //pro(var1, var2, m);
            var2 = 0;
            TB_small.Text = var1 + "";
            TB_Normal.Text = "0";
            temp = "";
            /*tempPlus = tempPlus + temp + "-";
            TB_small.Text = tempPlus;
            if (temp == "")
            {

            }
            else
            {
                if (cal == 0)
                {
                    cal = int.Parse(TB_Normal.Text);
                    temp = "";
                    TB_Normal.Text = cal + "";
                    t = cal;
                }
                else
                {
                    cal = cal - int.Parse(temp);
                    temp = "";
                    TB_Normal.Text = cal + "";
                    t = cal;
                }

            }*/

        }

        private void BT_M_Click(object sender, EventArgs e)
        {
            if (m != null)
            {
                var2 = int.Parse(TB_Normal.Text);
                result = pro(var1, var2, m);
                var1 = result;
                m = null;
                TB_Normal.Text = result + "";
                temp = "";
                TB_small.Text = var1 + "";
                a = false;
            }
            m = "*";

            if (var1 == -9999)
            {
                var1 = int.Parse(TB_Normal.Text);
                TB_Normal.Text = result + "";
                temp = "";
            }
            else
            {
                if (a == false)
                {

                }
                else
                {
                    var2 = int.Parse(TB_Normal.Text);
                    result = pro(var1, var2, m);
                    var1 = result;
                    TB_Normal.Text = result + "";
                    temp = "";
                    TB_small.Text = var1 + "";
                    a = true;
                }


            }
            /*foreach (int n in TotalList)
            {
                total = n;
            }
            TB_small.Text = total + "";
            if (total==0)
            {
                total = 1;
                total = total * int.Parse(TB_Normal.Text);
                TotalList.Add(total);
                VarList.Add(int.Parse(TB_Normal.Text));
                TB_small.Text = total + "";
            }
            else
            {
                total = total * int.Parse(TB_Normal.Text);
                TotalList.Add(total);
                VarList.Add(int.Parse(TB_Normal.Text));
                TB_small.Text = total + "";
            }
            
            //TB_Normal.Text = "0";
            temp = "";
            */
            /*
            if (m!=null)
            {
                var2 = int.Parse(TB_Normal.Text);
                var1 = pro(var1, var2, m);

            }
            if (var1 == 0)
            {
                var1 = int.Parse(TB_Normal.Text);
            }
            else
            {
                var2 = int.Parse(TB_Normal.Text);
                var1 = pro(var1, var2, m);


            }

            //pro(var1, var2, m);
            var2 = 0;
            TB_small.Text = var1 + "";
            //TB_Normal.Text = "0";
            temp = "";
            //m = null;
            /*
            tempPlus = tempPlus + temp + "x";
            TB_small.Text = tempPlus;
            temp = "";
            int x = int.Parse(TB_Normal.Text);

            */
        }

        private void BT_D_Click(object sender, EventArgs e)
        {
            if (m != null)
            {
                var2 = int.Parse(TB_Normal.Text);
                result = pro(var1, var2, m);
                var1 = result;
                m = null;
                TB_Normal.Text = result + "";
                temp = "";
                TB_small.Text = var1 + "";
                a = false;
            }
            m = "/";

            if (var1 == -9999)
            {
                var1 = int.Parse(TB_Normal.Text);
                TB_Normal.Text = result + "";
                temp = "";
            }
            else
            {
                if (a == false)
                {

                }
                else
                {
                    var2 = int.Parse(TB_Normal.Text);
                    result = pro(var1, var2, m);
                    var1 = result;
                    TB_Normal.Text = result + "";
                    temp = "";
                    TB_small.Text = var1 + "";
                    a = true;
                }


            }
            /*m = "/";
            if (var1 == 0)
            {
                var1 = int.Parse(TB_Normal.Text);
            }
            else
            {
                var2 = int.Parse(TB_Normal.Text);
                var1 = pro(var1, var2, m);


            }

            //pro(var1, var2, m);
            var2 = 0;
            TB_small.Text = var1 + "";
            TB_Normal.Text = "0";
            temp = "";
            /*
            tempPlus = tempPlus + temp + "/";
            int d;
            k = int.Parse(TB_Normal.Text);
            if (z==0)
            {
                z = k;
            }
            else
            {
                d = z / k;
                TB_Normal.Text = d + "";
                z = int.Parse(TB_Normal.Text);
                t = d;
            }
            TB_small.Text = tempPlus;
            temp = "";
            */
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BT_E_Click(object sender, EventArgs e)
        {
            var2 = int.Parse(TB_Normal.Text);
            TB_small.Text = pro(var1, var2, m) + "";
            
            
        }
    }
}

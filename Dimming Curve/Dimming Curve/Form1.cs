using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dimming_Curve
{
    public partial class Form1 : Form
    {
        int[] OutPutNum = new int[1024];
        public Form1()
        {
            InitializeComponent();
        }
        
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(trackBar1.Value / 99.99);
            textBox46.Text = Convert.ToString(trackBar1.Value);
            OutPutNum[167] = trackBar1.Value;
            if (trackBar1.Value / 99.99 > 99.99)
                textBox1.Text = "100";
        }
        //二级光调试数据
        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            textBox2.Text = Convert.ToString(trackBar2.Value / 99.99);
            textBox45.Text = Convert.ToString(trackBar2.Value);

            OutPutNum[180] = trackBar2.Value;
            if (trackBar2.Value / 99.99 > 99.99)
                textBox2.Text = "100";
        }
        //三级光调试数据
        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(trackBar3.Value / 99.99);
            textBox44.Text = Convert.ToString(trackBar3.Value);

            OutPutNum[207] = trackBar3.Value;
            if (trackBar3.Value / 99.99 > 99.99)
                textBox3.Text = "100";
        }
        //四级光调试数据
        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            textBox4.Text = Convert.ToString(trackBar4.Value / 99.99);
            textBox43.Text = Convert.ToString(trackBar4.Value);

            OutPutNum[235] = trackBar4.Value;
            if (trackBar4.Value / 99.99 > 99.99)
                textBox4.Text = "100";
        }
        //五级光调试数据
        private void trackBar5_Scroll(object sender, EventArgs e)
        {
            textBox5.Text = Convert.ToString(trackBar5.Value / 99.99);
            textBox42.Text = Convert.ToString(trackBar5.Value);

            OutPutNum[265] = trackBar5.Value;
            if (trackBar5.Value / 99.99 > 99.99)
                textBox5.Text = "100";
        }


        private void trackBar6_Scroll(object sender, EventArgs e)
        {
            textBox6.Text = Convert.ToString(trackBar6.Value / 99.99);
            textBox41.Text = Convert.ToString(trackBar6.Value);

            OutPutNum[298] = trackBar6.Value;
            if (trackBar6.Value / 99.99 > 99.99)
                textBox6.Text = "100";
        }

        private void trackBar7_Scroll(object sender, EventArgs e)
        {
            textBox7.Text = Convert.ToString(trackBar7.Value / 99.99);
            textBox40.Text = Convert.ToString(trackBar7.Value);

            OutPutNum[331] = trackBar7.Value;
            if (trackBar7.Value / 99.99 > 99.99)
                textBox7.Text = "100";
        }

        private void trackBar8_Scroll(object sender, EventArgs e)
        {
            textBox8.Text = Convert.ToString(trackBar8.Value / 99.99);
            textBox39.Text = Convert.ToString(trackBar8.Value);

            OutPutNum[367] = trackBar8.Value;
            if (trackBar8.Value / 99.99 > 99.99)
                textBox8.Text = "100";
        }

        private void trackBar9_Scroll(object sender, EventArgs e)
        {
            textBox9.Text = Convert.ToString(trackBar9.Value / 99.99);
            textBox38.Text = Convert.ToString(trackBar9.Value);

            OutPutNum[386] = trackBar9.Value;
            if (trackBar9.Value / 99.99 > 99.99)
                textBox9.Text = "100";
        }

        private void trackBar11_Scroll(object sender, EventArgs e)
        {
            textBox11.Text = Convert.ToString(trackBar11.Value / 99.99);
            textBox37.Text = Convert.ToString(trackBar11.Value);

            OutPutNum[424] = trackBar11.Value;
            if (trackBar11.Value / 99.99 > 99.99)
                textBox11.Text = "100";
        }

        private void trackBar12_Scroll(object sender, EventArgs e)
        {
            textBox12.Text = Convert.ToString(trackBar12.Value / 99.99);
            textBox36.Text = Convert.ToString(trackBar12.Value);

            OutPutNum[465] = trackBar12.Value;
            if (trackBar12.Value / 99.99 > 99.99)
                textBox12.Text = "100";
        }

        private void trackBar13_Scroll(object sender, EventArgs e)
        {
            textBox13.Text = Convert.ToString(trackBar13.Value / 99.99);
            textBox35.Text = Convert.ToString(trackBar13.Value);

            OutPutNum[507] = trackBar13.Value;
            if (trackBar13.Value / 99.99 > 99.99)
                textBox13.Text = "100";
        }

        private void trackBar14_Scroll(object sender, EventArgs e)
        {
            textBox14.Text = Convert.ToString(trackBar14.Value / 99.99);
            textBox34.Text = Convert.ToString(trackBar14.Value);

            OutPutNum[551] = trackBar14.Value;
            if (trackBar14.Value / 99.99 > 99.99)
                textBox14.Text = "100";
        }

        private void trackBar15_Scroll(object sender, EventArgs e)
        {
            textBox15.Text = Convert.ToString(trackBar15.Value / 99.99);
            textBox33.Text = Convert.ToString(trackBar15.Value);

            OutPutNum[597] = trackBar15.Value;
            if (trackBar15.Value / 99.99 > 99.99)
                textBox15.Text = "100";
        }

        private void trackBar16_Scroll(object sender, EventArgs e)
        {
            textBox16.Text = Convert.ToString(trackBar16.Value / 99.99);
            textBox32.Text = Convert.ToString(trackBar16.Value);

            OutPutNum[621] = trackBar16.Value;
            if (trackBar16.Value / 99.99 > 99.99)
                textBox16.Text = "100";
        }

        private void trackBar17_Scroll(object sender, EventArgs e)
        {
            textBox17.Text = Convert.ToString(trackBar17.Value / 99.99);
            textBox31.Text = Convert.ToString(trackBar17.Value);

            OutPutNum[669] = trackBar17.Value;
            if (trackBar17.Value / 99.99 > 99.99)
                textBox17.Text = "100";
        }

        private void trackBar18_Scroll(object sender, EventArgs e)
        {
            textBox18.Text = Convert.ToString(trackBar18.Value / 99.99);
            textBox30.Text = Convert.ToString(trackBar18.Value);

            OutPutNum[720] = trackBar18.Value;
            if (trackBar18.Value / 99.99 > 99.99)
                textBox18.Text = "100";
        }

        private void trackBar19_Scroll(object sender, EventArgs e)
        {
            textBox19.Text = Convert.ToString(trackBar19.Value / 99.99);
            textBox29.Text = Convert.ToString(trackBar19.Value);

            OutPutNum[772] = trackBar19.Value;
            if (trackBar19.Value / 99.99 > 99.99)
                textBox19.Text = "100";
        }

        private void trackBar20_Scroll(object sender, EventArgs e)
        {
            textBox20.Text = Convert.ToString(trackBar20.Value / 99.99);
            textBox28.Text = Convert.ToString(trackBar20.Value);

            OutPutNum[826] = trackBar20.Value;
            if (trackBar20.Value / 99.99 > 99)
                textBox20.Text = "100";
        }

        private void trackBar21_Scroll(object sender, EventArgs e)
        {
            textBox21.Text = Convert.ToString(trackBar21.Value / 99.99);
            textBox27.Text = Convert.ToString(trackBar21.Value);

            OutPutNum[882] = trackBar21.Value;
            if (trackBar21.Value / 99.99 > 99.99)
                textBox21.Text = "100";
        }

        private void trackBar22_Scroll(object sender, EventArgs e)
        {
            textBox22.Text = Convert.ToString(trackBar22.Value / 99.99);
            textBox26.Text = Convert.ToString(trackBar22.Value);

            OutPutNum[940] = trackBar22.Value;
            if (trackBar22.Value / 99.99 > 99.99)
                textBox22.Text = "100";
        }

        private void trackBar23_Scroll(object sender, EventArgs e)
        {
            textBox23.Text = Convert.ToString(trackBar23.Value / 99.99);
            textBox25.Text = Convert.ToString(trackBar23.Value);

            OutPutNum[1000] = trackBar23.Value;
            if (trackBar23.Value / 99.99 <=1)
                textBox23.Text = "0";
        }

        private void trackBar24_Scroll(object sender, EventArgs e)
        {
            OutPutNum[1023] = trackBar24.Value;

            textBox24.Text = Convert.ToString(OutPutNum[1023] / 99.99);
            textBox10.Text = Convert.ToString(OutPutNum[1023]);

            //if (trackBar24.Value / 99.99<=1)
            //    textBox24.Text ="0";
        }
       
        
        
        //计算光级之间填充的数据
        //按照等差数列来填写，可调用函数EqualDifference(Head ，End ,Num)
        private void button1_Click(object sender, EventArgs e)
        {
           
           //五点拟合法
            //计算四次方程的五个参数
           // long A,B,C,D,E;

           //A = Convert.ToInt64(((((OutPutNum[1000]-OutPutNum[621])-1.613*(OutPutNum[621]-OutPutNum[386]))-2.780517*((OutPutNum[621]-OutPutNum[386])-1.942*(OutPutNum[386]-OutPutNum[265])))-4.6416*(((OutPutNum[621]-OutPutNum[386])-1.942*(OutPutNum[386]-OutPutNum[265]))-3.3592*((OutPutNum[386]-OutPutNum[265])-1.424*(OutPutNum[265]-OutPutNum[180]))))/(1.40127E+11));
           //B = Convert.ToInt64((((OutPutNum[621]-OutPutNum[386])-1.942*(OutPutNum[386]-OutPutNum[265]))-3.3592*((OutPutNum[386]-OutPutNum[265])-1.424*(OutPutNum[265]-OutPutNum[180])))/36860697-1452.637625*(((((OutPutNum[1000]-OutPutNum[621])-1.613*(OutPutNum[621]-OutPutNum[386]))-2.780517*((OutPutNum[621]-OutPutNum[386])-1.942*(OutPutNum[386]-OutPutNum[265])))-4.6416*(((OutPutNum[621]-OutPutNum[386])-1.942*(OutPutNum[386]-OutPutNum[265]))-3.3592*((OutPutNum[386]-OutPutNum[265])-1.424*(OutPutNum[265]-OutPutNum[180]))))/(1.40127E+11)));
           //C = Convert.ToInt64((((OutPutNum[386] - OutPutNum[265]) - 1.424 * (OutPutNum[265] - OutPutNum[180])) / 24908.2) - 471354.3147 * (((((OutPutNum[1000] - OutPutNum[621]) - 1.613 * (OutPutNum[621] - OutPutNum[386])) - 2.780517 * ((OutPutNum[621] - OutPutNum[386]) - 1.942 * (OutPutNum[386] - OutPutNum[265]))) - 4.6416 * (((OutPutNum[621] - OutPutNum[386]) - 1.942 * (OutPutNum[386] - OutPutNum[265])) - 3.3592 * ((OutPutNum[386] - OutPutNum[265]) - 1.424 * (OutPutNum[265] - OutPutNum[180])))) / (1.40127E+11)) - 831.3524 * ((((OutPutNum[621] - OutPutNum[386]) - 1.942 * (OutPutNum[386] - OutPutNum[265])) - 3.3592 * ((OutPutNum[386] - OutPutNum[265]) - 1.424 * (OutPutNum[265] - OutPutNum[180]))) / 36860697 - 1452.637625 * (((((OutPutNum[1000] - OutPutNum[621]) - 1.613 * (OutPutNum[621] - OutPutNum[386])) - 2.780517 * ((OutPutNum[621] - OutPutNum[386]) - 1.942 * (OutPutNum[386] - OutPutNum[265]))) - 4.6416 * (((OutPutNum[621] - OutPutNum[386]) - 1.942 * (OutPutNum[386] - OutPutNum[265])) - 3.3592 * ((OutPutNum[386] - OutPutNum[265]) - 1.424 * (OutPutNum[265] - OutPutNum[180])))) / (1.40127E+11))));
           //D = Convert.ToInt64((OutPutNum[265] - OutPutNum[180]) / 85 - 45668125 * (((((OutPutNum[1000] - OutPutNum[621]) - 1.613 * (OutPutNum[621] - OutPutNum[386])) - 2.780517 * ((OutPutNum[621] - OutPutNum[386]) - 1.942 * (OutPutNum[386] - OutPutNum[265]))) - 4.6416 * (((OutPutNum[621] - OutPutNum[386]) - 1.942 * (OutPutNum[386] - OutPutNum[265])) - 3.3592 * ((OutPutNum[386] - OutPutNum[265]) - 1.424 * (OutPutNum[265] - OutPutNum[180])))) / (1.40127E+11)) - 150325 * ((((OutPutNum[621] - OutPutNum[386]) - 1.942 * (OutPutNum[386] - OutPutNum[265])) - 3.3592 * ((OutPutNum[386] - OutPutNum[265]) - 1.424 * (OutPutNum[265] - OutPutNum[180]))) / 36860697 - 1452.637625 * (((((OutPutNum[1000] - OutPutNum[621]) - 1.613 * (OutPutNum[621] - OutPutNum[386])) - 2.780517 * ((OutPutNum[621] - OutPutNum[386]) - 1.942 * (OutPutNum[386] - OutPutNum[265]))) - 4.6416 * (((OutPutNum[621] - OutPutNum[386]) - 1.942 * (OutPutNum[386] - OutPutNum[265])) - 3.3592 * ((OutPutNum[386] - OutPutNum[265]) - 1.424 * (OutPutNum[265] - OutPutNum[180])))) / (1.40127E+11))) - 445 * ((((OutPutNum[386] - OutPutNum[265]) - 1.424 * (OutPutNum[265] - OutPutNum[180])) / 24908.2) - 471354.3147 * (((((OutPutNum[1000] - OutPutNum[621]) - 1.613 * (OutPutNum[621] - OutPutNum[386])) - 2.780517 * ((OutPutNum[621] - OutPutNum[386]) - 1.942 * (OutPutNum[386] - OutPutNum[265]))) - 4.6416 * (((OutPutNum[621] - OutPutNum[386]) - 1.942 * (OutPutNum[386] - OutPutNum[265])) - 3.3592 * ((OutPutNum[386] - OutPutNum[265]) - 1.424 * (OutPutNum[265] - OutPutNum[180])))) / (1.40127E+11)) - 831.3524 * ((((OutPutNum[621] - OutPutNum[386]) - 1.942 * (OutPutNum[386] - OutPutNum[265])) - 3.3592 * ((OutPutNum[386] - OutPutNum[265]) - 1.424 * (OutPutNum[265] - OutPutNum[180]))) / 36860697 - 1452.637625 * (((((OutPutNum[1000] - OutPutNum[621]) - 1.613 * (OutPutNum[621] - OutPutNum[386])) - 2.780517 * ((OutPutNum[621] - OutPutNum[386]) - 1.942 * (OutPutNum[386] - OutPutNum[265]))) - 4.6416 * (((OutPutNum[621] - OutPutNum[386]) - 1.942 * (OutPutNum[386] - OutPutNum[265])) - 3.3592 * ((OutPutNum[386] - OutPutNum[265]) - 1.424 * (OutPutNum[265] - OutPutNum[180])))) / (1.40127E+11)))));
           //E = Convert.ToInt64(OutPutNum[180] - 1049760000 * (((((OutPutNum[1000] - OutPutNum[621]) - 1.613 * (OutPutNum[621] - OutPutNum[386])) - 2.780517 * ((OutPutNum[621] - OutPutNum[386]) - 1.942 * (OutPutNum[386] - OutPutNum[265]))) - 4.6416 * (((OutPutNum[621] - OutPutNum[386]) - 1.942 * (OutPutNum[386] - OutPutNum[265])) - 3.3592 * ((OutPutNum[386] - OutPutNum[265]) - 1.424 * (OutPutNum[265] - OutPutNum[180])))) / (1.40127E+11)) - 5832000 * ((((OutPutNum[621] - OutPutNum[386]) - 1.942 * (OutPutNum[386] - OutPutNum[265])) - 3.3592 * ((OutPutNum[386] - OutPutNum[265]) - 1.424 * (OutPutNum[265] - OutPutNum[180]))) / 36860697 - 1452.637625 * (((((OutPutNum[1000] - OutPutNum[621]) - 1.613 * (OutPutNum[621] - OutPutNum[386])) - 2.780517 * ((OutPutNum[621] - OutPutNum[386]) - 1.942 * (OutPutNum[386] - OutPutNum[265]))) - 4.6416 * (((OutPutNum[621] - OutPutNum[386]) - 1.942 * (OutPutNum[386] - OutPutNum[265])) - 3.3592 * ((OutPutNum[386] - OutPutNum[265]) - 1.424 * (OutPutNum[265] - OutPutNum[180])))) / (1.40127E+11))) - 32400 * ((((OutPutNum[386] - OutPutNum[265]) - 1.424 * (OutPutNum[265] - OutPutNum[180])) / 24908.2) - 471354.3147 * (((((OutPutNum[1000] - OutPutNum[621]) - 1.613 * (OutPutNum[621] - OutPutNum[386])) - 2.780517 * ((OutPutNum[621] - OutPutNum[386]) - 1.942 * (OutPutNum[386] - OutPutNum[265]))) - 4.6416 * (((OutPutNum[621] - OutPutNum[386]) - 1.942 * (OutPutNum[386] - OutPutNum[265])) - 3.3592 * ((OutPutNum[386] - OutPutNum[265]) - 1.424 * (OutPutNum[265] - OutPutNum[180])))) / (1.40127E+11)) - 831.3524 * ((((OutPutNum[621] - OutPutNum[386]) - 1.942 * (OutPutNum[386] - OutPutNum[265])) - 3.3592 * ((OutPutNum[386] - OutPutNum[265]) - 1.424 * (OutPutNum[265] - OutPutNum[180]))) / 36860697 - 1452.637625 * (((((OutPutNum[1000] - OutPutNum[621]) - 1.613 * (OutPutNum[621] - OutPutNum[386])) - 2.780517 * ((OutPutNum[621] - OutPutNum[386]) - 1.942 * (OutPutNum[386] - OutPutNum[265]))) - 4.6416 * (((OutPutNum[621] - OutPutNum[386]) - 1.942 * (OutPutNum[386] - OutPutNum[265])) - 3.3592 * ((OutPutNum[386] - OutPutNum[265]) - 1.424 * (OutPutNum[265] - OutPutNum[180])))) / (1.40127E+11)))) - 180 * ((OutPutNum[265] - OutPutNum[180]) / 85 - 45668125 * (((((OutPutNum[1000] - OutPutNum[621]) - 1.613 * (OutPutNum[621] - OutPutNum[386])) - 2.780517 * ((OutPutNum[621] - OutPutNum[386]) - 1.942 * (OutPutNum[386] - OutPutNum[265]))) - 4.6416 * (((OutPutNum[621] - OutPutNum[386]) - 1.942 * (OutPutNum[386] - OutPutNum[265])) - 3.3592 * ((OutPutNum[386] - OutPutNum[265]) - 1.424 * (OutPutNum[265] - OutPutNum[180])))) / (1.40127E+11)) - 150325 * ((((OutPutNum[621] - OutPutNum[386]) - 1.942 * (OutPutNum[386] - OutPutNum[265])) - 3.3592 * ((OutPutNum[386] - OutPutNum[265]) - 1.424 * (OutPutNum[265] - OutPutNum[180]))) / 36860697 - 1452.637625 * (((((OutPutNum[1000] - OutPutNum[621]) - 1.613 * (OutPutNum[621] - OutPutNum[386])) - 2.780517 * ((OutPutNum[621] - OutPutNum[386]) - 1.942 * (OutPutNum[386] - OutPutNum[265]))) - 4.6416 * (((OutPutNum[621] - OutPutNum[386]) - 1.942 * (OutPutNum[386] - OutPutNum[265])) - 3.3592 * ((OutPutNum[386] - OutPutNum[265]) - 1.424 * (OutPutNum[265] - OutPutNum[180])))) / (1.40127E+11))) - 445 * ((((OutPutNum[386] - OutPutNum[265]) - 1.424 * (OutPutNum[265] - OutPutNum[180])) / 24908.2) - 471354.3147 * (((((OutPutNum[1000] - OutPutNum[621]) - 1.613 * (OutPutNum[621] - OutPutNum[386])) - 2.780517 * ((OutPutNum[621] - OutPutNum[386]) - 1.942 * (OutPutNum[386] - OutPutNum[265]))) - 4.6416 * (((OutPutNum[621] - OutPutNum[386]) - 1.942 * (OutPutNum[386] - OutPutNum[265])) - 3.3592 * ((OutPutNum[386] - OutPutNum[265]) - 1.424 * (OutPutNum[265] - OutPutNum[180])))) / (1.40127E+11)) - 831.3524 * ((((OutPutNum[621] - OutPutNum[386]) - 1.942 * (OutPutNum[386] - OutPutNum[265])) - 3.3592 * ((OutPutNum[386] - OutPutNum[265]) - 1.424 * (OutPutNum[265] - OutPutNum[180]))) / 36860697 - 1452.637625 * (((((OutPutNum[1000] - OutPutNum[621]) - 1.613 * (OutPutNum[621] - OutPutNum[386])) - 2.780517 * ((OutPutNum[621] - OutPutNum[386]) - 1.942 * (OutPutNum[386] - OutPutNum[265]))) - 4.6416 * (((OutPutNum[621] - OutPutNum[386]) - 1.942 * (OutPutNum[386] - OutPutNum[265])) - 3.3592 * ((OutPutNum[386] - OutPutNum[265]) - 1.424 * (OutPutNum[265] - OutPutNum[180])))) / (1.40127E+11))))));
           

           // //输出OutPutNum[0]~OutPutNum[142]的值，既电流小于2.5A的情况

           //for (int i = 0; i < 142;i++ )
           //{
           //    OutPutNum[i] = 0;
           //}

           //    //输出OutPutNum[142]~OutPutNum[180]的值，均等于OutPutNum[180]

           //for (int i = 142; i < 180;i++ )
           //{
           //    OutPutNum[i] = OutPutNum[180];
           //}

           //    //输出OutPutNum[181]~OutPutNum[1000]的值，按照四次方程输出

           //for (long i = 181; i < 1000;i++ )
           //{
           //    OutPutNum[i] = Convert.ToInt32(A * i * i * i * i + B * i * i * i + C * i * i + D * i + E);
           //    if (OutPutNum[i] > OutPutNum[1000])
           //        OutPutNum[i] = OutPutNum[1000];
           //}

           //    //输出OutPutNum[1001]~OutPutNum[1023]的值，均等于OutPutNum[1000]
           //for (int i = 1001; i < OutPutNum.Length;i++ )
           //{
           //    OutPutNum[i] = OutPutNum[1000];
           //}


            // //输出OutPutNum[0]~OutPutNum[142]的值，既电流小于2.5A的情况

            for (int i = 0; i < 142; i++)
            {
                OutPutNum[i] = 0;
            }

            //    //输出OutPutNum[142]~OutPutNum[180]的值，均等于OutPutNum[180]
            ///////既2.5到2.8的值均等于2.8

            for (int i = 142; i < 180; i++)
            {
                OutPutNum[i] = OutPutNum[180];
            }

               //一级光之前的数据填充OutPutNum[0]~OutPutNum[179]
               //for(int i=0;i<=179;i++)
               //{
               //    OutPutNum[i] = 0;
               //}

               //一级光与二级光之间的数据填充OutPutNum[180]~OutPutNum[264]
               int grap2 = EqualDifference(OutPutNum[180], OutPutNum[207], 27);

               //显示grap2的计算结果
               //label2.Text = Convert.ToString(grap2);

               for (int i = 180; i < 207 - 1; i++)
               {
                   OutPutNum[i+1] = OutPutNum[i] + grap2;
                   if (OutPutNum[i + 1] > OutPutNum[207])
                       OutPutNum[i + 1] = OutPutNum[207];
               }

               //显示OutPutNum[181]的值
               //label3.Text = Convert.ToString(OutPutNum[181]);

               
               int grap3 = EqualDifference(OutPutNum[207], OutPutNum[235], 28);
               for (int i = 207; i < 235 - 1; i++)
               {
                   OutPutNum[i+1] = OutPutNum[i] + grap3;
                   if (OutPutNum[i + 1] > OutPutNum[235])
                       OutPutNum[i + 1] = OutPutNum[235];
               }

              
               int grap4 = EqualDifference(OutPutNum[235], OutPutNum[265], 30);
               for (int i = 235; i < 265 - 1; i++)
               {
                   OutPutNum[i+1] = OutPutNum[i] + grap4;
                   if (OutPutNum[i + 1] > OutPutNum[265])
                       OutPutNum[i + 1] = OutPutNum[265];
               }

               
               //二级光与三级光之间的数据填充OutPutNum[265]~OutPutNum[385]
               int grap5 = EqualDifference(OutPutNum[265], OutPutNum[298], 33);
               for (int i = 265; i < 298 - 1; i++)
               {
                   OutPutNum[i+1] = OutPutNum[i] + grap5;

                   //防止溢出
                   if (OutPutNum[i + 1] > OutPutNum[298])
                       OutPutNum[i + 1] = OutPutNum[298];
               }

               int grap6 = EqualDifference(OutPutNum[298], OutPutNum[331], 33);
               for (int i = 298; i < 331 - 1; i++)
               {
                   OutPutNum[i + 1] = OutPutNum[i] + grap6;

                   //防止溢出
                   if (OutPutNum[i + 1] > OutPutNum[331])
                       OutPutNum[i + 1] = OutPutNum[331];
               }

               int grap7 = EqualDifference(OutPutNum[331], OutPutNum[367], 36);
               for (int i = 331; i < 367 - 1; i++)
               {
                   OutPutNum[i + 1] = OutPutNum[i] + grap7;

                   //防止溢出
                   if (OutPutNum[i + 1] > OutPutNum[367])
                       OutPutNum[i + 1] = OutPutNum[367];
               }


               int grap8 = EqualDifference(OutPutNum[367], OutPutNum[386], 19);
               for (int i = 367; i < 386 - 1; i++)
               {
                   OutPutNum[i + 1] = OutPutNum[i] + grap8;

                   //防止溢出
                   if (OutPutNum[i + 1] > OutPutNum[386])
                       OutPutNum[i + 1] = OutPutNum[386];
               }


               //三级光与四级光之间的数据填充OutPutNum[386]~OutPutNum[620]
               int grap9 = EqualDifference(OutPutNum[386], OutPutNum[424], 38);
               for (int i = 386; i < 424 - 1; i++)
               {
                   OutPutNum[i + 1] = OutPutNum[i] + grap9;

                   //防止溢出
                   if (OutPutNum[i + 1] > OutPutNum[424])
                       OutPutNum[i + 1] = OutPutNum[424];
               }

               int grap10 = EqualDifference(OutPutNum[424], OutPutNum[465], 41);
               for (int i = 424; i < 465 - 1; i++)
               {
                   OutPutNum[i + 1] = OutPutNum[i] + grap10;

                   //防止溢出
                   if (OutPutNum[i + 1] > OutPutNum[465])
                       OutPutNum[i + 1] = OutPutNum[465];
               }

               int grap11 = EqualDifference(OutPutNum[465], OutPutNum[507], 42);
               for (int i = 465; i < 507 - 1; i++)
               {
                   OutPutNum[i + 1] = OutPutNum[i] + grap11;

                   //防止溢出
                   if (OutPutNum[i + 1] >OutPutNum[507])
                       OutPutNum[i + 1] = OutPutNum[507];
               }

               int grap12 = EqualDifference(OutPutNum[507], OutPutNum[551], 44);
               for (int i = 507; i < 551 - 1; i++)
               {
                   OutPutNum[i + 1] = OutPutNum[i] + grap12;

                   //防止溢出
                   if (OutPutNum[i + 1] > OutPutNum[551])
                       OutPutNum[i + 1] = OutPutNum[551];
               }

               int grap13= EqualDifference(OutPutNum[551], OutPutNum[597], 46);
               for (int i = 551; i < 597 - 1; i++)
               {
                   OutPutNum[i + 1] = OutPutNum[i] + grap13;

                   //防止溢出
                   if (OutPutNum[i + 1] > OutPutNum[597])
                       OutPutNum[i + 1] = OutPutNum[597];
               }

               int grap14 = EqualDifference(OutPutNum[597], OutPutNum[621], 24);
               for (int i = 597; i < 621 - 1; i++)
               {
                   OutPutNum[i + 1] = OutPutNum[i] + grap14;

                   //防止溢出
                   if (OutPutNum[i + 1] > OutPutNum[621])
                       OutPutNum[i + 1] = OutPutNum[621];
               }


               //四级光与五级光之间的数据填充OutPutNum[621]~OutPutNum[999]
               int grap15 = EqualDifference(OutPutNum[621], OutPutNum[669], 48);
               for (int i = 621; i < 669 - 1; i++)
               {
                   OutPutNum[i + 1] = OutPutNum[i] + grap15;

                   //防止溢出
                   if (OutPutNum[i + 1] > OutPutNum[669])
                       OutPutNum[i + 1] = OutPutNum[669];
               }

               int grap16 = EqualDifference(OutPutNum[669], OutPutNum[720], 51);
               for (int i = 669; i < 720 - 1; i++)
               {
                   OutPutNum[i + 1] = OutPutNum[i] + grap16;

                   //防止溢出
                   if (OutPutNum[i + 1] > OutPutNum[720])
                       OutPutNum[i + 1] = OutPutNum[720];
               }

               int grap17= EqualDifference(OutPutNum[720], OutPutNum[772], 52);
               for (int i = 720; i < 772 - 1; i++)
               {
                   OutPutNum[i + 1] = OutPutNum[i] + grap17;

                   //防止溢出
                   if (OutPutNum[i + 1] > OutPutNum[772])
                       OutPutNum[i + 1] = OutPutNum[772];
               }

               int grap18 = EqualDifference(OutPutNum[772], OutPutNum[826], 54);
               for (int i = 772; i < 826-1; i++)
               {
                   OutPutNum[i + 1] = OutPutNum[i] + grap18;

                   //防止溢出
                   if (OutPutNum[i + 1] > OutPutNum[826])
                       OutPutNum[i + 1] = OutPutNum[826];
               }


               int grap19 = EqualDifference(OutPutNum[826], OutPutNum[882], 56);
               for (int i = 826; i < 882-1; i++)
               {
                   OutPutNum[i + 1] = OutPutNum[i] + grap19;

                   //防止溢出
                   if (OutPutNum[i + 1] > OutPutNum[882])
                       OutPutNum[i + 1] = OutPutNum[882];
               }

               int grap20 = EqualDifference(OutPutNum[882], OutPutNum[940], 58);
               for (int i = 882; i < 940-1; i++)
               {
                   OutPutNum[i + 1] = OutPutNum[i] + grap20;

                   //防止溢出
                   if (OutPutNum[i + 1] > OutPutNum[940])
                       OutPutNum[i + 1] = OutPutNum[940];
               }

               int grap21 = EqualDifference(OutPutNum[940], OutPutNum[1000], 58);
               for (int i = 940; i < 1000-1; i++)
               {
                   OutPutNum[i + 1] = OutPutNum[i] + grap21;

                   //防止溢出
                   if (OutPutNum[i + 1] > OutPutNum[1000])
                       OutPutNum[i + 1] = OutPutNum[1000];
               }


               //五级光之后的数据填充OutPutNum[1000]~OutPutNum[1023]
               for (int i = 1000; i < OutPutNum.Length; i++)
               {
                    OutPutNum[i] = 9999;
               }

               //显示计算完成，可以保存
               label1.Text = "计算完成，请保存！";

        }


        //自定义函数

        //计算等差grap的函数
        public int EqualDifference(int head, int end, int num)
        {
            int grap=1;
            grap += (end - head) / num;
            return grap;
        }


        //trackBar的数据与textBox的数据转换函数（省略）


        //输出数组OutPutNum[]的所有内容到文本文档OutPutNum.txt中
        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "已保存在D盘\n\nOutPutNum.txt\n\n文件中！";
            using (StreamWriter sw=new StreamWriter(@"D:\OutPutNum.txt"))
            {
                for(int i=0;i<OutPutNum.Length;i++)
                {
                    sw.WriteLine(OutPutNum[i] + ",\n");
                    //"Line"+i+"   " + 
                    //,
                }
            }
        }


        //软件打开后的初始显示控制
        private void Form1_Load(object sender, EventArgs e)
        {
            //显示系统默认数值，以trackBar的数据为准，分别赋值给textBox和数组OutPutNum

            textBox1.Text = Convert.ToString(trackBar1.Value/99.99);// 百分比
            textBox46.Text = Convert.ToString(trackBar1.Value);// 实际PWM值

            textBox2.Text = Convert.ToString(trackBar2.Value/99.99);
            textBox45.Text = Convert.ToString(trackBar2.Value);


            textBox3.Text = Convert.ToString(trackBar3.Value/99.99);
            textBox44.Text = Convert.ToString(trackBar3.Value);


            textBox4.Text = Convert.ToString(trackBar4.Value / 99.99);
            textBox43.Text = Convert.ToString(trackBar4.Value);


            textBox5.Text = Convert.ToString(trackBar5.Value / 99.99);
            textBox42.Text = Convert.ToString(trackBar5.Value);

            textBox6.Text = Convert.ToString(trackBar6.Value / 99.99);
            textBox41.Text = Convert.ToString(trackBar6.Value);


            textBox7.Text = Convert.ToString(trackBar7.Value / 99.99);
            textBox40.Text = Convert.ToString(trackBar7.Value);


            textBox8.Text = Convert.ToString(trackBar8.Value / 99.99);
            textBox39.Text = Convert.ToString(trackBar8.Value);


            textBox9.Text = Convert.ToString(trackBar9.Value / 99.99);
            textBox38.Text = Convert.ToString(trackBar9.Value);


            //textBox10.Text = Convert.ToString(9999);
            textBox11.Text = Convert.ToString(trackBar11.Value / 99.99);
            textBox37.Text = Convert.ToString(trackBar11.Value);


            textBox12.Text = Convert.ToString(trackBar12.Value / 99.99);
            textBox36.Text = Convert.ToString(trackBar12.Value);


            textBox13.Text = Convert.ToString(trackBar13.Value / 99.99);
            textBox35.Text = Convert.ToString(trackBar13.Value);


            textBox14.Text = Convert.ToString(trackBar14.Value / 99.99);
            textBox34.Text = Convert.ToString(trackBar14.Value);


            textBox15.Text = Convert.ToString(trackBar15.Value / 99.99);
            textBox33.Text = Convert.ToString(trackBar15.Value);


            textBox16.Text = Convert.ToString(trackBar16.Value / 99.99);
            textBox32.Text = Convert.ToString(trackBar16.Value);


            textBox17.Text = Convert.ToString(trackBar17.Value / 99.99);
            textBox31.Text = Convert.ToString(trackBar17.Value);


            textBox18.Text = Convert.ToString(trackBar18.Value / 99.99);
            textBox30.Text = Convert.ToString(trackBar18.Value);


            textBox19.Text = Convert.ToString(trackBar19.Value / 99.99);
            textBox29.Text = Convert.ToString(trackBar19.Value);


            textBox20.Text = Convert.ToString(trackBar20.Value / 99.99);
            textBox28.Text = Convert.ToString(trackBar20.Value);


            textBox21.Text = Convert.ToString(trackBar21.Value / 99.99);
            textBox27.Text = Convert.ToString(trackBar21.Value);


            textBox22.Text = Convert.ToString(trackBar22.Value / 99.99);
            textBox26.Text = Convert.ToString(trackBar22.Value);


            textBox23.Text = Convert.ToString(trackBar23.Value / 99.99);
            textBox25.Text = Convert.ToString(trackBar23.Value);


            textBox24.Text = Convert.ToString(trackBar24.Value / 99.99);
            textBox10.Text = Convert.ToString(trackBar24.Value);

            

            //初始化OutPutNum[]数组对应五个光级的数值
            //开头
            OutPutNum[167] = Convert.ToInt32(trackBar1.Value);
            //一级光
            OutPutNum[180] = Convert.ToInt32(trackBar2.Value);
            OutPutNum[207] = Convert.ToInt32(trackBar3.Value);
            OutPutNum[235] = Convert.ToInt32(trackBar4.Value);
            //二级光
            OutPutNum[265] = Convert.ToInt32(trackBar5.Value);
            OutPutNum[298] = Convert.ToInt32(trackBar6.Value);
            OutPutNum[331] = Convert.ToInt32(trackBar7.Value);
            OutPutNum[367] = Convert.ToInt32(trackBar8.Value);
            //三级光
            OutPutNum[386] = Convert.ToInt32(trackBar9.Value);
            OutPutNum[424] = Convert.ToInt32(trackBar11.Value);
            OutPutNum[465] = Convert.ToInt32(trackBar12.Value);
            OutPutNum[507] = Convert.ToInt32(trackBar13.Value);
            OutPutNum[551] = Convert.ToInt32(trackBar14.Value);
            OutPutNum[597] = Convert.ToInt32(trackBar15.Value);
            //四级光
            OutPutNum[621] = Convert.ToInt32(trackBar16.Value);
            OutPutNum[669] = Convert.ToInt32(trackBar17.Value);
            OutPutNum[720] = Convert.ToInt32(trackBar18.Value);
            OutPutNum[772] = Convert.ToInt32(trackBar19.Value);
            OutPutNum[826] = Convert.ToInt32(trackBar20.Value);
            OutPutNum[882] = Convert.ToInt32(trackBar21.Value);
            OutPutNum[940] = Convert.ToInt32(trackBar22.Value);
            //五级光
            OutPutNum[1000] = Convert.ToInt32(trackBar23.Value);
            //结尾
            OutPutNum[1023] = Convert.ToInt32(trackBar24.Value);

            //trackBar1.Value = 9999;

            

        }



//****************************设置textbox的可修改功能********************************//
        private void textBox24_TextChanged(object sender, EventArgs e)
        {
            //trackBar24.Value = Convert.ToInt32(textBox24.Text);
            
            if(textBox24.Text!="" && textBox24.Text!=" ")
            {
                //if (100 >= Convert.ToInt32(textBox24.Text))
                {
                    double temp = 0;
                    temp = Convert.ToDouble(textBox24.Text);
                    if(temp<=100)
                    {
                        temp *= 99.99;
                        OutPutNum[1023] = Convert.ToInt32(temp);
                        trackBar24.Value = Convert.ToInt32(temp);
                        textBox10.Text = Convert.ToString(temp);
                    }
                    else
                    {
                        MessageBox.Show("请输入0~100的数字！");
                        textBox24.Clear();

                    }

                }
                //else if (textBox24.Text == null)

                //    MessageBox.Show("请输入0~100的数字！");
                //else
                //    MessageBox.Show("请输入0~100的数字！");
            }
           

        }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {
            if(textBox23.Text!="" && textBox23.Text!=" ")
            {
                //if (100 >= Convert.ToInt32(textBox24.Text))
                
                    double temp = 0;
                    temp = Convert.ToDouble(textBox23.Text);
                    if(temp<=100)
                    {
                        temp *= 99.99;
                        OutPutNum[1000] = Convert.ToInt32(temp);
                        trackBar23.Value = Convert.ToInt32(temp);
                        textBox25.Text = Convert.ToString(temp);
                    }
                    else
                    {
                        MessageBox.Show("请输入0~100的数字！");
                        textBox23.Clear();

                    }

                }
        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {
            if (textBox22.Text != "" && textBox22.Text != " ")
            {
                //if (100 >= Convert.ToInt32(textBox24.Text))

                double temp = 0;
                temp = Convert.ToDouble(textBox22.Text);
                if (temp <= 100)
                {
                    temp *= 99.99;
                    OutPutNum[940] = Convert.ToInt32(temp);
                    trackBar22.Value = Convert.ToInt32(temp);
                    textBox26.Text = Convert.ToString(temp);
                }
                else
                {
                    MessageBox.Show("请输入0~100的数字！");
                    textBox22.Clear();

                }

            }
        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {
            if (textBox21.Text != "" && textBox21.Text != " ")
            {
                //if (100 >= Convert.ToInt32(textBox24.Text))

                double temp = 0;
                temp = Convert.ToDouble(textBox21.Text);
                if (temp <= 100)
                {
                    temp *= 99.99;
                    OutPutNum[882] = Convert.ToInt32(temp);
                    trackBar21.Value = Convert.ToInt32(temp);
                    textBox27.Text = Convert.ToString(temp);
                }
                else
                {
                    MessageBox.Show("请输入0~100的数字！");
                    textBox21.Clear();

                }

            }
        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {
            if (textBox20.Text != "" && textBox20.Text != " ")
            {
                //if (100 >= Convert.ToInt32(textBox24.Text))

                double temp = 0;
                temp = Convert.ToDouble(textBox20.Text);
                if (temp <= 100)
                {
                    temp *= 99.99;
                    OutPutNum[826] = Convert.ToInt32(temp);
                    trackBar20.Value = Convert.ToInt32(temp);
                    textBox28.Text = Convert.ToString(temp);
                }
                else
                {
                    MessageBox.Show("请输入0~100的数字！");
                    textBox20.Clear();

                }

            }
        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {
            if (textBox19.Text != "" && textBox19.Text != " ")
            {
                //if (100 >= Convert.ToInt32(textBox24.Text))

                double temp = 0;
                temp = Convert.ToDouble(textBox19.Text);
                if (temp <= 100)
                {
                    temp *= 99.99;
                    OutPutNum[772] = Convert.ToInt32(temp);
                    trackBar19.Value = Convert.ToInt32(temp);
                    textBox29.Text = Convert.ToString(temp);
                }
                else
                {
                    MessageBox.Show("请输入0~100的数字！");
                    textBox19.Clear();

                }

            }
        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {
            if (textBox18.Text != "" && textBox18.Text != " ")
            {
                //if (100 >= Convert.ToInt32(textBox24.Text))

                double temp = 0;
                temp = Convert.ToDouble(textBox18.Text);
                if (temp <= 100)
                {
                    temp *= 99.99;
                    OutPutNum[720] = Convert.ToInt32(temp);
                    trackBar18.Value = Convert.ToInt32(temp);
                    textBox30.Text = Convert.ToString(temp);
                }
                else
                {
                    MessageBox.Show("请输入0~100的数字！");
                    textBox18.Clear();

                }

            }
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            if (textBox10.Text != "" && textBox10.Text != " ")
            {
                //if (100 >= Convert.ToInt32(textBox24.Text))

                double temp = 0;
                temp = Convert.ToDouble(textBox10.Text);
                if (temp <= 9999)
                {
                    OutPutNum[1023] = Convert.ToInt32(temp);
                    trackBar24.Value = Convert.ToInt32(temp);
                    temp /= 99.99;
                    textBox24.Text = Convert.ToString(temp);
                }
                else
                {
                    MessageBox.Show("请输入0~9999的数字！");
                    textBox10.Clear();

                }

            }
        }

        private void textBox25_TextChanged(object sender, EventArgs e)
        {
            if (textBox25.Text != "" && textBox25.Text != " ")
            {
                //if (100 >= Convert.ToInt32(textBox24.Text))

                double temp = 0;
                temp = Convert.ToDouble(textBox25.Text);
                if (temp <= 9999)
                {
                    OutPutNum[1000] = Convert.ToInt32(temp);
                    trackBar23.Value = Convert.ToInt32(temp);
                    temp /= 99.99;
                    textBox23.Text = Convert.ToString(temp);
                }
                else
                {
                    MessageBox.Show("请输入0~9999的数字！");
                    textBox25.Clear();

                }

            }
        }

        private void textBox26_TextChanged(object sender, EventArgs e)
        {
            if (textBox26.Text != "" && textBox26.Text != " ")
            {
                //if (100 >= Convert.ToInt32(textBox24.Text))

                double temp = 0;
                temp = Convert.ToDouble(textBox26.Text);
                if (temp <= 9999)
                {
                    OutPutNum[940] = Convert.ToInt32(temp);
                    trackBar22.Value = Convert.ToInt32(temp);
                    temp /= 99.99;
                    textBox22.Text = Convert.ToString(temp);
                }
                else
                {
                    MessageBox.Show("请输入0~9999的数字！");
                    textBox26.Clear();

                }

            }
        }

        private void textBox27_TextChanged(object sender, EventArgs e)
        {
            if (textBox27.Text != "" && textBox27.Text != " ")
            {
                //if (100 >= Convert.ToInt32(textBox24.Text))

                double temp = 0;
                temp = Convert.ToDouble(textBox27.Text);
                if (temp <= 9999)
                {
                    OutPutNum[882] = Convert.ToInt32(temp);
                    trackBar21.Value = Convert.ToInt32(temp);
                    temp /= 99.99;
                    textBox21.Text = Convert.ToString(temp);
                }
                else
                {
                    MessageBox.Show("请输入0~9999的数字！");
                    textBox27.Clear();

                }

            }
        }

        private void textBox28_TextChanged(object sender, EventArgs e)
        {
            if (textBox28.Text != "" && textBox28.Text != " ")
            {
                //if (100 >= Convert.ToInt32(textBox24.Text))

                double temp = 0;
                temp = Convert.ToDouble(textBox28.Text);
                if (temp <= 9999)
                {
                    OutPutNum[826] = Convert.ToInt32(temp);
                    trackBar20.Value = Convert.ToInt32(temp);
                    temp /= 99.99;
                    textBox20.Text = Convert.ToString(temp);
                }
                else
                {
                    MessageBox.Show("请输入0~9999的数字！");
                    textBox28.Clear();

                }

            }
        }

        private void textBox29_TextChanged(object sender, EventArgs e)
        {
            if (textBox29.Text != "" && textBox29.Text != " ")
            {
                //if (100 >= Convert.ToInt32(textBox24.Text))

                double temp = 0;
                temp = Convert.ToDouble(textBox29.Text);
                if (temp <= 9999)
                {
                    OutPutNum[772] = Convert.ToInt32(temp);
                    trackBar19.Value = Convert.ToInt32(temp);
                    temp /= 99.99;
                    textBox19.Text = Convert.ToString(temp);
                }
                else
                {
                    MessageBox.Show("请输入0~9999的数字！");
                    textBox29.Clear();

                }

            }
        }

        private void textBox30_TextChanged(object sender, EventArgs e)
        {
            if (textBox30.Text != "" && textBox30.Text != " ")
            {
                //if (100 >= Convert.ToInt32(textBox24.Text))

                double temp = 0;
                temp = Convert.ToDouble(textBox30.Text);
                if (temp <= 9999)
                {
                    OutPutNum[720] = Convert.ToInt32(temp);
                    trackBar18.Value = Convert.ToInt32(temp);
                    temp /= 99.99;
                    textBox18.Text = Convert.ToString(temp);
                }
                else
                {
                    MessageBox.Show("请输入0~9999的数字！");
                    textBox30.Clear();

                }

            }
        }

        private void textBox31_TextChanged(object sender, EventArgs e)
        {
            if (textBox31.Text != "" && textBox31.Text != " ")
            {
                //if (100 >= Convert.ToInt32(textBox24.Text))

                double temp = 0;
                temp = Convert.ToDouble(textBox31.Text);
                if (temp <= 9999)
                {
                    OutPutNum[669] = Convert.ToInt32(temp);
                    trackBar17.Value = Convert.ToInt32(temp);
                    temp /= 99.99;
                    textBox17.Text = Convert.ToString(temp);
                }
                else
                {
                    MessageBox.Show("请输入0~9999的数字！");
                    textBox31.Clear();

                }

            }
        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {
            if (textBox17.Text != "" && textBox17.Text != " ")
            {
                //if (100 >= Convert.ToInt32(textBox24.Text))

                double temp = 0;
                temp = Convert.ToDouble(textBox17.Text);
                if (temp <= 100)
                {
                    temp *= 99.99;
                    OutPutNum[669] = Convert.ToInt32(temp);
                    trackBar17.Value = Convert.ToInt32(temp);
                    textBox31.Text = Convert.ToString(temp);
                }
                else
                {
                    MessageBox.Show("请输入0~100的数字！");
                    textBox17.Clear();

                }

            }
        }

        private void textBox32_TextChanged(object sender, EventArgs e)
        {
            if (textBox32.Text != "" && textBox32.Text != " ")
            {
                //if (100 >= Convert.ToInt32(textBox24.Text))

                double temp = 0;
                temp = Convert.ToDouble(textBox32.Text);
                if (temp <= 9999)
                {
                    OutPutNum[621] = Convert.ToInt32(temp);
                    trackBar16.Value = Convert.ToInt32(temp);
                    temp /= 99.99;
                    textBox16.Text = Convert.ToString(temp);
                }
                else
                {
                    MessageBox.Show("请输入0~9999的数字！");
                    textBox32.Clear();

                }

            }
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            if (textBox16.Text != "" && textBox16.Text != " ")
            {
                //if (100 >= Convert.ToInt32(textBox24.Text))

                double temp = 0;
                temp = Convert.ToDouble(textBox16.Text);
                if (temp <= 100)
                {
                    temp *= 99.99;
                    OutPutNum[621] = Convert.ToInt32(temp);
                    trackBar16.Value = Convert.ToInt32(temp);
                    textBox32.Text = Convert.ToString(temp);
                }
                else
                {
                    MessageBox.Show("请输入0~100的数字！");
                    textBox16.Clear();

                }

            }
        }

        private void textBox33_TextChanged(object sender, EventArgs e)
        {
            if (textBox33.Text != "" && textBox33.Text != " ")
            {
                //if (100 >= Convert.ToInt32(textBox24.Text))

                double temp = 0;
                temp = Convert.ToDouble(textBox33.Text);
                if (temp <= 9999)
                {
                    OutPutNum[597] = Convert.ToInt32(temp);
                    trackBar15.Value = Convert.ToInt32(temp);
                    temp /= 99.99;
                    textBox15.Text = Convert.ToString(temp);
                }
                else
                {
                    MessageBox.Show("请输入0~9999的数字！");
                    textBox33.Clear();

                }

            }
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            if (textBox15.Text != "" && textBox15.Text != " ")
            {
                //if (100 >= Convert.ToInt32(textBox24.Text))

                double temp = 0;
                temp = Convert.ToDouble(textBox15.Text);
                if (temp <= 100)
                {
                    temp *= 99.99;
                    OutPutNum[597] = Convert.ToInt32(temp);
                    trackBar15.Value = Convert.ToInt32(temp);
                    textBox33.Text = Convert.ToString(temp);
                }
                else
                {
                    MessageBox.Show("请输入0~100的数字！");
                    textBox15.Clear();

                }

            }
        }

        private void textBox34_TextChanged(object sender, EventArgs e)
        {
            if (textBox34.Text != "" && textBox34.Text != " ")
            {
                //if (100 >= Convert.ToInt32(textBox24.Text))

                double temp = 0;
                temp = Convert.ToDouble(textBox34.Text);
                if (temp <= 9999)
                {
                    OutPutNum[551] = Convert.ToInt32(temp);
                    trackBar14.Value = Convert.ToInt32(temp);
                    temp /= 99.99;
                    textBox14.Text = Convert.ToString(temp);
                }
                else
                {
                    MessageBox.Show("请输入0~9999的数字！");
                    textBox34.Clear();

                }

            }
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            if (textBox14.Text != "" && textBox14.Text != " ")
            {
                //if (100 >= Convert.ToInt32(textBox24.Text))

                double temp = 0;
                temp = Convert.ToDouble(textBox14.Text);
                if (temp <= 100)
                {
                    temp *= 99.99;
                    OutPutNum[551] = Convert.ToInt32(temp);
                    trackBar14.Value = Convert.ToInt32(temp);
                    textBox34.Text = Convert.ToString(temp);
                }
                else
                {
                    MessageBox.Show("请输入0~100的数字！");
                    textBox14.Clear();

                }

            }
        }

        private void textBox35_TextChanged(object sender, EventArgs e)
        {
            if (textBox35.Text != "" && textBox35.Text != " ")
            {
                //if (100 >= Convert.ToInt32(textBox24.Text))

                double temp = 0;
                temp = Convert.ToDouble(textBox35.Text);
                if (temp <= 9999)
                {
                    OutPutNum[507] = Convert.ToInt32(temp);
                    trackBar13.Value = Convert.ToInt32(temp);
                    temp /= 99.99;
                    textBox13.Text = Convert.ToString(temp);
                }
                else
                {
                    MessageBox.Show("请输入0~9999的数字！");
                    textBox35.Clear();

                }

            }
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            if (textBox13.Text != "" && textBox13.Text != " ")
            {
                //if (100 >= Convert.ToInt32(textBox24.Text))

                double temp = 0;
                temp = Convert.ToDouble(textBox13.Text);
                if (temp <= 100)
                {
                    temp *= 99.99;
                    OutPutNum[507] = Convert.ToInt32(temp);
                    trackBar13.Value = Convert.ToInt32(temp);
                    textBox35.Text = Convert.ToString(temp);
                }
                else
                {
                    MessageBox.Show("请输入0~100的数字！");
                    textBox13.Clear();

                }

            }
        }

        private void textBox36_TextChanged(object sender, EventArgs e)
        {
            if (textBox36.Text != "" && textBox36.Text != " ")
            {
                //if (100 >= Convert.ToInt32(textBox24.Text))

                double temp = 0;
                temp = Convert.ToDouble(textBox36.Text);
                if (temp <= 9999)
                {
                    OutPutNum[465] = Convert.ToInt32(temp);
                    trackBar12.Value = Convert.ToInt32(temp);
                    temp /= 99.99;
                    textBox12.Text = Convert.ToString(temp);
                }
                else
                {
                    MessageBox.Show("请输入0~9999的数字！");
                    textBox36.Clear();

                }

            }
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            if (textBox12.Text != "" && textBox12.Text != " ")
            {
                //if (100 >= Convert.ToInt32(textBox24.Text))

                double temp = 0;
                temp = Convert.ToDouble(textBox12.Text);
                if (temp <= 100)
                {
                    temp *= 99.99;
                    OutPutNum[465] = Convert.ToInt32(temp);
                    trackBar12.Value = Convert.ToInt32(temp);
                    textBox36.Text = Convert.ToString(temp);
                }
                else
                {
                    MessageBox.Show("请输入0~100的数字！");
                    textBox12.Clear();

                }

            }
        }

        private void textBox37_TextChanged(object sender, EventArgs e)
        {
            if (textBox37.Text != "" && textBox37.Text != " ")
            {
                //if (100 >= Convert.ToInt32(textBox24.Text))

                double temp = 0;
                temp = Convert.ToDouble(textBox37.Text);
                if (temp <= 9999)
                {
                    OutPutNum[424] = Convert.ToInt32(temp);
                    trackBar11.Value = Convert.ToInt32(temp);
                    temp /= 99.99;
                    textBox11.Text = Convert.ToString(temp);
                }
                else
                {
                    MessageBox.Show("请输入0~9999的数字！");
                    textBox37.Clear();

                }

            }
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            if (textBox11.Text != "" && textBox11.Text != " ")
            {
                //if (100 >= Convert.ToInt32(textBox24.Text))

                double temp = 0;
                temp = Convert.ToDouble(textBox11.Text);
                if (temp <= 100)
                {
                    temp *= 99.99;
                    OutPutNum[424] = Convert.ToInt32(temp);
                    trackBar11.Value = Convert.ToInt32(temp);
                    textBox37.Text = Convert.ToString(temp);
                }
                else
                {
                    MessageBox.Show("请输入0~100的数字！");
                    textBox11.Clear();

                }

            }
        }

        private void textBox38_TextChanged(object sender, EventArgs e)
        {
            if (textBox38.Text != "" && textBox38.Text != " ")
            {
                //if (100 >= Convert.ToInt32(textBox24.Text))

                double temp = 0;
                temp = Convert.ToDouble(textBox38.Text);
                if (temp <= 9999)
                {
                    OutPutNum[386] = Convert.ToInt32(temp);
                    trackBar9.Value = Convert.ToInt32(temp);
                    temp /= 99.99;
                    textBox9.Text = Convert.ToString(temp);
                }
                else
                {
                    MessageBox.Show("请输入0~9999的数字！");
                    textBox38.Clear();

                }

            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            if (textBox9.Text != "" && textBox9.Text != " ")
            {
                //if (100 >= Convert.ToInt32(textBox24.Text))

                double temp = 0;
                temp = Convert.ToDouble(textBox9.Text);
                if (temp <= 100)
                {
                    temp *= 99.99;
                    OutPutNum[424] = Convert.ToInt32(temp);
                    trackBar9.Value = Convert.ToInt32(temp);
                    textBox38.Text = Convert.ToString(temp);
                }
                else
                {
                    MessageBox.Show("请输入0~100的数字！");
                    textBox9.Clear();

                }

            }
        }

        private void textBox39_TextChanged(object sender, EventArgs e)
        {
            if (textBox39.Text != "" && textBox39.Text != " ")
            {
                //if (100 >= Convert.ToInt32(textBox24.Text))

                double temp = 0;
                temp = Convert.ToDouble(textBox39.Text);
                if (temp <= 9999)
                {
                    OutPutNum[367] = Convert.ToInt32(temp);
                    trackBar8.Value = Convert.ToInt32(temp);
                    temp /= 99.99;
                    textBox8.Text = Convert.ToString(temp);
                }
                else
                {
                    MessageBox.Show("请输入0~9999的数字！");
                    textBox39.Clear();

                }

            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            if (textBox8.Text != "" && textBox8.Text != " ")
            {
                //if (100 >= Convert.ToInt32(textBox24.Text))

                double temp = 0;
                temp = Convert.ToDouble(textBox8.Text);
                if (temp <= 100)
                {
                    temp *= 99.99;
                    OutPutNum[367] = Convert.ToInt32(temp);
                    trackBar8.Value = Convert.ToInt32(temp);
                    textBox39.Text = Convert.ToString(temp);
                }
                else
                {
                    MessageBox.Show("请输入0~100的数字！");
                    textBox8.Clear();

                }

            }
        }

        private void textBox40_TextChanged(object sender, EventArgs e)
        {
            if (textBox40.Text != "" && textBox40.Text != " ")
            {
                //if (100 >= Convert.ToInt32(textBox24.Text))

                double temp = 0;
                temp = Convert.ToDouble(textBox40.Text);
                if (temp <= 9999)
                {
                    OutPutNum[331] = Convert.ToInt32(temp);
                    trackBar7.Value = Convert.ToInt32(temp);
                    temp /= 99.99;
                    textBox7.Text = Convert.ToString(temp);
                }
                else
                {
                    MessageBox.Show("请输入0~9999的数字！");
                    textBox40.Clear();

                }

            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (textBox7.Text != "" && textBox7.Text != " ")
            {
                //if (100 >= Convert.ToInt32(textBox24.Text))

                double temp = 0;
                temp = Convert.ToDouble(textBox7.Text);
                if (temp <= 100)
                {
                    temp *= 99.99;
                    OutPutNum[331] = Convert.ToInt32(temp);
                    trackBar7.Value = Convert.ToInt32(temp);
                    textBox40.Text = Convert.ToString(temp);
                }
                else
                {
                    MessageBox.Show("请输入0~100的数字！");
                    textBox7.Clear();

                }

            }
        }

        private void textBox41_TextChanged(object sender, EventArgs e)
        {
            if (textBox41.Text != "" && textBox41.Text != " ")
            {
                //if (100 >= Convert.ToInt32(textBox24.Text))

                double temp = 0;
                temp = Convert.ToDouble(textBox41.Text);
                if (temp <= 9999)
                {
                    OutPutNum[298] = Convert.ToInt32(temp);
                    trackBar6.Value = Convert.ToInt32(temp);
                    temp /= 99.99;
                    textBox6.Text = Convert.ToString(temp);
                }
                else
                {
                    MessageBox.Show("请输入0~9999的数字！");
                    textBox41.Clear();

                }

            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (textBox6.Text != "" && textBox6.Text != " ")
            {
                //if (100 >= Convert.ToInt32(textBox24.Text))

                double temp = 0;
                temp = Convert.ToDouble(textBox6.Text);
                if (temp <= 100)
                {
                    temp *= 99.99;
                    OutPutNum[298] = Convert.ToInt32(temp);
                    trackBar6.Value = Convert.ToInt32(temp);
                    textBox41.Text = Convert.ToString(temp);
                }
                else
                {
                    MessageBox.Show("请输入0~100的数字！");
                    textBox6.Clear();

                }

            }
        }

        private void textBox42_TextChanged(object sender, EventArgs e)
        {
            if (textBox42.Text != "" && textBox42.Text != " ")
            {
                //if (100 >= Convert.ToInt32(textBox24.Text))

                double temp = 0;
                temp = Convert.ToDouble(textBox42.Text);
                if (temp <= 9999)
                {
                    OutPutNum[265] = Convert.ToInt32(temp);
                    trackBar5.Value = Convert.ToInt32(temp);
                    temp /= 99.99;
                    textBox5.Text = Convert.ToString(temp);
                }
                else
                {
                    MessageBox.Show("请输入0~9999的数字！");
                    textBox42.Clear();

                }

            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.Text != "" && textBox5.Text != " ")
            {
                //if (100 >= Convert.ToInt32(textBox24.Text))

                double temp = 0;
                temp = Convert.ToDouble(textBox5.Text);
                if (temp <= 100)
                {
                    temp *= 99.99;
                    OutPutNum[265] = Convert.ToInt32(temp);
                    trackBar5.Value = Convert.ToInt32(temp);
                    textBox42.Text = Convert.ToString(temp);
                }
                else
                {
                    MessageBox.Show("请输入0~100的数字！");
                    textBox5.Clear();

                }

            }
        }

        private void textBox43_TextChanged(object sender, EventArgs e)
        {
            if (textBox43.Text != "" && textBox43.Text != " ")
            {
                //if (100 >= Convert.ToInt32(textBox24.Text))

                double temp = 0;
                temp = Convert.ToDouble(textBox43.Text);
                if (temp <= 9999)
                {
                    OutPutNum[235] = Convert.ToInt32(temp);
                    trackBar4.Value = Convert.ToInt32(temp);
                    temp /= 99.99;
                    textBox4.Text = Convert.ToString(temp);
                }
                else
                {
                    MessageBox.Show("请输入0~9999的数字！");
                    textBox43.Clear();

                }

            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text != "" && textBox4.Text != " ")
            {
                //if (100 >= Convert.ToInt32(textBox24.Text))

                double temp = 0;
                temp = Convert.ToDouble(textBox4.Text);
                if (temp <= 100)
                {
                    temp *= 99.99;
                    OutPutNum[235] = Convert.ToInt32(temp);
                    trackBar4.Value = Convert.ToInt32(temp);
                    textBox43.Text = Convert.ToString(temp);
                }
                else
                {
                    MessageBox.Show("请输入0~100的数字！");
                    textBox4.Clear();

                }

            }
        }

        private void textBox44_TextChanged(object sender, EventArgs e)
        {
            if (textBox44.Text != "" && textBox44.Text != " ")
            {
                //if (100 >= Convert.ToInt32(textBox24.Text))

                double temp = 0;
                temp = Convert.ToDouble(textBox44.Text);
                if (temp <= 9999)
                {
                    OutPutNum[207] = Convert.ToInt32(temp);
                    trackBar3.Value = Convert.ToInt32(temp);
                    temp /= 99.99;
                    textBox3.Text = Convert.ToString(temp);
                }
                else
                {
                    MessageBox.Show("请输入0~9999的数字！");
                    textBox44.Clear();

                }

            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text != "" && textBox3.Text != " ")
            {
                //if (100 >= Convert.ToInt32(textBox24.Text))

                double temp = 0;
                temp = Convert.ToDouble(textBox3.Text);
                if (temp <= 100)
                {
                    temp *= 99.99;
                    OutPutNum[207] = Convert.ToInt32(temp);
                    trackBar3.Value = Convert.ToInt32(temp);
                    textBox44.Text = Convert.ToString(temp);
                }
                else
                {
                    MessageBox.Show("请输入0~100的数字！");
                    textBox3.Clear();

                }

            }
        }

        private void textBox45_TextChanged(object sender, EventArgs e)
        {
            if (textBox45.Text != "" && textBox45.Text != " ")
            {
                //if (100 >= Convert.ToInt32(textBox24.Text))

                double temp = 0;
                temp = Convert.ToDouble(textBox45.Text);
                if (temp <= 9999)
                {
                    OutPutNum[180] = Convert.ToInt32(temp);
                    trackBar2.Value = Convert.ToInt32(temp);
                    temp /= 99.99;
                    textBox2.Text = Convert.ToString(temp);
                }
                else
                {
                    MessageBox.Show("请输入0~9999的数字！");
                    textBox45.Clear();

                }

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != "" && textBox2.Text != " ")
            {
                //if (100 >= Convert.ToInt32(textBox24.Text))

                double temp = 0;
                temp = Convert.ToDouble(textBox2.Text);
                if (temp <= 100)
                {
                    temp *= 99.99;
                    OutPutNum[180] = Convert.ToInt32(temp);
                    trackBar2.Value = Convert.ToInt32(temp);
                    textBox45.Text = Convert.ToString(temp);
                }
                else
                {
                    MessageBox.Show("请输入0~100的数字！");
                    textBox2.Clear();

                }

            }
        }

        private void textBox46_TextChanged(object sender, EventArgs e)
        {
            if (textBox46.Text != "" && textBox46.Text != " ")
            {
                //if (100 >= Convert.ToInt32(textBox24.Text))

                double temp = 0;
                temp = Convert.ToDouble(textBox46.Text);
                if (temp <= 9999)
                {
                    OutPutNum[167] = Convert.ToInt32(temp);
                    trackBar1.Value = Convert.ToInt32(temp);
                    temp /= 99.99;
                    textBox1.Text = Convert.ToString(temp);
                }
                else
                {
                    MessageBox.Show("请输入0~9999的数字！");
                    textBox46.Clear();

                }

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox1.Text != " ")
            {
                //if (100 >= Convert.ToInt32(textBox24.Text))

                double temp = 0;
                temp = Convert.ToDouble(textBox1.Text);
                if (temp <= 100)
                {
                    temp *= 99.99;
                    OutPutNum[167] = Convert.ToInt32(temp);
                    trackBar1.Value = Convert.ToInt32(temp);
                    textBox46.Text = Convert.ToString(temp);
                }
                else
                {
                    MessageBox.Show("请输入0~100的数字！");
                    textBox1.Clear();

                }

            }
        }

        
//***************************设置textbox的单击全选功能***************************//
        private void textBox24_Click(object sender, EventArgs e)
        {
            if (((TextBox)sender).Tag == null)
                ((TextBox)sender).SelectAll();
        }

        private void textBox23_Click(object sender, EventArgs e)
        {
            if (((TextBox)sender).Tag == null)
                ((TextBox)sender).SelectAll();
        }

        private void textBox22_Click(object sender, EventArgs e)
        {
            if (((TextBox)sender).Tag == null)
                ((TextBox)sender).SelectAll();
        }

        private void textBox21_Click(object sender, EventArgs e)
        {
            if (((TextBox)sender).Tag == null)
                ((TextBox)sender).SelectAll();
        }

        private void textBox20_Click(object sender, EventArgs e)
        {
            if (((TextBox)sender).Tag == null)
                ((TextBox)sender).SelectAll();
        }

        private void textBox19_Click(object sender, EventArgs e)
        {
            if (((TextBox)sender).Tag == null)
                ((TextBox)sender).SelectAll();
        }

        private void textBox18_Click(object sender, EventArgs e)
        {
            if (((TextBox)sender).Tag == null)
                ((TextBox)sender).SelectAll();
        }

        private void textBox17_Click(object sender, EventArgs e)
        {
            if (((TextBox)sender).Tag == null)
                ((TextBox)sender).SelectAll();
        }

        private void textBox16_Click(object sender, EventArgs e)
        {
            if (((TextBox)sender).Tag == null)
                ((TextBox)sender).SelectAll();
        }

        private void textBox15_Click(object sender, EventArgs e)
        {
            if (((TextBox)sender).Tag == null)
                ((TextBox)sender).SelectAll();
        }

        private void textBox14_Click(object sender, EventArgs e)
        {
            if (((TextBox)sender).Tag == null)
                ((TextBox)sender).SelectAll();
        }

        private void textBox13_Click(object sender, EventArgs e)
        {
            if (((TextBox)sender).Tag == null)
                ((TextBox)sender).SelectAll();
        }

        private void textBox12_Click(object sender, EventArgs e)
        {
            if (((TextBox)sender).Tag == null)
                ((TextBox)sender).SelectAll();
        }

        private void textBox11_Click(object sender, EventArgs e)
        {
            if (((TextBox)sender).Tag == null)
                ((TextBox)sender).SelectAll();
        }

        private void textBox9_Click(object sender, EventArgs e)
        {
            if (((TextBox)sender).Tag == null)
                ((TextBox)sender).SelectAll();
        }

        private void textBox8_Click(object sender, EventArgs e)
        {
            if (((TextBox)sender).Tag == null)
                ((TextBox)sender).SelectAll();
        }

        private void textBox7_Click(object sender, EventArgs e)
        {
            if (((TextBox)sender).Tag == null)
                ((TextBox)sender).SelectAll();
        }

        private void textBox6_Click(object sender, EventArgs e)
        {
            if (((TextBox)sender).Tag == null)
                ((TextBox)sender).SelectAll();
        }

        private void textBox5_Click(object sender, EventArgs e)
        {
            if (((TextBox)sender).Tag == null)
                ((TextBox)sender).SelectAll();
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            if (((TextBox)sender).Tag == null)
                ((TextBox)sender).SelectAll();
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            if (((TextBox)sender).Tag == null)
                ((TextBox)sender).SelectAll();
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            if (((TextBox)sender).Tag == null)
                ((TextBox)sender).SelectAll();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            //if (((TextBox)sender).Tag == null)
                ((TextBox)sender).SelectAll();
        }

        private void textBox46_Click(object sender, EventArgs e)
        {
            //if (((TextBox)sender).Tag == null)
                ((TextBox)sender).SelectAll();
        }

        private void textBox10_Click(object sender, EventArgs e)
        {
            //if (((TextBox)sender).Tag == null)
                ((TextBox)sender).SelectAll();
        }

        private void textBox25_Click(object sender, EventArgs e)
        {
            if (((TextBox)sender).Tag == null)
                ((TextBox)sender).SelectAll();
        }

        private void textBox26_Click(object sender, EventArgs e)
        {
            if (((TextBox)sender).Tag == null)
                ((TextBox)sender).SelectAll();
        }

        private void textBox27_Click(object sender, EventArgs e)
        {
            if (((TextBox)sender).Tag == null)
                ((TextBox)sender).SelectAll();
        }

        private void textBox28_Click(object sender, EventArgs e)
        {
            if (((TextBox)sender).Tag == null)
                ((TextBox)sender).SelectAll();
        }

        private void textBox29_Click(object sender, EventArgs e)
        {
            if (((TextBox)sender).Tag == null)
                ((TextBox)sender).SelectAll();
        }

        private void textBox30_Click(object sender, EventArgs e)
        {
            if (((TextBox)sender).Tag == null)
                ((TextBox)sender).SelectAll();
        }

        private void textBox31_Click(object sender, EventArgs e)
        {
            if (((TextBox)sender).Tag == null)
                ((TextBox)sender).SelectAll();
        }

        private void textBox32_Click(object sender, EventArgs e)
        {
            if (((TextBox)sender).Tag == null)
                ((TextBox)sender).SelectAll();
        }

        private void textBox33_Click(object sender, EventArgs e)
        {
            if (((TextBox)sender).Tag == null)
                ((TextBox)sender).SelectAll();
        }

        private void textBox34_Click(object sender, EventArgs e)
        {
            if (((TextBox)sender).Tag == null)
                ((TextBox)sender).SelectAll();
        }

        private void textBox35_Click(object sender, EventArgs e)
        {
            if (((TextBox)sender).Tag == null)
                ((TextBox)sender).SelectAll();
        }

        private void textBox36_Click(object sender, EventArgs e)
        {
            if (((TextBox)sender).Tag == null)
                ((TextBox)sender).SelectAll();
        }

        private void textBox37_Click(object sender, EventArgs e)
        {
            if (((TextBox)sender).Tag == null)
                ((TextBox)sender).SelectAll();
        }

        private void textBox38_Click(object sender, EventArgs e)
        {
            if (((TextBox)sender).Tag == null)
                ((TextBox)sender).SelectAll();
        }

        private void textBox39_Click(object sender, EventArgs e)
        {
            if (((TextBox)sender).Tag == null)
                ((TextBox)sender).SelectAll();
        }

        private void textBox40_Click(object sender, EventArgs e)
        {
            if (((TextBox)sender).Tag == null)
                ((TextBox)sender).SelectAll();
        }

        private void textBox41_Click(object sender, EventArgs e)
        {
            if (((TextBox)sender).Tag == null)
                ((TextBox)sender).SelectAll();
        }

        private void textBox42_Click(object sender, EventArgs e)
        {
            if (((TextBox)sender).Tag == null)
                ((TextBox)sender).SelectAll();
        }

        private void textBox43_Click(object sender, EventArgs e)
        {
            if (((TextBox)sender).Tag == null)
                ((TextBox)sender).SelectAll();
        }

        private void textBox44_Click(object sender, EventArgs e)
        {
            if (((TextBox)sender).Tag == null)
                ((TextBox)sender).SelectAll();
        }

        private void textBox45_Click(object sender, EventArgs e)
        {
            if (((TextBox)sender).Tag == null)
                ((TextBox)sender).SelectAll();
        }


        //******使textbox只能输入数字*******////


        //private void textBox24_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
        //    {
        //        e.Handled = false;

        //    }
        //    else
        //        MessageBox.Show("请输入数字");
                
        //}

        //private void textBox1_TextChanged(object sender, EventArgs e)
        //{
        //    trackBar1.Value = Convert.ToInt32(textBox1.Text) * 99 ;
        //    //textBox46.Text = Convert.ToString(trackBar1.Value);
        //}
       
        
        
        //当Textbox中的数值改变时，trackBar对应的数值也改变
        //private void textBox1_TextChanged(object sender, EventArgs e)
        //{
        //    trackBar1.Value = Convert.ToInt32(textBox1.Text);
        //    OutPutNum[180] = trackBar1.Value;
        //}

        //private void textBox2_TextChanged(object sender, EventArgs e)
        //{
        //    //trackBar2.Value = Convert.ToInt32(textBox2.Text);
        //    //OutPutNum[265] = trackBar2.Value;
        //}

        //private void textBox3_TextChanged(object sender, EventArgs e)
        //{
        //    //trackBar3.Value = Convert.ToInt32(textBox3.Text);
        //    //OutPutNum[386] = trackBar3.Value;
        //}

        //private void textBox4_TextChanged(object sender, EventArgs e)
        //{
        //    //trackBar4.Value = Convert.ToInt32(textBox4.Text);
        //    //OutPutNum[621] = trackBar4.Value;
        //}

        //private void textBox5_TextChanged(object sender, EventArgs e)
        //{
        //    //trackBar5.Value = Convert.ToInt32(textBox5.Text);
        //    //OutPutNum[1000] = trackBar5.Value;
        //}


        //private void textBox1_TextChanged(object sender, EventArgs e)
        //{
        //    textBox1.Text = Convert.ToString(trackBar1.Value);
            
        //}
    }
}

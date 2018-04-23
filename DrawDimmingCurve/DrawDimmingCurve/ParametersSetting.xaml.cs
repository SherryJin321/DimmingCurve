using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DrawDimmingCurve
{
    /// <summary>
    /// ParametersSetting.xaml 的交互逻辑
    /// </summary>
    public partial class ParametersSetting : Window
    {
        int arrayMaxValue = 0;
        int pwmMaxValue = 0;
        bool IsClickConfirm = false;


        public ParametersSetting()
        {
            InitializeComponent();
        }              

        private void ParametersSettingConfirm_Click(object sender, RoutedEventArgs e)
        {
            if(ArraySize.Text.Trim() != "" && PWMMaxValue.Text.Trim() != "")
            {
                try
                {
                    arrayMaxValue = Convert.ToInt32(ArraySize.Text.Trim());
                    pwmMaxValue = Convert.ToInt32(PWMMaxValue.Text.Trim());

                    if (arrayMaxValue <= 1024 && arrayMaxValue >= 100)
                    {
                        if(pwmMaxValue >= 1)
                        {
                            ConfigureParameters.ArrayMaxValue = arrayMaxValue;
                            ConfigureParameters.PWMMaxValue = pwmMaxValue;
                            ConfigureParameters.IsWhiteOrNot = LampColorSelect.SelectedIndex + 1;

                            MessageBox.Show("参数配置成功！");
                            IsClickConfirm = true;
                            this.Close();                                                 
                        }
                        else
                        {
                            MessageBox.Show("PWM最大值输入错误！请输入大于等于1的整数。");
                        }
                    }
                    else
                    {
                        MessageBox.Show("数组大小输入错误！请输入数值范围为100~1024。");
                    }

                }
                catch
                {
                    MessageBox.Show("输入错误！请输入整数。");
                }
            }
            else
            {
                MessageBox.Show("文本框为空！请输入数值。");
            }
         
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if(IsClickConfirm==false)
            {
                if (ArraySize.Text.Trim() != "" && PWMMaxValue.Text.Trim() != "")
                {
                    try
                    {
                        arrayMaxValue = Convert.ToInt32(ArraySize.Text.Trim());
                        pwmMaxValue = Convert.ToInt32(PWMMaxValue.Text.Trim());

                        if (arrayMaxValue <= 1024 && arrayMaxValue >= 100)
                        {
                            if (pwmMaxValue >= 1)
                            {
                                ConfigureParameters.ArrayMaxValue = arrayMaxValue;
                                ConfigureParameters.PWMMaxValue = pwmMaxValue;
                                ConfigureParameters.IsWhiteOrNot = LampColorSelect.SelectedIndex + 1;

                                MessageBox.Show("参数配置成功！");
                            }
                            else
                            {
                                MessageBox.Show("PWM最大值输入错误！请输入大于等于1的整数。");
                                e.Cancel = true;
                            }
                        }
                        else
                        {
                            MessageBox.Show("数组大小输入错误！请输入数值范围为100~1024。");
                            e.Cancel = true;
                        }

                    }
                    catch
                    {
                        MessageBox.Show("输入错误！请输入整数。");
                        e.Cancel = true;
                    }
                }
                else
                {
                    MessageBox.Show("文本框为空！请输入数值。");
                    e.Cancel = true;
                }
            }            
        }       
    }
}

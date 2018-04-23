using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace DrawDimmingCurve
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
    }

    public static class ConfigureParameters
    {
        static public int PWMMaxValue;
        static public int ArrayMaxValue;
        static public int IsWhiteOrNot;
    }
}

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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data;
using Microsoft.Research.DynamicDataDisplay;
using Microsoft.Research.DynamicDataDisplay.DataSources;
using System.IO;
using System.Windows.Forms;
using System.Collections;


namespace DrawDimmingCurve
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        #region 原始数据
        double[] CurrentArray = new double[41] { 2.7, 2.8, 2.9, 3.0, 3.1, 3.2, 3.3, 3.4, 3.5, 3.6, 3.7, 3.8, 3.9, 4.0, 4.1, 4.2, 4.3, 4.4, 4.5, 4.6, 4.7, 4.8, 4.9, 5, 5.1, 5.2, 5.3, 5.4, 5.5, 5.6, 5.7, 5.8, 5.9, 6.0, 6.1, 6.2, 6.3, 6.4, 6.5, 6.6, 6.7 };
        double[] PercentageWhiteLightMinimumArray = new double[41] { 0.15, 0.15, 0.28, 0.41, 0.54, 0.67, 0.8, 1, 1.36, 1.79, 2.22, 2.65, 3.08, 3.51, 3.94, 4.57, 5.28, 6.08, 6.98, 7.99, 9.11, 10.37, 11.76, 13.31, 15.03, 16.93, 19.03, 21.34, 23.88, 26.67, 29.73, 33.07, 36.73, 40.71, 45.05, 49.77, 58.13, 71.58, 85.18, 100, 100 };
        double[] PercentageWhiteLightMaximumArray = new double[41] { 0.7, 0.7, 0.92, 1.14, 1.35, 1.57, 1.78, 2.1, 2.75, 3.5, 4.25, 5, 5.75, 6.5, 7.35, 8.45, 9.76, 11.23, 12.89, 14.75, 16.83, 19.15, 21.73, 24.59, 27.76, 31.27, 35.15, 39.41, 44.11, 49.26, 54.9, 61.08, 67.83, 75.19, 83.21, 91.93, 100, 100, 100, 100, 100 };
        double[] PercentageNotWhiteLightMinimumArray = new double[41] { 0.13, 0.15, 0.33, 0.5, 0.68, 0.85, 1.03, 1.2, 1.57, 1.93, 2.3, 2.9, 3.55, 4.28, 5, 5.71, 6.43, 7.14, 7.86, 8.57, 9.29, 10, 11.25, 12.5, 14, 16.8, 21.2, 25.6, 30, 33, 36, 39, 42, 45, 48, 53, 62, 74.67, 87.33, 100, 100 };
        double[] PercentageNotWhiteLightMaximumArray = new double[41] { 1.6, 1.65, 1.8, 2.01, 2.23, 2.44, 2.65, 3, 3.7, 4.75, 5.8, 6.85, 7.9, 8.95, 10, 11.17, 12.33, 13.5, 14.67, 15.83, 17, 19, 24, 31.5, 36, 39.75, 43.5, 47.25, 51, 56, 62.29, 68.57, 74.86, 81.14, 87.43, 93.71, 100, 100, 100, 100, 100 };
        #endregion

        #region 衍生数据        
        double[] PercentageWhiteLightAverageArray = new double[41];
        double[] PercentageNotWhiteLightAverageArray = new double[41];
        #endregion

        #region 应用数据
        int[] PWMArray = new int[41];
        double[] PercentageArray = new double[41];
        System.Data.DataTable myDataTable = new System.Data.DataTable();
        #endregion

        #region 导出数组
        int[] RawPWMArray = new int[41];
        int[] ExportPWMArray = new int[41];
        #endregion

        #region 绘制调光曲线模板参数
        private ObservableDataSource<Point> DataSourceWhiteLightMinimum = new ObservableDataSource<Point>();
        private ObservableDataSource<Point> DataSourceWhiteLightMaximum = new ObservableDataSource<Point>();
        private ObservableDataSource<Point> DataSourceNotWhiteLightMinimum = new ObservableDataSource<Point>();
        private ObservableDataSource<Point> DataSourceNotWhiteLightMaximum = new ObservableDataSource<Point>();
        private ObservableDataSource<Point> DataSourcePercentage = new ObservableDataSource<Point>();

        private LineGraph graphWhiteLightMinimum = new LineGraph();
        private LineGraph graphWhiteLightMaximum = new LineGraph();
        private LineGraph graphNotWhiteLightMinimum = new LineGraph();
        private LineGraph graphNotWhiteLightMaximum = new LineGraph();
        private LineGraph graphPercentage = new LineGraph();
        #endregion

        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 41; i++)
            {
                PercentageWhiteLightAverageArray[i] = Math.Round((PercentageWhiteLightMinimumArray[i] + PercentageWhiteLightMaximumArray[i]) / 2, 2, MidpointRounding.AwayFromZero);
                PercentageNotWhiteLightAverageArray[i] = Math.Round((PercentageNotWhiteLightMinimumArray[i] + PercentageNotWhiteLightMaximumArray[i]) / 2, 2, MidpointRounding.AwayFromZero);
            }            
        }

        #region 配置参数--打开参数配置窗口
        private void SetParameters_Click(object sender, RoutedEventArgs e)
        {
            ParametersSetting myParametersSetting = new ParametersSetting();
            myParametersSetting.ShowDialog();

            AdjustCurve.IsEnabled = true;
            ImportData.IsEnabled = true;
            GenerateCurve.IsEnabled = false;
            ExportArray.IsEnabled = false;

            myDataGrid.IsEnabled = false;
            DimmingCurveChart.IsEnabled = false;
        }
        #endregion

        #region 调整曲线
        private void AdjustCurve_Click(object sender, RoutedEventArgs e)
        {
            myDataGrid.IsEnabled = true;
            DimmingCurveChart.IsEnabled = true;

            GenerateCurve.IsEnabled = true;
            ExportArray.IsEnabled = true;

            GenerateMyDataGrid();
            RemoveGraph();

            //绘制调光曲线上下限
            if(ConfigureParameters.IsWhiteOrNot==1)
            {
                DrawWhiteLightMinimum();
                DrawWhiteLightMaximum();
                DimmingCurveChartHeader.Content = "调光曲线图（白色光）";
            }
            if(ConfigureParameters.IsWhiteOrNot==2)
            {
                DrawNotWhiteLightMinimum();
                DrawNotWhiteLightMaximum();
                DimmingCurveChartHeader.Content = "调光曲线图（非白色光）";
            }            
        }

        private void myDataGrid_LostFocus(object sender, RoutedEventArgs e)
        {
            RefreshMyDataGrid();
        }

        private void myDataGrid_MouseUp(object sender, MouseButtonEventArgs e)
        {
            RefreshMyDataGrid();
        }

        public void GenerateMyDataGrid()
        {            
            if (ConfigureParameters.IsWhiteOrNot == 1)
            {
                for (int i = 0; i < 41; i++)
                {
                    PercentageArray[i] = PercentageWhiteLightAverageArray[i];
                }
            }
            if (ConfigureParameters.IsWhiteOrNot == 2)
            {
                for (int i = 0; i < 41; i++)
                {
                    PercentageArray[i] = PercentageNotWhiteLightAverageArray[i];
                }
            }

            for (int i = 0; i < 41; i++)
            {
                PWMArray[i] = Convert.ToInt32( Math.Round((PercentageArray[i] * ConfigureParameters.PWMMaxValue * 0.01),0,MidpointRounding.AwayFromZero));
            }

            myDataTable = new System.Data.DataTable();

            myDataTable.Columns.Add("Current", typeof(double));
            myDataTable.Columns.Add("PWM", typeof(int));
            myDataTable.Columns.Add("Percentage", typeof(double));

            DataRow myDataRow;

            for (int i = 0; i < 41; i++)
            {
                myDataRow = myDataTable.NewRow();
                myDataRow["Current"] = CurrentArray[i];
                myDataRow["PWM"] = PWMArray[i];
                myDataRow["Percentage"] = PercentageArray[i];

                myDataTable.Rows.Add(myDataRow);
            }

            myDataGrid.ItemsSource = myDataTable.DefaultView;
        }

        public void RefreshMyDataGrid()
        {
            for (int i = 0; i < 41; i++)
            {
                myDataTable.Rows[i][2] = Math.Round(Convert.ToDouble(myDataTable.Rows[i][1]) / ConfigureParameters.PWMMaxValue * 100, 2, MidpointRounding.AwayFromZero);
            }

            myDataGrid.ItemsSource = myDataTable.DefaultView;
        }

        #endregion

        #region 绘制曲线

        private void GenerateCurve_Click(object sender, RoutedEventArgs e)
        {
            DrawPercentage();
        }

        //白色，最小曲线
        public void DrawWhiteLightMinimum()
        {            
            graphWhiteLightMinimum = DimmingCurveChart.AddLineGraph(DataSourceWhiteLightMinimum, Colors.Blue, 2, "最小值");

            for (int i = 0; i < 41; i++)
            {
                Point point = new Point(CurrentArray[i], PercentageWhiteLightMinimumArray[i]);
                DataSourceWhiteLightMinimum.AppendAsync(base.Dispatcher, point);
            }
        }

        //白色，最大曲线
        public void DrawWhiteLightMaximum()
        {            
            graphWhiteLightMaximum = DimmingCurveChart.AddLineGraph(DataSourceWhiteLightMaximum, Colors.Red, 2, "最大值");

            for (int i = 0; i < 41; i++)
            {
                Point point = new Point(CurrentArray[i], PercentageWhiteLightMaximumArray[i]);
                DataSourceWhiteLightMaximum.AppendAsync(base.Dispatcher, point);
            }
        }

        //非白色，最小曲线
        public void DrawNotWhiteLightMinimum()
        {            
            graphNotWhiteLightMinimum = DimmingCurveChart.AddLineGraph(DataSourceNotWhiteLightMinimum, Colors.Blue, 2, "最小值");

            for (int i = 0; i < 41; i++)
            {
                Point point = new Point(CurrentArray[i], PercentageNotWhiteLightMinimumArray[i]);
                DataSourceNotWhiteLightMinimum.AppendAsync(base.Dispatcher, point);
            }
        }

        //非白色，最大曲线
        public void DrawNotWhiteLightMaximum()
        {            
            graphNotWhiteLightMaximum = DimmingCurveChart.AddLineGraph(DataSourceNotWhiteLightMaximum, Colors.Red, 2, "最大值");

            for (int i = 0; i < 41; i++)
            {
                Point point = new Point(CurrentArray[i], PercentageNotWhiteLightMaximumArray[i]);
                DataSourceNotWhiteLightMaximum.AppendAsync(base.Dispatcher, point);
            }
        }

        //实际曲线
        public void DrawPercentage()
        {
            DimmingCurveChart.Children.Remove(graphPercentage);
            DataSourcePercentage = new ObservableDataSource<System.Windows.Point>();

            graphPercentage = DimmingCurveChart.AddLineGraph(DataSourcePercentage, Colors.Black, 2, "实际值");

            for (int i = 0; i < 41; i++)
            {
                Point point = new Point(CurrentArray[i], (double)myDataTable.Rows[i][2]);
                DataSourcePercentage.AppendAsync(base.Dispatcher, point);
            }
        }

        public void RemoveGraph()
        {
            DimmingCurveChart.Children.Remove(graphWhiteLightMinimum);
            DataSourceWhiteLightMinimum = new ObservableDataSource<System.Windows.Point>();

            DimmingCurveChart.Children.Remove(graphWhiteLightMaximum);
            DataSourceWhiteLightMaximum = new ObservableDataSource<System.Windows.Point>();

            DimmingCurveChart.Children.Remove(graphNotWhiteLightMinimum);
            DataSourceNotWhiteLightMinimum = new ObservableDataSource<System.Windows.Point>();

            DimmingCurveChart.Children.Remove(graphNotWhiteLightMaximum);
            DataSourceNotWhiteLightMaximum = new ObservableDataSource<System.Windows.Point>();

            DimmingCurveChart.Children.Remove(graphPercentage);
            DataSourcePercentage = new ObservableDataSource<System.Windows.Point>();
        }

        #endregion

        #region 导出数据

        private void ExportArray_Click(object sender, RoutedEventArgs e)
        {
            RawPWMArray = new int[41];

            for(int i=0;i<41;i++)
            {
                RawPWMArray[i] = (int)myDataTable.Rows[i][1];
            }

            if(JudgeRawPWMArray(RawPWMArray)==true)
            {
                ExportPWMArray = GenerateFinalPWMArray(RawPWMArray, ConfigureParameters.ArrayMaxValue);
                ExportTXT(ExportPWMArray);
            }
            else
            {
                System.Windows.MessageBox.Show("曲线不符合递增趋势！请确认。");
            }

        }

        public bool JudgeRawPWMArray(int[] TempArray)
        {
            for(int i=0;i<40;i++)
            {
                if(TempArray[i+1]< TempArray[i])
                {
                    return false;
                }
            }

            return true;
        }

        

        public int[] GenerateFinalPWMArray(int[] RawArray,int ArraySize)
        {
            int quotient = (ArraySize - 41) / 40;
            int remainder = ArraySize-41-40*quotient;

            //countArray，指示40个插入点中，每个插入点插入的个数
            int[] countArray = new int[40];
            for(int i=0;i<40;i++)
            {
                if(i< remainder)
                {
                    countArray[i] = quotient + 1;
                }
                else
                {
                    countArray[i] = quotient;
                }
            }

            //numberArray，指示原数组的元素对应于新数组的位置
            int[] numberArray = new int[41];
            numberArray[0] = 0;
            numberArray[40] = ArraySize - 1;
            for(int i=1;i<40;i++)
            {
                numberArray[i] = numberArray[i - 1] + countArray[i-1]+1;
            }

            //resultArray，指示最终生成的数组
            int[] resultArray = new int[ArraySize];                       
            for(int i=0;i<41;i++)
            {
                resultArray[numberArray[i]] = RawArray[i];
            }

            for(int i=0;i<40;i++)
            {
                int k = (RawArray[i + 1] - RawArray[i]) / (countArray[i] + 1);

                if(countArray[i]!=0)
                {
                    for (int j = 1; j < countArray[i] + 1; j++)
                    {
                        resultArray[numberArray[i] + j] = RawArray[i] + j * k;
                    }
                }
                
            }

            return resultArray;

        }

        public void ExportTXT(int[] TempArray)
        {
            string FileName = "d:\\调光曲线PWM数组" + " " + DateTime.Now.ToString("yyyyMMddHHmmss") + ".txt";
            FileStream fs = new FileStream(FileName, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);

            for(int i=0;i<TempArray.Length;i++)
            {
                sw.WriteLine(TempArray[i]+",");
            }

            sw.Flush();
            sw.Close();
            fs.Close();

            System.Windows.MessageBox.Show("数据已导出! 保存至D盘TXT文档");
        }

        #endregion

        #region 导入数据
        private void ImportData_Click(object sender, RoutedEventArgs e)
        {
            ArrayList myArrayList = new ArrayList();
            myArrayList = AcquireTXTFileData();

            int[] myIntArray = new int[41];
            myIntArray = ArrayListToIntArray(myArrayList);

            if(myIntArray[myIntArray.Length-1]!=0)
            {
                //将数据导入DataGrid控件
            }

        }

        //获取TXT文件数据
        public ArrayList AcquireTXTFileData()
        {
            ArrayList ImportData = new ArrayList();

            System.Windows.Forms.OpenFileDialog openFileDialog = new System.Windows.Forms.OpenFileDialog();
            openFileDialog.InitialDirectory = "d:\\";
            openFileDialog.Filter = "文本文件（*.txt）|*.txt";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                FileStream fs = new FileStream(openFileDialog.FileName, FileMode.Open);
                StreamReader sr = new StreamReader(fs);

                int intCode = sr.Read();                
                while(intCode!=-1)
                {
                    ImportData.Add(intCode);
                    intCode = sr.Read();
                }
                sr.Close();
            }

            return ImportData;
        }

        //解析TXT文件数据，生成可导入 DataGrid控件的数组
        public int[] ArrayListToIntArray(ArrayList TempArrayList)
        {
            ArrayList CountArrayList = new ArrayList();
            for(int i=0;i<TempArrayList.Count;i++)
            {
                if((int)TempArrayList[i]==44)
                {
                    CountArrayList.Add(i);
                }
            }

            int[] ResultArray = new int[CountArrayList.Count];
            for(int i=0;i<ResultArray.Length;i++)
            {
                if(i==0)
                {
                    for (int j=0;j<(int)CountArrayList[i];j++)
                    {
                        ResultArray[i]+=Convert.ToInt32(((int)TempArrayList[j]-48)*Math.Pow(10, (int)CountArrayList[i] -1-j));
                    }
                }
                else
                {
                    for(int j=(int)CountArrayList[i-1]+3;j<(int)CountArrayList[i];j++)
                    {
                        ResultArray[i] += Convert.ToInt32(((int)TempArrayList[j] - 48) * Math.Pow(10, (int)CountArrayList[i] - 1 - j));
                    }
                }
                
            }

            int[] FinalArray = new int[41];
            if(ResultArray.Length==ConfigureParameters.ArrayMaxValue)
            {
                if(ResultArray[ResultArray.Length-1]==ConfigureParameters.PWMMaxValue)
                {
                    int[] numberArray = new int[41];
                    numberArray = GenerateLocationArray(ResultArray.Length);

                    for (int i=0;i<41;i++)
                    {
                        FinalArray[i] = ResultArray[numberArray[i]];
                    }
                }
                else
                {
                    System.Windows.MessageBox.Show("PWM最大值不符！请重新配置PWM最大值。");
                }
            }
            else
            {
                System.Windows.MessageBox.Show("数组大小不符！请重新配置数组大小。");
            }

            return FinalArray;

        }

        //生成原int[41]的元素对应于扩展后数组的位置
        public int[] GenerateLocationArray(int arraySize)
        {
            int quotient = (arraySize - 41) / 40;
            int remainder = arraySize - 41 - 40 * quotient;

            //countArray，指示40个插入点中，每个插入点插入的个数
            int[] countArray = new int[40];
            for (int i = 0; i < 40; i++)
            {
                if (i < remainder)
                {
                    countArray[i] = quotient + 1;
                }
                else
                {
                    countArray[i] = quotient;
                }
            }

            //numberArray，指示原数组的元素对应于新数组的位置
            int[] numberArray = new int[41];
            numberArray[0] = 0;
            numberArray[40] = arraySize - 1;
            for (int i = 1; i < 40; i++)
            {
                numberArray[i] = numberArray[i - 1] + countArray[i - 1] + 1;
            }

            return numberArray;
        }

        #endregion
    }

    public class DimmingCurve
    {
        public double Current { get; set; }
        public int PWM { get; set; }
        public double Percentage { get; set; }
    }
}

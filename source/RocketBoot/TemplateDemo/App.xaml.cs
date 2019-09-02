using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using TemplateDemo.ViewModels;

namespace TemplateDemo
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        [STAThread]
        protected override void OnStartup(StartupEventArgs e)
        {

            MainWindow mw = new MainWindow();
            this.MainWindow = mw;
            StuViewModel svm = new StuViewModel();

            mw.DataContext = svm;
            mw.Show();
        }
    }
}

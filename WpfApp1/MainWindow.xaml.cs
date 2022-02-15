using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
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
using WpfApp1.Resx;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    [DesignTimeVisible(false)]
    public partial class MainWindow : Window
    {
        static int index = -1;
        public MainWindow()
        {
            InitializeComponent();

            //string language = Thread.CurrentThread.CurrentUICulture.Name;
            //cbLanguage.SelectedIndex = language == "vi" ? 2 : language == "en" ? 1 : 0;
            App.SelectCulture("");
        }

        private void cbLanguage_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //if (index == cbLanguage.SelectedIndex)
            //    return;
            //index = cbLanguage.SelectedIndex;
            //CultureInfo language = new CultureInfo(cbLanguage.SelectedIndex == 0 ? "" : cbLanguage.SelectedIndex == 1 ? "en" : "vi");
            //Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(cbLanguage.SelectedIndex == 0 ? "" : cbLanguage.SelectedIndex == 1 ? "en" : "vi");
            //Thread.CurrentThread.CurrentUICulture = language;
            //AppResource.Culture = language;

            //Window oldWindow = Application.Current.MainWindow;
            //Application.Current.MainWindow = new MainWindow();
            //Application.Current.MainWindow.Show();
            //oldWindow.Close();


            //way 2:
            App.SelectCulture(cbLanguage.SelectedIndex == 0 ? "" : cbLanguage.SelectedIndex == 1 ? "en" : "vi");
        }

        private void laName_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var name = laName.Content;
        }
    }
}

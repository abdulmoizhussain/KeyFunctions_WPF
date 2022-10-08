using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
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

namespace KeyFunctions_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //public ObservableCollection<object> asdf;

        public MainWindow()
        {
            InitializeComponent();

            // source links:
            // https://www.youtube.com/watch?v=ayp3tHEkRc0 (sqlite c# windows app dapper)
            // https://www.youtube.com/watch?v=dOZYOnFb56Q
            // https://www.youtube.com/watch?v=YW3gq-zyzoE
            // https://www.youtube.com/watch?v=CNVR-Rp54aY
            // https://www.youtube.com/watch?v=_LFxV1thbkQ
            // https://parallelcodes.com/wpf-datagrid-with-button/
            // successful keywords on google:
            // C# dotnet datagridview obersablecollection
        }

        private void MainWindow_OnLoaded(object sender, RoutedEventArgs e)
        {
            // DataGrid_ClipHistory.DataContext // this is the one to be used.

            DataGrid_ClipHistory.Items.Add(new
            {
                DateTime = DateTime.Now.ToString()
            });
        }

        private void CheckBox_OnStateChanged(object sender, RoutedEventArgs e)
        {
            var checkbox = (CheckBox)sender;
            Console.WriteLine($"{checkbox.Name} {checkbox.IsChecked}");

            //DataGrid_ClipHistory.Items = new ItemCollection();
            DataGrid_ClipHistory.Items.Add(new
            {
                DateTime = DateTime.Now.ToString()
            });
        }

        private void CopyButtonView_OnClick(object sender, RoutedEventArgs e)
        {
            dynamic dataContext = ((Button)e.Source).DataContext;

            Console.WriteLine(dataContext.DateTime);
        }

        private void aPicture_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Console.WriteLine("MouseButtonEventArgs");
        }
    }
}

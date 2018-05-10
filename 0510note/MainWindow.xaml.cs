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

namespace _0510note
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void save_button_Click(object sender, RoutedEventArgs e)
        {
            //產生儲存檔案視窗
            Microsoft.Win32.SaveFileDialog dig = new Microsoft.Win32.SaveFileDialog();

            //顯示視窗
            Nullable<bool> result = dig.ShowDialog();

            //按下save後的反應
            if (result == true)
            {
                //寫入檔案
                System.IO.File.WriteAllText(@"C:\Users\USER\Desktop\temp.txt", Textarea.Text);
            }         
        }       

        private void open_button_Click(object sender, RoutedEventArgs e)
        {
            //產生儲存檔案視窗
            Microsoft.Win32.OpenFileDialog dig = new Microsoft.Win32.OpenFileDialog();

            //顯示視窗
            Nullable<bool> result = dig.ShowDialog();

            //按下open後的反應
            if (result == true)
            {
                //寫入檔案
                Textarea.Text = System.IO.File.ReadAllText(@"C:\Users\USER\Desktop\temp.txt");
            }
        }
    }
}

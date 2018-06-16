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
        string filePath = "";

        public MainWindow()
        {
            InitializeComponent();
        }
          // 存檔文件
        private void save_button_Click(object sender, RoutedEventArgs e)
        {
            // 產生儲存檔案視窗
            Microsoft.Win32.SaveFileDialog dig = new Microsoft.Win32.SaveFileDialog();

            // 顯示視窗
            Nullable<bool> result = dig.ShowDialog();

            // 按下save後的反應
            if (result == true)
            {
                // 寫入檔案
                System.IO.File.WriteAllText(@"C:\Users\USER\Desktop\temp.txt", Textarea.Text);
            }         
        }       

        private void open_button_Click(object sender, RoutedEventArgs e)
        {
            // 產生儲存檔案視窗
            Microsoft.Win32.OpenFileDialog dig = new Microsoft.Win32.OpenFileDialog();

            // 顯示視窗
            Nullable<bool> result = dig.ShowDialog();

            // 按下open後的反應
            if (result == true)
            {
                // 寫入檔案
                Textarea.Text = System.IO.File.ReadAllText(@"C:\Users\USER\Desktop\temp.txt");
            }
        }
            // 按下save as後的反應
        private void save_as_button_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.SaveFileDialog dig = new Microsoft.Win32.SaveFileDialog();

            // open save window
            Nullable<bool> result = dig.ShowDialog();

            if (result == true)
            {
                filePath = dig.FileName;
                System.IO.File.WriteAllText(dig.FileName, Textarea.Text);
            }
        }

        private void new_button_Click(object sender, RoutedEventArgs e)
        {
            // 重置資料

            filePath = " ";
            Textarea.Text = " ";

        }

        // 讓字體變小
        private void small_a_click(object sender, RoutedEventArgs e)
        {
            Textarea.FontSize = 15;
        }

        private void medium_a_click(object sender, RoutedEventArgs e)
        {
            Textarea.FontSize = 20;
        }

        private void big_a_click(object sender, RoutedEventArgs e)
        {
            Textarea.FontSize = 25;
        }

        private void white_click(object sender, RoutedEventArgs e)
        {
            Textarea.Background = Brushes.White;
            Textarea.Foreground = Brushes.Black;
        }

        private void black_click(object sender, RoutedEventArgs e)
        {
            Textarea.Background = Brushes.Gray;
            Textarea.Foreground = Brushes.White;
        }

    }
}

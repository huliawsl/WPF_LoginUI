using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Media;
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

namespace WPF_LoginUI
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        LoginViewModel viewModel;
        public MainWindow()
        {

            InitializeComponent();

            viewModel = new LoginViewModel();

            this.DataContext = viewModel;

        }


        
        private void Button_click(object sender, RoutedEventArgs e)
        {


            if (viewModel.LoginM.UserName == "123" && viewModel.LoginM.Password == "2")
            {
                SystemSounds.Asterisk.Play();
                MessageBox.Show("登录成功");
                Index index = new Index();
                index.Show();
                this.Close();
            }
            else
            {
                SystemSounds.Asterisk.Play();
                MessageBox.Show("输入的用户名和密码不正确");

                
            }
            viewModel.LoginM.UserName = "";
            viewModel.LoginM.Password = "";
            viewModel.LoginM = viewModel.LoginM;
        }
    }
}

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
        LoginModel loginModel;
        public MainWindow()
        {
            InitializeComponent();
            loginModel = new LoginModel();  

            this.DataContext = this;
        }


        
        private void Button_click(object sender, RoutedEventArgs e)
        {


            if (loginModel.UserName == "123" && loginModel.Password == "2")
            {
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
            loginModel.UserName = "";
            loginModel.Password = "";
        }
    }
}
 public class LoginModel:INotifyPropertyChanged
{
    public event PropertyChangedEventHandler PropertyChanged;
    private void RaisePropertyChanged(string propertyName)
    {
        PropertyChangedEventHandler handler = PropertyChanged;
        if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
    }

    private string _UserName;

    public string UserName
    {
        get { return _UserName; }
        set
        {
            _UserName = value;
            RaisePropertyChanged("UserName");
        }
    }

    private string _Password;

    public string Password
    {
        get { return _Password; }
        set
        {
            _Password = value;
            RaisePropertyChanged("Password");
        }
    }

}

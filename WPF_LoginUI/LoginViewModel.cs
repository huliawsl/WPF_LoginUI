using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace WPF_LoginUI
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        private LoginModel _LoginM = new LoginModel();

        private MainWindow _MainWindow;

        public LoginViewModel(MainWindow mainWindow)
        {
            _MainWindow = mainWindow;
        }

        public string UserName
        {
            get { return _LoginM.UserName; }
            set { 
                _LoginM.UserName = value;
                RaisePropertyChanged(nameof(UserName));
            }
        }        
        public string Password
        {
            get { return _LoginM.Password; }
            set { 
                _LoginM.Password = value;
                RaisePropertyChanged(nameof(Password));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
               handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        void LoginFunc()
        {

            if (UserName == "123" && Password == "2")
            {
                SystemSounds.Asterisk.Play();
                MessageBox.Show("登录成功");
                Index index = new Index();
                index.Show();
                _MainWindow.Close();
            }
            else
            {
                SystemSounds.Asterisk.Play();
                MessageBox.Show("输入的用户名和密码不正确");

            }
            UserName = "";
            Password = "";
        }

        private bool CanLoginExecute() { return true; }


        public ICommand LoginAction
        {
            get
            {
                return new RelayCommand(LoginFunc, CanLoginExecute);
            }
        }
    }
}

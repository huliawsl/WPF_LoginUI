﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_LoginUI
{
    public class LoginModel
    {
        public LoginModel() { }

        private string _UserName;

        public string UserName
        {
            get { return _UserName; }
            set
            {
                _UserName = value;

            }
        }

        private string _Password;

        public string Password
        {
            get { return _Password; }
            set
            {
                _Password = value;

            }
        }
    }
}

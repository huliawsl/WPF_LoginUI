using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPF_LoginUI
{
    public class RelayCommand : ICommand
    {
       

        /// <summary>
        /// 命令能否执行
        /// </summary>
        readonly Func<bool> _canExecute;

        /// <summary>
        /// 命令执行方法
        /// </summary>
        readonly Action _execute;
        private Action loginFunc;
        private bool v;

        public RelayCommand(Action action ,Func<bool> canExecute)
        {
            _execute = action;
            _canExecute = canExecute;
        }

        public RelayCommand(Action loginFunc, bool v)
        {
            this.loginFunc = loginFunc;
            this.v = v;
        }

        public bool CanExecute(object parameter)
        {
            if (_canExecute == null)
            {
                return true;
            }
            return _canExecute();
        }

        public void Execute(object parameter)
        {
            _execute();
        }

        public event EventHandler CanExecuteChanged
        {
            add
            {
                if (_canExecute != null)
                {
                    CommandManager.RequerySuggested += value;
                }
            }
            remove
            {
                if (_canExecute != null)
                {
                    CommandManager.RequerySuggested -= value;
                }
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Medical_center_Lifeline.ViewModel
{
    public class AppViewModel : INotifyPropertyChanged
    {

        // Close App Method //
        public void CloseApp(object obj)
        {
            MainWindow authorization = obj as MainWindow;

            if (authorization != null)
            {
                authorization.Close();
            }

        }

        // Close App Command //
        private ICommand _closeCommand;
        public ICommand CloseAppCommand
        {
            get
            {
                if (_closeCommand == null)
                {
                    _closeCommand = new RelayCommand.Command.RelayCommand(p => CloseApp(p));
                }
                return _closeCommand;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}


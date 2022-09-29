using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace GroupView.ViewModel
{
    public class MainWindowViewModel : BaseViewModel
    {

        private string _tx1;
        private string _tx2;
        private string _txSum;


        public string TextOne
        {
            get => _tx1;
            set
            {
                _tx1 = value;
                OnPropertyChanged(nameof(TextOne));
            }
        }

        public string TextTwo
        {
            get => _tx2;
            set
            {
                _tx2 = value;
                OnPropertyChanged(nameof(TextTwo));
            }
        }

        public string TextSum
        {
            get => _txSum;
            set
            {
                _txSum = value;
                OnPropertyChanged(nameof(TextSum));
            }
        }

        public void TextOut()
        {
            if (_tx1 == null || string.IsNullOrEmpty(_tx1))
            {
                MessageBox.Show("Не все поля заполнены!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Stop);
                return;
            }
            if (_tx2 == null || string.IsNullOrEmpty(_tx2))
            {
                MessageBox.Show("Не все поля заполнены!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Stop);
                return;
            }

            //_displayGroup.Display(_number, _name, _groupName);
            TextSum = TextOne + "-" + TextTwo.ToString();
        }


        public void Clear()
        {

            TextSum = "";
            TextOne = "";
            TextTwo = "";
        }
    }
}
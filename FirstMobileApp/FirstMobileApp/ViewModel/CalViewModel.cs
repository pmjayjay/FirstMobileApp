using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace FirstMobileApp.ViewModel
{
    public class CalViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public Command AddCommand { get; }
        public Command SubCommand { get; }
        public Command MulCommand { get; }
        public Command DivCommand { get; }
        int _num1;
        int _num2;
        string _result;

        public CalViewModel()
        {
            AddCommand = new Command(() =>
                {
                    Result = Add().ToString();
                });
            SubCommand = new Command(() =>
            {
                Result = Sub().ToString();
            });
            MulCommand = new Command(() =>
            {
                Result = Mul().ToString();
            });
            DivCommand = new Command(() =>
            {
                Result = Div().ToString();
            });
        }

        public int Num1
        {
            get { return _num1; }
            set { 
                _num1 = value;
                var args = new PropertyChangedEventArgs(nameof(Num1));
                PropertyChanged?.Invoke(this, args);
            }
        }

        public int Num2
        {
            get { return _num2; }
            set
            {
                _num2 = value;
                var args = new PropertyChangedEventArgs(nameof(Num2));
                PropertyChanged?.Invoke(this, args);
            }
        }

        public string Result
        {
            get { return _result; }
            set
            {
                _result = value;
                var args = new PropertyChangedEventArgs(nameof(Result));
                PropertyChanged?.Invoke(this, args);
            }
        }

        public int Add()
        {
            return Num1 + Num2;
        }
        public int Sub()
        {
            return Num1 - Num2;
        }
        public int Mul()
        {
            return Num1 * Num2;
        }
        public int Div()
        {
            if (Num2 == 0)
                return 0;
            return Num1 / Num2;
        }
    }
}

using System;
using System.ComponentModel;
using System.Windows.Input;
using System.Windows.Media;
using WpfViewModelExercice.Model;
using WpfViewModelExercice.ViewModel.Command;

namespace WpfViewModelExercice.ViewModel
{
    /// <summary>
    /// View model of Data
    /// </summary>
    public class DataViewModel : ViewModelBase
    {
        /// <summary>
        /// Encapsulate the Model
        /// </summary>
        private DataModel Data = new DataModel();

        /// <summary>
        /// Command
        /// </summary>
        private ICommand _mouseEnterTbxACommand;
        private ICommand _mouseEnterTbxBCommand;
        private ICommand _mouseLeaveTbxCommand;

        public ICommand MouseEnterTbxACommand
        {
            get
            {
                return _mouseEnterTbxACommand;
            }
            set
            {
                _mouseEnterTbxACommand = value;
            }
        }

        public ICommand MouseEnterTbxBCommand
        {
            get
            {
                return _mouseEnterTbxBCommand;
            }
            set
            {
                _mouseEnterTbxBCommand = value;
            }
        }

        public ICommand MouseLeaveTbxCommand
        {
            get
            {
                return _mouseLeaveTbxCommand;
            }
            set
            {
                _mouseLeaveTbxCommand = value;
            }
        }

        private void ChangeBackGroundColor(SolidColorBrush color)
        {
            MainBackgroundColor = color;
            Notify(() => MainBackgroundColor);
        }

        public void ChangeBackGroundLGray(object obj)
        {
            ChangeBackGroundColor(Brushes.LightGray);
        }

        public void ChangeBackGroundLGreen(object obj)
        {
            ChangeBackGroundColor(Brushes.LightGreen);
        }

        public void ChangeBackGroundLBleu(object obj)
        {
            ChangeBackGroundColor(Brushes.LightBlue);
        }

        /// <summary>
        /// BackGround Color of the Window
        /// </summary>
        private SolidColorBrush _mainBackgroundColor = Brushes.LightGray;
        public SolidColorBrush MainBackgroundColor
        {
            get { return _mainBackgroundColor; }
            set { _mainBackgroundColor = value; }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public DataViewModel()
        {
            MouseEnterTbxACommand = new RelayCommand(ChangeBackGroundLBleu);
            MouseEnterTbxBCommand = new RelayCommand(ChangeBackGroundLGreen);
            MouseLeaveTbxCommand = new RelayCommand(ChangeBackGroundLGray);
        }




        /// <summary>
        /// Text value of Ctrl_Tbx_A
        /// </summary>
        private string _dataA = "0";
        public string DataA
        {
            get { return _dataA; }
            set
            {
                SolidColorBrush color = Brushes.White;
                _dataA = value;
                Double result;
                if (Double.TryParse(DataA, out result))
                {
                    Data.A = result;
                }
                else
                {
                    Data.A = Double.NaN;
                    color = Brushes.Red;

                }
                this.Operation();
                Notify(() => DataA);
                NotificationColorA = color;
                Notify(() => NotificationColorA);

            }
        }

        /// <summary>
        /// Text value of Ctrl_Tbx_B
        /// </summary>
        private string _dataB = "0";
        public string DataB
        {
            get { return _dataB; }
            set
            {
                SolidColorBrush color = Brushes.White;
                _dataB = value;
                Double result;
                if (Double.TryParse(_dataB, out result))
                {
                    Data.B = result;
                }
                else
                {
                    color = Brushes.Red;
                    Data.B = Double.NaN;
                }
                this.Operation();
                Notify(() => DataB);
                NotificationColorB = color;
                Notify(() => NotificationColorB);
            }
        }

        /// <summary>
        /// BackGround Color of ctrl_Tbx_B
        /// </summary>
        private SolidColorBrush _notificationColorB = Brushes.White;
        public SolidColorBrush NotificationColorB
        {
            get { return _notificationColorB; }
            set { _notificationColorB = value; }
        }

        /// <summary>
        /// BackGround Color of ctrl_Tbx_A
        /// </summary>
        private SolidColorBrush _notificationColorA = Brushes.White;
        public SolidColorBrush NotificationColorA
        {
            get { return _notificationColorA; }
            set { _notificationColorA = value; }
        }

        /// <summary>
        /// Result of A + B
        /// </summary>
        public string DataC
        {
            get { return Data.C.ToString(); }
        }

        /// <summary>
        /// result od A * B
        /// </summary>
        public string DataD
        {
            get { return Data.D.ToString(); }
        }

        /// <summary>
        /// Operation on A and B
        /// </summary>
        private void Operation()
        {
            Data.Operation();
            Notify(() => DataC);
            Notify(() => DataD);
        }
    }
}
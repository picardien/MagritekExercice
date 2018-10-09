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
using WpfViewModelExercice.ViewModel;

namespace WpfViewModelExercice
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            this.Ctrl_Grd_View.DataContext = new DataViewModel();
        //    this.Ctrl_Tbx_A.MouseEnter += Ctrl_Tbx_A_MouseEnter;
        //    this.Ctrl_Tbx_B.MouseEnter += Ctrl_Tbx_B_MouseEnter;
        //    this.Ctrl_Tbx_A.MouseLeave += Ctrl_Tbx_A_MouseLeave;
        //    this.Ctrl_Tbx_B.MouseLeave += Ctrl_Tbx_B_MouseLeave;
        }

        //private void Ctrl_Tbx_B_MouseLeave(object sender, MouseEventArgs e)
        //{
        //    SetColorBackground(this, Brushes.LightGray);
        //}

        //private void Ctrl_Tbx_A_MouseLeave(object sender, MouseEventArgs e)
        //{
        //    SetColorBackground(this, Brushes.LightGray);
        //}

        //private void Ctrl_Tbx_B_MouseEnter(object sender, MouseEventArgs e)
        //{
        //    SetColorBackground(this, Brushes.LightGreen);
        //}

        //private void Ctrl_Tbx_A_MouseEnter(object sender, MouseEventArgs e)
        //{
        //    SetColorBackground(this, Brushes.LightBlue);
        //}

        ///// <summary>
        /////  Set the backGround of control
        ///// </summary>
        ///// <param name="ctrl">Ctrl which need to changed of color</param>
        ///// <param name="brush">Color to apply</param>
        //private void SetColorBackground(Control ctrl, SolidColorBrush brush)
        //{
        //    ctrl.Background = brush;
        //}
    }
}

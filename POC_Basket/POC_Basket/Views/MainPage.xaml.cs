using System;

using POC_Basket.ViewModels;

using Windows.UI.Xaml.Controls;

namespace POC_Basket.Views
{
    public sealed partial class MainPage : Page
    {
        private MainViewModel ViewModel
        {
            get { return ViewModelLocator.Current.MainViewModel; }
        }

        public MainPage()
        {
            InitializeComponent();
        }
    }
}

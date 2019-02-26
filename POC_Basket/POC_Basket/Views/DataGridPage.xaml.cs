using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Toolkit.Uwp.UI.Controls;
using POC_Basket.Core.Models;
using POC_Basket.ViewModels;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace POC_Basket.Views
{
    public sealed partial class DataGridPage : Page
    {
        private DataGridViewModel ViewModel
        {
            get { return ViewModelLocator.Current.DataGridViewModel; }
        }

        // TODO WTS: Change the grid as appropriate to your app, adjust the column definitions on DataGridPage.xaml.
        // For more details see the documentation at https://docs.microsoft.com/windows/communitytoolkit/controls/datagrid
        public DataGridPage()
        {
            InitializeComponent();
        }

        private async void MenuFlyoutItem_Copy(object sender, RoutedEventArgs e)
        {
            dataGrid.IsEnabled = false;
            MenuFlyoutItem mfi = sender as MenuFlyoutItem;
            SampleOrder seleted = mfi.DataContext as SampleOrder;
            IList<SampleOrder> dGrid = dataGrid.ItemsSource as IList<SampleOrder>;

            seleted.isLoading = true;
            dataGrid.ItemsSource = dGrid.ToList();

            Random random = new Random();
            int randomNumber = random.Next(2000, 5000);
            await Task.Delay(randomNumber);

            var copiedItem = (SampleOrder)seleted.Clone();

            dGrid.Add(copiedItem);
            seleted.isLoading = false;
            dataGrid.ItemsSource = dGrid.ToList();
            dataGrid.IsEnabled = true;
        }

        private async void MenuFlyoutItem_Delete(object sender, RoutedEventArgs e)
        {
            dataGrid.IsEnabled = false;
            MenuFlyoutItem mfi = sender as MenuFlyoutItem;
            SampleOrder seleted = mfi.DataContext as SampleOrder;
            IList<SampleOrder> dGrid = dataGrid.ItemsSource as IList<SampleOrder>;

            seleted.isLoading = true;
            dataGrid.ItemsSource = dGrid.ToList();

            Random random = new Random();
            int randomNumber = random.Next(2000, 5000);
            await Task.Delay(randomNumber);

            dGrid.Remove(seleted);
            dataGrid.ItemsSource = dGrid.ToList();
            dataGrid.IsEnabled = true;
        }
    }
}

using System;
using System.Collections.ObjectModel;

using GalaSoft.MvvmLight;

using POC_Basket.Core.Models;
using POC_Basket.Core.Services;

namespace POC_Basket.ViewModels
{
    public class DataGridViewModel : ViewModelBase
    {
        public ObservableCollection<SampleOrder> Source
        {
            get
            {
                // TODO WTS: Replace this with your actual data
                return SampleDataService.GetGridSampleData();
            }
        }
    }
}

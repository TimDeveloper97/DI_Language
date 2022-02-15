using Manager8Bia.Services;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class A
    {
        public string B { get; set; }
        public string C { get; set; }
    }

    public class MainViewModel : BaseViewModel
    {
        private string title;
        private IDataStore<A> _dataService;
        private object _current;

        public object Current
        { get => _current; set { _current = value; OnPropertyChanged(); } }
        public string Title { get => title; set { title = value; OnPropertyChanged(); } }

        public MainViewModel(UserViewModel userVM, SettingViewModel settingVM)
        {
            Title = "DUYANH HOT FIX1";
            OnPropertyChanged(Title);
            Current = settingVM;
        }

        [Inject]
        public void SetDataService(IDataStore<A> dataService)
        {
            _dataService = dataService;
        }
    }
}

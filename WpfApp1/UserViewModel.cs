using Manager8Bia.Services;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class UserViewModel:BaseViewModel
    {
        private IDataStore<A> _dataService;
        public UserViewModel()
        {
            
        }

        [Inject]
        public void SetDataService(IDataStore<A> dataService)
        {
            _dataService = dataService;
        }
    }
}

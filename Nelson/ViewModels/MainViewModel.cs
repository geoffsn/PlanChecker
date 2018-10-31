using ESAPIX.Interfaces;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ESAPIX.Common;
using VMS.TPS.Common.Model.API;
using Prism.Commands;
using System.Collections.ObjectModel;

namespace Nelson.ViewModels
{
    public class MainViewModel : BindableBase
    {
        AppComThread VMS = AppComThread.Instance;

        public MainViewModel()
        {

        }

        public DelegateCommand EvaluateCommand { get; set; }
        public ObservableCollection<PlanConstraint> Constraints { get; private set; } = new ObservableCollection<PlanConstraint>();

    }
}

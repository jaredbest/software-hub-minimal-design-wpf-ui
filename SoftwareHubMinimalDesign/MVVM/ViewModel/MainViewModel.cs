using System;
using SoftwareHubMinimalDesign.Core;

namespace SoftwareHubMinimalDesign.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {
        public RelayCommand ProjectsViewCommand { get; set; }
        public RelayCommand InstallsViewCommand { get; set; }
        public RelayCommand LicensesViewCommand { get; set; }
        public RelayCommand LearnViewCommand { get; set; }
        public RelayCommand CommunityViewCommand { get; set; }


        public ProjectsViewModel ProjectsVM { get; set; }
        public InstallsViewModel InstallsVM { get; set; }
        public LicensesViewModel LicensesVM { get; set; }
        public LearnViewModel LearnVM { get; set; }
        public CommunityViewModel CommunityVM { get; set; }

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView;  }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            ProjectsVM = new ProjectsViewModel();
            InstallsVM = new InstallsViewModel();
            LicensesVM = new LicensesViewModel();
            LearnVM = new LearnViewModel();
            CommunityVM = new CommunityViewModel();

            CurrentView = ProjectsVM;

            ProjectsViewCommand = new RelayCommand(o =>
            {
                CurrentView = ProjectsVM;
            });

            InstallsViewCommand = new RelayCommand(o =>
            {
                CurrentView = InstallsVM;
            });

            LicensesViewCommand = new RelayCommand(o =>
            {
                CurrentView = LicensesVM;
            });

            LearnViewCommand = new RelayCommand(o =>
            {
                CurrentView = LearnVM;
            });

            CommunityViewCommand = new RelayCommand(o =>
            {
                CurrentView = CommunityVM;
            });
        }
    }
}

using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityApp.ViewModel
{
    public class MainPageViewModel : ViewModelBase
    {
        public RelayCommand AllMoviesCommand { get; set; }
        private ViewModelBase _currentData;

        public ViewModelBase CurrentData
        {
            get { return _currentData; }
            set { _currentData = value; RaisePropertyChanged(); }
        }


        public MainPageViewModel()
        {
            AllMoviesCommand = new RelayCommand(_ => ShowMovies());
        }

        private void ShowMovies()
        {
            //CurrentData = new MoviesViewModel();
            Debug.WriteLine("ShowMovies Called");
        }
    }
}

﻿using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VueMovieNet
{
    public class MainViewModel : ViewModelBase
    {
        private string _name;

        public string Name
        {
            get { return _name; }

            set
            {
                RaisePropertyChanged();
                _name = value;
            }
        }
    }
}

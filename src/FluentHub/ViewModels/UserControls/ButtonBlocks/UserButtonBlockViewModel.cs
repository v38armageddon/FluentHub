﻿using FluentHub.Octokit.Models;
using Octokit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FluentHub.ViewModels.UserControls.ButtonBlocks
{
    public class UserButtonBlockViewModel : INotifyPropertyChanged
    {
        private Octokit.Models.UserOverviewItem user;
        public Octokit.Models.UserOverviewItem User
        {
            get => user;
            set
            {
                SetProperty(ref user, value);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected bool SetProperty<T>(ref T field, T newValue, [CallerMemberName] string propertyName = null)
        {
            if (!Equals(field, newValue))
            {
                field = newValue;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
                return true;
            }

            return false;
        }
    }
}
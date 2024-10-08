﻿using CommunityToolkit.Mvvm.ComponentModel;
using ExemploHttp.Models;
using ExemploHttp.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ExemploHttp.ViewModels
{
    public partial class PhotosViewModel : ObservableObject
    {

        [ObservableProperty]
        ObservableCollection<Photo> photos;

        public ICommand getPostsCommand { get; }

        public PhotosViewModel()
        {
            getPostsCommand = new Command(getPhotos);
        }

        public async void getPhotos()
        {
            RestService restService = new RestService();
            Photos = await restService.GetPhotoAsync();
        }
    }
}

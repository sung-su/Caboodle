﻿using System.Threading.Tasks;
using Samples.ViewModel;
using Tizen.Wearable.CircularUI.Forms;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Samples.View
{
    public class CircleBasePage : CirclePage
    {
        public CircleBasePage()
        {
            NavigationPage.SetBackButtonTitle(this, "Back");

            // Tizen defaults to a transparent background
            if (DeviceInfo.Platform == DeviceInfo.Platforms.Tizen)
            {
                BackgroundColor = Color.White;
            }
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            SetupBinding(BindingContext);
        }

        protected override void OnDisappearing()
        {
            TearDownBinding(BindingContext);

            base.OnDisappearing();
        }

        protected void SetupBinding(object bindingContext)
        {
            if (bindingContext is BaseViewModel vm)
            {
                vm.DoDisplayAlert += OnDisplayAlert;
                vm.OnAppearing();
            }
        }

        protected void TearDownBinding(object bindingContext)
        {
            if (bindingContext is BaseViewModel vm)
            {
                vm.OnDisappearing();
                vm.DoDisplayAlert -= OnDisplayAlert;
            }
        }

        Task OnDisplayAlert(string message)
        {
            return DisplayAlert(Title, message, "OK");
        }
    }
}

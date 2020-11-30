﻿namespace ViewModel
{
    using System.Threading.Tasks;
    using Zebble;
    using Domain.Services;
    using Domain.Services.Firebase;

    public class LoginPage : Zebble.Mvvm.FullScreen
    {
        readonly IAuthService AuthService;

        public readonly Bindable<string> Email = new("");
        public readonly Bindable<string> Password = new("");

        public LoginPage()
        {
            AuthService = new FirebaseAuthService();
        }

        public async Task LoginTapped()
        {
            var result = await AuthService.Login(Email.Value, Password.Value);

            if (result.Succeeded)
                Go<HomePage>();
            else
                Dialog.Alert($"Login failed: {result.Message} ({result.Code})");
        }

        public void RegisterTapped() => Forward<RegisterPage>();
    }
}

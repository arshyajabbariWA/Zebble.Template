﻿/***********************************************
* GENERATED BY ZEBBLE
***********************************************/

#region UI.Pages.Login
namespace UI.Pages
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Domain;
    using Zebble;
    using Zebble.Plugin;

    [EscapeGCop("Auto-generated")]
    public partial class Login : Zebble.Page, ITemplate<ViewModel.LoginPage>
    {
        public ViewModel.LoginPage Model => Zebble.Mvvm.ViewModel.The<ViewModel.LoginPage>();

        protected override async Task InitializeFromMarkup()
        {
            await base.InitializeFromMarkup();

            var __imageView1 = new ImageView { Path = "Images/Logo.png" };

            var __textView1 = new TextView { Text = "Hello there", CssClass = "title" };

            var __textInput1 = new TextInput()
            .Bind("Text", Model.Email);

            var __textInput2 = new TextInput()
            .Bind("Text", Model.Password);

            var __button1 = new Button { Text = "Login" }
            .On(v => v.Tapped, Model.LoginTapped);

            await AddRange(new View[] { __imageView1, __textView1, __textInput1, __textInput2, __button1 });
        }
    }
}
#endregion

#region UI.Pages.Welcome
namespace UI.Pages
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Domain;
    using Zebble;
    using Zebble.Plugin;

    [EscapeGCop("Auto-generated")]
    public partial class Welcome : Zebble.Page, ITemplate<ViewModel.WelcomePage>
    {
        public ViewModel.WelcomePage Model => Zebble.Mvvm.ViewModel.The<ViewModel.WelcomePage>();

        protected override async Task InitializeFromMarkup()
        {
            await base.InitializeFromMarkup();

            var __imageView1 = new ImageView { Path = "Images/Logo.png" };

            var __textView1 = new TextView { Text = "Hello there", CssClass = "title" };

            var __button1 = new Button { Text = "Login" }
            .On(v => v.Tapped, Model.LoginTapped);

            var __button2 = new Button { Text = "Sign up" }
            .On(v => v.Tapped, Model.SignUpTapped);

            await AddRange(new View[] { __imageView1, __textView1, __button1, __button2 });
        }
    }
}
#endregion

namespace UI
{
    partial class StartUp
    {
        // Hashed content of all resources
        public override string GetResourcesVersion() => "igchm7EJ76UbNE1wHi421H6bRVI";
    }
}

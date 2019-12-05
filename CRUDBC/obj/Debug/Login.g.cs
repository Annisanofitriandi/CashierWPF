﻿#pragma checksum "..\..\Login.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "F738B405947CA8598F3E33229AE11BB5"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using CRUDBC;
using CRUDBC.Model;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace CRUDBC {
    
    
    /// <summary>
    /// Login
    /// </summary>
    public partial class Login : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 30 "..\..\Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid gLogin;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtUserEmail;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox TxtPassword;
        
        #line default
        #line hidden
        
        
        #line 91 "..\..\Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnLogin;
        
        #line default
        #line hidden
        
        
        #line 92 "..\..\Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnDaftar;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid gForgotPassword;
        
        #line default
        #line hidden
        
        
        #line 112 "..\..\Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnSubmitForgetPwd;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/CRUDBC;component/login.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Login.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.gLogin = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.TxtUserEmail = ((System.Windows.Controls.TextBox)(target));
            
            #line 42 "..\..\Login.xaml"
            this.TxtUserEmail.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.TxtUserEmail_PreviewTextInput);
            
            #line default
            #line hidden
            
            #line 55 "..\..\Login.xaml"
            this.TxtUserEmail.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TxtUserEmail_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.TxtPassword = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 67 "..\..\Login.xaml"
            this.TxtPassword.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.TxtPassword_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 4:
            this.BtnLogin = ((System.Windows.Controls.Button)(target));
            
            #line 91 "..\..\Login.xaml"
            this.BtnLogin.Click += new System.Windows.RoutedEventHandler(this.BtnLogin_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.BtnDaftar = ((System.Windows.Controls.Button)(target));
            return;
            case 6:
            
            #line 95 "..\..\Login.xaml"
            ((System.Windows.Documents.Hyperlink)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnForgot_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.gForgotPassword = ((System.Windows.Controls.Grid)(target));
            return;
            case 8:
            this.BtnSubmitForgetPwd = ((System.Windows.Controls.Button)(target));
            
            #line 112 "..\..\Login.xaml"
            this.BtnSubmitForgetPwd.Click += new System.Windows.RoutedEventHandler(this.BtnSubmitForgetPwd_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 114 "..\..\Login.xaml"
            ((System.Windows.Documents.Hyperlink)(target)).Click += new System.Windows.RoutedEventHandler(this.Hyperlink_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


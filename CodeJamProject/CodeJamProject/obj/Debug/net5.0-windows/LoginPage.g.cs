﻿#pragma checksum "..\..\..\LoginPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "568BD9E4B8F7473988E2B5AE7E52A1D7EE6D7F65"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using CodeJamProject;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace CodeJamProject {
    
    
    /// <summary>
    /// LoginPage
    /// </summary>
    public partial class LoginPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\LoginPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox usernameInput;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\LoginPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox passwordInput;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\LoginPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label usernameText;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\LoginPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label passwordText;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\LoginPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button signInButton;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\LoginPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button signUpButton;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\LoginPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button tenantTemp;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\LoginPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button landlordTemp;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
<<<<<<< HEAD
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.2.0")]
=======
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.2.0")]
>>>>>>> 68de312688507acc31fe36f93a427376e3c5e981
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/CodeJamProject;component/loginpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\LoginPage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
<<<<<<< HEAD
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.2.0")]
=======
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.2.0")]
>>>>>>> 68de312688507acc31fe36f93a427376e3c5e981
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.usernameInput = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.passwordInput = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 3:
            this.usernameText = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.passwordText = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.signInButton = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\LoginPage.xaml"
            this.signInButton.Click += new System.Windows.RoutedEventHandler(this.signInButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.signUpButton = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\..\LoginPage.xaml"
            this.signUpButton.Click += new System.Windows.RoutedEventHandler(this.signUpButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.tenantTemp = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\..\LoginPage.xaml"
            this.tenantTemp.Click += new System.Windows.RoutedEventHandler(this.tenantTemp_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.landlordTemp = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\LoginPage.xaml"
            this.landlordTemp.Click += new System.Windows.RoutedEventHandler(this.landlordTemp_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


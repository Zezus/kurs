﻿#pragma checksum "..\..\PageRegistr.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "758DF6908ED075356B18B6865C119D3E"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using KursTest;
using MaterialDesignThemes.Wpf;
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


namespace KursTest {
    
    
    /// <summary>
    /// PageRegistr
    /// </summary>
    public partial class PageRegistr : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\PageRegistr.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LogIn;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\PageRegistr.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbLogin;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\PageRegistr.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Login;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\PageRegistr.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Password;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\PageRegistr.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label RepeatPass;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\PageRegistr.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button butRegistr_RegWin;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\PageRegistr.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button butExit_RegPage;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\PageRegistr.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox tbPassword;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\PageRegistr.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox tbRepeatPass;
        
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
            System.Uri resourceLocater = new System.Uri("/KursTest;component/pageregistr.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\PageRegistr.xaml"
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
            this.LogIn = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.tbLogin = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.Login = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.Password = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.RepeatPass = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.butRegistr_RegWin = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\PageRegistr.xaml"
            this.butRegistr_RegWin.Click += new System.Windows.RoutedEventHandler(this.butRegistr_RegWin_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.butExit_RegPage = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\PageRegistr.xaml"
            this.butExit_RegPage.Click += new System.Windows.RoutedEventHandler(this.butExit_RegPage_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.tbPassword = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 9:
            this.tbRepeatPass = ((System.Windows.Controls.PasswordBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}


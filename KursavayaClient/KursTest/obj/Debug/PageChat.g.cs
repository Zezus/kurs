﻿#pragma checksum "..\..\PageChat.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "F4C566C942953690B134C8D9644966B4"
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
    /// PageChat
    /// </summary>
    public partial class PageChat : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\PageChat.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbSend;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\PageChat.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button butExit_ChatPage;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\PageChat.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btSend;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\PageChat.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbChat;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\PageChat.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbCount;
        
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
            System.Uri resourceLocater = new System.Uri("/KursTest;component/pagechat.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\PageChat.xaml"
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
            this.tbSend = ((System.Windows.Controls.TextBox)(target));
            
            #line 21 "..\..\PageChat.xaml"
            this.tbSend.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.tbSend_TextChanged);
            
            #line default
            #line hidden
            
            #line 21 "..\..\PageChat.xaml"
            this.tbSend.KeyUp += new System.Windows.Input.KeyEventHandler(this.tbSend_KeyUp);
            
            #line default
            #line hidden
            return;
            case 2:
            this.butExit_ChatPage = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\PageChat.xaml"
            this.butExit_ChatPage.Click += new System.Windows.RoutedEventHandler(this.butExit_ChatPage_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btSend = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\PageChat.xaml"
            this.btSend.Click += new System.Windows.RoutedEventHandler(this.ButtonSend);
            
            #line default
            #line hidden
            return;
            case 4:
            this.tbChat = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.tbCount = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}


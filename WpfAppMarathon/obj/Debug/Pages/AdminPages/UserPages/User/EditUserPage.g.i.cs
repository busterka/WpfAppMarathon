﻿#pragma checksum "..\..\..\..\..\..\Pages\AdminPages\UserPages\User\EditUserPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "70F1E2D9C1054B9F26F8465C69A90A8281BFC0A36ED6CAFC591A950A622B62B3"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

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
using WpfAppMarathon.Pages.AdminPages.UserPages.User;


namespace WpfAppMarathon.Pages.AdminPages.UserPages.User {
    
    
    /// <summary>
    /// EditUserPage
    /// </summary>
    public partial class EditUserPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 35 "..\..\..\..\..\..\Pages\AdminPages\UserPages\User\EditUserPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox RoleCMB;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\..\..\..\Pages\AdminPages\UserPages\User\EditUserPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PassTBX;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\..\..\..\Pages\AdminPages\UserPages\User\EditUserPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DPassTBX;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\..\..\..\Pages\AdminPages\UserPages\User\EditUserPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SaveBTN;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\..\..\..\Pages\AdminPages\UserPages\User\EditUserPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CanselBTN;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfAppMarathon;component/pages/adminpages/userpages/user/edituserpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\Pages\AdminPages\UserPages\User\EditUserPage.xaml"
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
            this.RoleCMB = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 2:
            this.PassTBX = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.DPassTBX = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.SaveBTN = ((System.Windows.Controls.Button)(target));
            return;
            case 5:
            this.CanselBTN = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}


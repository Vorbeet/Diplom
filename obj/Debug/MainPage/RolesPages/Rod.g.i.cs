﻿#pragma checksum "..\..\..\..\MainPage\RolesPages\Rod.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "985FDC580D33F6D5656BB34B673962BC53C1C75A79283C0B7BCA3E67CF1282D6"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Diplomnaya.MainPage.RolesPages;
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


namespace Diplomnaya.MainPage.RolesPages {
    
    
    /// <summary>
    /// Rod
    /// </summary>
    public partial class Rod : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 18 "..\..\..\..\MainPage\RolesPages\Rod.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Mother;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\..\MainPage\RolesPages\Rod.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Father;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\..\MainPage\RolesPages\Rod.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnOtchet;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\..\MainPage\RolesPages\Rod.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DGridStudents;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\..\MainPage\RolesPages\Rod.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBoxSearch1;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\..\MainPage\RolesPages\Rod.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnAdd;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\..\MainPage\RolesPages\Rod.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnDel;
        
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
            System.Uri resourceLocater = new System.Uri("/Diplomnaya;component/mainpage/rolespages/rod.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\MainPage\RolesPages\Rod.xaml"
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
            this.Mother = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\..\..\MainPage\RolesPages\Rod.xaml"
            this.Mother.Click += new System.Windows.RoutedEventHandler(this.Mother_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Father = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\..\..\MainPage\RolesPages\Rod.xaml"
            this.Father.Click += new System.Windows.RoutedEventHandler(this.Father_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BtnOtchet = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\..\..\MainPage\RolesPages\Rod.xaml"
            this.BtnOtchet.Click += new System.Windows.RoutedEventHandler(this.BtnOtchet_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.DGridStudents = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 6:
            this.TBoxSearch1 = ((System.Windows.Controls.TextBox)(target));
            
            #line 42 "..\..\..\..\MainPage\RolesPages\Rod.xaml"
            this.TBoxSearch1.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TBoxSearch1_TextChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.BtnAdd = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\..\..\MainPage\RolesPages\Rod.xaml"
            this.BtnAdd.Click += new System.Windows.RoutedEventHandler(this.BtnAdd_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.BtnDel = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\..\..\MainPage\RolesPages\Rod.xaml"
            this.BtnDel.Click += new System.Windows.RoutedEventHandler(this.BtnDel_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 5:
            
            #line 33 "..\..\..\..\MainPage\RolesPages\Rod.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnEdit_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}


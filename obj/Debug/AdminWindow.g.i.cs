﻿#pragma checksum "..\..\AdminWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "64282306D3E044F429A6471AC704D71109A660979CC265ECC0D8D321EFAEDEAF"
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
using ieaisadmin;


namespace ieaisadmin {
    
    
    /// <summary>
    /// AdminWindow
    /// </summary>
    public partial class AdminWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGridClients;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonDeleteClient;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonExcel;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGridEmployee;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonDeleteEmployee;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonExcelEmployee;
        
        #line default
        #line hidden
        
        
        #line 103 "..\..\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGridContracts;
        
        #line default
        #line hidden
        
        
        #line 136 "..\..\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textBlockContractNum;
        
        #line default
        #line hidden
        
        
        #line 141 "..\..\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBoxLogin;
        
        #line default
        #line hidden
        
        
        #line 146 "..\..\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox passwordBoxPassword;
        
        #line default
        #line hidden
        
        
        #line 151 "..\..\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboBoxRole;
        
        #line default
        #line hidden
        
        
        #line 154 "..\..\AdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonAddEmployee;
        
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
            System.Uri resourceLocater = new System.Uri("/ieaisadmin;component/adminwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AdminWindow.xaml"
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
            this.dataGridClients = ((System.Windows.Controls.DataGrid)(target));
            
            #line 23 "..\..\AdminWindow.xaml"
            this.dataGridClients.Loaded += new System.Windows.RoutedEventHandler(this.dataGridClients_Loaded);
            
            #line default
            #line hidden
            
            #line 28 "..\..\AdminWindow.xaml"
            this.dataGridClients.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.dataGridClients_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.buttonDeleteClient = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\AdminWindow.xaml"
            this.buttonDeleteClient.Click += new System.Windows.RoutedEventHandler(this.buttonDeleteClient_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.buttonExcel = ((System.Windows.Controls.Button)(target));
            
            #line 49 "..\..\AdminWindow.xaml"
            this.buttonExcel.Click += new System.Windows.RoutedEventHandler(this.buttonExcel_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.dataGridEmployee = ((System.Windows.Controls.DataGrid)(target));
            
            #line 64 "..\..\AdminWindow.xaml"
            this.dataGridEmployee.Loaded += new System.Windows.RoutedEventHandler(this.dataGridEmployee_Loaded);
            
            #line default
            #line hidden
            
            #line 69 "..\..\AdminWindow.xaml"
            this.dataGridEmployee.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.dataGridEmployee_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.buttonDeleteEmployee = ((System.Windows.Controls.Button)(target));
            
            #line 80 "..\..\AdminWindow.xaml"
            this.buttonDeleteEmployee.Click += new System.Windows.RoutedEventHandler(this.buttonDeleteEmployee_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.buttonExcelEmployee = ((System.Windows.Controls.Button)(target));
            
            #line 86 "..\..\AdminWindow.xaml"
            this.buttonExcelEmployee.Click += new System.Windows.RoutedEventHandler(this.buttonExcelEmployee_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.dataGridContracts = ((System.Windows.Controls.DataGrid)(target));
            
            #line 108 "..\..\AdminWindow.xaml"
            this.dataGridContracts.Loaded += new System.Windows.RoutedEventHandler(this.dataGridContracts_Loaded);
            
            #line default
            #line hidden
            
            #line 108 "..\..\AdminWindow.xaml"
            this.dataGridContracts.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.dataGridContracts_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.textBlockContractNum = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this.textBoxLogin = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.passwordBoxPassword = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 11:
            this.comboBoxRole = ((System.Windows.Controls.ComboBox)(target));
            
            #line 153 "..\..\AdminWindow.xaml"
            this.comboBoxRole.Loaded += new System.Windows.RoutedEventHandler(this.comboBoxRole_Loaded);
            
            #line default
            #line hidden
            return;
            case 12:
            this.buttonAddEmployee = ((System.Windows.Controls.Button)(target));
            
            #line 161 "..\..\AdminWindow.xaml"
            this.buttonAddEmployee.Click += new System.Windows.RoutedEventHandler(this.buttonAddEmployee_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


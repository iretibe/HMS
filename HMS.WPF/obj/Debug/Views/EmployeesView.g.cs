#pragma checksum "..\..\..\Views\EmployeesView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "20D58A22EB5C5C267B6BA885F4BF594F7291C990BA918FACEA1CD84C93F5C3E6"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using HMS.WPF.Views;
using HMS.WPF.Views.Components;
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


namespace HMS.WPF.Views {
    
    
    /// <summary>
    /// EmployeesView
    /// </summary>
    public partial class EmployeesView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 80 "..\..\..\Views\EmployeesView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox EmployeeNameTextBox;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\Views\EmployeesView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox EmployeeAddressTextBox;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\..\Views\EmployeesView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker EmployeeBirthDatePicker;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\..\Views\EmployeesView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox EmployeeSalaryTextBox;
        
        #line default
        #line hidden
        
        
        #line 91 "..\..\..\Views\EmployeesView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox EmployeeDepartmentComboBox;
        
        #line default
        #line hidden
        
        
        #line 100 "..\..\..\Views\EmployeesView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox EmpoloyeeRoleComboBox;
        
        #line default
        #line hidden
        
        
        #line 104 "..\..\..\Views\EmployeesView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox isHeadCheckBox;
        
        #line default
        #line hidden
        
        
        #line 106 "..\..\..\Views\EmployeesView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock validation;
        
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
            System.Uri resourceLocater = new System.Uri("/HMS.WPF;component/views/employeesview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\EmployeesView.xaml"
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
            this.EmployeeNameTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.EmployeeAddressTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.EmployeeBirthDatePicker = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 4:
            this.EmployeeSalaryTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.EmployeeDepartmentComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.EmpoloyeeRoleComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.isHeadCheckBox = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 8:
            this.validation = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            
            #line 112 "..\..\..\Views\EmployeesView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.addEmployee);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


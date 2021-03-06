#pragma checksum "..\..\..\Views\PatientsView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "96BED9C9FE022A25C4A9A5AB59BC84E59A14510B8D0E6E9CE12DA078C9B0D0EB"
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
    /// PatientsView
    /// </summary>
    public partial class PatientsView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 81 "..\..\..\Views\PatientsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PatientNameTextBox;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\..\Views\PatientsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PatientAddressTextBox;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\..\Views\PatientsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker PatientBirthDatetDatePicker;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\..\Views\PatientsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PatientDiagnosis;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\..\Views\PatientsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox PatientTypeComboBox;
        
        #line default
        #line hidden
        
        
        #line 92 "..\..\..\Views\PatientsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox RoomNumberComboBox;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\..\Views\PatientsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox PatientDepartmentCombobox;
        
        #line default
        #line hidden
        
        
        #line 110 "..\..\..\Views\PatientsView.xaml"
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
            System.Uri resourceLocater = new System.Uri("/HMS.WPF;component/views/patientsview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\PatientsView.xaml"
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
            this.PatientNameTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.PatientAddressTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.PatientBirthDatetDatePicker = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 4:
            this.PatientDiagnosis = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.PatientTypeComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.RoomNumberComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.PatientDepartmentCombobox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            this.validation = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}


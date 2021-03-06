#pragma checksum "..\..\..\Views\AppointmentsView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "35E137D553AE16550DBD66AD93B46B8FCA5B3EA78276D979846B46F1C7F1E67E"
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
    /// AppointmentsView
    /// </summary>
    public partial class AppointmentsView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 90 "..\..\..\Views\AppointmentsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox PatientNameComboBox;
        
        #line default
        #line hidden
        
        
        #line 98 "..\..\..\Views\AppointmentsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox DoctorNameComboBox;
        
        #line default
        #line hidden
        
        
        #line 103 "..\..\..\Views\AppointmentsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker AppointmentDatePicker;
        
        #line default
        #line hidden
        
        
        #line 109 "..\..\..\Views\AppointmentsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.TimePicker AppointmentTimePicker;
        
        #line default
        #line hidden
        
        
        #line 115 "..\..\..\Views\AppointmentsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox AppointmentDuration;
        
        #line default
        #line hidden
        
        
        #line 116 "..\..\..\Views\AppointmentsView.xaml"
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
            System.Uri resourceLocater = new System.Uri("/HMS.WPF;component/views/appointmentsview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\AppointmentsView.xaml"
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
            this.PatientNameComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 2:
            this.DoctorNameComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.AppointmentDatePicker = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 4:
            this.AppointmentTimePicker = ((MaterialDesignThemes.Wpf.TimePicker)(target));
            return;
            case 5:
            this.AppointmentDuration = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.validation = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            
            #line 123 "..\..\..\Views\AppointmentsView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.addSubmit);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


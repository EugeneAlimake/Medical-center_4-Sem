#pragma checksum "..\..\Createorder.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "DCF8809BC5AAA3F7EEB8CE5F2E4D3BADAEBD45DB1166D649E92777517F0D4388"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Medical_center_Lifeline;
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


namespace Medical_center_Lifeline {
    
    
    /// <summary>
    /// Createorder
    /// </summary>
    public partial class Createorder : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\Createorder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Spesname;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\Createorder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox DoctorName;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\Createorder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image foto;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\Createorder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Date;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\Createorder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Time;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\Createorder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Create;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\Createorder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Warring;
        
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
            System.Uri resourceLocater = new System.Uri("/Medical center-Lifeline;component/createorder.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Createorder.xaml"
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
            this.Spesname = ((System.Windows.Controls.ComboBox)(target));
            
            #line 28 "..\..\Createorder.xaml"
            this.Spesname.DropDownClosed += new System.EventHandler(this.Spesname_DropDownClosed);
            
            #line default
            #line hidden
            return;
            case 2:
            this.DoctorName = ((System.Windows.Controls.ComboBox)(target));
            
            #line 31 "..\..\Createorder.xaml"
            this.DoctorName.DropDownClosed += new System.EventHandler(this.DoctorName_DropDownClosed);
            
            #line default
            #line hidden
            return;
            case 3:
            this.foto = ((System.Windows.Controls.Image)(target));
            return;
            case 4:
            this.Date = ((System.Windows.Controls.ComboBox)(target));
            
            #line 37 "..\..\Createorder.xaml"
            this.Date.DropDownClosed += new System.EventHandler(this.Date_DropDownClosed);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Time = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.Create = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\Createorder.xaml"
            this.Create.Click += new System.Windows.RoutedEventHandler(this.Create_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Warring = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}


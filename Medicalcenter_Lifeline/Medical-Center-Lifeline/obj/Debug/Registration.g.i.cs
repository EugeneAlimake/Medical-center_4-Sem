#pragma checksum "..\..\Registration.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B89822ED1F6EEC12D462BB33601B8C32909B770031C72DE4C30BA50D078D79B8"
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
    /// Registration
    /// </summary>
    public partial class Registration : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 29 "..\..\Registration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox email;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\Registration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox name;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\Registration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Logine;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\Registration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Password;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\Registration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image Yesornoemail;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\Registration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image Yesornoname;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\Registration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image Yesornolastname;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\Registration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Surrename;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\Registration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image Yesornologine;
        
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
            System.Uri resourceLocater = new System.Uri("/Medical center-Lifeline;component/registration.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Registration.xaml"
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
            
            #line 28 "..\..\Registration.xaml"
            ((System.Windows.Controls.Image)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Image_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.email = ((System.Windows.Controls.TextBox)(target));
            
            #line 29 "..\..\Registration.xaml"
            this.email.GotFocus += new System.Windows.RoutedEventHandler(this.email_GotFocus);
            
            #line default
            #line hidden
            
            #line 29 "..\..\Registration.xaml"
            this.email.LostFocus += new System.Windows.RoutedEventHandler(this.email_LostFocus);
            
            #line default
            #line hidden
            return;
            case 3:
            this.name = ((System.Windows.Controls.TextBox)(target));
            
            #line 30 "..\..\Registration.xaml"
            this.name.GotFocus += new System.Windows.RoutedEventHandler(this.name_GotFocus);
            
            #line default
            #line hidden
            
            #line 30 "..\..\Registration.xaml"
            this.name.LostFocus += new System.Windows.RoutedEventHandler(this.name_LostFocus);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Logine = ((System.Windows.Controls.TextBox)(target));
            
            #line 31 "..\..\Registration.xaml"
            this.Logine.GotFocus += new System.Windows.RoutedEventHandler(this.Logine_GotFocus);
            
            #line default
            #line hidden
            
            #line 31 "..\..\Registration.xaml"
            this.Logine.LostFocus += new System.Windows.RoutedEventHandler(this.Logine_LostFocus);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Password = ((System.Windows.Controls.TextBox)(target));
            
            #line 32 "..\..\Registration.xaml"
            this.Password.GotFocus += new System.Windows.RoutedEventHandler(this.Password_GotFocus);
            
            #line default
            #line hidden
            
            #line 32 "..\..\Registration.xaml"
            this.Password.LostFocus += new System.Windows.RoutedEventHandler(this.Password_LostFocus);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 33 "..\..\Registration.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Yesornoemail = ((System.Windows.Controls.Image)(target));
            return;
            case 8:
            this.Yesornoname = ((System.Windows.Controls.Image)(target));
            return;
            case 9:
            this.Yesornolastname = ((System.Windows.Controls.Image)(target));
            return;
            case 10:
            this.Surrename = ((System.Windows.Controls.TextBox)(target));
            
            #line 42 "..\..\Registration.xaml"
            this.Surrename.GotFocus += new System.Windows.RoutedEventHandler(this.Surrename_GotFocus);
            
            #line default
            #line hidden
            
            #line 42 "..\..\Registration.xaml"
            this.Surrename.LostFocus += new System.Windows.RoutedEventHandler(this.Surrename_LostFocus);
            
            #line default
            #line hidden
            return;
            case 11:
            this.Yesornologine = ((System.Windows.Controls.Image)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}


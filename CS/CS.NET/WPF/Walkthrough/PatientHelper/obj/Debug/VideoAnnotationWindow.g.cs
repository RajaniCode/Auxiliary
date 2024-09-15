//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.42
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using IdentityMine.Avalon.Controls;
using System;
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


namespace IdentityMine.Avalon.Controls {
    
    
    /// <summary>
    /// VideoAnnotationWindow
    /// </summary>
    public partial class VideoAnnotationWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        internal IdentityMine.Avalon.Controls.VideoAnnotationWindow DocumentRoot;
        
        internal System.Windows.Media.Animation.BeginStoryboard OnLoaded_BeginButton;
        
        internal System.Windows.Controls.MediaElement Heart_Ultrasound_wmv1;
        
        internal System.Windows.Controls.InkCanvas myInkCanvas;
        
        internal System.Windows.Shapes.Ellipse Ellipse2;
        
        internal System.Windows.Controls.ListBox AnnotationsListBox;
        
        internal System.Windows.Controls.TextBlock TimerText;
        
        internal System.Windows.Controls.Slider Slider1;
        
        internal System.Windows.Controls.TextBox TextBox1;
        
        internal System.Windows.Controls.Primitives.ToggleButton ToggleButton1;
        
        internal System.Windows.Controls.Button Button1;
        
        internal System.Windows.Controls.Button BeginButton;
        
        internal System.Windows.Controls.Button PauseButton;
        
        internal System.Windows.Controls.Button Button2;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/PatientHelper;component/videoannotationwindow.xaml", System.UriKind.Relative);
            System.Windows.Application.LoadComponent(this, resourceLocater);
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.DocumentRoot = ((IdentityMine.Avalon.Controls.VideoAnnotationWindow)(target));
            
            #line 8 "..\..\VideoAnnotationWindow.xaml"
            this.DocumentRoot.Initialized += new System.EventHandler(this.OnInitialized);
            
            #line default
            #line hidden
            
            #line 8 "..\..\VideoAnnotationWindow.xaml"
            this.DocumentRoot.Loaded += new System.Windows.RoutedEventHandler(this.OnLoaded);
            
            #line default
            #line hidden
            
            #line 8 "..\..\VideoAnnotationWindow.xaml"
            this.DocumentRoot.KeyDown += new System.Windows.Input.KeyEventHandler(this.OnKeyDown);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 384 "..\..\VideoAnnotationWindow.xaml"
            ((System.Windows.Media.Animation.Storyboard)(target)).CurrentStateInvalidated += new System.EventHandler(this.OnStoryboardInvalidated);
            
            #line default
            #line hidden
            
            #line 384 "..\..\VideoAnnotationWindow.xaml"
            ((System.Windows.Media.Animation.Storyboard)(target)).CurrentTimeInvalidated += new System.EventHandler(this.OnCurrentTimeInvalidated);
            
            #line default
            #line hidden
            return;
            case 3:
            this.OnLoaded_BeginButton = ((System.Windows.Media.Animation.BeginStoryboard)(target));
            return;
            case 4:
            this.Heart_Ultrasound_wmv1 = ((System.Windows.Controls.MediaElement)(target));
            return;
            case 5:
            this.myInkCanvas = ((System.Windows.Controls.InkCanvas)(target));
            return;
            case 6:
            this.Ellipse2 = ((System.Windows.Shapes.Ellipse)(target));
            return;
            case 7:
            this.AnnotationsListBox = ((System.Windows.Controls.ListBox)(target));
            
            #line 513 "..\..\VideoAnnotationWindow.xaml"
            this.AnnotationsListBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.OnAnnotationsListBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.TimerText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this.Slider1 = ((System.Windows.Controls.Slider)(target));
            
            #line 521 "..\..\VideoAnnotationWindow.xaml"
            this.Slider1.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Slider_MouseDown);
            
            #line default
            #line hidden
            
            #line 521 "..\..\VideoAnnotationWindow.xaml"
            this.Slider1.PreviewMouseUp += new System.Windows.Input.MouseButtonEventHandler(this.Slider_MouseUp);
            
            #line default
            #line hidden
            
            #line 521 "..\..\VideoAnnotationWindow.xaml"
            this.Slider1.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.Slider_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 10:
            this.TextBox1 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            this.ToggleButton1 = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            
            #line 525 "..\..\VideoAnnotationWindow.xaml"
            this.ToggleButton1.Click += new System.Windows.RoutedEventHandler(this.OnAnnotationToggle);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 526 "..\..\VideoAnnotationWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OnDeleteButton);
            
            #line default
            #line hidden
            return;
            case 13:
            this.Button1 = ((System.Windows.Controls.Button)(target));
            
            #line 527 "..\..\VideoAnnotationWindow.xaml"
            this.Button1.Click += new System.Windows.RoutedEventHandler(this.OnPauseButton);
            
            #line default
            #line hidden
            return;
            case 14:
            this.BeginButton = ((System.Windows.Controls.Button)(target));
            
            #line 528 "..\..\VideoAnnotationWindow.xaml"
            this.BeginButton.Click += new System.Windows.RoutedEventHandler(this.OnBeginButton);
            
            #line default
            #line hidden
            return;
            case 15:
            this.PauseButton = ((System.Windows.Controls.Button)(target));
            return;
            case 16:
            this.Button2 = ((System.Windows.Controls.Button)(target));
            
            #line 530 "..\..\VideoAnnotationWindow.xaml"
            this.Button2.Click += new System.Windows.RoutedEventHandler(this.OnResumeButton);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

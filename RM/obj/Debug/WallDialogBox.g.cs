﻿#pragma checksum "..\..\WallDialogBox.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F70E9AE738FCBA11727D183907899ACA2DA67D2CAED60ACF2154EBF62B1FD4D8"
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


namespace RM {
    
    
    /// <summary>
    /// WallDialogBox
    /// </summary>
    public partial class WallDialogBox : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\WallDialogBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton all_rooms_radio;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\WallDialogBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton selected_rooms_radio;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\WallDialogBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label select_wall_label;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\WallDialogBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox WallTypeListBox;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\WallDialogBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Ok_Button;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\WallDialogBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Cancel_Button;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\WallDialogBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GroupBox groupboxParam;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\WallDialogBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton from_level_radio;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\WallDialogBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton to_height_radio;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\WallDialogBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox HeightTextBox;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\WallDialogBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GroupBox groupBoxRoom;
        
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
            System.Uri resourceLocater = new System.Uri("/RM;component/walldialogbox.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\WallDialogBox.xaml"
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
            this.all_rooms_radio = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 2:
            this.selected_rooms_radio = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 3:
            this.select_wall_label = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.WallTypeListBox = ((System.Windows.Controls.ListBox)(target));
            return;
            case 5:
            this.Ok_Button = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\WallDialogBox.xaml"
            this.Ok_Button.Click += new System.Windows.RoutedEventHandler(this.Ok_Button_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Cancel_Button = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\WallDialogBox.xaml"
            this.Cancel_Button.Click += new System.Windows.RoutedEventHandler(this.Cancel_Button_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.groupboxParam = ((System.Windows.Controls.GroupBox)(target));
            return;
            case 8:
            this.from_level_radio = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 9:
            this.to_height_radio = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 10:
            this.HeightTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 46 "..\..\WallDialogBox.xaml"
            this.HeightTextBox.LostFocus += new System.Windows.RoutedEventHandler(this.Height_TextBox_Wall);
            
            #line default
            #line hidden
            return;
            case 11:
            this.groupBoxRoom = ((System.Windows.Controls.GroupBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}


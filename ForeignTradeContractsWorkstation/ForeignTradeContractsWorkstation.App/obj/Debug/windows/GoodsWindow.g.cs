﻿#pragma checksum "..\..\..\Windows\GoodsWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "0BD7027EB51820969EB4D2F957B9DAD9"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ForeignTradeContractsWorkstation.App.Windows;
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


namespace ForeignTradeContractsWorkstation.App.Windows {
    
    
    /// <summary>
    /// GoodsWindow
    /// </summary>
    public partial class GoodsWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\Windows\GoodsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGrid;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\Windows\GoodsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox listBox;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\Windows\GoodsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addRecord;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\Windows\GoodsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button updateRecord;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\Windows\GoodsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button deleteRecord;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\Windows\GoodsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label searchLabel;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\Windows\GoodsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox searchTextBox;
        
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
            System.Uri resourceLocater = new System.Uri("/ForeignTradeContractsWorkstation.App;component/windows/goodswindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\GoodsWindow.xaml"
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
            
            #line 8 "..\..\..\Windows\GoodsWindow.xaml"
            ((ForeignTradeContractsWorkstation.App.Windows.GoodsWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.dataGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 16 "..\..\..\Windows\GoodsWindow.xaml"
            this.dataGrid.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.DataGrid_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.listBox = ((System.Windows.Controls.ListBox)(target));
            return;
            case 4:
            this.addRecord = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\..\Windows\GoodsWindow.xaml"
            this.addRecord.Click += new System.Windows.RoutedEventHandler(this.addRecord_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.updateRecord = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\..\Windows\GoodsWindow.xaml"
            this.updateRecord.Click += new System.Windows.RoutedEventHandler(this.updateRecord_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.deleteRecord = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\..\Windows\GoodsWindow.xaml"
            this.deleteRecord.Click += new System.Windows.RoutedEventHandler(this.deleteRecord_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.searchLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.searchTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 48 "..\..\..\Windows\GoodsWindow.xaml"
            this.searchTextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.searchTextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

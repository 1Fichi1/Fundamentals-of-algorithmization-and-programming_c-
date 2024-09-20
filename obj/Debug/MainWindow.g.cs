﻿#pragma checksum "..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C3ED8D67CE8DA0699A62CAAECDF0DD45F0AABC5FC442560B43B2B30E1490CA46"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

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


namespace PracticalWork3 {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock CurrentSongName;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider SongPositionSlider;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock NowTime;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock RemainingTime;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider VolumeSlider;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image VolumeIcon;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Play_Button;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Stop_Button;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button PreviousSong_Button;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Pause_Button;
        
        #line default
        #line hidden
        
        
        #line 112 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button NextSong_Button;
        
        #line default
        #line hidden
        
        
        #line 123 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Loop_Button;
        
        #line default
        #line hidden
        
        
        #line 134 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Random_Button;
        
        #line default
        #line hidden
        
        
        #line 145 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button FolderOpen_Button;
        
        #line default
        #line hidden
        
        
        #line 156 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox songList;
        
        #line default
        #line hidden
        
        
        #line 160 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MediaElement mediaElement;
        
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
            System.Uri resourceLocater = new System.Uri("/PracticalWork3;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
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
            this.CurrentSongName = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.SongPositionSlider = ((System.Windows.Controls.Slider)(target));
            
            #line 48 "..\..\MainWindow.xaml"
            this.SongPositionSlider.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.SongPositionSlider_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.NowTime = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.RemainingTime = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.VolumeSlider = ((System.Windows.Controls.Slider)(target));
            
            #line 63 "..\..\MainWindow.xaml"
            this.VolumeSlider.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.VolumeSlider_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.VolumeIcon = ((System.Windows.Controls.Image)(target));
            return;
            case 7:
            this.Play_Button = ((System.Windows.Controls.Button)(target));
            
            #line 69 "..\..\MainWindow.xaml"
            this.Play_Button.Click += new System.Windows.RoutedEventHandler(this.Play_Button_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Stop_Button = ((System.Windows.Controls.Button)(target));
            
            #line 80 "..\..\MainWindow.xaml"
            this.Stop_Button.Click += new System.Windows.RoutedEventHandler(this.Stop_Button_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.PreviousSong_Button = ((System.Windows.Controls.Button)(target));
            
            #line 91 "..\..\MainWindow.xaml"
            this.PreviousSong_Button.Click += new System.Windows.RoutedEventHandler(this.PreviousSong_Button_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.Pause_Button = ((System.Windows.Controls.Button)(target));
            
            #line 102 "..\..\MainWindow.xaml"
            this.Pause_Button.Click += new System.Windows.RoutedEventHandler(this.Pause_Button_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.NextSong_Button = ((System.Windows.Controls.Button)(target));
            
            #line 113 "..\..\MainWindow.xaml"
            this.NextSong_Button.Click += new System.Windows.RoutedEventHandler(this.NextSong_Button_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.Loop_Button = ((System.Windows.Controls.Button)(target));
            
            #line 124 "..\..\MainWindow.xaml"
            this.Loop_Button.Click += new System.Windows.RoutedEventHandler(this.Loop_Button_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            this.Random_Button = ((System.Windows.Controls.Button)(target));
            
            #line 135 "..\..\MainWindow.xaml"
            this.Random_Button.Click += new System.Windows.RoutedEventHandler(this.Random_Button_Click);
            
            #line default
            #line hidden
            return;
            case 14:
            this.FolderOpen_Button = ((System.Windows.Controls.Button)(target));
            
            #line 146 "..\..\MainWindow.xaml"
            this.FolderOpen_Button.Click += new System.Windows.RoutedEventHandler(this.FolderOpen_Button_Click);
            
            #line default
            #line hidden
            return;
            case 15:
            this.songList = ((System.Windows.Controls.ListBox)(target));
            
            #line 158 "..\..\MainWindow.xaml"
            this.songList.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.songList_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 16:
            this.mediaElement = ((System.Windows.Controls.MediaElement)(target));
            
            #line 162 "..\..\MainWindow.xaml"
            this.mediaElement.MediaOpened += new System.Windows.RoutedEventHandler(this.mediaElement_MediaOpened);
            
            #line default
            #line hidden
            
            #line 162 "..\..\MainWindow.xaml"
            this.mediaElement.MediaEnded += new System.Windows.RoutedEventHandler(this.mediaElement_MediaEnded);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


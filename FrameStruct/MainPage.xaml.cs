using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

//“空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409 上有介绍

namespace FrameStruct
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void FrameDemo_Click(object sender, RoutedEventArgs e)
        {
            Sv_splitView.IsPaneOpen = !Sv_splitView.IsPaneOpen;
        }

        private void Sv_Lb_Cls_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (InternetListboxItem.IsSelected)
            {
                ResultShow.Text = "Internet";
            }
            else if (FavoriteListboxItem.IsSelected)
            {
                ResultShow.Text = "Favorites";
            } else if (FingerListboxItem.IsSelected)
            {
                ResultShow.Text = "Finger";
            }
        }
    }
}

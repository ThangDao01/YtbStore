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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace YtbDemo
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        
        }

        private void getLinkResult_Click(object sender, RoutedEventArgs e)
        {
            string html = "<html><head>";
            html += " <meta content='IE=Edge' http-equiv='X-UA-Compatible'/> ";
            html += " <iframe id='video' src= 'https://www.youtube.com/embed/{0}' width='600' height='300' frameborder='0' allowfullscreen  </iframe> ";
            html += " </body></html>";
            //this.webBrowser1.DocumentText = string.Format(html, txtLink.Text.Split('=')[1]);
        }
    }
}

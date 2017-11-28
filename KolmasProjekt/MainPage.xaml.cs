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

namespace KolmasProjekt
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private int tries = 0;
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void signinbtn_Click(object sender, RoutedEventArgs e)
        {
            String username = "vanaisa";
            String password = "admin";

            if (textbox1.Text == "" || passwordbox.Password == "") {
                errortext.Text = "Both fields must be filled!";
            } else if (textbox1.Text != username) {
                tries++;
                errortext.Text = "Username is not correct!";
            } else if(passwordbox.Password != password) {
                tries++;
                errortext.Text = "Password is not correct!";
            } else if (textbox1.Text == username && passwordbox.Password == password && tries < 3) {
                errortext.Text = "Signed in successfully!";
                this.Frame.Navigate(typeof(BlankPage1));
            } else if (tries >= 3) {
                errortext.Text = "Too many login attempts!";
            } else {
                tries++;
                errortext.Text = "Wrong password!";
            }
        }

        private void signinbtn_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            btnrotation.RotationX = 0;
            btnrotation.RotationZ = 0;
            btnrotation.RotationY = 0;
        }

        private void signinbtn_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            btnrotation.RotationX = 5;
            btnrotation.RotationZ = 150;
            btnrotation.RotationY = 9;
        }
    }
}

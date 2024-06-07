using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using static WpfMvvmApp.Windows.AcrylicTransparency;

namespace WpfMvvmApp.Windows
{
    public class AcrylicTransparency
    {
        internal enum AccentState
        {
            ACCENT_DISABLED = 0,
            ACCENT_ENABLE_GRADIENT = 1,
            ACCENT_ENABLE_TRANSPARENTGRADIENT = 2,
            ACCENT_ENABLE_BLURBEHIND = 3,
            ACCENT_ENABLE_ACRYLICBLURBEHIND = 4,
            ACCENT_INVALID_STATE = 5
        }
        [StructLayout(LayoutKind.Sequential)]
        internal struct AccentPolicy
        {
            public AccentState AccentState;
            public uint AccentFlags;
            public uint GradientColor;
            public uint AnimationId;
        }

        [StructLayout(LayoutKind.Sequential)]
        internal struct WindowCompositionAttributeData
        {
            public WindowCompositionAttribute Attribute;
            public IntPtr Data;
            public int SizeOfData;
        }
        internal enum WindowCompositionAttribute
        {
            WCA_ACCENT_POLICY = 19
        }



        [DllImport("user32.dll")]
        internal static extern int SetWindowCompositionAttribute(IntPtr hwnd, ref WindowCompositionAttributeData data);

        private uint _blurOpacity;
        public double BlurOpacity
        {
            get { return _blurOpacity; }
            set { _blurOpacity = (uint)value; EnableBlur(); }
        }

        private uint _blurBackgroundColor = 0x990000; //0x990000;

        private Window window { get; set; }
        private AccentState accentState { get; set; }
        internal void EnableBlur()
        {
            var windowHelper = new WindowInteropHelper(window);
            var accent = new AccentPolicy();


            //To  enable blur the image behind the window
            accent.AccentState = accentState;
            //accent.GradientColor = (_blurOpacity << 24) | (_blurBackgroundColor & 0xFFFFFF); /*(White mask 0xFFFFFF)*/


            var accentStructSize = Marshal.SizeOf(accent);

            var accentPtr = Marshal.AllocHGlobal(accentStructSize);
            Marshal.StructureToPtr(accent, accentPtr, false);

            var data = new WindowCompositionAttributeData();
            data.Attribute = WindowCompositionAttribute.WCA_ACCENT_POLICY;
            data.SizeOfData = accentStructSize;
            data.Data = accentPtr;

            SetWindowCompositionAttribute(windowHelper.Handle, ref data);

            Marshal.FreeHGlobal(accentPtr);
        }

        //to call blur in our desired window
        internal AcrylicTransparency(Window window, AccentState accentState)
        {
            this.window = window;
            this.accentState = accentState;
            EnableBlur();
        }

    }



    /// <summary>
    /// OpacityWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class OpacityWindow : Window
    {
        public OpacityWindow()
        {
            InitializeComponent();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //To move our window on mouse down
            if (e.ChangedButton == MouseButton.Left)
                DragMove();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.DataContext = new AcrylicTransparency(this, AccentState.ACCENT_ENABLE_BLURBEHIND) { BlurOpacity = 100 };
        }
    }
}

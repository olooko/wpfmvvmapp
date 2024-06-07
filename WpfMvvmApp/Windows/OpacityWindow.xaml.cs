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

namespace WpfMvvmApp.Windows
{
    public class AcrylicTransparency
    {
        [DllImport("user32.dll")]
        internal static extern int SetWindowCompositionAttribute(IntPtr hwnd, ref WindowCompositionAttributeData data);

        public enum WindowCompositionAttribute
        {
            WCA_ACCENT_POLICY = 19
        }

        public enum AccentState
        {
            ACCENT_DISABLED = 0,
            ACCENT_ENABLE_GRADIENT = 1,
            ACCENT_ENABLE_TRANSPARENTGRADIENT = 2,
            ACCENT_ENABLE_BLURBEHIND = 3,
            ACCENT_INVALID_STATE = 4
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct WindowCompositionAttributeData
        {
            #region Field 
            public WindowCompositionAttribute Attribute;
            public IntPtr DataHandle;
            public int DataCount;
            #endregion
        }

        [StructLayout(LayoutKind.Sequential)]
        internal struct AccentPolicy
        {
            public AccentState AccentState;
            public int AccentFlags;
            public int GradientColor;
            public int AnimationId;
        }

        public static void turnOn(Window win)
        {
            IntPtr hwnd = new WindowInteropHelper(win).Handle;
            if (hwnd == IntPtr.Zero)
                throw new InvalidProgramException("에러!!!!!");
            win.Background = Brushes.Transparent;
            HwndSource.FromHwnd(hwnd).CompositionTarget.BackgroundColor = Colors.Transparent;
            AccentPolicy accent = new AccentPolicy();
            int accentStructSize = Marshal.SizeOf(accent);
            accent.AccentState = AccentState.ACCENT_ENABLE_BLURBEHIND;
            IntPtr accentPtr = Marshal.AllocHGlobal(accentStructSize);
            Marshal.StructureToPtr(accent, accentPtr, false);
            WindowCompositionAttributeData data = new WindowCompositionAttributeData();
            data.Attribute = WindowCompositionAttribute.WCA_ACCENT_POLICY;
            data.DataCount = accentStructSize;
            data.DataHandle = accentPtr;
            SetWindowCompositionAttribute(hwnd, ref data);
            Marshal.FreeHGlobal(accentPtr);
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            AcrylicTransparency.turnOn(this);
        }
    }
}

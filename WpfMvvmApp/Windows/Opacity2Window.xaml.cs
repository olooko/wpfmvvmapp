using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
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
using System.Security;
using System.Runtime.InteropServices;

namespace WpfMvvmApp.Windows
{

    [SuppressUnmanagedCodeSecurity]
    public static class NativeMethods
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct DWM_BLURBEHIND
        {
            public DWM_BB dwFlags;
            public bool fEnable;
            public IntPtr hRgnBlur;
            public bool fTransitionOnMaximized;
        }

        [Flags]
        public enum DWM_BB
        {
            DWM_BB_ENABLE = 1,
            DWM_BB_BLURREGION = 2,
            DWM_BB_TRANSITIONONMAXIMIZED = 4
        }

        [DllImport("dwmapi.dll", PreserveSig = false)]
        public static extern bool DwmIsCompositionEnabled();

        [DllImport("dwmapi.dll", PreserveSig = false)]
        public static extern void DwmEnableBlurBehindWindow(IntPtr hwnd, ref DWM_BLURBEHIND blurBehind);
    }

    /// <summary>
    /// Opacity2Window.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Opacity2Window : Window
    {
        public Opacity2Window()
        {
            InitializeComponent();


            WindowStyle = WindowStyle.None;
            AllowsTransparency = true;

            SourceInitialized += OnSourceInitialized;
        }

        private void OnSourceInitialized(object sender, EventArgs eventArgs)
        {
            if (!NativeMethods.DwmIsCompositionEnabled())
                return;

            var hwnd = new WindowInteropHelper(this).Handle;

            var hwndSource = HwndSource.FromHwnd(hwnd);
            var sizeFactor = hwndSource.CompositionTarget.TransformToDevice.Transform(new Vector(1.0, 1.0));

            Background = System.Windows.Media.Brushes.Transparent;
            hwndSource.CompositionTarget.BackgroundColor = Colors.Transparent;

            using (var path = new GraphicsPath())
            {
                path.AddEllipse(0, 0, (int)(ActualWidth * sizeFactor.X), (int)(ActualHeight * sizeFactor.Y));

                using (var region = new Region(path))
                using (var graphics = Graphics.FromHwnd(hwnd))
                {
                    var hRgn = region.GetHrgn(graphics);

                    var blur = new NativeMethods.DWM_BLURBEHIND
                    {
                        dwFlags = NativeMethods.DWM_BB.DWM_BB_ENABLE | NativeMethods.DWM_BB.DWM_BB_BLURREGION | NativeMethods.DWM_BB.DWM_BB_TRANSITIONONMAXIMIZED,
                        fEnable = true,
                        hRgnBlur = hRgn,
                        fTransitionOnMaximized = true
                    };

                    NativeMethods.DwmEnableBlurBehindWindow(hwnd, ref blur);

                    region.ReleaseHrgn(hRgn);
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ReZe
{
    internal class enumdisplay
    {
        [DllImport("user32.dll")]
        static extern bool EnumDisplaySettings(

        string deviceName,
        int modeNum,
        ref DEVMODE devMode

        );

        const int ENUM_CURRENT_SETTINGS = -1;
        const int ENUM_REGISTRY_SETTINGS = -2;

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        struct DEVMODE
        {
            private const int CCHDEVICENAME = 32;
            private const int CCHFORMNAME = 32;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CCHDEVICENAME)]
            public string dmDeviceName;

            public short dmSpecVersion;
            public short dmDriverVersion;
            public short dmSize;
            public short dmDriverExtra;
            public int dmFields;

            public int dmPositionX;
            public int dmPositionY;
            public int dmDisplayOrientation;
            public int dmDisplayFixedOutput;

            public short dmColor;
            public short dmDuplex;
            public short dmYResolution;
            public short dmTTOption;
            public short dmCollate;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CCHFORMNAME)]
            public string dmFormName;

            public short dmLogPixels;
            public int dmBitsPerPel;
            public int dmPelsWidth;
            public int dmPelsHeight;
            public int dmDisplayFlags;
            public int dmDisplayFrequency;
        }

        private static (int w, int h) get_displayResolution()
        {
            DEVMODE dm = new DEVMODE();
            dm.dmSize = (short)Marshal.SizeOf(typeof(DEVMODE));
            EnumDisplaySettings(null, ENUM_CURRENT_SETTINGS, ref dm);
            return (dm.dmPelsWidth, dm.dmPelsHeight); // return resolution
        }

        private static List<int> get_refreshRates()
        {
            var(w, h) = get_displayResolution();

            HashSet<int> rates = new HashSet<int>();
            DEVMODE dm = new DEVMODE();
            dm.dmSize = (short)Marshal.SizeOf(typeof(DEVMODE));

            int i = 0;
            while(EnumDisplaySettings(null, i, ref dm)) {
                if (dm.dmPelsWidth == w && dm.dmPelsHeight == h && dm.dmDisplayFrequency >= 48)
                {
                    rates.Add(dm.dmDisplayFrequency);
                }
                i++;
            }
            return rates.OrderBy(r => r).ToList(); // return sorted.
        }
    }
}

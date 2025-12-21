using System;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection;
// refresh rate detection import
using System.Runtime.InteropServices;
using System.Xml.Linq;


namespace ReZe
{
    public partial class ReZe : Form
    {

        string config_applist = ".\\applist_config.txt";
        string[] applist;

        string config_settings = ".\\settings_config.txt";
        string[] settings;
        public ReZe()
        {
            InitializeComponent();
            applist_init();
            config_init();

            // place holder methods

            placeholder_ui();
        }

        // EnumDisplaySettings

        [DllImport("user32.dll")]
        static extern bool EnumDisplaySettings(
        string deviceName,
        int modeNum,
        ref DEVMODE devMode
);

        const int ENUM_CURRENT_SETTINGS = -1;
        const int ENUM_REGISTRY_SETTINGS = -2;

        // Define DEV MODE

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



        // Enum Display Settings


        private void placeholder_ui()
        {
            // marked to modify ui not implemented but already in the design

            rb_pwrPlugged.Checked = true;
            rb_pwrPlugged.Enabled = false;
        }
        private void btn_add_Click(object sender, EventArgs e)
        {

            String filePath = string.Empty;

            OpenFileDialog add_program = new OpenFileDialog();
            add_program.Title = "Add a program";
            add_program.InitialDirectory = @"C:\";
            add_program.Filter = "Executable files (*.exe)|*.exe|All files (*.*)|*.*";
            add_program.FilterIndex = 0;
            add_program.RestoreDirectory = true;

            if (add_program.ShowDialog() == DialogResult.OK)
            {
                filePath = add_program.FileName;
                File.AppendAllText(config_applist, filePath + Environment.NewLine);
                list_app.Items.Add(Path.GetFileName(filePath));

                File.AppendAllText(config_settings, Path.GetFileName(filePath));

                get_refreshrate();
            }
            else
            {
                MessageBox.Show("Invalid Directory");
            }

        }

        private void applist_read()
        {
            applist_init();
            foreach (string line in applist)
            {
                list_app.Items.Add(line);
            }
        }

        private void applist_init()  // method for config check and reading.
        {

            if (!File.Exists(config_applist))
            {
                File.Create(config_applist); // create empty congfig
                MessageBox.Show("Config file created. Add some Programs first.");
            }
            else
            {
                applist = File.ReadAllLines(config_applist);
                foreach (string line in applist)
                {
                    string name = Path.GetFileName(line); //    filters only the exe name.
                    list_app.Items.Add(name);
                }
            }

        }

        private void config_init()
        {
            if (!File.Exists(config_settings))
            {
                File.Create(config_settings);
                MessageBox.Show("Config Settings created");
            }
        }

        /*
         I wanted to seperate the applist and config on an ini text file for easy reading the config
        Format: exe name, refresh rate, fps cap, rendering res , DLSS mode (if supported)
         */

        private void plugged_config_init() // stores the settings
        {

        }



        private void debugWMIToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        public int get_configrr(string exeName)
        {
            string line = File.ReadLines(config_settings)
                              .FirstOrDefault(l => l.StartsWith(exeName + ",", StringComparison.OrdinalIgnoreCase));

            if (line == null)
                return 0;

            string[] parts = line.Split(',');
            if (parts.Length < 2)
                return 0;

            if (int.TryParse(parts[1], out int value))
                return value;

            return 0;
        }
        private void list_app_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = list_app.SelectedIndex;

            string[] lines = File.ReadAllLines("applist_config.txt");

            string selected_program = lines[index];

            get_refreshrate();

            int rr = get_configrr(Path.GetFileName(selected_program));

            if (rr == 0)
            {
                cb_rr.SelectedIndex = 0;
            }
            else
            {
                cb_rr.SelectedItem = rr;
            }

            current_refresh.Text = "Current: " + rr;

        }

        // Implement refresh rate changer first

        // filter out only the current native resolution on refresh mode

        public static (int Width, int Height) GetCurrentResolution()
        {
            DEVMODE dm = new DEVMODE();
            dm.dmSize = (short)Marshal.SizeOf(typeof(DEVMODE));

            EnumDisplaySettings(null, ENUM_CURRENT_SETTINGS, ref dm);

            return (dm.dmPelsWidth, dm.dmPelsHeight);
        }


        public static List<int> enum_refreshrates()
        {
            var (nativeW, nativeH) = GetCurrentResolution();

            HashSet<int> rates = new HashSet<int>();
            DEVMODE dm = new DEVMODE();
            dm.dmSize = (short)Marshal.SizeOf(typeof(DEVMODE));

            int i = 0;
            while (EnumDisplaySettings(null, i, ref dm))
            {
                if (dm.dmPelsWidth == nativeW &&
                    dm.dmPelsHeight == nativeH &&
                    dm.dmDisplayFrequency > 1)
                {
                    rates.Add(dm.dmDisplayFrequency);
                }
                i++;
            }

            return rates.OrderBy(r => r).ToList();
        }

        public void get_refreshrate()
        {
            var hz = enum_refreshrates();

            cb_rr.Items.Clear();

            foreach (int r in hz)
            {
                cb_rr.Items.Add($"{r} Hz");
            }

            cb_rr.SelectedIndex = 0;
        }

        private void btn_apply_Click(object sender, EventArgs e)
        {
            int index = list_app.SelectedIndex;
            if (index == -1) return; // no selection

            string[] lines = File.ReadAllLines("applist_config.txt");
            if (index >= lines.Length) return;

            string selected_program = lines[index];
            string exeName = Path.GetFileName(selected_program).Split(',')[0]; // exe name only

            if (cb_rr.SelectedItem == null) return;

            int newValue = int.Parse(System.Text.RegularExpressions.Regex.Match(cb_rr.SelectedItem.ToString(), @"\d+").Value);

            var configLines = File.Exists(config_settings)
                                ? File.ReadAllLines(config_settings).ToList()
                                : new List<string>();

            // Match by exe name only
            int existingIndex = configLines.FindIndex(l =>
            {
                string lineExeName = l.Split(',')[0];
                return string.Equals(lineExeName, exeName, StringComparison.OrdinalIgnoreCase);
            });

            string newLine = $"{exeName},{newValue}";

            if (existingIndex >= 0)
            {
                configLines[existingIndex] = newLine; // replace
            }
            else
            {
                configLines.Add(newLine); // append
            }

            File.WriteAllLines(config_settings, configLines);

            MessageBox.Show($"Value for {exeName} updated to {newValue}.");
            current_refresh.Text = "Current: " + newValue;
        }


        private void current_refresh_Click(object sender, EventArgs e)
        {

        }
    }
}

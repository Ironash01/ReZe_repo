using System.Drawing.Imaging;

namespace ReZe
{
    public partial class ReZe : Form
    {
        public ReZe()
        {
            InitializeComponent();
            config_init();
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
            }
        }

        private void config_read()
        {

        }

        private void config_init()  // method for config check and reading.
        {

            string config_applist = ".\\applist_config.txt";
            string[] programs;

            if (!File.Exists(config_applist))
            {
                File.Create(config_applist); // create empty congfig
                MessageBox.Show("Config file created. Add some Programs first.");
            } else
            {
                programs = File.ReadAllLines(config_applist);
                foreach (string line in programs)
                {
                    string name = Path.GetFileName(line); //    filters only the exe name.
                    list_app.Items.Add(name);
                }
            }

        }
    }
}

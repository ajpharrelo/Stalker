using Stalker;
using System.Diagnostics;

namespace StalkerUI
{
    public partial class Main : Form
    {
        private List<TProcess> processList = TProcess.ReadProcessList(
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Stalker\list.json");

        private List<TProcessSession> sessionList = TProcessSession.ReadSessionList(
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Stalker\sessions.json");

        private string listPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Stalker\list.json";
        private string selectedGame = "";
        private bool sessionVisible = false;

        public Main()
        {
            InitializeComponent();
            this.SizeChanged += Main_SizeChanged;
        }

        private void Main_SizeChanged(object? sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Maximized)
            {
                btnSessions.Visible = false;
            }
            else
            {
                btnSessions.Visible = true;
            }
        }

        private void UpdateSessions()
        {
            foreach (TProcessSession ps in sessionList)
            {
                if (ps.ID == selectedApp.ID)
                {
                    sessionGridView.Rows.Add(ps.SessionDate, ps.StartTime, ps.ExitTime);
                }
            }
        }

        private void UpdateListBox()
        {
            processListBox.Items.Clear();
            foreach (TProcess tp in processList)
            {
                processListBox.Items.Add(tp.Name);
            }
        }

        private TProcess selectedApp;

        private void Main_Load(object sender, EventArgs e)
        {
            Height = 404;
            UpdateListBox();
        }

        private void processListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(processListBox.SelectedItem != null)
            {
                selectedGame = processListBox.SelectedItem.ToString();
                selectedApp = processList.Find(x => x.Name == selectedGame);

                gbxAppControls.Text = "Selected - " + selectedGame;
                lblAppGuid.Text = "GUID: " + selectedApp.ID.ToString();
                lblExecPath.Text = "Executable path: " + selectedApp.ExecutablePath;
                lblSession.Text = selectedApp.Name + " - Sessions";
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            if (txtNewAppPath.Text != "" && txtNewName.Text != "")
            {
                if (File.Exists(txtNewAppPath.Text))
                {

                    TProcess tp = new TProcess()
                    {
                        Name = txtNewName.Text,
                        ExecutablePath = txtNewAppPath.Text,
                        ID = Guid.NewGuid()
                    };

                    processList.Add(tp);
                    TProcess.WriteProcessList(listPath, processList);
                    TProcess.ReadProcessList(listPath);
                    UpdateListBox();
                }
                else
                {
                    MessageBox.Show("Selected executable file does not exist", "Error", default, MessageBoxIcon.Error);
                }

                

            }
            else
            {
                MessageBox.Show("All fields need to be filled", "Missing fields", default, MessageBoxIcon.Error);
            }
        }

        private void btnAddBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();

            fd.Filter = "Executable files (*.exe)|*.exe";
            fd.RestoreDirectory = true;

            if (fd.ShowDialog() == DialogResult.OK)
            {
                txtNewAppPath.Text = fd.FileName;
            }    
            else
            {
                MessageBox.Show("You must select an executable file.", "No executable chosen", default, MessageBoxIcon.Error);
            }

            
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            processList.Remove(selectedApp);
            TProcess.WriteProcessList(listPath, processList);
            UpdateListBox();
        }

        private void btnSessions_Click(object sender, EventArgs e)
        {
            if(sessionVisible == false)
            {
                btnSessions.Text = "Hide Sessions";
                sessionVisible = true;
                this.Height = 920;
            }
            else
            {
                btnSessions.Text = "View Sessions";
                sessionVisible = false;
                this.Height = 404;
            }
        }
    }
}
namespace MTGAM;

public partial class MainForm : Form {
    private readonly (Guid create, Guid save, Guid load) dialogGUID =
        (Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid());
    private AddonConfigFile? acf;
    private void CreatePlugin(String root) {
        // TODO
    }
    private void TryToLoadPlugin(String root) {
        TB_PluginRoot.Text = root;
        if (!AddonConfigFile.IsValidPlugin(root)) {
            CB_ValidPath.Checked = false;
            return;
        }
        CB_ValidPath.Checked = true;
    }
    public MainForm() {
        this.InitializeComponent();
    }

    private void MainForm_Load(object sender, EventArgs e) {

    }

    private void TSMI_Exit_Click(object sender, EventArgs e) {
        this.Close();
    }

    private void TSMI_StartSync_Click(object sender, EventArgs e) {
        //FileSystemWatcher watcher = new();
        //FolderBrowserDialog fbd = new();
    }

    private void TSMI_NewAddon_Click(object sender, EventArgs e) {
        FolderBrowserDialog fbd = new() {
            ClientGuid = dialogGUID.create,
            Description = "Specify a destination folder for the new Addon.",
            RootFolder = Environment.SpecialFolder.Favorites,
            InitialDirectory = "",
            AutoUpgradeEnabled = true,
            ShowNewFolderButton = true,
            ShowPinnedPlaces = true,
            UseDescriptionForTitle = true
        };
        _ = fbd.ShowDialog();
        if (fbd.SelectedPath == String.Empty)
            return;
        this.CreatePlugin(fbd.SelectedPath);
    }

    private void TSMI_Load_Click(object sender, EventArgs e) {
        FolderBrowserDialog fbd = new() {
            ClientGuid = dialogGUID.load,
            Description = "Select a folder that contains a 'plugin.cfg' file.",
            RootFolder = Environment.SpecialFolder.MyComputer,
            InitialDirectory = "",
            AutoUpgradeEnabled = true,
            ShowNewFolderButton = false,
            ShowPinnedPlaces = true,
            UseDescriptionForTitle = true,
        };
        _ = fbd.ShowDialog();
        if (fbd.SelectedPath == String.Empty)
            return;
        this.TryToLoadPlugin(fbd.SelectedPath);
    }
}

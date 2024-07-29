namespace MTGAM;

public partial class MainForm : Form {
    private readonly (Guid create, Guid save, Guid load) dialogGUID =
        (Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid());
    private AddonConfigFile? acf;
    /// <summary>
    /// Shows a <see cref="FolderBrowserDialog"/>, so that the user can select a plugin directory. If one is selected, <see cref="TryToLoadPlugin"/> will be called.
    /// </summary>
    private void ShowLoadPluginDialog() {
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
        DialogResult res = fbd.ShowDialog();
        if (res == DialogResult.Cancel)
            return;
        this.TryToLoadPlugin(fbd.SelectedPath);
    }
    private void submitChange(object? sender, EventArgs? e) { }
    private void refreshInfo() {
        if (this.acf is null) {
            B_Reload.Enabled = false;
            B_SaveChanges.Enabled = false;
            return;
        }
        B_Reload.Enabled = true;
        B_SaveChanges.Enabled = true;
        TB_Name.Text = this.acf.FindValue("name");
        TB_Description.Text = this.acf.FindValue("description");
        TB_Author.Text = this.acf.FindValue("author");
        TB_Version.Text = this.acf.FindValue("version");
        TB_Script.Text = this.acf.FindValue("script");
    }
    private void CreatePlugin(String root) {
        //this.acf = new(root) {
        //    Name = TB_Name.Text,
        //    Description = TB_Description.Text,
        //    Author = TB_Author.Text,
        //    Version = TB_Version.Text,
        //    Script = TB_Script.Text
        //};
        if (this.acf is not null)
            return;
        //String cfgData = this.acf.Compile();
        File.WriteAllText(this.acf.FilePath, null);
    }
    private void TryToLoadPlugin(String root) {
        TB_PluginRoot.Text = root;
        if (!AddonConfigFile.DirectoryIsValidPlugin(root)) {
            CB_ValidPath.Checked = false;
            return;
        }
        CB_ValidPath.Checked = true;
        this.acf = new(root);
        this.refreshInfo();
    }
    public MainForm() {
        this.InitializeComponent();
    }

    private void MainForm_Load(object sender, EventArgs e) {
        TB_Author.Text = Environment.UserName;
    }

    private void TSMI_Exit_Click(object sender, EventArgs e) {
        this.Close();
    }

    private void TSMI_StartSync_Click(object sender, EventArgs e) { }

    private void TSMI_NewAddon_Click(object sender, EventArgs e) {
        FolderBrowserDialog fbd = new() {
            ClientGuid = dialogGUID.load,
            Description = "Select a folder that will contain a 'plugin.cfg' file.",
            RootFolder = Environment.SpecialFolder.MyComputer,
            InitialDirectory = "",
            AutoUpgradeEnabled = true,
            ShowNewFolderButton = false,
            ShowPinnedPlaces = true,
            UseDescriptionForTitle = true,
        };
        DialogResult res = fbd.ShowDialog();
        if (res == DialogResult.Cancel)
            return;
        this.acf = new(fbd.SelectedPath);
        this.acf.Create();
    }

    private void TSMI_Load_Click(object sender, EventArgs e) {
        this.ShowLoadPluginDialog();
    }

    private void TB_PluginRoot_Click(object sender, EventArgs e) {
        this.ShowLoadPluginDialog();
    }

    private void B_Reload_Click(object sender, EventArgs e) {
        this.refreshInfo();
    }

    private void TB_Script_Click(object sender, EventArgs e) {

    }
}

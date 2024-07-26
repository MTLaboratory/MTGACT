namespace MTGAM;
internal class AddonConfigFile {
    public static Boolean IsValidPlugin(String root) {
        return Directory.Exists(root) && File.Exists($"{root}\\plugin.cfg");
    }
    private String rootPath;
    public Boolean Exists {
        get {
            return File.Exists($"{rootPath}\\plugin.cfg");
        }
    }

    public AddonConfigFile(String root) {
        rootPath = root.Trim();
    }

    public void Assert() {

    }
}

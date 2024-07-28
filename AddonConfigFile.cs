using System.Text.RegularExpressions;

namespace MTGAM;
public class AddonConfigFile {
    public String Name, Description, Author, Version, Script;
    private MTLib.Generative.SyntacticGenerator cfgGenerator = new() {
        Language = "cfg",
        Literals = new() {
            {0b000, "[plugin]"},
            {0b001, "\r\nname="},
            {0b010, "\r\ndescription="},
            {0b100, "\r\nauthor="},
            {0b011, "\r\nversion="},
            {0b101, "\r\nscript="},
            {0b111, "\r\n"},
        }
    };
    public String Compile() {
        _ = cfgGenerator.Result.Clear();
        _ = cfgGenerator.Write(0b000).Write(0b111).Write(0b001);
        _ = cfgGenerator.Write("\"" + Name + "\"").Write(0b010);
        _ = cfgGenerator.Write("\"" + Description + "\"").Write(0b100);
        _ = cfgGenerator.Write("\"" + Author + "\"").Write(0b011);
        _ = cfgGenerator.Write("\"" + Version + "\"").Write(0b101);
        _ = cfgGenerator.Write("\"" + Script + "\"").Write(0b111);
        return cfgGenerator.ToString();
    }
    /// <summary>
    /// Determines if the given path exists, and if it contains a file named 'plugin.cfg'.
    /// </summary>
    /// <param name="root">path to search for plugin</param>
    /// <returns><c>true</c>, if the <paramref name="root"/> path contains a valid Godot plugin.</returns>
    public static Boolean DirectoryIsValidPlugin(String root) {
        return Directory.Exists(root) && File.Exists($"{root}\\plugin.cfg");
    }
    private String rootPath;

    public String FindValue(String key) {
        Match match = new Regex(@"\b" + key + @"\s*=\s*\x22([^\x22]*)\x22").Match(File.ReadAllText($"{rootPath}\\plugin.cfg"));
        return !match.Success
            ? throw new KeyNotFoundException() : match.Groups[1].Value;
    }
    public Boolean Exists {
        get {
            return File.Exists($"{rootPath}\\plugin.cfg");
        }
    }
    public void Create() {
        if (this.Exists)
            return;
        // TODO
    }
    public AddonConfigFile(String root) {
        rootPath = root.Trim();
    }
}

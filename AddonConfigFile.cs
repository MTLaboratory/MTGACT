using System.Text.RegularExpressions;

namespace MTGAM;
public class AddonConfigFile {
    public struct Parameters {
        public String Name, Description, Author, Version, Script;
    }
    public Parameters Params;
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
    /// <summary>
    /// Compiles the cfg file into a <see cref="String"/>.
    /// </summary>
    /// <returns><see cref="String"/> contents of the cfg file</returns>
    public String Compile() {
        _ = cfgGenerator.Result.Clear();
        _ = cfgGenerator.Write(0b000).Write(0b111).Write(0b001);
        _ = cfgGenerator.Write("\"" + Params.Name + "\"").Write(0b010);
        _ = cfgGenerator.Write("\"" + Params.Description + "\"").Write(0b100);
        _ = cfgGenerator.Write("\"" + Params.Author + "\"").Write(0b011);
        _ = cfgGenerator.Write("\"" + Params.Version + "\"").Write(0b101);
        _ = cfgGenerator.Write("\"" + Params.Script + "\"").Write(0b111);
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
    /// <summary>
    /// Searches the <c>plugin.cfg</c> file for the given <paramref name="key"/>.
    /// </summary>
    /// <param name="key">Key to find</param>
    /// <returns>the value associated with the <paramref name="key"/></returns>
    /// <exception cref="KeyNotFoundException">If the <paramref name="key"/> cannot be found.</exception>
    public String FindValue(String key) {
        Match match = new Regex(@"\b" + key + @"\s*=\s*\x22([^\x22]*)\x22").Match(File.ReadAllText(this.FilePath));
        return !match.Success
            ? throw new KeyNotFoundException() : match.Groups[1].Value;
    }
    /// <summary>
    /// Determines if the <c>plugin.cfg</c> file currently exists on the filesystem.
    /// </summary>
    public Boolean Exists {
        get {
            return File.Exists(this.FilePath);
        }
    }
    /// <summary>
    /// Determines the full <c>plugin.cfg</c> Path. As long as the <c>root</c> is properly set, this will work.
    /// </summary>
    public String FilePath {
        get {
            return $"{rootPath}\\plugin.cfg";
        }
    }
    /// <summary>
    /// Creates the plugin file (.cfg) structure, if it is not present.
    /// </summary>
    /// <exception cref="InvalidOperationException"></exception>
    public void Create() {
        if (this.Exists)
            throw new InvalidOperationException();
        File.WriteAllText(this.FilePath, this.Compile());
    }
    public AddonConfigFile(String root) {
        rootPath = root.Trim();
    }
}

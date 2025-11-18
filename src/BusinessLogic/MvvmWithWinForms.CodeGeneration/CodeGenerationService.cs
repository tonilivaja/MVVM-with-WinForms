using MvvmWithWinForms.CodeGeneration.Contracts;

namespace MvvmWithWinForms.CodeGeneration;

/// <summary>
/// A simple code generation service that simulates code generation by writing a string to a log file.
/// It will ensure the target directory exists before writing and appends a timestamp.
/// </summary>
public class CodeGenerationService : ICodeGenerationService
{
    public string Generate(string path, string code)
    {
        if (string.IsNullOrWhiteSpace(path))
            throw new ArgumentException("Path must not be null or empty.", nameof(path));

        var ts = DateTime.Now.ToString("s");
        var entry = $"[{ts}] {code}{Environment.NewLine}";

        // Ensure directory exists
        var dir = Path.GetDirectoryName(path);
        if (!string.IsNullOrEmpty(dir) && !Directory.Exists(dir))
        {
            Directory.CreateDirectory(dir);
        }

        // Append the generated code/text to the file
        File.AppendAllText(path, entry);

        return entry;
    }
}

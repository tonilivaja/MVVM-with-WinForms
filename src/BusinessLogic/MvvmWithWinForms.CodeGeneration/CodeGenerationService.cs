namespace MvvmWithWinForms.CodeGeneration;

public interface ICodeGenerationService
{
	/// <summary>
	/// Generate a code-like string from a template name and body. For the demo this
	/// simply returns a formatted message that can be logged by the UI.
	/// </summary>
	string Generate(string templateName, string templateBody);
}

public class CodeGenerationService : ICodeGenerationService
{
	public string Generate(string templateName, string templateBody)
	{
		var ts = DateTime.Now.ToString("s");
		var safeName = string.IsNullOrWhiteSpace(templateName) ? "(unnamed)" : templateName.Trim();
		var safeBody = templateBody ?? string.Empty;
		return $"[{ts}] Generated '{safeName}': {safeBody}";
	}
}

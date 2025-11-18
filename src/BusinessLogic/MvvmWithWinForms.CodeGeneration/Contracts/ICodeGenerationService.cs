namespace MvvmWithWinForms.CodeGeneration.Contracts;

public interface ICodeGenerationService
{
    string Generate(string path, string code);
}

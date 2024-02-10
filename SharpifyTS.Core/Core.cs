namespace SharpifyTS;

public struct TranspileOptions
{
    public CompilerOptions? CompilerOptions { get; set; }
    public string? FileName { get; set; }
}

public struct TranspileOutput
{
    public string OutputText { get; set; }
    public string? SourceMapText { get; set; }
}

public static class Core
{
    public static TranspileOutput Transpile(string input, TranspileOptions options)
    {
        var c = new {};
        return default;
    }
}
namespace SharpifyTS;

public abstract class CompilerOptions(
    string baseUrl,
    string charset,
    string declarationDir,
    List<string> lib,
    string locale,
    string mapRoot,
    string @out,
    string outDir,
    string outFile,
    IDictionary<string, IEnumerable<string>> paths,
    string project,
    string reactNamespace,
    IEnumerable<IProjectReference> references,
    string rootDir,
    IEnumerable<string> rootDirs,
    string sourceRoot,
    IEnumerable<string> types,
    IEnumerable<string> typeRoots)
{
    public bool? AllowJs { get; set; }
    public bool? AllowSyntheticDefaultImports { get; set; }
    public bool? AllowUnreachableCode { get; set; }
    public bool? AllowUnusedLabels { get; set; }
    public bool? AlwaysStrict { get; set; }
    public string BaseUrl { get; set; } = baseUrl;
    public string Charset { get; set; } = charset;
    public bool? CheckJs { get; set; }
    public bool? Declaration { get; set; }
    public string DeclarationDir { get; set; } = declarationDir;
    public bool? DisableSizeLimit { get; set; }
    public bool? DownlevelIteration { get; set; }
    public bool? EmitBOM { get; set; }
    public bool? EmitDecoratorMetadata { get; set; }
    public bool? ExperimentalDecorators { get; set; }
    public bool? ForceConsistentCasingInFileNames { get; set; }
    public bool? ImportHelpers { get; set; }
    public bool? InlineSourceMap { get; set; }
    public bool? InlineSources { get; set; }
    public bool? IsolatedModules { get; set; }
    public JsxEmit? Jsx { get; set; }
    public List<string> Lib { get; set; } = lib;
    public string Locale { get; set; } = locale;
    public string MapRoot { get; set; } = mapRoot;
    public int? MaxNodeModuleJsDepth { get; set; }
    public ModuleKind? Module { get; set; }
    public ModuleResolutionKind? ModuleResolution { get; set; }
    public NewLineKind? NewLine { get; set; }
    public bool? NoEmit { get; set; }
    public bool? NoEmitHelpers { get; set; }
    public bool? NoEmitOnError { get; set; }
    public bool? NoErrorTruncation { get; set; }
    public bool? NoFallthroughCasesInSwitch { get; set; }
    public bool? NoImplicitAny { get; set; }
    public bool? NoImplicitReturns { get; set; }
    public bool? NoImplicitThis { get; set; }
    public bool? NoUnusedLocals { get; set; }
    public bool? NoUnusedParameters { get; set; }
    public bool? NoImplicitUseStrict { get; set; }
    public bool? NoLib { get; set; }
    public bool? NoResolve { get; set; }
    public string Out { get; set; } = @out;
    public string OutDir { get; set; } = outDir;
    public string OutFile { get; set; } = outFile;
    public IDictionary<string, IEnumerable<string>> Paths { get; set; } = paths;
    public bool? PreserveConstEnums { get; set; }
    public bool? PreserveSymlinks { get; set; }
    public string Project { get; set; } = project;
    public string ReactNamespace { get; set; } = reactNamespace;
    public bool? RemoveComments { get; set; }
    public IEnumerable<IProjectReference> References { get; set; } = references;
    public string RootDir { get; set; } = rootDir;
    public IEnumerable<string> RootDirs { get; set; } = rootDirs;
    public bool? SkipLibCheck { get; set; }
    public bool? SkipDefaultLibCheck { get; set; }
    public bool? SourceMap { get; set; }
    public string SourceRoot { get; set; } = sourceRoot;
    public bool? Strict { get; set; }
    public bool? StrictNullChecks { get; set; }
    public bool? SuppressExcessPropertyErrors { get; set; }
    public bool? SuppressImplicitAnyIndexErrors { get; set; }
    public bool? UseDefineForClassFields { get; set; }
    public ScriptTarget? Target { get; set; }
    public bool? TraceResolution { get; set; }
    public bool? ResolveJsonModule { get; set; }
    public IEnumerable<string> Types { get; set; } = types;
    public IEnumerable<string> TypeRoots { get; set; } = typeRoots;
    public abstract CompilerOptionsValue this[string option] { get; set; }
}

public enum JsxEmit
{
    None,
    Preserve,
    React,
    ReactNative
}

public enum ModuleKind
{
    None,
    CommonJS,
    AMD,
    UMD,
    System,
    ES6,
    ES2015,
    ESNext,
    Node16,
    NodeNext,
    Preserve
}

public enum ModuleResolutionKind
{
    Classic,
    Node,
    Node10,
    Node16,
    NodeNext,
    Bundler
}

public enum NewLineKind
{
    Crlf,
    Lf
}

public enum ScriptTarget
{
    ES3,
    ES5,
    ES2015,
    ES2016,
    ES2017,
    ES2018,
    ES2019,
    ES2020,
    ESNext
}

public interface IProjectReference
{
    public string Path { get; set; }
    public string OriginalPath { get; set; }
    public bool? Prepend { get; set; }
    public bool? Circular { get; set; }
}

[TSUnion(typeof(string), typeof(int), typeof(bool), typeof(string[]), typeof(int[]))]
public partial struct CompilerOptionsValue;
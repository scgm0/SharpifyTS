namespace SharpifyTS;

public interface ICompilerOptions
{
    public bool? AllowJs { get; set; }
    public bool? AllowSyntheticDefaultImports { get; set; }
    public bool? AllowUnreachableCode { get; set; }
    public bool? AllowUnusedLabels { get; set; }
    public bool? AlwaysStrict { get; set; }
    public string BaseUrl { get; set; }
    public string Charset { get; set; }
    public bool? CheckJs { get; set; }
    public bool? Declaration { get; set; }
    public string DeclarationDir { get; set; }
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
    public List<string> Lib { get; set; }
    public string Locale { get; set; }
    public string MapRoot { get; set; }
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
    public string Out { get; set; }
    public string OutDir { get; set; }
    public string OutFile { get; set; }
    public Dictionary<string, string[]> Paths { get; set; }
    public bool? PreserveConstEnums { get; set; }
    public bool? PreserveSymlinks { get; set; }
    public string Project { get; set; }
    public string ReactNamespace { get; set; }
    public bool? RemoveComments { get; set; }
    public IEnumerable<ProjectReference> References { get; set; }
    public string RootDir { get; set; }
    public IEnumerable<string> RootDirs { get; set; }
    public bool? SkipLibCheck { get; set; }
    public bool? SkipDefaultLibCheck { get; set; }
    public bool? SourceMap { get; set; }
    public string SourceRoot { get; set; }
    public bool? Strict { get; set; }
    public bool? StrictNullChecks { get; set; }
    public bool? SuppressExcessPropertyErrors { get; set; }
    public bool? SuppressImplicitAnyIndexErrors { get; set; }
    public bool? UseDefineForClassFields { get; set; }
    public ScriptTarget? Target { get; set; }
    public bool? TraceResolution { get; set; }
    public bool? ResolveJsonModule { get; set; }
    public IEnumerable<string> Types { get; set; }
    public IEnumerable<string> TypeRoots { get; set; }
    public CompilerOptionsValue this[string option] { get; set; }
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

public interface ProjectReference
{
    public string Path { get; set; }
    public string OriginalPath { get; set; }
    public bool? Prepend { get; set; }
    public bool? Circular { get; set; }
}

public readonly struct CompilerOptionsValue
{
    private readonly object _value;

    private CompilerOptionsValue(string value)
    {
        _value = value;
    }

    private CompilerOptionsValue(int value)
    {
        _value = value;
    }

    private CompilerOptionsValue(bool value)
    {
        _value = value;
    }

    private CompilerOptionsValue(IEnumerable<string> value)
    {
        _value = value;
    }

    private CompilerOptionsValue(IEnumerable<int> value)
    {
        _value = value;
    }

    // 隐式转换，允许从 CompilerOptionsValue 到其基础类型的隐式转换
    public static implicit operator string(CompilerOptionsValue value)
    {
        if (value._value is string valueValue)
            return valueValue;
        throw new InvalidCastException();
    }

    public static implicit operator int(CompilerOptionsValue value)
    {
        if (value._value is int valueValue)
            return valueValue;
        throw new InvalidCastException();
    }

    public static implicit operator bool(CompilerOptionsValue value)
    {
        if (value._value is bool valueValue)
            return valueValue;
        throw new InvalidCastException();
    }

    public static implicit operator string[](CompilerOptionsValue value)
    {
        if (value._value is string[] valueValue)
            return valueValue;
        throw new InvalidCastException();
    }

    public static implicit operator int[](CompilerOptionsValue value)
    {
        if (value._value is int[] valueValue)
            return valueValue;
        throw new InvalidCastException();
    }

    public static implicit operator CompilerOptionsValue(string value)
    {
        return new CompilerOptionsValue(value);
    }

    public static implicit operator CompilerOptionsValue(int value)
    {
        return new CompilerOptionsValue(value);
    }

    public static implicit operator CompilerOptionsValue(bool value)
    {
        return new CompilerOptionsValue(value);
    }

    public static implicit operator CompilerOptionsValue(string[] value)
    {
        return new CompilerOptionsValue(value);
    }

    public static implicit operator CompilerOptionsValue(int[] value)
    {
        return new CompilerOptionsValue(value);
    }
}
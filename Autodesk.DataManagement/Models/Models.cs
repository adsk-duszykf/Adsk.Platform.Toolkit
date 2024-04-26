using System.Text.RegularExpressions;

namespace Autodesk.DataManagement.Helpers.Models;

public partial record class FileVersion(string? FolderId, string FileName, string Id) : IHasFileName
{
    public int Version => int.Parse(GetVersion().Match(Id).Groups[1].Value);

    [GeneratedRegex(@"version=(\d+)")]
    private static partial Regex GetVersion();
}

public record SubFolderList
{
    public FolderItem ParentFolder { get; set; } = new();
    public List<FolderItem> SubFolders { get; set; } = [];
}

public record FolderItem
{
    public IdNameMap Hub { get; set; } = new();
    public IdNameMap Project { get; set; } = new();
    public IdNameMap Folder { get; set; } = new();
    public string Path { get; set; } = "";
}

public record FolderPath
{
    public IdNameMap Hub { get; set; } = new();
    public IdNameMap Project { get; set; } = new();
    public List<IdNameMap> Folders { get; set; } = [];
    public string Path => string.Join("\\", Folders.Select(f => f.Name));
}
public record IdNameMap
{
    public string Id { get; set; } = "";
    public string Name { get; set; } = "";
};

public interface IHasFileName
{
    string FileName { get; }
}
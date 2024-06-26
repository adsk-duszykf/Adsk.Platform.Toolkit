﻿using System.Text.RegularExpressions;
using Autodesk.DataManagement.Models;

namespace Autodesk.DataManagement.Helpers.Models;

public partial record class FileVersion(string? FolderId, string FileName, string Id) : IHasFileName
{
    public int Version => int.Parse(GetVersion().Match(Id).Groups[1].Value);

    [GeneratedRegex(@"version=(\d+)")]
    private static partial Regex GetVersion();
}

/// <summary>
/// File item data
/// </summary>
/// <param name="Data">File Item data</param>
/// <param name="Included">Tip version of the file item</param>
public record FileItem(FolderContents_data Data, FolderContents_included Included) { }
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
    /// <summary>
    /// List of folders in the path
    /// </summary>
    public List<IdNameMap> Folders { get; set; } = [];
    public string Path => string.Join("\\", Folders.Select(f => f.Name));
}
public record IdNameMap(string Id = "", string Name = "");

public interface IHasFileName
{
    string FileName { get; }
}
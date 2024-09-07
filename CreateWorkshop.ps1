# Changes the current directory to the path that the specified file is located at.
# Useful for programs that have a "copy file path to clipboard", but not a "directory only" option.
param(
    [Parameter(Mandatory)]
    [string] $UserName,
    [Parameter(Mandatory)]
    [string] $Password,
    [Parameter(Mandatory)]
    [string] $SteamGuardCode
)

$VdfPath = dir .\Workshop\workshop.vdf | %{$_.FullName}

steamcmd.exe +login $UserName $Password $SteamGuardCode +workshop_build_item $VdfPath +quit

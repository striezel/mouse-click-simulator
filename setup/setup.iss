[Setup]
;INFO --> http://www.jrsoftware.org/ishelp/

; ****  Always generate a new GUID for every setup! ****
; (To generate a new GUID, click Tools > Generate GUID inside the IDE.)

AppId={{15F5DF60-44EA-4311-A42A-964865853D90}}
AppName=Mouse Click Simulator
AppVersion=0.3.2.0
AppPublisher=Dirk Stolle
AppPublisherURL=https://github.com/striezel/mouse-click-simulator
AppSupportURL=https://github.com/striezel/mouse-click-simulator
AppUpdatesURL=https://github.com/striezel/mouse-click-simulator
DefaultDirName={pf}\mouse-click-simulator
DisableDirPage=no
DefaultGroupName=Mouse Click Simulator
DisableProgramGroupPage=no
OutputDir=..\output
OutputBaseFilename=mouse-click-simulator_setup
Compression=lzma
SolidCompression=yes
; icon for installer
SetupIconFile=..\mouse-click-simulator\icons\fugue\mouse.ico

[Languages]
Name: "en"; MessagesFile: "compiler:Default.isl"
Name: "ca"; MessagesFile: "compiler:Languages\Catalan.isl"
Name: "co"; MessagesFile: "compiler:Languages\Corsican.isl"
Name: "cs"; MessagesFile: "compiler:Languages\Czech.isl"
Name: "da"; MessagesFile: "compiler:Languages\Danish.isl"
Name: "nl"; MessagesFile: "compiler:Languages\Dutch.isl"
Name: "fi"; MessagesFile: "compiler:Languages\Finnish.isl"
Name: "fr"; MessagesFile: "compiler:Languages\French.isl"
Name: "de"; MessagesFile: "compiler:Languages\German.isl"
Name: "he"; MessagesFile: "compiler:Languages\Hebrew.isl"
Name: "it"; MessagesFile: "compiler:Languages\Italian.isl"
Name: "jp"; MessagesFile: "compiler:Languages\Japanese.isl"
Name: "no"; MessagesFile: "compiler:Languages\Norwegian.isl"
Name: "pl"; MessagesFile: "compiler:Languages\Polish.isl"
Name: "pt"; MessagesFile: "compiler:Languages\Portuguese.isl"
Name: "ru"; MessagesFile: "compiler:Languages\Russian.isl"
Name: "sl"; MessagesFile: "compiler:Languages\Slovenian.isl"
Name: "es"; MessagesFile: "compiler:Languages\Spanish.isl"
Name: "tr"; MessagesFile: "compiler:Languages\Turkish.isl"
Name: "uk"; MessagesFile: "compiler:Languages\Ukrainian.isl"

; [Tasks]
; Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
;main executable
Source: "..\mouse-click-simulator\bin\Release\net6.0-windows7.0\mouse-click-simulator.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "..\mouse-click-simulator\bin\Release\net6.0-windows7.0\mouse-click-simulator.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "..\mouse-click-simulator\bin\Release\net6.0-windows7.0\mouse-click-simulator.runtimeconfig.json"; DestDir: "{app}"; Flags: ignoreversion
; NLog main assembly (logging)
; Source: "{#GetEnv('USERPROFILE')}\.nuget\packages\nlog\5.0.4\lib\netstandard2.0\NLog.dll"; DestDir: "{app}"; Flags: ignoreversion
; GPL 3 license text
Source: "..\LICENSE"; DestDir: "{app}"; Flags: ignoreversion
; documentation files
Source: "..\readme.md"; DestDir: "{app}\documentation"; Flags: ignoreversion
Source: "..\changelog.md"; DestDir: "{app}\documentation"; Flags: ignoreversion
Source: "..\screenshot.png"; DestDir: "{app}\documentation"; Flags: ignoreversion

[Icons]
; Start Menu entry for updater: check for new updates
Name: "{group}\Mouse Click Simulator"; Filename: "{app}\mouse-click-simulator.exe"
; Start Menu entry for Uninstaller
Name: "{group}\Uninstall Mouse Click Simulator"; Filename: "{app}\unins000.exe"; IconFilename: "{app}\mouse-click-simulator.exe" 
;; Desktopicon (if selected during install - default is unselected)
;Name: "{commondesktop}\Mouse Click Simulator"; Filename: "{app}\mouse-click-simulator.exe"; Parameters: "check"; Tasks: desktopicon

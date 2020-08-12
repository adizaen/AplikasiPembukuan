[Setup]
AppName = Aplikasi Pembukuan
AppVerName = Aplikasi Pembukuan version 1.0
AppPublisher = Adi Zaenul
AllowCancelDuringInstall = yes
DefaultDirName={pf}\Aplikasi Pembukuan
DefaultGroupName = Aplikasi Pembukuan
Compression = lzma
SolidCompression = yes
OutputBaseFilename = Aplikasi Pembukuan
AllowNoIcons = yes
AlwaysRestart = no
AlwaysShowComponentsList = no
DisableProgramGroupPage = yes
AppendDefaultDirName = yes
CreateUninstallRegKey = yes
DisableStartupPrompt = yes
LanguageDetectionMethod=none
ShowLanguageDialog=no
Uninstallable = yes
UninstallFilesDir={app}\uninst
UninstallDisplayIcon={app}\AplikasiPembukuan.exe,0
UninstallDisplayName = Aplikasi Pembukuan
WindowVisible = no
AppCopyright = Copyright © 2020. Adi Zaenul
FlatComponentsList = yes
PrivilegesRequired = admin
VersionInfoVersion = 1.0
SetupIconFile = book.ico

[Languages]
Name: en; MessagesFile: compiler:Default.isl

[Tasks]
Name: desktopicon; Description: {cm:CreateDesktopIcon}; GroupDescription: {cm:AdditionalIcons}; Flags: checkedonce
Name: installmysql; Description: "Install MySQL"; GroupDescription: "Proses tambahan:"; Flags: checkedonce

[Files]
;daftar file MySQL
Source: "C:\xampp\mysql\bin\*"; DestDir: {app}\mysql\bin; Flags: ignoreversion recursesubdirs createallsubdirs
Source: "C:\xampp\mysql\data\*"; DestDir: {app}\mysql\data; Flags: ignoreversion recursesubdirs createallsubdirs
Source: "C:\xampp\mysql\*"; DestDir: {app}\mysql; Flags: ignoreversion recursesubdirs createallsubdirs

;My Application Runtime
Source: main\exec.cmd; DestDir: {app}\mysql\bin; Flags: ignoreversion
Source: main\dbpembukuan.sql; DestDir: {app}\mysql\bin; Flags: ignoreversion
Source: main\AplikasiPembukuan.exe; DestDir: "{app}"; Flags: ignoreversion
Source: main\AplikasiPembukuan.exe.config; DestDir: "{app}"; Flags: ignoreversion
Source: main\AplikasiPembukuan.pdb; DestDir: "{app}"; Flags: ignoreversion
Source: main\Guna.UI.dll; DestDir: "{app}"; Flags: ignoreversion
Source: main\Microsoft.Office.Interop.Excel.dll; DestDir: "{app}"; Flags: ignoreversion
Source: main\MySql.Data.DLL; DestDir: "{app}"; Flags: ignoreversion
Source: main\MySqlBackup.dll; DestDir: "{app}"; Flags: ignoreversion

[Icons]
Name: {group}\Aplikasi Pembukuan; Filename: {app}\AplikasiPembukuan.exe; WorkingDir: {app}
Name: {userdesktop}\Aplikasi Pembukuan; Filename: {app}\AplikasiPembukuan.exe; WorkingDir: {app}; Tasks: desktopicon

[INI]
Filename: {app}\mysql\my.ini; Section: mysqld; Key: basedir; String: {app}\mysql; Tasks: installmysql
Filename: {app}\mysql\my.ini; Section: mysqld; Key: datadir; String: {app}\mysql\data; Tasks: installmysql

Filename: {app}\infoProgram.ini; Section: Sistem; Key: serverName; String: "localhost"
Filename: {app}\infoProgram.ini; Section: Sistem; Key: dbName; String: "dbpembukuan"

[Run]
;install service MySQL
Filename: "{app}\mysql\bin\mysqld.exe"; Parameters: "install ""MySQL"""; StatusMsg: "Sedang menginstall service MySQL ..."; Flags: runhidden; MinVersion: 0,5.01.2600sp2; Tasks: installmysql

;jalankan service MySQL
Filename: {sys}\net.exe; Parameters: "start ""MySQL"""; StatusMsg: "Sedang menjalankan service MySQL ..."; Flags: runhidden; MinVersion: 0.0,4.0.1381; Tasks: installmysql

;mendaftarkan port default mysql (3306) ke firewall
Filename: "{sys}\netsh.exe"; Parameters: "firewall add portopening TCP 3306 ""Port MySQL"""; StatusMsg: "Sedang mendaftarkan port MySQL ..."; Flags: runhidden; MinVersion: 0,5.01.2600sp2
Filename: "{sys}\netsh.exe"; Parameters: "firewall set service type = fileandprint mode = enable"; StatusMsg: "Mengaktifkan File and Printer Sharing ..."; Flags: runhidden; MinVersion: 0,5.01.2600sp2

;mengganti password default root (blank). ex : masterkey
Filename: "{app}\mysql\bin\mysqladmin.exe"; Parameters: "-uroot "; StatusMsg: "Mengganti password root"; Flags: runhidden; MinVersion: 0,5.01.2600sp2

;menghapus user default1 (user=blank, password=blank)
Filename: "{app}\mysql\bin\mysql.exe"; Parameters: "-uroot -e ""DELETE FROM mysql.user WHERE Host='localhost' AND User=''"""; Flags: runhidden; MinVersion: 0,5.01.2600sp2
Filename: "{app}\mysql\bin\mysql.exe"; Parameters: "-uroot -e ""FLUSH PRIVILEGES"""; Flags: runhidden; MinVersion: 0,5.01.2600sp2

;menghapus user default2 (user=root, password=blank)
Filename: "{app}\mysql\bin\mysql.exe"; Parameters: "-uroot -e ""DELETE FROM mysql.user WHERE Host='localhost' AND User='root'"""; Flags: runhidden; MinVersion: 0,5.01.2600sp2
Filename: "{app}\mysql\bin\mysql.exe"; Parameters: "-uroot -e ""FLUSH PRIVILEGES"""; Flags: runhidden; MinVersion: 0,5.01.2600sp2

;set agar user root bisa login dari mesin lain (kalo diperlukan)
Filename: "{app}\mysql\bin\mysql.exe"; Parameters: "-uroot -e ""GRANT ALL PRIVILEGES ON *.* TO root@'%' IDENTIFIED BY ''"""; Flags: runhidden; MinVersion: 0,5.01.2600sp2
Filename: "{app}\mysql\bin\mysql.exe"; Parameters: "-uroot -e ""FLUSH PRIVILEGES"""; Flags: runhidden; MinVersion: 0,5.01.2600sp2

;membuat database kosong
Filename: "{app}\mysql\bin\mysql.exe"; Parameters: "-uroot -e ""CREATE DATABASE dbpembukuan"""; Flags: runhidden; MinVersion: 0,5.01.2600sp2

;menjalankan file batch exec.cmd untuk melakukan proses undump
Filename: "{app}\mysql\bin\exec.cmd"; Flags: runhidden; MinVersion: 0,5.01.2600sp2


[UninstallRun]
Filename: {sys}\net.exe; Parameters: "stop ""MySQL"""; StatusMsg: "Menghentikan Service MySQL ..."; Flags: runhidden; MinVersion: 0.0,4.0.1381
Filename: "{app}\mysql\bin\mysqld.exe"; Parameters: "remove ""MySQL"""; StatusMsg: "Sedang menghapus service MySQL ..."; Flags: runhidden; MinVersion: 0,5.01.2600sp2

[UninstallDelete]
Type: files; Name: {app}\mysql\*.*
Type: files; Name: {app}\infoProgram.ini

[Registry]
;mencatat lokasi instalasi program, ini dibutuhkan jika kita ingin membuat paket instalasi update
Root: HKCU; Subkey: "Software\Aplikasi Pembukuan"; ValueName: "installDir"; ValueType: String; ValueData: {app}; Flags: uninsdeletevalue
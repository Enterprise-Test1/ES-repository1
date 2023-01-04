#Create Software folder for download
New-Item -ItemType Directory -Force -Path D:/Software

#Install gitleaks 
& { (New-Object System.Net.WebClient).DownloadFile("https://github.com/zricethezav/gitleaks/releases/download/v8.15.2/gitleaks_8.15.2_windows_x64.zip", "D:/Software/gitleaks_8.15.2_windows_x64.zip")}

#Extract gitleaks zip file
Add-Type -AssemblyName System.IO.Compression.FileSystem
[System.IO.Compression.ZipFile]::ExtractToDirectory('D:/Software\gitleaks_8.15.2_windows_x64.zip', 'D:/gitleaks')

#Install sendmail tool
& { (New-Object System.Net.WebClient).DownloadFile("https://nexus.syncfusion.com/repository/nuget-hosted/Syncfusion.Send.Mail/1.0.0", "D:/Software/Sendmailtool.zip")}

#Extract sendmail tool zip file
Add-Type -AssemblyName System.IO.Compression.FileSystem
[System.IO.Compression.ZipFile]::ExtractToDirectory('D:/Software/Sendmailtool.zip', 'D:/Sendmailtool')

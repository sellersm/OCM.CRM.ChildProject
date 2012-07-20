echo copy uimodel assembly to local bin and release folders...
xcopy "C:\MissionOfMercy\CRM\Source\MoM.Sponsorship.ChildProject\MoM.Sponsorship.ChildProject.UIModel\bin\Release\MoM.Sponsorship.ChildProject.UIModel.dll" "C:\Program Files\Blackbaud\bbappfx\vroot\bin\custom" /y /d

echo.
echo copy all htmlforms to the appropriate location on the webserver...
xcopy "C:\MissionOfMercy\CRM\Source\MoM.Sponsorship.ChildProject\MoM.Sponsorship.ChildProject.UIModel\ChildProject\ChildProject.Extension.AddForm.html" "C:\Program Files\Blackbaud\bbappfx\vroot\browser\htmlforms\custom" /y /d
xcopy "C:\MissionOfMercy\CRM\Source\MoM.Sponsorship.ChildProject\MoM.Sponsorship.ChildProject.UIModel\ChildProject\ChildProject.ExtensionSummary.ViewForm.html" "C:\Program Files\Blackbaud\bbappfx\vroot\browser\htmlforms\custom" /y /d
xcopy "C:\MissionOfMercy\CRM\Source\MoM.Sponsorship.ChildProject\MoM.Sponsorship.ChildProject.UIModel\ChildProject\ChildProject.ExtensionSummary.EditForm.html" "C:\Program Files\Blackbaud\bbappfx\vroot\browser\htmlforms\custom" /y /d
xcopy "C:\MissionOfMercy\CRM\Source\MoM.Sponsorship.ChildProject\MoM.Sponsorship.ChildProject.UIModel\ChildProject\ChildProject.UIModelVersion.ViewForm.html" "C:\Program Files\Blackbaud\bbappfx\vroot\browser\htmlforms\custom" /y /d

xcopy "C:\MissionOfMercy\CRM\Source\MoM.Sponsorship.ChildProject\MoM.Sponsorship.ChildProject.UIModel\ProjectInfo\ChildProject.ProjectInfo.ViewForm.html" "C:\Program Files\Blackbaud\bbappfx\vroot\browser\htmlforms\custom" /y /d
xcopy "C:\MissionOfMercy\CRM\Source\MoM.Sponsorship.ChildProject\MoM.Sponsorship.ChildProject.UIModel\ProjectInfo\ChildProject.ProjectInfo.EditForm.html" "C:\Program Files\Blackbaud\bbappfx\vroot\browser\htmlforms\custom" /y /d
xcopy "C:\MissionOfMercy\CRM\Source\MoM.Sponsorship.ChildProject\MoM.Sponsorship.ChildProject.UIModel\Quota\ChildProject.Quota.ViewForm.html" "C:\Program Files\Blackbaud\bbappfx\vroot\browser\htmlforms\custom" /y /d
xcopy "C:\MissionOfMercy\CRM\Source\MoM.Sponsorship.ChildProject\MoM.Sponsorship.ChildProject.UIModel\Quota\ChildProject.Quota.EditForm.html" "C:\Program Files\Blackbaud\bbappfx\vroot\browser\htmlforms\custom" /y /d
xcopy "C:\MissionOfMercy\CRM\Source\MoM.Sponsorship.ChildProject\MoM.Sponsorship.ChildProject.UIModel\Community\ChildProject.Community.ViewForm.html" "C:\Program Files\Blackbaud\bbappfx\vroot\browser\htmlforms\custom" /y /d
xcopy "C:\MissionOfMercy\CRM\Source\MoM.Sponsorship.ChildProject\MoM.Sponsorship.ChildProject.UIModel\Community\ChildProject.Community.EditForm.html" "C:\Program Files\Blackbaud\bbappfx\vroot\browser\htmlforms\custom" /y /d
xcopy "C:\MissionOfMercy\CRM\Source\MoM.Sponsorship.ChildProject\MoM.Sponsorship.ChildProject.UIModel\Community\ChildProject.Community2.ViewForm.html" "C:\Program Files\Blackbaud\bbappfx\vroot\browser\htmlforms\custom" /y /d
xcopy "C:\MissionOfMercy\CRM\Source\MoM.Sponsorship.ChildProject\MoM.Sponsorship.ChildProject.UIModel\Community\ChildProject.Community2.EditForm.html" "C:\Program Files\Blackbaud\bbappfx\vroot\browser\htmlforms\custom" /y /d
xcopy "C:\MissionOfMercy\CRM\Source\MoM.Sponsorship.ChildProject\MoM.Sponsorship.ChildProject.UIModel\Community\ChildProject.Community3.ViewForm.html" "C:\Program Files\Blackbaud\bbappfx\vroot\browser\htmlforms\custom" /y /d
xcopy "C:\MissionOfMercy\CRM\Source\MoM.Sponsorship.ChildProject\MoM.Sponsorship.ChildProject.UIModel\Community\ChildProject.Community3.EditForm.html" "C:\Program Files\Blackbaud\bbappfx\vroot\browser\htmlforms\custom" /y /d

rem echo minify the html and js files to optimize their payload on the wire
rem %~dp0..\..\..\..\Utils\Blackbaud.AppFx.JSMinifier\bin\JSMinifier.exe %~dp0..\..\..\..\Blackbaud.AppFx.Server\Deploy\browser\htmlforms\<subfolder>\*.html /pre
rem %~dp0..\..\..\..\Utils\Blackbaud.AppFx.JSMinifier\bin\JSMinifier.exe %~dp0..\..\..\..\Blackbaud.AppFx.Server\Deploy\browser\htmlforms\<subfolder>\*.js


rem iisreset /restart



::A script to clear out all IIS temporary files

::Stop IIS first, so the files won't be in use
::iisreset /stop

::Go to the root temp folder
::cd "C:\WINDOWS\Microsoft.NET\Framework64\v2.0.50727\Temporary ASP.NET Files"

::Remove all of the subfolders within it
::FOR /D %%g IN (*) DO rmdir /q /s %%g

::Repeat for the .NET 4 files
::cd "C:\WINDOWS\Microsoft.NET\Framework64\v4.0.30319\Temporary ASP.NET Files"
::FOR /D %%g IN (*) DO rmdir /q /s %%g

::Pick up where we left off
::iisreset /start

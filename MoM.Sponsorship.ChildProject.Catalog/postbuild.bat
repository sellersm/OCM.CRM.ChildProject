echo copy catalog assembly to local bin and release folders...
xcopy "C:\MissionOfMercy\CRM\Source\MoM.Sponsorship.ChildProject\MoM.Sponsorship.ChildProject.Catalog\bin\Release\MoM.Sponsorship.ChildProject.Catalog.dll" "C:\Program Files\Blackbaud\bbappfx\vroot\bin\custom" /y /d
xcopy "C:\MissionOfMercy\CRM\Source\MoM.Sponsorship.ChildProject\MoM.Sponsorship.ChildProject.Catalog\bin\Release\MoM.Sponsorship.ChildProject.Catalog.dll" "C:\MissionOfMercy\CRM\Releases\DEV\Catalog Assemblies" /y /d

echo.
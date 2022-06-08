# PXCommandLineExample
Example of usage of Acumatica PXCommandLine Tool to create a Customization Package in an automated way

This example covering a common scenario, when Acumatica ERP customization is updated and a new customization package had to be created. It also demonstrates how to automate this process.
This customization includes Customization Project items, like Site Map, Web Service Endpoint, as well as files - like Pages and dll.

All customization project items are exported from Acumatca ERP using **Source Controll -> Save Project To Folder** option available in the Acumatica Customization Project Editor
In this repository the customization project files reside in **DemoProjectCustomization** directory

The DemoProject solution contains the dummy business logic of the customization, with **DemoProject.dll** as build result.

This project includes a Post-Puilds Event that copyes the result dll to the DemoProjectCustomization/Bin/.
After, it calling the PX.CommandLine tool to build the customization packge based on **DemoProjectCustomization** content and place it in **OutputCustomization**:

    copy /Y "$(TargetDir)$(ProjectName).dll" "$(SolutionDir)\DemoProjectCustomization\Bin\$(ProjectName).dll"
    **[PathToYourAcumaticaInstance]**\Bin\PX.CommandLine.exe /method BuildProject /in "$(SolutionDir)\DemoProjectCustomization" /out "$(SolutionDir)\OutputCustomization\DemoProject.zip"

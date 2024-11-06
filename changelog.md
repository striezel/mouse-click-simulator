# Version history of Mouse Click Simulator

_(Note: This changelog focuses on the major changes between the different
versions. Therefore, it may not contain all changes. Especially smaller fixes or
improvements may be omitted.)_

## Version 0.4.0-rc (2024-11-06)

__[breaking change]__
This version does now require .NET 8 instead of .NET 6, as in previous versions.
Reason for that change is that Microsoft will end support for .NET 6 on
12th November 2024. From that date onwards, .NET 6 will not receive any
maintenance or security fixes, so this application is switching to .NET 8, the
current Long Term Support release of .NET.

## Version 0.3.4 (2024-10-21)

* Microsoft's support for .NET 6 will end in November 2024. While this is still
  a few weeks in the future this also means that the program will switch from
  .NET 6 to .NET 8, a newer Long Term Support release of .NET, in the coming
  weeks. Most likely this will happen with the next releases of the program.
* When the user refreshes the window list, the current selection (if any) is
  kept after the refresh, if that is possible (i. e. if the previously selected
  window is still there).

## Version 0.3.3 (2024-10-13)

Fix problem that the "Load preset now" menu item was not working.

## Version 0.3.2 (2024-10-12)

* The application icon is now properly set. (It's the same as the main window of
  the application - a mouse icon.)
* The window list will now have a horizontal scrollbar, if that is necessary to
  show longer texts.
* A bug is fixed that could cause the application to crash when loading a preset
  from the configuration file, if the configuration file contained values that
  were outside of the allowed range.

## Version 0.3.1 (2024-01-27)

New releases do now provide an installer-less ZIP file, too.
(However, you can still use the installer executable, if you prefer that.)

## Version 0.3.0 (2022-10-09)

Mouse click settings can now be saved, and loaded later and / or at program
startup.

## Version 0.2.2 (2022-10-01)

* The list of available target windows is loaded during startup. That way the
  users do not have to explicitly refresh the list, if the target window is
  already there when the program starts.

## Version 0.2.1 (2022-09-18)

* The version information window does now show the revision from the Git version
  control system that was used to build the application, too.
* The version information window does now show some information about the .NET
  runtime, too.
* Some icons used in the application are replaced. More specifically, all icons
  from the Silk icon set are replaced with similar icons from the Fugue icon
  set. This way only one icon set is required to cover all needs.
* A proper icon is added to the setup and to the main windows of the
  application.

## Version 0.2.0 (2022-09-17)

* Icons are added to most buttons and menu entries.
* A separate form to show the application version and information about used
  third party components is added.

## Version 0.1.0 (2022-09-15)

Initial version.

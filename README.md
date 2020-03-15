# KeyLogger
Can log keys discretely in the background of windows machines.
NOTE: 
If the keylogger does not run, you might need to update your microsoft Windows SDK.

# Running the application 
A sample release build can found under the Sample Execute File Directory. Simply navigate to this folder and run the .exe file.
Otherwise, you can open the .sln file in Visual Studio.
Do note that when you run this application, Windows defender will warn you that this might be a possible malware. You can simply just select more info and run anyways.

# Modes
Normal mode:
When the application starts up, the normal mode is launched. In here as soon as you hit start recording you can 
start typing anywhere and your keystrokes will be recorded in the space provided.

Ninja Mode:
When you click Ninja Mode, a new window will pop up. Here it will prompt you for the duration for which you want 
the keylogging session will last. You can select which unit of time and simply hit start.
Once the time is reached, this will produce a .txt file (the file name will have the date and the time it was created) 
under your Desktop directory.
NOTE:
When in this mode, the application will hide itself and will not be visible on your tray icons nor in 
task manager. The only way the program will close is when it reaches the time allotted or a shutdown or restart 
of the system.

# Disclaimer
This is for educational purpose only.

# Limitations
Currently, some special key strokes are not being recorded (ex. symbols)


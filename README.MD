# Funey's Process Manager
**PLEASE USE TASK MANAGER IF YOU ARE ABLE!!!**

A simple-ish task manager alternative for system administrators - pretty good if you need to circumvent an explicit Deny of Task Manager access in a GPO that is applied to you.

**THE END USER OF THIS PROGRAM IS RESPONSIBLE FOR ANY DAMAGES THAT ARISE FROM THE USE/MISUSE OF THIS PROGRAM.**

**I WILL NOT BE LIABLE FOR ANY DAMAGE THAT MAY OCCUR FROM THE USE OF THIS PROGRAM - THIS INCLUDES LOSS OF DATA**

## Build Instructions
This was programmed using Visual Studio 2019, this should be as easy as:
```
git clone https://github.com/xFuney/funey-process-mgmt.git
```
Then open the Project up in VS2019 - settings should be set for proper building automatically, raise an issue if it isn't.

Please don't report issues if they're to do with your environment - "exotic" environments (non-VS2019) shouldn't have issues raised unless they are proven to affect non-exotic builds.
## Run Instructions
**No releases are available for this program - you must build them yourself. This is to prevent misuse of this program.**

After building, you'll find your files in the Debug/ folder of your workspace. The executable file is the only one you need - don't build a proper Release executable, as it does some dodgy downloading stuff that is just too uncomfortable. If you want to do it, do it but just remember that it's probably not your best solution.
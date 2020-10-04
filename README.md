# synctimewin
simple app for sync windows time

## How to run app every startup
- General Tab
  - fill Name value to "synctimewin"
  - click button "change user or group" and type system and press ok
  - check "run with highest privilges"
  - change "configure for" value to "windows 7,windows server 2008 r2"
  
- Trigger Tab
  - press new
  - change "begin the task" value to "At startup"
  - press ok
  
- Action Tab
  - press new
  - browse synctimewn.exe
  - press ok
  
- Condition Tab
  - uncheck "stop if if computer switches to battery power"
  - uncheck "start if the task only if the computer is on power AC"
  
- Setting tab
  - uncheck "stop the task if it runs longer than"
  - uncheck "if the running task does end when requested, force to stop"

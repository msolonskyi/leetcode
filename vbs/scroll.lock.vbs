Set objShell = CreateObject("WScript.Shell")
Do
  WScript.Sleep(60 * 1000)
  objShell.SendKeys("{SCROLLLOCK 2}")
Loop
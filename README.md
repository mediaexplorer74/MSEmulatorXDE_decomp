# Microsoft Emulator (XDE) dotnet Decompiled

My fork of MS Emulator (decompiled by Empyreal96).

## About

This is the source codes for parts of the Microsoft Emulator (aka XDE).
XDE used to run the Windows 10 Mobile Emulator Images.


## Tech. details

```
.NET Framworks
Decomp: 4.0-4.6--4.7.2
Changed to: 4.8

Common libs:
Newtonsoft.Json 12.0
System.Threading.Tasks.Dataflow (?)
System.Management.Automation (?)
Microsoft.Diagnostics.Tracing.EventSource (?)

(XDE)
XDE
Microsoft.Xde.Base
Microsoft.Xde.Client.RdpClientAxHost
Microsoft.Xde.Client.RdpClientInterop
Microsoft.Xde.Communication
Microsoft.Xde.LocSimulator
Microsoft.Xde.SantPlugin
System.Threading.Tasks.Dataflow (?)

(XdeConfig)
XdeConfig
CommandLine
System.Management.Automation (?)

(XdeManager)
XdeManager
DiscUtils.Core
DiscUtils.Ntfs
DiscUtils.Registry
DiscUtils.Streams
DiscUtils.Vhd
DiscUtils.Vhdx
Diskstream
Microsoft.Diagnostics.Tracing.EventSource (?)
Microsoft.HyperV.Schema
Microsoft.Xde.Common
Microsoft.Xde.Common.Base
Microsoft.Xde.DeviceManagement
Microsoft.Xde.Hcs
Microsoft.Xde.Interface.Common
Microsoft.Xde.Interface.Public.10.1
Microsoft.Xde.WindowsAPICodePack
Microsoft.Xde.Wmi
WindowsDevicePortalWrapper
```

**Original AppxPackage:** `Microsoft.MicrosoftEmulator_1.1.1081.0_x64__8wekyb3d8bbwe`

## My 2 cents
- 30 projects merged on main "XDE" solution.
- Some fast RnD completed (see Docs folder). 

## TODO
Expect fixes needing to be applied to parts of the decompiled code, also some sections may have errors. 
`dnSpy` was used to obtain this code.


## .. 
AS IS. No support. RnD only / DIY

## .
MediaExplorer

2022, November


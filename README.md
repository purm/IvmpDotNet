IvmpDotNet
==========

A .Net wrapper for the IV:MP Module SDK

Installation guide:
-------------------

1. Copy ```Interop.mscoree.2.4.dll```, ```IvmpDotNet.Core.dll```, ```IvmpDotNet.SDK.dll``` into the ivmp-svr root folder
2. Copy ```IvmpDotNet.Proxy.dll``` into the ```Modules``` folder (it the folder doesn't exist create it)
3. Edit the ivmp settings.xml file: add the following line ```<module>IvmpDotNet.Proxy.dll</module>```
4. Create a new folder named ```CLRModules```
5. Copy insert your CLR Modules

CLR Module creation guide:
--------------------------

1. Create a new ClassLibrary project (You can use VB.Net, c++ CLI or C#)
2. Add a reference to the ```IvmpDotNet.SDK.dll```
3. Create a class
4. Implement ```IvmpDotNet.SDK.IModule``` in the class
5. Write your gamemode
6. Compile (create a dll)
7. Copy the created dll in the ```CLRModules``` folder
8. Start your server or if already running type ```clr reload``` into the server console

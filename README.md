IvmpDotNet
==========

A .Net Wrapper for the IV:MP Module SDK

Installation Guide:
-------------------

1. Copy ```Interop.mscoree.2.4.dll```, ```IvmpDotNet.Core.dll```, ```IvmpDotNet.SDK.dll``` into the ivmp-svr root folder
2. Copy ```IvmpDotNet.Proxy.dll``` into the ```Modules``` folder (it the folder doesn't exist create it)
3. Edit the ivmp settings.xml file: add the following line ```<module>IvmpDotNet.Proxy.dll</module>```
4. Create a new folder named ```CLRModules```
5. Copy insert your CLR Modules

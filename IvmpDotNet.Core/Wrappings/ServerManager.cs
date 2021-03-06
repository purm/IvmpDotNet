﻿using IvmpDotNet.Imports;
using IvmpDotNet.SDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IvmpDotNet.Wrappings {
    public class ServerManager : IServerManager {
        public void Log(string txt, params object[] args) {
            Server.Server_Log(string.Format(txt, args));
        }

        public void AddRule(string rule, string value) {
            Server.Server_AddRule(rule, value);
        }

        public void RemoveRule(string rule) {
            Server.Server_RemoveRule(rule);
        }

        public void SetRule(string rule, string value) {
            Server.Server_SetRule(rule, value);
        }

        public string GetRule(string rule) {
            return System.Runtime.InteropServices.Marshal.PtrToStringAnsi(Server.Server_GetRule(rule));
        }

        public void SetPassword(string pass) {
            Server.Server_SetPassword(pass);
        }

        public void SetHostName(string szHostname) {
            Server.Server_SetHostName(szHostname);
        }

        public void TogglePayAndSpray(bool toggle) {
            Server.Server_TogglePayAndSpray(toggle);
        }

        public void ToggleAutoAim(bool toggle) {
            Server.Server_ToggleAutoAim(toggle);
        }

        public void SendInput(string input) {
            Server.Server_SendInput(input);
        }

        public string GetWeaponName(Weapons iWeaponId) {
            return System.Runtime.InteropServices.Marshal.PtrToStringAnsi(Server.Server_GetWeaponName((int)iWeaponId));
        }

        public string GetVehicleName(VehicleModels iModelId) {
            return System.Runtime.InteropServices.Marshal.PtrToStringAnsi(Server.Server_GetVehicleName((int)iModelId));
        }

        public void ToggleFrequentEvents(bool bToggle) {
            Server.Server_ToggleFrequentEvents(bToggle);
        }

        public bool SetWeather(WeatherTypes iWeather) {
            return Server.Server_SetWeather((int)iWeather);
        }

        public bool ForceWind(float fWind) {
            return Server.Server_ForceWind(fWind);
        }
    }
}

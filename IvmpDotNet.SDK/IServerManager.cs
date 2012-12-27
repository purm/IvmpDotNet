using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IvmpDotNet.SDK {
    public interface IServerManager {
        void Log(string txt);
        void Log(string txt, params object[] args);
        void AddRule(String rule, String value);
        void RemoveRule(String rule);
        void SetRule(String rule, String value);
        string GetRule(String rule);
        void SetPassword(String pass);
        void SetHostName(String szHostname);
        void TogglePayAndSpray(Boolean toggle);
        void ToggleAutoAim(Boolean toggle);
        void SendInput(String input);
        string GetWeaponName(Int32 iWeaponId);
        string GetVehicleName(Int32 iModelId);
        void ToggleFrequentEvents(Boolean bToggle);
        bool SetWeather(Int32 iWeather);
        bool ForceWind(Single fWind);
    }
}

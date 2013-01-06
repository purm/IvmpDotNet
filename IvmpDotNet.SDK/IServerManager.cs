using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IvmpDotNet.SDK {
    /// <summary>
    /// Manages some general server functions
    /// </summary>
    public interface IServerManager {
        /// <summary>
        /// This function outputs a line to the console and log file.
        /// </summary>
        /// <param name="txt">text to log</param>
        void Log(string txt, params object[] args);

        /// <summary>
        /// This function adds a new rule to the server.
        /// </summary>
        /// <param name="rule">the rule to add</param>
        /// <param name="value">the value of the new rule</param>
        void AddRule(String rule, String value);

        /// <summary>
        /// This function removes a rule from the server.
        /// </summary>
        /// <param name="rule">the rule to remove</param>
        void RemoveRule(String rule);

        /// <summary>
        /// This function sets a server rule's value.
        /// </summary>
        /// <param name="rule">the rule to modify</param>
        /// <param name="value">the new value of the rule</param>
        void SetRule(String rule, String value);

        /// <summary>
        /// This function gets a server rule's value.
        /// </summary>
        /// <param name="rule">the rule to get</param>
        /// <returns>Returns returns value as string or false if rule doesn't exists.</returns>
        string GetRule(String rule);

        /// <summary>
        /// This function sets the server password.
        /// </summary>
        /// <param name="pass">the password</param>
        void SetPassword(String pass);

        /// <summary>
        /// This function sets the server's hostname.
        /// </summary>
        /// <param name="szHostname">the hostname</param>
        void SetHostName(String szHostname);

        /// <summary>
        /// Toggles pay and spray
        /// </summary>
        /// <param name="toggle">toggle</param>
        void TogglePayAndSpray(Boolean toggle);

        /// <summary>
        /// Toggles auto aim
        /// </summary>
        /// <param name="toggle">toggle</param>
        void ToggleAutoAim(Boolean toggle);

        /// <summary>
        /// Sends input to the server console
        /// </summary>
        /// <param name="input">text to send</param>
        void SendInput(String input);

        /// <summary>
        /// Gets the name of a weapon type
        /// </summary>
        /// <param name="iWeaponId">weapon type</param>
        /// <returns>the weapon's name</returns>
        string GetWeaponName(Weapons iWeaponId);

        /// <summary>
        /// Gets the name of a vehicle type
        /// </summary>
        /// <param name="iModelId">the vehicle's model</param>
        /// <returns>the vehicles name</returns>
        string GetVehicleName(VehicleModels iModelId);

        /// <summary>
        /// toggles frequently event handling
        /// </summary>
        /// <param name="bToggle">true = handle</param>
        void ToggleFrequentEvents(Boolean bToggle);

        /// <summary>
        /// Sets the weather
        /// </summary>
        /// <param name="iWeather">weather type</param>
        /// <returns>Returns true if the weather was set, false otherwise.</returns>
        bool SetWeather(WeatherTypes iWeather);

        /// <summary>
        /// This function lets you control the wind.
        /// </summary>
        /// <param name="fWind">wind</param>
        /// <returns>true when the function executed successfully, false otherwise.</returns>
        bool ForceWind(Single fWind);
    }
}

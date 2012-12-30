using IvmpDotNet.SDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IvmpDotNet.Imports;
using System.Runtime.InteropServices;

namespace IvmpDotNet.Wrappings {
    public class Vehicle : IVehicle {
        public ushort VehicleId {
            get;
            set;
        }

        public CVector3 Coordinates {
            get {
                return Vehicles.Vehicles_GetCoordinates(this.VehicleId);
            }
            set {
                Vehicles.Vehicles_SetCoordinates(this.VehicleId, value);
            }
        }

        public CVector3 Rotation {
            get {
                return Vehicles.Vehicles_GetRotation(this.VehicleId);
            }
            set {
                Vehicles.Vehicles_SetRotation(this.VehicleId, value);
            }
        }

        public float DirtLevel {
            get {
                return Vehicles.Vehicles_GetDirtLevel(this.VehicleId);
            }
            set {
                Vehicles.Vehicles_SetDirtLevel(this.VehicleId, value);
            }
        }

        public bool SirenState {
            get {
                return Vehicles.Vehicles_GetSirenState(this.VehicleId);
            }
            set {
                Vehicles.Vehicles_SetSirenState(this.VehicleId, value);
            }
        }

        public bool IsValid {
            get { return Vehicles.Vehicles_IsValid(this.VehicleId); }
        }

        public int[] Colors {
            get {
                int[] buffer = new int[4];
                Marshal.Copy(Vehicles.Vehicles_GetColor(this.VehicleId), buffer, 0, 4);
                return buffer;
            }
            set {
                IntPtr unmanagedPointer = Marshal.AllocHGlobal(4 * sizeof(int));
                Marshal.Copy(value, 0, unmanagedPointer, value.Length);
                Vehicles.Vehicles_SetColor(this.VehicleId, unmanagedPointer);

                //Marshal.FreeHGlobal(unmanagedPointer); *TODO* clean up (?)
            }
        }

        public int Model {
            get { return Vehicles.Vehicles_GetModel(this.VehicleId); }
        }

        public int Health {
            get {
                return Vehicles.Vehicles_GetHealth(this.VehicleId);
            }
            set {
                Vehicles.Vehicles_SetHealth(this.VehicleId, value);
            }
        }

        public CVector3 Velocty {
            get {
                return Vehicles.Vehicles_GetVelocity(this.VehicleId);
            }
            set {
                Vehicles.Vehicles_SetVelocity(this.VehicleId, value);
            }
        }

        public CVector3 AngularVelocity {
            get {
                return Vehicles.Vehicles_GetAngularVelocity(this.VehicleId);
            }
            set {
                Vehicles.Vehicles_SetAngularVelocity(this.VehicleId, value);
            }
        }

        public bool IsOccupied {
            get { return Vehicles.Vehicles_IsOccupied(this.VehicleId); }
        }

        public IPlayer[] Occupants {
            get {
                List<IPlayer> tmp = new List<IPlayer>();
                short[] buffer = new short[16];
                foreach (short playerId in buffer) {
                    buffer[playerId] = -1;
                }

                Marshal.Copy(Vehicles.Vehicles_GetOccupants(this.VehicleId), buffer, 0, buffer.Length);
                foreach (short playerId in buffer) {
                    if (buffer[playerId] >= 0)
                        tmp.Add(new Player() {
                            PlayerId = (ushort)buffer[playerId]
                        });
                }

                return tmp.ToArray();
            }
        }

        public LockedState Locked {
            get {
                return (LockedState)Vehicles.Vehicles_GetLocked(this.VehicleId);
            }
            set {
                Vehicles.Vehicles_SetLocked(this.VehicleId, (int)value);
            }
        }

        public int Variation {
            get {
                return Vehicles.Vehicles_GetVariation(this.VehicleId);
            }
            set {
                Vehicles.Vehicles_SetVariation(this.VehicleId, value);
            }
        }

        public bool EngineStatus {
            get {
                return Vehicles.Vehicles_GetEngineStatus(this.VehicleId);
            }
            set {
                Vehicles.Vehicles_SetEngineStatus(this.VehicleId, value);
            }
        }

        public bool Lights {
            get {
                return Vehicles.Vehicles_GetLights(this.VehicleId);
            }
            set {
                Vehicles.Vehicles_SetLights(this.VehicleId, value);
            }
        }

        public bool TaxiLights {
            get { return Vehicles.Vehicles_GetTaxiLights(this.VehicleId); }
            set { Vehicles.Vehicles_SwitchTaxiLights(this.VehicleId, value); }
        }

        public int Dimension {
            get {
                return Vehicles.Vehicles_GetDimension(this.VehicleId);
            }
            set {
                Vehicles.Vehicles_SetDimension(this.VehicleId, value);
            }
        }

        public int RespawnDelay {
            get {
                return Vehicles.Vehicles_GetRespawnDelay(this.VehicleId);
            }
            set {
                Vehicles.Vehicles_SetRespawnDelay(this.VehicleId, value);
            }
        }

        public bool Delete() {
            return Vehicles.Vehicles_Delete(this.VehicleId);
        }

        public bool SoundHorn(int iDuration) {
            return Vehicles.Vehicles_SoundHorn(this.VehicleId, iDuration);
        }

        public bool Respawn() {
            return Vehicles.Vehicles_Respawn(this.VehicleId);
        }

        public bool SetIndicators(bool bFrontLeft, bool bFrontRight, bool bBackLeft, bool bBackRight) {
            return Vehicles.Vehicles_SetIndicators(this.VehicleId, bFrontLeft, bFrontRight, bBackLeft, bBackRight);
        }

        public bool ResetComponents() {
            return Vehicles.Vehicles_ResetComponents(this.VehicleId);
        }

        public bool SwitchTaxiLights(bool check) {
            return Vehicles.Vehicles_SwitchTaxiLights(this.VehicleId, check);
        }

        public bool ControlCarDoors(VehicleDoors door, bool door2, float door3) {
            return Vehicles.Vehicles_ControlCarDoors(this.VehicleId, (int)door, door2, door3);
        }

        public bool RepairWheels() {
            return Vehicles.Vehicles_RepairWheels(this.VehicleId);
        }

        public bool RepairWindows() {
            return Vehicles.Vehicles_RepairWindows(this.VehicleId);
        }

        public bool Repair() {
            return Vehicles.Vehicles_Repair(this.VehicleId);
        }

        public bool[] GetIndicators() {
            throw new NotImplementedException();
        }

        public bool SetComponent(int iSlot, bool bOn) {
            throw new NotImplementedException();
        }

        public bool[] GetComponents() {
            throw new NotImplementedException();
        }
    }
}

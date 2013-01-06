using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace IvmpDotNet.SDK {
    /// <summary>
    /// Indicates that an event is only triggerd if "frequently events" are turned on
    /// </summary>
    [AttributeUsage(AttributeTargets.Event, AllowMultiple = false)]
    public class FrequentlyEventAttribute : Attribute { }

    /// <summary>
    /// Vehicle Models
    /// </summary>
    public enum VehicleModels : int {
        Admiral = 0,
        Airtug = 1,
        Ambulance = 2,
        Banshee = 3,
        Benson = 4,
        Biff = 5,
        Blista = 6,
        Bobcat = 7,
        Boxville = 8,
        Buccaneer = 9,
        Burrito = 10,
        Burrito2 = 11,
        Bus = 12,
        Cabby = 13,
        Cavallcade = 14,
        Chavos = 15,
        Cognoscenti = 16,
        Comet = 17,
        Coquette = 18,
        DF8 = 19,
        Dilettante = 20,
        Dukes = 21,
        E109 = 22,
        Emperor = 23,
        Emperor2 = 24,
        Esperanto = 25,
        Faction = 26,
        FBI = 27,
        Feltzer = 28,
        Feroci = 29,
        Feroci2 = 30,
        Firetruk = 31,
        Flatbed = 32,
        Fortune = 33,
        Forklift = 34,
        Futo = 35,
        CavalcadeFXT = 36,
        Habanero = 37,
        Hakumai = 38,
        Huntley = 39,
        Infernus = 40,
        //Ingot<DONOTUSE:Willcrashserver> = 41,
        Intruder = 42,
        Landstalker = 43,
        Lokus = 44,
        Manana = 45,
        Marbella = 46,
        Merit = 47,
        Minivan = 48,
        Moonbeam = 49,
        Mrtasty = 50,
        Mule = 51,
        Noose = 52,
        Enforcer = 53,
        Oracle = 54,
        Packer = 55,
        Patriot = 56,
        Perennial = 57,
        Perennial2 = 58,
        Peyote = 59,
        Phantom = 60,
        Pinnacle = 61,
        PMP600 = 62,
        Police = 63,
        Police2 = 64,
        Polpatriot = 65,
        Pony = 66,
        Premier = 67,
        Pres = 68,
        PStockade = 70,
        Rancher = 71,
        Rebla = 72,
        Ripley = 73,
        Romero = 74,
        Rom = 75,
        Ruiner = 76,
        Sabre = 77,
        Sabre2 = 78,
        SabreGT = 79,
        Schafter = 80,
        Sentinel = 81,
        Solair = 82,
        Speedo = 83,
        Stallion = 84,
        Steed = 85,
        Stockade = 86,
        Stratum = 87,
        Stretch = 88,
        Sultan = 89,
        SultanRS = 90,
        SuperGT = 91,
        Taxi = 92,
        Taxi2 = 93,
        Trash = 94,
        Turismo = 95,
        Uranus = 96,
        Vigero = 97,
        Vigero2 = 98,
        Vincent = 99,
        Virgo = 100,
        Voodoo = 101,
        Washington = 102,
        Willard = 103,
        Yankee = 104,
        Freeway = 105,
        Faggio = 106,
        NRG900 = 108,
        PCJ = 109,
        Sanchez = 110,
        Annihilator = 112,
        Maverick = 113,
        PoliceMaverick = 114,
        Tourmav = 115,
        Dinghy = 116,
        Jetmax = 117,
        Marquis = 118,
        Predator = 119,
        Reefer = 120,
        Squalo = 121,
        TugBoat = 122,
        Tropic = 123,
    }

    /// <summary>
    /// Ped Models
    /// </summary>
    public enum PedModels : int {
        Niko = 0,
        //M_Y_MULTIPLAYER-Can'tbeused. = 1,
        //F_Y_MULTIPLAYER-Can'tbeused. = 2,
        //SUPERLOD-Can'tbeused. = 3,
        AnnaFaustin = 4,
        Anthony = 5,
        Badman = 6,
        Bernie = 7,
        Blendar = 8,
        Brian = 9,
        Brucie = 10,
        Bulgarin = 11,
        Charise = 12,
        IG_CHARLIEUC = 13,
        Clarence = 14,
        IG_DARDAN = 15,
        Darko = 16,
        Derick = 17,
        Dimitri = 18,
        Dwayne = 19,
        Eddie = 20,
        Faustin = 21,
        Francis = 22,
        FrenchTom = 23,
        IG_GORDON = 24,
        Gracie = 25,
        Hossan = 26,
        Ilyena = 27,
        IG_ISAAC = 28,
        Ivan = 29,
        IG_JAY = 30,
        IG_JASON = 31,
        Jeff = 32,
        Pegorino = 33,
        Johnny = 34,
        Kate = 35,
        Lenny = 36,
        Jacob = 37,
        Luca = 39,
        Luis = 40,
        Mallorie = 41,
        IG_MAMC = 42,
        Manny = 43,
        Marnie = 44,
        Mel = 45,
        IG_MICHAEL = 46,
        Michelle = 47,
        IG_MICKEY = 48,
        Packie = 49,
        Pathos = 50,
        Kenny = 51,
        Phil = 52,
        PlayboyX = 53,
        RayBoccino = 54,
        Ricky = 55,
        Roman = 56,
        Sara = 58,
        Tuna = 59,
        VinnySpaz = 60,
        Vlad = 61,
        M_Y_GAFR_LO_1 = 62,
        M_Y_GAFR_LO_2 = 63,
        M_Y_GAFR_HI_1 = 64,
        M_Y_GAFR_HI_2 = 65,
        M_Y_GALB_LO_1 = 66,
        M_Y_GALB_LO_2 = 67,
        M_Y_GALB_LO_3 = 68,
        M_Y_GALB_LO_4 = 69,
        M_M_GBIK_LO_3 = 70,
        M_Y_GBIK_HI_1 = 71,
        M_Y_GBIK_HI_2 = 72,
        M_Y_GBIK3_LO2 = 73,
        M_Y_GBIK_LO_1 = 74,
        M_Y_GBIK_LO_2 = 75,
        M_Y_GIRI_LO_1 = 76,
        M_Y_GIRI_LO_2 = 77,
        M_Y_GIRI_LO_3 = 78,
        M_M_GJAM_HI_1 = 79,
        M_M_GJAM_HI_2 = 80,
        M_M_GJAM_HI_3 = 81,
        M_Y_GJAM_LO_1 = 82,
        M_Y_GJAM_LO_2 = 83,
        M_Y_GKOR_LO_1 = 84,
        M_Y_GKOR_LO_2 = 85,
        M_Y_GLAT_LO_1 = 86,
        M_Y_GLAT_LO_2 = 87,
        M_Y_GLAT_HI_1 = 88,
        M_Y_GLAT_HI_2 = 89,
        M_Y_GMAF_HI_1 = 90,
        M_Y_GMAF_HI_2 = 91,
        M_Y_GMAF_LO_1 = 92,
        M_Y_GMAF_LO_2 = 93,
        M_O_GRUS_HI_1 = 94,
        M_Y_GRUS_LO_1 = 95,
        M_Y_GRUS_LO_2 = 96,
        M_Y_GRUS_HI_2 = 97,
        M_M_GRU3_HI_1 = 98,
        M_M_GRU3_HI_2 = 99,
        M_M_GRU3_LO_2 = 100,
        M_Y_GRU3_LO_1 = 101,
        M_M_GTRI_HI_1 = 102,
        M_M_GTRI_HI_2 = 103,
        M_Y_GTRI_LO_1 = 104,
        M_Y_GTRI_LO_2 = 105,
        F_O_MAID_1 = 106,
        F_O_BINCO = 107,
        F_Y_BANK_2 = 108,
        FemaleDoctor = 109,
        F_Y_GYMGAL_0 = 110,
        F_Y_FF_BURGER_R = 111,
        F_Y_FF_CLUCK_R = 112,
        F_Y_FF_RSCAFE = 113,
        F_Y_FF_TWCAFE = 114,
        F_Y_FF_WSPIZZAR = 115,
        FatHooker = 116,
        Hooker = 117,
        Nurse = 118,
        Stripper1 = 119,
        Stripper2 = 120,
        F_Y_WAITRESS_1 = 121,
        Alcoholic = 122,
        ArmouredSecurity = 123,
        M_M_BUSDRIVER = 124,
        M_M_CHINATOWN_1 = 125,
        M_M_CRACKHEAD = 126,
        M_M_DOC_SCRUBS1 = 127,
        M_M_DOCTOR_1 = 128,
        M_M_DODGYDOC = 129,
        M_M_EECOOK = 130,
        M_M_ENFORCER = 131,
        M_M_FACTORY_1 = 132,
        FatPoliceman = 133,
        FBIAgent = 134,
        M_M_FEDCO = 135,
        M_M_FIRECHIEF = 136,
        M_M_GUNNUT_1 = 137,
        M_M_HELIPILOT_1 = 138,
        M_M_HPORTER_1 = 139,
        M_M_KOREACOOK_1 = 140,
        M_M_LAWYER_1 = 141,
        TomGoldberg = 142,
        M_M_LOONYBLACK = 143,
        M_M_PILOT = 144,
        M_M_PINDUS_1 = 145,
        M_M_POSTAL_1 = 146,
        M_M_SAXPLAYER_1 = 147,
        Security = 148,
        M_M_SELLER_1 = 149,
        M_M_SHORTORDER = 150,
        M_M_STREETFOOD1 = 151,
        M_M_SWEEPER = 152,
        M_M_TAXIDRIVER = 153,
        M_M_TELEPHONE = 154,
        M_M_TENNIS = 155,
        M_M_TRAIN_1 = 156,
        M_M_TRAMPBLACK = 157,
        M_M_TRUCKER_1 = 158,
        M_O_JANITOR = 159,
        M_O_HOTEL_FOOT = 160,
        M_O_MPMOBBOSS = 161,
        M_Y_AIRWORKER = 162,
        M_Y_BARMAN_1 = 163,
        M_Y_BOUNCER_1 = 164,
        M_Y_BOUNCER_2 = 165,
        M_Y_BOWL_1 = 166,
        M_Y_BOWL_2 = 167,
        M_Y_CLUBFIT = 169,
        M_Y_CONSTRUCT_1 = 170,
        M_Y_CONSTRUCT_2 = 171,
        M_Y_CONSTRUCT_3 = 172,
        Policeman = 173,
        TrafficPoliceman = 174,
        M_Y_COURIER = 175,
        M_Y_COWBOY_1 = 176,
        M_Y_DEALER = 177,
        M_Y_DRUG_1 = 178,
        M_Y_FF_BURGER_R = 179,
        M_Y_FF_CLUCK_R = 180,
        M_Y_FF_RSCAFE = 181,
        M_Y_FF_TWCAFE = 182,
        M_Y_FF_WSPIZZAR = 183,
        M_Y_FIREMAN = 184,
        M_Y_GARBAGE = 185,
        M_Y_GOON_1 = 186,
        M_Y_GYMGUY_1 = 187,
        M_Y_MECHANIC_2 = 188,
        M_Y_MODO = 189,
        M_Y_NHELIPILOT = 190,
        M_Y_PERSEUS = 191,
        M_Y_PINDUS_1 = 192,
        M_Y_PINDUS_2 = 193,
        M_Y_PINDUS_3 = 194,
        M_Y_PMEDIC = 195,
        M_Y_PRISON = 196,
        M_Y_PRISONAOM = 197,
        M_Y_ROMANCAB = 198,
        M_Y_RUNNER = 199,
        M_Y_SHOPASST_1 = 200,
        M_Y_STROOPER = 201,
        SWAT = 202,
        M_Y_SWORDSWALLO = 203,
        M_Y_THIEF = 204,
        M_Y_VALET = 205,
        M_Y_VENDOR = 206,
        M_Y_FRENCHTOM = 207,
        M_Y_JIM_FITZ = 208,
        F_O_PEASTEURO_1 = 209,
        F_O_PEASTEURO_2 = 210,
        F_O_PHARBRON_1 = 211,
        F_O_PJERSEY_1 = 212,
        F_O_PORIENT_1 = 213,
        F_O_RICH_1 = 214,
        F_M_BUSINESS_1 = 215,
        F_M_BUSINESS_2 = 216,
        F_M_CHINATOWN = 217,
        F_M_PBUSINESS = 218,
        F_M_PEASTEURO_1 = 219,
        F_M_PHARBRON_1 = 220,
        F_M_PJERSEY_1 = 221,
        F_M_PJERSEY_2 = 222,
        F_M_PLATIN_1 = 223,
        F_M_PLATIN_2 = 224,
        F_M_PMANHAT_1 = 225,
        F_M_PMANHAT_2 = 226,
        F_M_PORIENT_1 = 227,
        F_M_PRICH_1 = 228,
        F_Y_BUSINESS_1 = 229,
        F_Y_CDRESS_1 = 230,
        F_Y_PBRONX_1 = 231,
        F_Y_PCOOL_1 = 232,
        F_Y_PCOOL_2 = 233,
        F_Y_PEASTEURO_1 = 234,
        F_Y_PHARBRON_1 = 235,
        F_Y_PHARLEM_1 = 236,
        F_Y_PJERSEY_2 = 237,
        F_Y_PLATIN_1 = 238,
        F_Y_PLATIN_2 = 239,
        F_Y_PLATIN_3 = 240,
        F_Y_PMANHAT_1 = 241,
        F_Y_PMANHAT_2 = 242,
        F_Y_PMANHAT_3 = 243,
        F_Y_PORIENT_1 = 244,
        F_Y_PQUEENS_1 = 245,
        F_Y_PRICH_1 = 246,
        F_Y_PVILLBO_2 = 247,
        F_Y_SHOP_3 = 248,
        F_Y_SHOP_4 = 249,
        F_Y_SHOPPER_5 = 250,
        F_Y_SOCIALITE = 251,
        F_Y_STREET_2 = 252,
        F_Y_STREET_5 = 253,
        F_Y_STREET_9 = 254,
        F_Y_STREET_12 = 255,
        F_Y_STREET_30 = 256,
        F_Y_STREET_34 = 257,
        F_Y_TOURIST_1 = 258,
        F_Y_VILLBO_1 = 259,
        M_M_BUSINESS_2 = 260,
        M_M_BUSINESS_3 = 261,
        M_M_EE_HEAVY_1 = 262,
        M_M_EE_HEAVY_2 = 263,
        M_M_FATMOB_1 = 264,
        M_M_GAYMID = 265,
        M_M_GENBUM_1 = 266,
        M_M_LOONYWHITE = 267,
        M_M_MIDTOWN_1 = 268,
        M_M_PBUSINESS_1 = 269,
        M_M_PEASTEURO_1 = 270,
        M_M_PHARBRON_1 = 271,
        M_M_PINDUS_2 = 272,
        M_M_PITALIAN_1 = 273,
        M_M_PITALIAN_2 = 274,
        M_M_PLATIN_1 = 275,
        M_M_PLATIN_2 = 276,
        M_M_PLATIN_3 = 277,
        M_M_PMANHAT_1 = 278,
        M_M_PMANHAT_2 = 279,
        M_M_PORIENT_1 = 280,
        M_M_PRICH_1 = 281,
        M_O_EASTEURO_1 = 282,
        M_O_HASID_1 = 283,
        M_O_MOBSTER = 284,
        M_O_PEASTEURO_2 = 285,
        M_O_PHARBRON_1 = 286,
        M_O_PJERSEY_1 = 287,
        M_O_STREET_1 = 288,
        M_O_SUITED = 289,
        M_Y_BOHO_1 = 290,
        M_Y_BOHOGUY_1 = 291,
        M_Y_BRONX_1 = 292,
        M_Y_BUSINESS_1 = 293,
        M_Y_BUSINESS_2 = 294,
        M_Y_CHINATOWN_3 = 295,
        M_Y_CHOPSHOP_1 = 296,
        M_Y_CHOPSHOP_2 = 297,
        M_Y_DODGY_1 = 298,
        M_Y_DORK_2 = 299,
        M_Y_DOWNTOWN_1 = 300,
        M_Y_DOWNTOWN_2 = 301,
        M_Y_DOWNTOWN_3 = 302,
        M_Y_GAYYOUNG = 303,
        M_Y_GENSTREET11 = 304,
        M_Y_GENSTREET16 = 305,
        M_Y_GENSTREET20 = 306,
        M_Y_GENSTREET34 = 307,
        M_Y_HARDMAN_1 = 308,
        M_Y_HARLEM_1 = 309,
        M_Y_HARLEM_2 = 310,
        M_Y_HARLEM_4 = 311,
        M_Y_HASID_1 = 312,
        M_Y_LEASTSIDE_1 = 313,
        M_Y_PBRONX_1 = 314,
        M_Y_PCOOL_1 = 315,
        M_Y_PCOOL_2 = 316,
        M_Y_PHARBRON_1 = 318,
        M_Y_PHARLEM_1 = 319,
        M_Y_PJERSEY_1 = 320,
        M_Y_PLATIN_1 = 321,
        M_Y_PLATIN_3 = 323,
        M_Y_PMANHAT_1 = 324,
        M_Y_PMANHAT_2 = 325,
        M_Y_PORIENT_1 = 326,
        M_Y_PQUEENS_1 = 327,
        M_Y_PRICH_1 = 328,
        M_Y_PVILLBO_1 = 329,
        M_Y_PVILLBO_2 = 330,
        M_Y_PVILLBO_3 = 331,
        M_Y_QUEENSBRIDG = 332,
        M_Y_SHADY_2 = 333,
        M_Y_SKATEBIKE_1 = 334,
        M_Y_SOHO_1 = 335,
        M_Y_STREET_1 = 336,
        M_Y_STREET_3 = 337,
        M_Y_STREET_4 = 338,
        M_Y_STREETBLK_2 = 339,
        M_Y_STREETBLK_3 = 340,
        M_Y_STREETPUNK2 = 341,
        M_Y_STREETPUNK4 = 342,
        M_Y_STREETPUNK5 = 343,
        M_Y_TOUGH_5 = 344,
        M_Y_TOURIST_2 = 345,
    }


    /// <summary>
    /// The phases of a traffic light
    /// </summary>
    public enum TrafficLightPhases : int {
        Green = 1,
        Yellow = 2,
        Red = 3
    }

    /// <summary>
    /// the week days
    /// </summary>
    public enum DaysOfWeek : int {
        Sunday = 0,
        Monday = 1,
        Tuesday = 2,
        Wednesday = 3,
        Thursday = 4,
        Friday = 5,
        Saturday = 6
    }

    /// <summary>
    /// a vehicle's doors
    /// </summary>
    public enum VehicleDoors : int {
        Driver = 0,
        FirstPassenger = 1,
        SecondPassenger = 2,
        ThirdPassenger = 3,
        Hood = 4,
        Trunk = 5
    }

    /// <summary>
    /// Locking states of vehicle doors
    /// </summary>
    public enum LockedState : int {
        Unlocked = 0,
        Locked = 1,
        LockedWithBreakableGlass = 2
    }

    /// <summary>
    /// weather types
    /// </summary>
    public enum WeatherTypes : int {
        ExtraSunny = 1,
        Sunny = 2,
        SunnyAndWindy = 3,
        Cloudy = 4,
        Raining = 5,
        Drizzle = 6,
        Foggy = 7,
        Thunderstorm = 8,
        ExtraSunny2 = 9,
        SunnyAndWindy2 = 10
    }

    /// <summary>
    /// Blip types
    /// </summary>
    public enum Blips : int {
        Destination = 0,
        Destination1 = 1,
        Destination2 = 2,
        Objective = 3,
        Objective1 = 4,
        Objective2 = 5,
        Player = 6,
        North = 7,
        Waypoint = 8,
        Pistol = 9,
        Shotgun = 10,
        Smg = 11,
        Rofle = 12,
        Rocket = 13,
        Grenade = 14,
        Molotov = 15,
        Sniper = 16,
        BaseballBat = 17,
        Knife = 18,
        Health = 19,
        Armor = 20,
        BurgerShot = 21,
        CluckinBell = 22,
        Vlad = 23,
        Internet = 24,
        Manny = 25,
        LittleJacob = 26,
        Roman = 27,
        Faustin = 28,
        Safehouse = 29,
        TaxiRank = 30,
        Bernie = 31,
        Brucie = 32,
        UnknownContact = 33,
        Dwayne = 34,
        Elizabeta = 35,
        Gambetti = 36,
        JimmyPegorino = 37,
        Derrick = 38,
        Francis = 39,
        Gerry = 40,
        Katie = 41,
        Packie = 42,
        PhilBell = 43,
        PlayboyX = 44,
        RayBoccino = 45,
        EightBall = 46,
        Bar = 47,
        BoatTour = 48,
        Bowling = 49,
        ClothesShop = 50,
        Club = 51,
        Darts = 52,
        DwayneRed = 53,
        Date = 54,
        PlayboXRed = 55,
        Helitour = 56,
        Restaurant = 57,
        Station = 58,
        Weapons = 59,
        PoliceStation = 60,
        FireStation = 61,
        Hospital = 62,
        Male = 63,
        Female = 64,
        FinishLine = 65,
        StripClub = 66,
        ConsoleGame = 67,
        CopCar = 68,
        Dimitri = 69,
        ComedyClub = 70,
        CabaretClub = 71,
        Ransom = 72,
        CopChopper = 73,
        Michelle = 74,
        PayNSpray = 75,
        Assassin = 76,
        Revenge = 77,
        Deal = 78,
        Garage = 79,
        Lawyer = 80,
        Trophy = 81,
        MultiplayerTutorial = 82,
        Station3 = 83,
        Station8 = 84,
        Stationa = 85,
        Stationb = 86,
        Stationc = 87,
        Statione = 88,
        Stationj = 89,
        Stationk = 90,
        CarWash = 91,
        UnitedLibertyPaper = 92,
        Boss = 93,
        Base = 94
    }

    /// <summary>
    /// The bodyparts of an player
    /// </summary>
    public enum Bodyparts : int {
        Head = 0,
        UpperBody = 1,
        LowerBody = 2,
        Special1 = 3,
        Hand = 4,
        Feet = 5,
        Jacket = 6,
        Hair = 7,
        Special2 = 8,
        Face = 10
    }

    /// <summary>
    /// The Weapons
    /// </summary>
    public enum Weapons : int {
        BaseballBat = 1,
        PoolCue = 2,
        Knife = 3,
        Grenade = 4,
        Molotov = 5,
        Glock = 7,
        DesertEagle = 9,
        PumpShotgun = 10,
        CombatShutgon = 11,
        MicroUzi = 12,
        Mp10 = 13,
        Ak47 = 14,
        M4 = 15,
        PSG1 = 16,
        Remington700 = 17,
        RPG7 = 18
    }

    /// <summary>
    /// There are various state types.
    /// </summary>
    public enum StateTypes : int {
        Disconnect = 0,
        Connect = 1,
        Spawn = 2,
        Death = 3,
        OnFoot = 4,
        EnterCar = 5,
        InVehicle = 6,
        Passenger = 7,
        ExitVehicle = 8,
        EnterVehicle = 9
    }

    /// <summary>
    /// The possible models for pickups
    /// </summary>
    public enum PickupModels : uint {
        HealthKit = 0x3fc62578,
        Armour = 0x972daa10,
        BaseballBat = 0x68d19067,
        PoolCue = 0x4e746e14,
        Knife = 0x3dfebd8b,
        Grenade = 0x3b373591,
        Molotov = 0x88b44609,
        RPG = 0x5603b9ec,
        GlockPistol = 0xf44c839d,
        DesertEagle = 0x5caeb064,
        Shotgun = 0x6e10d6c3,
        Beretta = 0xddb2b5ad,
        Uzi = 0xafd2e07b,
        Mp5 = 0x65daddfd,
        Ak47 = 0x1bdd0543,
        M4 = 0x35855559,
        Rifle = 0x08762932,
        M40A1 = 0x22c755b0
    }

    /// <summary>
    /// The types of pickups
    /// </summary>
    public enum PickupTypes : byte {
        /// <summary>
        /// Can't pickup, does not disappear
        /// </summary>
        CantPickup = 1,

        /// <summary>
        /// Can pickup, disappears on pickup
        /// </summary>
        CanPickup = 2
    }

    /// <summary>
    /// The Types of Checkpoints
    /// </summary>
    public enum CheckpointTypes : int {
        /// <summary>
        /// Cylinder (tube) with an arrow
        /// </summary>
        ArrowTube = 2,

        /// <summary>
        /// Cylinder (tube) with a flag
        /// </summary>
        FlagTube = 3,

        /// <summary>
        /// Corona with an arrow
        /// </summary>
        ArrowCorona = 4,

        /// <summary>
        /// Corona with a flag
        /// </summary>
        FlagCorona = 5,

        /// <summary>
        /// Just an arrow
        /// </summary>
        Arrow = 6,

        /// <summary>
        /// Just a flag
        /// </summary>
        Corona = 7,

        /// <summary>
        /// Just a circle
        /// </summary>
        Circle = 8
    }

    /// <summary>
    /// 3D Vector
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CVector3 {
        /// <summary>
        /// X Coordinate
        /// </summary>
        [System.ComponentModel.DefaultValue(0f)]
        public Single X { get; set; }

        /// <summary>
        /// Y Coordinate
        /// </summary>
        [System.ComponentModel.DefaultValue(0f)]
        public Single Y { get; set; }

        /// <summary>
        /// Z Coordinate
        /// </summary>
        [System.ComponentModel.DefaultValue(0f)]
        public Single Z { get; set; }
    }

    /// <summary>
    /// COntrol State
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CControlState {
        /// <summary>
        /// Left FootMove
        /// </summary>
        byte ucOnFootMove_left;

        /// <summary>
        /// Right Footmove
        /// </summary>
        byte ucOnFootMove_right;

        /// <summary>
        /// Upper Footmove
        /// </summary>
        byte ucOnFootMove_up;

        /// <summary>
        /// Down Footmove
        /// </summary>
        byte ucOnFootMove_down;

        /// <summary>
        /// VehicleMove Left
        /// </summary>
        byte ucInVehicleMove_left;

        /// <summary>
        /// VehicleMove Right
        /// </summary>
        byte ucInVehicleMove_right;

        /// <summary>
        /// VehicleMove Up
        /// </summary>
        byte ucInVehicleMove_up;

        /// <summary>
        /// VehicleMove Down
        /// </summary>
        byte ucInVehicleMove_down;

        /// <summary>
        /// VehicleTriggers Left
        /// </summary>
        byte ucInVehicleTriggers_left;

        /// <summary>
        /// VehicleTriggers Right
        /// </summary>
        byte ucInVehicleTriggers_right;

        /// <summary>
        /// Binary Key Count
        /// </summary>
        public enum AnonymousEnum {
            KEY_COUNT = 16
        }

        /// <summary>
        /// Binary Keys
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct Keys {
            // On Foot/In Vehicle
            /// <summary>
            /// Enter Vehicle Key
            /// </summary>
            public bool bEnterExitVehicle;

            // On Foot
            /// <summary>
            /// Sprint Key
            /// </summary>
            public bool bSprint;

            /// <summary>
            /// Jump Key
            /// </summary>
            public bool bJump;

            /// <summary>
            /// Attack Key
            /// </summary>
            public bool bAttack;

            /// <summary>
            /// Attack2 Key
            /// </summary>
            public bool bAttack2;

            /// <summary>
            /// Aimkey
            /// </summary>
            public bool bAim;

            /// <summary>
            /// FreeAim Key (?)
            /// </summary>
            public bool bFreeAim;

            /// <summary>
            /// MeleeAttack1 Key
            /// </summary>
            public bool bMeleeAttack1;

            /// <summary>
            /// MeleeAttack2 Key
            /// </summary>
            public bool bMeleeAttack2;

            /// <summary>
            /// MeleeKick Key
            /// </summary>
            public bool bMeleeKick;

            /// <summary>
            /// MeleeBlock Key
            /// </summary>
            public bool bMeleeBlock;

            // In Vehicle
            /// <summary>
            /// Handbrake Key
            /// </summary>
            public bool bHandbrake;

            /// <summary>
            /// Alternative Handbrake Key
            /// </summary>
            public bool bHandbrake2;

            /// <summary>
            /// Horn Key
            /// </summary>
            public bool bHorn;

            /// <summary>
            /// Driveby Key
            /// </summary>
            public bool bDriveBy;

            /// <summary>
            /// Helifire Key
            /// </summary>
            public bool bHeliPrimaryFire;
        }

        /// <summary>
        /// Keystate Infos
        /// </summary>
        public Keys keys;

        /// <summary>
        /// Is in combat?
        /// </summary>
        /// <returns>true if in combat otherwise false</returns>
        public bool IsInCombat() {
            return (keys.bMeleeAttack1 || keys.bMeleeAttack2 || keys.bMeleeKick || keys.bMeleeBlock);
        }

        /// <summary>
        /// Is firing?
        /// </summary>
        /// <returns>true if is firing otherwise false</returns>
        public bool IsFiring() {
            return (keys.bAttack);
        }

        /// <summary>
        /// Is aiming?
        /// </summary>
        /// <returns>true if is aiming otherwise false</returns>
        public bool IsAiming() {
            return (keys.bAttack2 || keys.bAim || keys.bFreeAim);
        }

        /// <summary>
        /// Is doing driveby?
        /// </summary>
        /// <returns>true if is doing driveby otherwise false</returns>
        public bool IsDoingDriveBy() {
            return (keys.bDriveBy);
        }

        /// <summary>
        /// Is firing with helicopter
        /// </summary>
        /// <returns>true if is firing with helicoper otherwise false</returns>
        public bool IsFiringHelicoptor() {
            return (keys.bHeliPrimaryFire);
        }

        /// <summary>
        /// Is sprinting?
        /// </summary>
        /// <returns>true if is sprinting otherwise false</returns>
        public bool IsSprinting() {
            return (keys.bSprint);
        }

        /// <summary>
        /// Using Horn?
        /// </summary>
        /// <returns>true if using otherwise false</returns>
        public bool IsUsingHorn() {
            return (keys.bHorn);
        }

        /// <summary>
        /// Is Jumping?
        /// </summary>
        /// <returns>true if jumping otherwise false</returns>
        public bool IsJumping() {
            return (keys.bJump);
        }

        /// <summary>
        /// Using Handbrake?
        /// </summary>
        /// <returns>true is using, otherwise false</returns>
        public bool IsUsingHandbrake() {
            return (keys.bHandbrake || keys.bHandbrake2);
        }

        /// <summary>
        /// Is using enter/exit @ Vehicle
        /// </summary>
        /// <returns>true if is using otherwise false</returns>
        public bool IsUsingEnterExitVehicle() {
            return (keys.bEnterExitVehicle);
        }
    }
}

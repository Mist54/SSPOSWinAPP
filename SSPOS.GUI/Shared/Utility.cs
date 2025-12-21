using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SSPOS.GUI.Shared
{
    public class Utility
    {
    }

    public class BillStatus
    {
        public static string Ordered => "Ordered";
        public static string Preparing => "Preparing";
        public static string ReadyToBill => "Ready to Bill";
        public static string Billed => "Billed";
        public static string Paid => "Paid";
        public static string PaymentPending => "Payment Pending";
        public static string Cancelled => "Cancelled";
        public static string Settled => "Settled";                  
    }

    public class RoleStatus
    {
        
        public static int Admin => 1;
        public static int Manager => 2;
        public static int Waiter => 3;
        public static int Cook => 2;
        public static int Cleaner => 4;
        public static int SuperUser => 0;

        public static string getRole(int role)
        {
            if (role == 0)
                return "SuperUser";
            else if (role == 1)
                return "SystemAdmin";
            else if (role == 2)
                return "Manager";
            else if (role == 3)
                return "Waiter";
            else
                return "Unknown";
        }

    }
    

    public static class ConfigManager
    {

        private static readonly string configFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Shared", "Config.json");

        public static Config Settings { get; private set; }

        static ConfigManager()
        {
            LoadConfig();
        }

        public static void LoadConfig()
        {
            if (File.Exists(configFilePath))
            {
                string json = File.ReadAllText(configFilePath);
                Settings = JsonConvert.DeserializeObject<Config>(json);
            }
            else
            {
                Settings = new Config(); // Default values if file is missing
            }
        }

        public static void SaveConfig()
        {
            string json = JsonConvert.SerializeObject(Settings, Formatting.Indented);
            File.WriteAllText(configFilePath, json);
        }
    }


    
    public class Config
    {
        public string RestaurantName { get; set; }
        public string Owner { get; set; }
        public string Address { get; set; }
        public string Contact { get; set; }
        public double TaxRate { get; set; }
    }


}

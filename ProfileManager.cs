using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace BuchhaltungConsolenApp
{
    static class ProfileManager
    {
        public static Profile CurrentProfile { get; private set; }

        public static void CreateProfile(string name, decimal balance)
        {
            CurrentProfile = new Profile(name, balance);
            SaveProfile(CurrentProfile);
        }

        public static void SaveProfile(Profile profile)
        {
            string filePath = AppContext.BaseDirectory + profile.Name + ".prof";  //Pfad der Seicherdatei direkt im Projektordner
            BinaryFormatter binaryFormatter = new BinaryFormatter();


            //Serialisierung - Profil erzeugen und speichern
            try
            {
                using (FileStream stream = new FileStream(filePath, FileMode.Create))
                {
                    binaryFormatter.Serialize(stream, profile);
                }
            }
            catch (Exception ex)
            {
                Console.Clear();
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
        }

        public static void LoadProfil(string profilePath)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();

            try
            {
                using (FileStream stream = new FileStream(profilePath, FileMode.Open))
                {
                    CurrentProfile = (Profile) binaryFormatter.Deserialize(stream);
                }
            }
            catch (Exception ex)
            {
                Console.Clear();
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
        }

        public static bool CheckIfProfileExists(string profileName)
        {
            string fullPath = AppContext.BaseDirectory + profileName + ".prof";
            return File.Exists(fullPath);
        }
    }
}

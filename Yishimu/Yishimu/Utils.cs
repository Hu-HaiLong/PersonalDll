using UnityEngine;

namespace Yishimu
{
    public class Utils
    {

        public static void SetInt(string key, int value)
        {
            PlayerPrefs.SetInt(key, value);
        }

        public static int GetInt(string key)
        {
            return PlayerPrefs.GetInt(key);
        }

        public static void SetString(string key, string value)
        {
            PlayerPrefs.SetString(key, value);
        }

        public static string GetString(string key)
        {
            return PlayerPrefs.GetString(key);
        }

        public static void SetBool(string key, bool value)
        {
            if (value)
                PlayerPrefs.SetInt(key, 1);
            else
                PlayerPrefs.SetInt(key, 0);
        }

        public static bool GetBool(string key)
        {
            int value = PlayerPrefs.GetInt(key);
            if (value == 1)
                return true;
            return false;
        }

        public static void DeleteAll()
        {
            PlayerPrefs.DeleteAll();
        }

        public static void DeleteKey(string key)
        {
            PlayerPrefs.DeleteKey(key);
        }

        public static bool HasKey(string key)
        {
            return PlayerPrefs.HasKey(key);
        }
    }
}

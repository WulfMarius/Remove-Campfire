using UnityEngine;

namespace RemoveCampfire
{
    internal class RemoveCampfire
    {
        public static void OnLoad()
        {
            Debug.Log("[Remove-Campfire]: Version " + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version);
        }
    }
}
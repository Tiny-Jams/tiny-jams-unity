using UnityEngine;

namespace com.tinyjams.tjlib
{
    public class LogOut : MonoBehaviour
    {
        public void Log(string text)
        {
#if UNITY_EDITOR
            Debug.Log(text);
#endif
        }
    }
}
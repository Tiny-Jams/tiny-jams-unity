using TinyJams.P01_TinyShooter.Runtime;
using UnityEditor;
using UnityEngine;

namespace TinyJams.P01_TinyShooter.Editor
{
    [CustomEditor(typeof(SpawnPrefab))]
    public class SpawnPrefabEditor : UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            
            SpawnPrefab spawnPrefab = (SpawnPrefab)this.target;
            if (GUILayout.Button("SpawnAtGameObjectPosition"))
            {
                spawnPrefab.SpawnAtGameObjectPosition();
            }
        }
    }
}
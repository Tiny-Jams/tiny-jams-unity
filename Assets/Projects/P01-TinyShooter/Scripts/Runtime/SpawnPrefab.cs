using UnityEngine;

namespace TinyJams.P01_TinyShooter.Runtime
{
    public class SpawnPrefab : MonoBehaviour
    {
        [SerializeField] private GameObject prefab;

        public GameObject SpawnAtPosition(Vector3 position, Transform parent = null)
        {
            return GameObject.Instantiate(this.prefab, position, Quaternion.identity, parent);
        }
        
        public GameObject SpawnAtGameObjectPosition(Transform parent = null)
        {
            return this.SpawnAtPosition(this.transform.position, parent);
        }
    }
}

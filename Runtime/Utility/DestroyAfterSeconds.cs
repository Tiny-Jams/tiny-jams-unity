using System.Collections;
using UnityEngine;

namespace com.tinyjams.tjlib.Runtime.Utility
{
    public class DestroyAfterSeconds : MonoBehaviour
    {
        [SerializeField] private float lifetime;

        private void Start()
        {
            this.StartCoroutine(this.DestroySelfAfterSeconds());
        }

        private IEnumerator DestroySelfAfterSeconds()
        {
            yield return new WaitForSeconds(this.lifetime);
            Destroy(this);
        }
    }
}
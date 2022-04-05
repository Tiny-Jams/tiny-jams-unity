using System;
using System.Collections;
using UnityEngine;

namespace TinyJams.P01_TinyShooter.Runtime
{
    public class DestroyAfterSeconds : MonoBehaviour
    {
        [SerializeField] private float lifetime;

        private void Start()
        {
            StartCoroutine(DestroySelfAfterSeconds());
        }

        private IEnumerator DestroySelfAfterSeconds()
        {
            yield return new WaitForSeconds(this.lifetime);
            Destroy(this);
        }
    }
}
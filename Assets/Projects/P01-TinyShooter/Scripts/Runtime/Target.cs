using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace TinyJams.P01_TinyShooter.Runtime
{
    [RequireComponent(typeof(Collider2D))]
    public class Target : MonoBehaviour
    {
        public UnityEvent onActivation = new UnityEvent();
        public UnityEvent onDeactivation = new UnityEvent();
        
        [SerializeField] private float respawnTime = 2.0f;
        
        private Collider2D collider2D;
        private bool active = true;

        private void Awake()
        {
            this.collider2D = this.GetComponent<Collider2D>();
        }

        private void OnTriggerEnter2D(Collider2D collider2D)
        {
            if (!this.active)
            {
                return;
            }

            this.active = false;
            this.onDeactivation.Invoke();
            this.StartCoroutine(this.SetActiveAfterTime());
        }

        private IEnumerator SetActiveAfterTime()
        {
            yield return new WaitForSeconds(this.respawnTime);
            this.active = true;
            this.onActivation.Invoke();
        }
    }
}
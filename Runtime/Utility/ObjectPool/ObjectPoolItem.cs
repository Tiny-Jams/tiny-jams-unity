using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

namespace com.tinyjams.tjlib.Runtime.Utility.ObjectPool
{
    public class ObjectPoolItem : MonoBehaviour
    {
        private ObjectPool objectPool;
        
        public string Key { get; private set; }

        public UnityEvent onActivated;
        public UnityEvent onReleased;
        
        public void Initiate(ObjectPool inObjectPool, string key)
        {
            this.objectPool = inObjectPool;
            this.Key = key;
            this.gameObject.SetActive(false);
        }

        /// <summary>
        /// Is called by the object pool. Do not call this manually.
        /// </summary>
        public void Activate()
        {
            this.gameObject.SetActive(true);
            this.onActivated.Invoke();
        }
        
        /// <summary>
        /// Is called by other scripts to return this object to the pool.
        /// </summary>
        public void Release()
        {
            this.objectPool.ReleaseObject(this);
            this.onReleased.Invoke();
            this.gameObject.SetActive(false);
        }
    }
}
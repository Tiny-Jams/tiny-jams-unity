using System.Collections;
using System.Collections.Generic;
using com.tinyjams.tjlib.Runtime.Utility.ObjectPool;
using UnityEngine;

namespace TinyJams
{
    public class ObjectPoolTester : MonoBehaviour
    {
        private Stack<ObjectPoolItem> spawnedObjects = new();
        
        private P02_Input input;

        private void Awake()
        {
            this.input = new P02_Input();
        }

        private void OnEnable()
        {
            this.input.General.Enable();
        }

        private void Start()
        {
            this.input.General.Activate.started += ctx => this.SpawnObject();
            this.input.General.Release.started += ctx => this.RemoveObject();
        }

        private void SpawnObject()
        {
            var pool = GameObject.FindObjectOfType<ObjectPool>();
            var spawnedObject = pool.GetObject("Circles", Random.insideUnitSphere);
            this.spawnedObjects.Push(spawnedObject);
        }

        private void RemoveObject()
        {
            var objectToRemove = this.spawnedObjects.Pop();
            objectToRemove.Release();
        }
    }
}
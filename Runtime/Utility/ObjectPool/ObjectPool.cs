using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace com.tinyjams.tjlib.Runtime.Utility.ObjectPool
{
    public class ObjectPool : MonoBehaviour
    {
        [SerializeField] private ObjectPoolSettings objectPoolSettings;
        [SerializeField] private Vector3 spawnPosition = new Vector3(0.0f, -1000.0f, 0.0f);

        private Dictionary<string, Stack<ObjectPoolItem>> pool = new();

        private void Start()
        {
            foreach (var itemTemplate in this.objectPoolSettings.templates)
            {
                if (!itemTemplate.Prefab.TryGetComponent<ObjectPoolItem>(out var result))
                {
                    Debug.LogError($"ObjectPoolItem Component is missing on {itemTemplate.Key}. Skipping.");
                    continue;
                }

                var stack = new Stack<ObjectPoolItem>();
                for (int i = 0; i < itemTemplate.MinPoolSize; i++)
                {
                    var poolItem = this.InstantiateObjectPoolItem(itemTemplate);
                    stack.Push(poolItem);
                }

                this.pool.Add(itemTemplate.Key, stack);
            }
        }

        private ObjectPoolItem InstantiateObjectPoolItem(ItemTemplate template)
        {
            var newObject = GameObject.Instantiate(template.Prefab, this.spawnPosition, Quaternion.identity);
            var poolItem = newObject.GetComponent<ObjectPoolItem>();
            poolItem.Initiate(this, template.Key);
            return poolItem;
        }

        public ObjectPoolItem GetObject(string key, Vector3 position = new(), Quaternion rotation = new())
        {
            if (!this.pool.ContainsKey(key))
            {
                Debug.LogError($"Key '{key}' does not exist in object pool.");
                return null;
            }

            var stack = this.pool[key];
            ObjectPoolItem item = null;
            if (stack.Count <= 0)
            {
                Debug.LogWarning($"Pool for key '{key}' is too small. Instantiating additional object.");

                var template = this.objectPoolSettings.templates.First(x => x.Key == key);
                item = this.InstantiateObjectPoolItem(template);
            }
            else
            {
                item = stack.Pop();
            }

            item.transform.position = position;
            item.transform.rotation = rotation;
            item.Activate();

            return item;
        }

        public void ReleaseObject(ObjectPoolItem objectToRelease)
        {
            if (!this.pool.ContainsKey(objectToRelease.Key))
            {
                Debug.LogError($"Key '{objectToRelease.Key}' does not exist in object pool.");
                return;
            }

            this.pool[objectToRelease.Key].Push(objectToRelease);
            objectToRelease.transform.position = this.spawnPosition;
        }
    }
}
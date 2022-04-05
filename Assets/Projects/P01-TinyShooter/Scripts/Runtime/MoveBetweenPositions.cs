using System;
using System.Collections.Generic;
using UnityEngine;

namespace TinyJams.P01_TinyShooter.Runtime
{
    public class MoveBetweenPositions : MonoBehaviour
    {
        [SerializeField] private List<Transform> targetPositions;
        [SerializeField] private float speed = 10.0f;
        
        private int currentTargetIdx;

        private void Update()
        {
            var currentTarget = this.targetPositions[this.currentTargetIdx];
            
            this.transform.position = Vector3.MoveTowards(this.transform.position, currentTarget.position, this.speed * Time.deltaTime);
            
            if (Vector3.Distance(this.transform.position, currentTarget.transform.position) < 0.01f)
            {
                this.currentTargetIdx++;
                this.currentTargetIdx %= this.targetPositions.Count;
            }
        }
    }
}
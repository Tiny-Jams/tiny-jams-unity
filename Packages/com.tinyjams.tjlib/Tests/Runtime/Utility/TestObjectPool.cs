using System.Collections;
using com.tinyjams.tjlib.Runtime.Utility.ObjectPool;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace com.tinyjams.tjlib.Tests.Runtime.Utility
{
    public class TestObjectPool
    {
        // A UnityTest behaves like a coroutine in PlayMode
        // and allows you to yield null to skip a frame in EditMode
        [UnityTest]
        public IEnumerator TestObjectPoolWithEnumeratorPasses()
        {
            //todo: do this
            yield return null;
        }
    }
}
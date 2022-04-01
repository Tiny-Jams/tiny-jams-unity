using System.Collections;
using NUnit.Framework;
using UnityEngine.TestTools;

namespace com.tinyjams.tjlib.Tests.Runtime
{
    public class TestRuntimeExample
    {
        [Test]
        public void TestRuntimeExampleSimplePasses()
        {
        }
        
        [UnityTest]
        public IEnumerator TestRuntimeExampleEnumeratorPasses()
        {
            yield return null;
        }
    }
}

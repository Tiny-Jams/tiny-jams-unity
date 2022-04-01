using System.Collections;
using NUnit.Framework;
using UnityEngine.TestTools;

namespace com.tinyjams.tjlib.Tests.Editor
{
    public class TestEditorExample
    {
        [Test]
        public void TestEditorExampleSimplePasses()
        {
        }

        [UnityTest]
        public IEnumerator TestEditorExampleWithEnumeratorPasses()
        {
            yield return null;
        }
    }
}

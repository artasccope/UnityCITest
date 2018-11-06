using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class NewTestScript {

    [Test]
    public void NewTestScriptSimplePasses() {
        //Assert.Pass();
    }
    
    [Test]
    public void NewTestScriptSimplePasses2() {
        Assert.Fail();
    }

}

using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using Scripts;

public class MeatGenerator_Test
{
    //// A Test behaves as an ordinary method
    //[Test]
    //public void MeatGenerator_TestSimplePasses()
    //{
    //    // Use the Assert class to test conditions
    //}

    //// A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    //// `yield return null;` to skip a frame.
    //[UnityTest]
    //public IEnumerator MeatGenerator_TestWithEnumeratorPasses()
    //{
    //    // Use the Assert class to test conditions.
    //    // Use yield to skip a frame.
    //    yield return null;
    //}

    GameObject _canvas;

    [SetUp]
    public void Setup()
    {
        _canvas = GameObject.Instantiate(Resources.Load<GameObject>("Canvas"));
    }

    [Test]
    public void MeatGeneratorGetMeat()
    {
        int temp = _canvas.GetComponent<MeatGenerator>().MeatStock;

        _canvas.GetComponent<MeatGenerator>().GetMeat();

        Assert.AreEqual(temp + 1, _canvas.GetComponent<MeatGenerator>().MeatStock);
    }

    [Test]
    public void MeatGeneratorUpgradeGetMeat()
    {
        int temp = _canvas.GetComponent<MeatGenerator>().AddMeat;

        _canvas.GetComponent<MeatGenerator>().UpgradeGetMeat();

        Assert.AreEqual(temp + 1, _canvas.GetComponent<MeatGenerator>().AddMeat);
    }
}

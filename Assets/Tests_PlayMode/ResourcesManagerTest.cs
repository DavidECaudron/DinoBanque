using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using Scripts;

public class ResourcesManagerTest
{
    GameObject _canvas;
    ResourcesManager _resourcesManager;

    [SetUp]
    public void Setup()
    {
        _canvas = GameObject.Instantiate(Resources.Load<GameObject>("Canvas"));
        _resourcesManager = _canvas.GetComponent<ResourcesManager>();
    }

    [Test]
    public void MeatStockStartsAtZero()
    {
        Assert.AreEqual(0, _resourcesManager.MeatStock);
    }

    [Test]
    public void MeatStockAddMeat()
    {
        int temp = _resourcesManager.MeatStock;

        _resourcesManager.AddMeatInStock(10);

        Assert.AreEqual(temp + 10, _resourcesManager.MeatStock);
    }

    [Test]
    public void MeatStockRemoveMeat()
    {
        int temp = _resourcesManager.MeatStock;

        _resourcesManager.RemoveMeatInStock(10);

        Assert.AreEqual(temp, _resourcesManager.MeatStock);
    }
}

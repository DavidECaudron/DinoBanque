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
        Assert.AreEqual(0, _resourcesManager.ResourcesStock["Meat"]);
    }

    [Test]
    public void MeatStockAddMeat()
    {
        int temp = _resourcesManager.ResourcesStock["Meat"];

        _resourcesManager.AddInStock("Meat", 10);

        Assert.AreEqual(temp + 10, _resourcesManager.ResourcesStock["Meat"]);
    }

    [Test]
    public void MeatStockRemoveMeat()
    {
        int temp = _resourcesManager.ResourcesStock["Meat"];

        _resourcesManager.RemoveInStock("Meat", 10);

        Assert.AreEqual(temp, _resourcesManager.ResourcesStock["Meat"]);
    }
}

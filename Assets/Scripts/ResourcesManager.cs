using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Scripts
{
    public class ResourcesManager : MonoBehaviour
    {
        #region Public

        #endregion

        #region Private

        private Dictionary<string, int> _resourcesStock = new Dictionary<string, int>();
        private CounterManager _counterManager;

        #endregion

        #region Unity

        private void Awake()
        {
            _counterManager = GetComponentInChildren<CounterManager>();

            _resourcesStock.Add("Meat", 0);
            _resourcesStock.Add("Wood", 0);
            _resourcesStock.Add("Rock", 0);
            _resourcesStock.Add("Egg", 0);

            RefreshCounter("Meat");
            RefreshCounter("Wood");
            RefreshCounter("Rock");
            RefreshCounter("Egg");
        }

        #endregion

        #region Methods

        private void RefreshCounter(string resource)
        {
            _counterManager.FindCounter(resource);
        }

        public void AddInStock(string resource, int amount)
        {
            _resourcesStock[resource] += amount;
            RefreshCounter(resource);
        }

        public void RemoveInStock(string resource, int amount)
        {
            if (_resourcesStock[resource] >= amount)
            {
                _resourcesStock[resource] -= amount;
                RefreshCounter(resource);
            }
        }

        #endregion

        #region Utils

        #endregion

        #region Getter & Setters

        public Dictionary<string, int> ResourcesStock
        {
            get { return _resourcesStock; }
            private set { _resourcesStock = value; }
        }

        #endregion
    }
}

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Scripts
{
    public class CounterManager : MonoBehaviour
    {
        #region Public

        [SerializeField] private ResourcesManager _resourcesManager;

        #endregion

        #region Private

        List<Text> _listCounter = new List<Text>();

        #endregion

        #region Unity

        private void Awake()
        {
            foreach (Transform item in transform)
            {
                _listCounter.Add(item.gameObject.GetComponent<Text>());
            }
        }

        #endregion

        #region Methods

        public void FindCounter(string resource)
        {
            foreach (Text item in _listCounter)
            {
                if (item.gameObject.name == resource)
                {
                    item.text = _resourcesManager.ResourcesStock[resource].ToString() + " " + resource;
                }
            }
        }

        #endregion

        #region Utils
        #endregion

        #region Getters & Setters
        #endregion
    }
}

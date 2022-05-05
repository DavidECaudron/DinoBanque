using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scripts
{
    public class EggSprite : MonoBehaviour
    {
        #region Public

        #endregion

        #region Private

        private ResourcesManager _resourcesManager;

        #endregion

        #region Unity

        private void Awake()
        {
            _resourcesManager = GetComponentInParent<ResourcesManager>();
        }

        #endregion

        #region Methods

        public void EggClick()
        {
            int random = Random.Range(1, 10);

            _resourcesManager.AddInStock("Egg", random);

            if (gameObject != null)
            {
                Destroy(gameObject);
            }
            
        }

        #endregion

        #region Utils
        #endregion

        #region Getters & Setters
        #endregion
    }
}

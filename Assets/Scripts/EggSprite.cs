using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scripts
{
    public class EggSprite : MonoBehaviour
    {
        #region Public

        [SerializeField]
        ResourcesManager _resourcesManager;

        #endregion

        #region Private
        #endregion

        #region Unity
        #endregion

        #region Methods

        public void EggClick()
        {
            int random = Random.Range(0, 10);

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

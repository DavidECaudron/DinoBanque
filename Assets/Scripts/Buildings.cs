using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Scripts
{
    public class Buildings : MonoBehaviour
    {
        #region Public

        [SerializeField]
        private ResourcesManager _resourcesManager;

        [SerializeField]
        private Text _buildingLabel;

        #endregion

        #region Private

        private int _buildingLevel;

        #endregion

        #region Unity

        private void Awake()
        {
            _buildingLevel = 0;
        }

        #endregion

        #region Methods

        public void HouseUpgrade()
        {
            _buildingLevel += 1;

            if (_buildingLevel == 1)
            {
                StartCoroutine(MeatGenerationCoroutine());
            }

            if (_buildingLevel >= 1)
            {
                _buildingLabel.text = gameObject.name + " Level : " + _buildingLevel;
            }
        }

        public void MeatGeneration()
        {
            _resourcesManager.AddMeatInStock(_buildingLevel);
        }

        #endregion

        #region Utils

        IEnumerator MeatGenerationCoroutine()
        {
            while (true)
            {
                yield return new WaitForSeconds(1.0f);
                MeatGeneration();
            }
        }

        #endregion

        #region Getter & Setters

        #endregion
    }
}

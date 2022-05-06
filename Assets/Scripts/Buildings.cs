using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Scripts
{
    public class Buildings : MonoBehaviour
    {
        #region Public

        [SerializeField] protected ResourcesManager _resourcesManager;
        [SerializeField] protected Text _buildingLabel;
        [SerializeField] protected Text _buildingPriceText;

        #endregion

        #region Private

        protected int _buildingLevel;
        protected int _buildingPrice;

        #endregion

        #region Unity

        private void Awake()
        {
            _buildingLevel = 0;
        }

        #endregion

        #region Methods

        public virtual void BuildingUpgrade()
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

        protected virtual void MeatGeneration()
        {
            //_resourcesManager.AddMeatInStock(_buildingLevel);
        }

        #endregion

        #region Utils

        protected IEnumerator MeatGenerationCoroutine()
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

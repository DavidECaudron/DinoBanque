using UnityEngine;

namespace Scripts
{
    public class MeatClicker : MonoBehaviour
    {
        #region Public

        [SerializeField]
        private ResourcesManager _resourcesManager;

        #endregion

        #region Private

        private int _clickValue;
        private int _upgradePrice;

        #endregion

        #region Unity

        private void Awake()
        {
            _clickValue = 1;
            _upgradePrice = 10;
        }

        #endregion

        #region Methods

        public void Click()
        {
            _resourcesManager.AddMeatInStock(_clickValue);
        }

        public void ClickUpgrade()
        {
            if (_resourcesManager.MeatStock >= _upgradePrice)
            {
                _clickValue += 1;
                _resourcesManager.RemoveMeatInStock(_upgradePrice);
                _upgradePrice *= 2;
            }
        }

        #endregion

        #region Utils

        #endregion

        #region Getter & Setters

        #endregion
    }
}

using UnityEngine;

namespace Scripts
{
    public class MeatClicker : MonoBehaviour
    {
        #region Public

        [SerializeField]
        private ResourcesManager _resourcesManager;
        [SerializeField]
        private SpriteManager _spriteManager;

        #endregion

        #region Private

        private int _clickValue;
        private int _upgradePrice;
        private Transform _mouseColliderTransform;

        #endregion

        #region Unity

        private void Awake()
        {
            _clickValue = 1;
            _upgradePrice = 10;

            _mouseColliderTransform = GetComponentInChildren<Collider2D>().gameObject.transform;
        }

        private void Update()
        {
            _mouseColliderTransform.position = Input.mousePosition;
        }

        #endregion

        #region Methods

        public void Click()
        {
            _resourcesManager.AddInStock("Meat", _clickValue);
            _spriteManager.SpriteInstantiate();
        }

        public void ClickUpgrade()
        {
            if (_resourcesManager.ResourcesStock["Meat"] >= _upgradePrice)
            {
                _clickValue += 1;
                _resourcesManager.RemoveInStock("Meat", _upgradePrice);
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

using UnityEngine;
using UnityEngine.UI;

namespace Scripts
{
    public class MeatClicker : MonoBehaviour
    {
        #region Public

        [SerializeField] private ResourcesManager _resourcesManager;
        [SerializeField] private SpriteManager _spriteManager;
        [SerializeField] private Text _upgradePriceText;

        #endregion

        #region Private

        private int _clickValue;
        private int _upgradePrice;
        private Transform _mouseColliderTransform;
        private GameObject _clickHereTextTemp;
        private float _clickedTime;
        private GameObject _clickHereText;
        private bool _isVisible;

        #endregion

        #region Unity

        private void Awake()
        {
            _clickValue = 1;
            _clickHereText = GetComponentInChildren<Text>().gameObject;

            _clickHereText.SetActive(false);
            _clickedTime = Time.time;

            _upgradePrice = 10;
            _upgradePriceText.text = _upgradePrice.ToString() + " Meat";

            _mouseColliderTransform = GetComponentInChildren<Collider2D>().gameObject.transform;
        }

        private void Update()
        {
            MouseCollider();
            ClickHere();
        }

        #endregion

        #region Methods

        private void MouseCollider()
        {
            _mouseColliderTransform.position = Input.mousePosition;
        }

        public void Click()
        {
            _resourcesManager.AddInStock("Meat", _clickValue);
            _spriteManager.SpriteInstantiate();

            _clickedTime = Time.time;
            _clickHereText.SetActive(false);
            _isVisible = false;

            Destroy(_clickHereTextTemp);
        }

        public void ClickUpgrade()
        {
            if (_resourcesManager.ResourcesStock["Meat"] >= _upgradePrice)
            {
                _clickValue += 1;
                _resourcesManager.RemoveInStock("Meat", _upgradePrice);

                _upgradePrice *= 2;
                _upgradePriceText.text = _upgradePrice.ToString() + " Meat";
            }
        }

        private void ClickHere()
        {
            if (Time.time - _clickedTime >= 5f && !_isVisible)
            {
                _clickHereText.SetActive(true);
                _isVisible = true;
            }
        }

        #endregion

        #region Utils

        #endregion

        #region Getter & Setters

        #endregion
    }
}

using UnityEngine;
using UnityEngine.UI;

namespace Scripts
{
    public class ResourcesManager : MonoBehaviour
    {
        #region Public

        [SerializeField]
        private Text _meatCounter;

        #endregion

        #region Private

        private int _meatStock;

        #endregion

        #region Unity

        private void Awake()
        {
            _meatStock = 0;
            RefreshMeatCounter();
        }

        #endregion

        #region Methods

        private void RefreshMeatCounter()
        {
            _meatCounter.text = _meatStock.ToString();
        }

        public void AddMeatInStock(int amount)
        {
            _meatStock += amount;
            RefreshMeatCounter();
        }

        public void RemoveMeatInStock(int amount)
        {
            if (_meatStock >= amount)
            {
                _meatStock -= amount;
                RefreshMeatCounter();
            }
        }

        #endregion

        #region Utils

        #endregion

        #region Getter & Setters

        public int MeatStock
        {
            get { return _meatStock; }
            private set { _meatStock = value; }
        }

        #endregion
    }
}

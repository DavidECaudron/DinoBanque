using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Scripts
{
    public class MeatGenerator : MonoBehaviour
    {
        #region Public

        [SerializeField] private Text _meatCounter;
        [SerializeField] private Button _meatHouse;

        #endregion

        #region Private

        private int _meatStock;
        private int _addMeat;
        private int _removeMeat;
        private int _upgradeMeatIteration;
        private int _meatHouseIteration;

        #endregion

        #region Unity

        private void Awake()
        {
            _meatStock = 0;
            _addMeat = 1;
            _removeMeat = 10;

            _upgradeMeatIteration = 1;
            _meatHouseIteration = 0;

            RefreshMeatCounter();
        }

        #endregion

        #region Methods

        private void RefreshMeatCounter()
        {
            _meatCounter.text = _meatStock.ToString();
        }

        public void GetMeat()
        {
            _meatStock += _addMeat;
            RefreshMeatCounter();
        }

        public void RemoveMeat(int iteration)
        {
            _meatStock -= _removeMeat * iteration;
            RefreshMeatCounter();
        }

        public void UpgradeGetMeat()
        {
            if (_meatStock >= _removeMeat * _upgradeMeatIteration)
            {
                _addMeat += 1;
                RemoveMeat(_upgradeMeatIteration);
                _upgradeMeatIteration += 1;
            }
        }

        public void GetMeatHouse()
        {
            if (_meatStock >= _removeMeat * _meatHouseIteration)
            {
                RemoveMeat(_meatHouseIteration);
                _meatHouseIteration += 1;
            }
        }

        #endregion

        #region Utils
        #endregion

        #region Getter & Setters

        public int MeatStock
        {
            get { return _meatStock; }
            set { _meatStock = value; }
        }

        public int AddMeat
        {
            get { return _addMeat; }
            private set { _addMeat = value; }
        }

        #endregion
    }
}

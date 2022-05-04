using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scripts
{
    public class MeatHouse : MonoBehaviour
    {
        #region Public

        [SerializeField]
        private MeatGenerator _meatGenerator;

        #endregion

        #region Private

        private float _time;

        #endregion

        #region Unity

        private void Awake()
        {
            _time = Time.time;
        }

        private void Update()
        {
            if (Time.time >= _time + 10.0f)
            {
                _meatGenerator.GetMeat();
                _time = Time.time;
            }
        }

        #endregion

        #region Methods
        #endregion

        #region Utils
        #endregion

        #region Getters & Setters
        #endregion
    }
}

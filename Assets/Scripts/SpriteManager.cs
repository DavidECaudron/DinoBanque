using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scripts
{
    public class SpriteManager : MonoBehaviour
    {
        #region Public

        [SerializeField]
        private List<GameObject> _listSprite = new List<GameObject>();

        #endregion
        #region Private

        private int _randomGen;

        #endregion
        #region Unity

        #endregion
        #region Methods

        public void SpriteInstantiate()
        {
            _randomGen = Random.Range(0, _listSprite.Count);

            GameObject temp = Instantiate(_listSprite[_randomGen], Input.mousePosition, Quaternion.identity, transform);

            float R1 = Random.Range(-360.0f, 360.0f);
            float R2 = Random.Range(-360.0f, 360.0f);

            temp.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(R1, R2), ForceMode2D.Impulse);
        }

        #endregion
        #region Utils
        #endregion
        #region Getters & Setters
        #endregion
    }
}

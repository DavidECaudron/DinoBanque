using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scripts
{
    public class SpriteManager : MonoBehaviour
    {
        #region Public

        [SerializeField] private List<GameObject> _listSprite = new List<GameObject>();
        [SerializeField] private GameObject _eggSprite;

        #endregion

        #region Private

        private int _randomGen;

        #endregion

        #region Unity

        private void Start()
        {
            StartCoroutine(EggCoroutine());
        }

        #endregion

        #region Methods

        public void SpriteInstantiate()
        {
            _randomGen = Random.Range(0, _listSprite.Count);

            GameObject temp = Instantiate(_listSprite[_randomGen], Input.mousePosition + new Vector3(0.0f, 50.0f, 0.0f), Quaternion.identity, transform);

            Destroy(temp, 10.0f);

            float randX = Random.Range(-360.0f, 360.0f);
            float randY = Random.Range(360.0f, 720.0f);

            temp.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(randX, randY), ForceMode2D.Impulse);
        }

        #endregion

        #region Utils

        private IEnumerator EggCoroutine()
        {
            while (true)
            {
                float randomSpawn = Random.Range(60.0f, 300.0f);
                yield return new WaitForSeconds(randomSpawn);

                float randX = Random.Range(50.0f, 575.0f);
                float randY = Random.Range(50.0f, 325.0f);

                GameObject temp = Instantiate(_eggSprite, new Vector3(randX, randY, 0.0f), Quaternion.identity, transform);

                if (temp != null)
                {
                    Destroy(temp, 5.0f);
                }
            }
        }

        #endregion

        #region Getters & Setters
        #endregion
    }
}

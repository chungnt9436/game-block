

using UnityEngine;

namespace GameVanilla.Core
{
    /// <summary>
    /// This class automatically returns the associated pooled object to its origin pool after a certain amount of
    /// time has passed.
    /// </summary>
    public class AutoKillPooled : MonoBehaviour
    {
        public float time = 2.0f;

        private PooledObject pooledObject;
        private float accTime;

        /// <summary>
        /// Unity's OnEnable method.
        /// </summary>
        private void OnEnable()
        {
            accTime = 0.0f;
        }

        /// <summary>
        /// Unity's Start method.
        /// </summary>
        private void Start()
        {
            pooledObject = GetComponent<PooledObject>();
        }

        /// <summary>
        /// Unity's Update method.
        /// </summary>
        private void Update()
        {
            accTime += Time.deltaTime;
            if (accTime >= time)
            {
                pooledObject.pool.ReturnObject(gameObject);
            }
        }
    }
}

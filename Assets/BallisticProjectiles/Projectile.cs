#region Includes
using UnityEngine;
#endregion

namespace TS.Examples.BallisticProjectiles
{
    [RequireComponent(typeof(Rigidbody))]
    public class Projectile : MonoBehaviour
    {
        #region Variables

        private Rigidbody _rigidbody;

        #endregion
        void Awake()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }

        private void OnCollisionEnter(Collision collision)
        {
            Destroy(gameObject);
        }

        public void Shoot(Vector3 direction, float power)
        {
            _rigidbody.AddForce(direction * power, ForceMode.Impulse);
        }
    }
}
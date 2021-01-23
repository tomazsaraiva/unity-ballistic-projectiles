#region Includes
using UnityEngine;
#endregion

namespace TS.Examples.BallisticProjectiles
{
    public class TankCannon : MonoBehaviour
    {
        #region Variables

        [Header("References")]
        [SerializeField] private Projectile _projectilePrefab;
        [SerializeField] private GameObject _shootOrigin;
        [SerializeField] private GameObject _shootTarget;

        [Header("Configuration")]
        [SerializeField] private float _shootPower;

        private TrajectoryData _trajectoryData;

        #endregion

        void Update()
        {
            _trajectoryData = TrajectoryHelper.GetTrajectory(_shootPower, -transform.rotation.eulerAngles.x, _shootOrigin.transform.position.y);

            Vector3 targetPosition = _shootOrigin.transform.position + (transform.parent.forward * _trajectoryData.Distance);
            _shootTarget.transform.position = new Vector3(targetPosition.x, 0, targetPosition.z);
        }

        public void Shoot()
        {
            Instantiate(_projectilePrefab, _shootOrigin.transform.position, transform.rotation).Shoot(transform.forward, _shootPower);
        }
    }

}
#region Includes
using UnityEngine;
#endregion

namespace TS.Examples.BallisticProjectiles
{
    public class Tank : MonoBehaviour
    {
        #region Variables

        [Header("References")]
        [SerializeField] private GameObject _turret;
        [SerializeField] private TankCannon _cannon;

        [Header("Configuration")]
        [SerializeField] private float _speedHorz;
        [SerializeField] private float _speedVert;

        #endregion

        void Update()
        {
            if (Input.GetKey(KeyCode.A))
            {
                _turret.transform.Rotate(Vector3.up * -_speedHorz * Time.deltaTime);
            }
            else if (Input.GetKey(KeyCode.D))
            {
                _turret.transform.Rotate(Vector3.up * _speedHorz * Time.deltaTime);
            }
            else if (Input.GetKey(KeyCode.W))
            {
                _cannon.transform.Rotate(Vector3.right * -_speedVert * Time.deltaTime);
            }
            else if (Input.GetKey(KeyCode.S))
            {
                _cannon.transform.Rotate(Vector3.right * _speedVert * Time.deltaTime);
            }
            else if (Input.GetKeyDown(KeyCode.Space))
            {
                _cannon.Shoot();
            }
        }
    }
}
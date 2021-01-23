#region Includes
using UnityEngine;
#endregion

namespace TS.Examples.BallisticProjectiles
{
    public static class TrajectoryHelper
    {
        public static TrajectoryData GetTrajectory(float velocity, float angle, float initialHeight)
        {
            angle *= Mathf.Deg2Rad;

            var gravity = Physics.gravity.magnitude;
            var vxo = velocity * Mathf.Cos(angle);
            var vyo = velocity * Mathf.Sin(angle);

            var t = vyo / gravity;

            var maxHeight = initialHeight + (vyo * t) - (0.5f * gravity * (t * t));
            var tfall = Mathf.Sqrt(2 * maxHeight / gravity);
            var totalTime = t + tfall;
            var range = vxo * totalTime;

            return new TrajectoryData(range, maxHeight, totalTime);
        }
    }
}

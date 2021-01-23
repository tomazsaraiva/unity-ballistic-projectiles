#region Includes
using System.Text;
#endregion

namespace TS.Examples.BallisticProjectiles
{
    public class TrajectoryData
    {
        #region Variables

        public float Distance { get; }
        public float Height { get; }
        public float Duration { get; }

        #endregion

        public TrajectoryData(float distance, float height, float duration)
        {
            Distance = distance;
            Height = height;
            Duration = duration;
        }
    }
}
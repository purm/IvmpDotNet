using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IvmpDotNet.SDK {
    /// <summary>
    /// Manages Area Calculations
    /// </summary>
    public interface IAreaManager {
        #region Methods

        /// <summary>
        /// Gets the distance between two 2D points.
        /// </summary>
        /// <param name="x">X1</param>
        /// <param name="y">Y1</param>
        /// <param name="xx">X2</param>
        /// <param name="yy">Y2</param>
        /// <returns>The distance between the inserted points</returns>
        Single DistanceBetween2d(Single x, Single y, Single xx, Single yy);

        /// <summary>
        /// Gets the distance between two 3D Points
        /// </summary>
        /// <param name="vec1">First Point</param>
        /// <param name="vec2">Second Point</param>
        /// <returns>The distance between the inserted points</returns>
        Single DistanceBetween3d(CVector3 vec1, CVector3 vec2);

        /// <summary>
        /// Checks if a point is in a circle.
        /// </summary>
        /// <param name="x">X coordinate of the point in the middle of the circle</param>
        /// <param name="y">Y coordinate of the point in the middle of the circle</param>
        /// <param name="xx">X coordinate of the point to check</param>
        /// <param name="yy">Y coordinate of the point to check</param>
        /// <param name="distance">The distance to check if the point is in the circle</param>
        /// <returns>True if the point is in the circle, false if not</returns>
        bool IsPointInCircle(Single x, Single y, Single xx, Single yy, Single distance);

        /// <summary>
        /// Checks if a point is in a tube.
        /// </summary>
        /// <param name="tubeCoords">The coordinates of the tube</param>
        /// <param name="tubeHeight">The height of the tube</param>
        /// <param name="tubeRadius">The radius of the tube</param>
        /// <param name="vec">The coordinates of the point to check</param>
        /// <returns>True if the point is in the tube, otherwise false</returns>
        bool IsPointInTube(CVector3 tubeCoords, Single tubeHeight, Single tubeRadius, CVector3 point);

        /// <summary>
        /// Checks if a point is in a ball.
        /// </summary>
        /// <param name="vec1">The ball coordinates</param>
        /// <param name="vec2">The point to check</param>
        /// <param name="distance">The ball radius</param>
        /// <returns>True if the point is in the ball, otherwise false</returns>
        bool IsPointInBall(CVector3 vec1, CVector3 vec2, Single distance);

        /// <summary>
        /// Checks if a point is in a area.
        /// </summary>
        /// <param name="areax">areaX</param>
        /// <param name="areay">areaY</param>
        /// <param name="areaxx">areaX2</param>
        /// <param name="areayy">areaY2</param>
        /// <param name="pointx">The X coordinate of the point to check</param>
        /// <param name="pointy"> The Y coordinate of the point to check</param>
        /// <returns>True if the point is in the area, otherwise false</returns>
        bool IsPointInArea(Single areax, Single areay, Single areaxx, Single areayy, Single pointx, Single pointy);

        /// <summary>
        /// Checks if a point is in a cuboid
        /// </summary>
        /// <param name="area1">First cuboid coordinates</param>
        /// <param name="area2">Second cuboid coordinates</param>
        /// <param name="point">Coordinates of the point to check</param>
        /// <returns>True if the point is in the area, otherwise false</returns>
        bool IsPointInCuboid(CVector3 area1, CVector3 area2, CVector3 point);

        #endregion
    }
}

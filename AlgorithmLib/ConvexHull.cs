using System.Collections;

namespace AlgorithmLib;

public static class ConvexHull
{
    private const double DoubleTolerance = 0.001;

    private const int COLINEAR = 0;
    private const int CONVEX = 1;
    private const int CONCAVE = 2; 

    public class Point
    {
        public double X;
        public double Y;

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public bool Equals(Point point)
        {
            return Math.Abs(X - point.X) < DoubleTolerance && 
                   Math.Abs(Y - point.Y) < DoubleTolerance;
        }
    }

    private static int Orientation(Point a, Point b, Point c)
    {
        // ADD CODE HERE AND FIX RETURN STATEMENT
        var cross_prod = (b.X - a.X) * (c.Y - b.Y) - (b.Y - a.Y) * (c.X - b.X);

        if (cross_prod == 0)
        {
            return COLINEAR; 
        }

        else if (cross_prod > 0)
        {
            return CONVEX;
        }

        else
        {
            return CONCAVE; 
        }
        
        return 0;
    }
    
    // If needed, you can create more private functions to be used by the 
    // GenerateHull function below.

    private static double getAngle(Point anchor, Point point)
    {
        return Math.Atan2(point.Y - anchor.Y, point.X - anchor.X);
    }

    private static double getDist(Point anchor, Point point)
    {
        return Math.Sqrt((Math.Pow(point.X - anchor.X, 2)) + Math.Pow(point.Y - anchor.Y, 2));
    }
    
    

    public static List<Point> GenerateHull(List<Point> points)
    {
        // ADD CODE HERE AND FIX RETURN STATEMENT
        if (points.Count < 3)
        {
            return new List<Point>();
        }

        Point anchor = points.OrderBy(point => point.Y).ThenBy(point => point.X).FirstOrDefault(); 
        
        var sorted = points.OrderBy(point => new { Angle = getAngle(anchor, point), Distance = getDist(anchor, point) }).ToList();
        
        var hull = new List<Point>() {sorted[0], sorted[1], sorted[2]};

        for (int i = 0; i < 3; i++)
        {
            while (Orientation(hull[-2], hull[-1], sorted[i]) != CONVEX)
            {   
                hull.RemoveAt(hull.Count - 1);
            }
            hull.Add(sorted[i]);
        }
        return hull;
    }
}
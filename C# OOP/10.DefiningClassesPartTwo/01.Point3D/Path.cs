using System;
using System.Collections.Generic;

public class Path
{
    public void AddPath(Point3D point)
    {
        seqOfPoints.Add(point);
    }
    private List<Point3D> seqOfPoints = new List<Point3D>();

    public IReadOnlyCollection<Point3D> SeqOfPoints
    {
        get { return seqOfPoints.AsReadOnly(); }
    }

}


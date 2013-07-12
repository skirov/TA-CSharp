using System;

public struct Point3D
{
    private int pointX;
    private int pointY;
    private int pointZ;

    #region properties and chained constructors

    public int X
    {
        get { return pointX; }
        set { this.pointX = value; }
    }

    public int Y
    {
        get { return pointY; }
        set { this.pointY = value; }
    }

    public int Z
    {
        get { return pointZ; }
        set { this.pointZ = value; }
    }

    public Point3D(int x, int y, int z)
        : this()
    {
        this.X = x;
        this.Y = y;
        this.Z = z;
    }

    private static readonly Point3D zero = new Point3D(0, 0, 0);

    public static Point3D ReturnZeroPoint
    {
        get { return zero; }
    }
    #endregion

    //Override ToString()
    public override string ToString()
    {
        return String.Format("{0:F2}, {1:F2}, {2:F2}", this.X, this.Y, this.Z);
    }

}


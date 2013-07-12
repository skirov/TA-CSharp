using System;

public class MainClass
{
    static void Main()
    {
        Path setPath = new Path();
        setPath.AddPath(new Point3D(3, 5, 6));
        setPath.AddPath(new Point3D(0, 0, 0));
        setPath.AddPath(new Point3D(0, 1, 514));

        PathStorage.SavePathsToFile(setPath.SeqOfPoints);

        PathStorage.ReadPathsFromFile();
    }
}

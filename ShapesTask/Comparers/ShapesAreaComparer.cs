﻿using ShapesTask.Shapes;

namespace ShapesTask.Comparers;

internal class ShapesAreaComparer : IComparer<IShape>
{
    public int Compare(IShape? shape1, IShape? shape2)
    {
        if (shape1 is null && shape2 is null)
        {
            return 0;
        }

        if (shape1 is null)
        {
            return -1;
        }

        if (shape2 is null)
        {
            return 1;
        }

        return shape1.GetArea().CompareTo(shape2.GetArea());
    }
}
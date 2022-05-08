using UnityEngine;
using DG.Tweening;
using System.Collections.Generic;

public class MovementSimpleCircle : TorusMovement
{
    Vector3[] pathArray;
    // Vector3[] path = new Vector3[63];
    public float R { get; set; } = 5;
    public float A { get; set; } = -5;

    public MovementSimpleCircle()
    {
        float x = A - R;
        List<Vector3> path = new List<Vector3>();
        path.Clear();
        path.Add(new Vector3(x, 0));

        for (float i = x; i < A + R; i += 0.5f)
        {
            float y = Mathf.Sqrt((R * R) - (i - A) * (i - A));
            path.Add(new Vector3(i, y));
        }

        for (float i = A + R; i >= x; i -= 0.5f)
        {
            float y = -Mathf.Sqrt((R * R) - (i - A) * (i - A));
            path.Add(new Vector3(i, y));
        }
        path.Add(new Vector3(x, 0));

        pathArray = path.ToArray();
    }

    public override void SetMovement(Transform transform)
    {
        transform.DOLocalPath(pathArray, Duration).SetEase(Ease.Linear).SetLoops(-1);
    }
}

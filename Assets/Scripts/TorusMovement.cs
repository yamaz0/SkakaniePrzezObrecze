using DG.Tweening;
using UnityEngine;

public abstract class TorusMovement
{
    public float Duration { get; set; } = 2;

    public abstract void SetMovement(Transform transform);
    public virtual void Kill(Transform transform)
    {
        transform.DOKill();
    }

}

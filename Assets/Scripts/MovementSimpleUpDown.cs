using UnityEngine;
using DG.Tweening;

public class MovementSimpleUpDown : TorusMovement
{
    public override void SetMovement(Transform transform)
    {
        transform.DOLocalMove(new Vector3(0, -5, 0), Duration).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo);
    }
}

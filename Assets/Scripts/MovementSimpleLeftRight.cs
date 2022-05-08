using UnityEngine;
using DG.Tweening;

public class MovementSimpleLeftRight : TorusMovement
{
    public override void SetMovement(Transform transform)
    {
        transform.DOLocalMove(new Vector3(5, 0, 0), Duration).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo);
    }
}

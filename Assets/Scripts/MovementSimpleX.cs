using UnityEngine;
using DG.Tweening;

public class MovementSimpleX : TorusMovement
{
    Sequence sx = DOTween.Sequence();

    public override void Kill(Transform transform)
    {
        base.Kill(transform);
        sx.Kill();
    }

    public override void SetMovement(Transform transform)
    {
        float x = 4;
        float y = 4;

        sx.Append(transform.DOLocalMove(new Vector3(x, y, 0), Duration).SetEase(Ease.InOutSine));
        sx.Append(transform.DOLocalMove(new Vector3(x, -y, 0), Duration).SetEase(Ease.InOutSine));
        sx.Append(transform.DOLocalMove(new Vector3(-x, y, 0), Duration).SetEase(Ease.InOutSine));
        sx.Append(transform.DOLocalMove(new Vector3(-x, -y, 0), Duration).SetEase(Ease.InOutSine));
        sx.SetLoops(-1, LoopType.Yoyo);
    }

    public override string ToString()
    {
        return base.ToString();
    }
}

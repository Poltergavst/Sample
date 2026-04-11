using DG.Tweening;
using UnityEngine;

public class RotationTweener : BaseTweener
{
    [SerializeField] private Vector3 _degrees;

    protected override void MakeTween()
    {
        transform.DORotate(_degrees, Duration, RotateMode.FastBeyond360).SetEase(Ease).SetLoops(-1, LoopType.Incremental);
    }
}

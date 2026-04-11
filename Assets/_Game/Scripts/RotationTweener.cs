using DG.Tweening;
using UnityEngine;

public class RotationTweener : BaseTweener
{
    [SerializeField] private Vector3 _degrees;

    protected override Tween MakeTween()
    {
        return transform.DORotate(_degrees, Duration, RotateMode.FastBeyond360).SetLoops(-1, LoopType.Incremental);
    }
}

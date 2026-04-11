using UnityEngine;
using DG.Tweening;

public class ScaleTweener : BaseTweener
{
    [SerializeField] private Vector3 _targetSize;

    protected override Tween MakeTween()
    {
        return transform.DOScale(_targetSize, Duration).SetLoops(-1, LoopType.Yoyo);
    }
}

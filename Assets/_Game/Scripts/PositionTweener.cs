using UnityEngine;
using DG.Tweening;

public class PositionTweener : BaseTweener
{
    [SerializeField] private Vector3 _distance;

    protected override void MakeTween()
    {
        transform.DOMove(_distance, Duration).SetRelative().SetEase(Ease).SetLoops(-1, LoopType.Yoyo);
    }
}

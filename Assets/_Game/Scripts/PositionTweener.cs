using UnityEngine;
using DG.Tweening;

public class PositionTweener : BaseTweener
{
    [SerializeField] private Vector3 _distance;

    protected override Tween MakeTween()
    {
        return transform.DOMove(_distance, Duration).SetRelative().SetLoops(-1, LoopType.Yoyo);
    }
}

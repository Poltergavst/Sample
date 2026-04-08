using UnityEngine;
using DG.Tweening;

public class TransformTweener : BaseTweener
{
    [SerializeField] private Vector3 _distance;
    [SerializeField] private Vector3 _degrees;
    [SerializeField] private Vector3 _targetSize;

    protected override void MakeTween()
    {
        Sequence sequence = DOTween.Sequence();

        sequence.Append(transform.DOMove(_distance, Duration).SetEase(Ease.Linear).SetRelative());
        sequence.SetLoops(-1, LoopType.Restart);
    }
}

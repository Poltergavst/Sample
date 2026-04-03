// Transformer.cs
using UnityEngine;
using DG.Tweening;

[ExecuteAlways]
public class Transformer : MonoBehaviour
{
    [SerializeField] private float duration = 1.5f;
    [SerializeField] private float distance = 1f;
    [SerializeField] private Vector3 degrees = Vector3.zero;
    [SerializeField] private Vector3 scale = Vector3.one;

    private Vector3 _startPosition;
    private Vector3 _startScale;
    private Vector3 _startRotation;

    public (Tween, Tween, Tween) CreateTweens()
    {
        _startPosition = transform.position;
        _startScale = transform.localScale;
        _startRotation = transform.eulerAngles;

        Tween t1 = transform.DOMoveX(_startPosition.x + distance, duration)
            .SetEase(Ease.Linear)
            .SetLoops(-1, LoopType.Yoyo);

        Tween t2 = transform.DOScale(scale, duration)
            .SetEase(Ease.Linear)
            .SetLoops(-1, LoopType.Yoyo);

        Tween t3 = transform.DORotate(degrees, duration)
            .SetEase(Ease.Linear)
            .SetLoops(-1, LoopType.Incremental);

        return (t1, t2, t3);
    }

    public (Tween, Tween, Tween) CreateTweensFromCurrent()
    {
        Vector3 current = transform.position;

        Tween t1 = transform.DOMoveX(current.x + distance, duration)
            .SetEase(Ease.Linear)
            .SetLoops(-1, LoopType.Yoyo);

        Tween t2 = transform.DOScale(scale, duration)
            .SetEase(Ease.Linear)
            .SetLoops(-1, LoopType.Yoyo);

        Tween t3 = transform.DORotate(degrees, duration)
            .SetEase(Ease.Linear)
            .SetLoops(-1, LoopType.Incremental);

        return (t1, t2, t3);
    }

    public void ResetToStart()
    {
        transform.position = _startPosition;
        transform.localScale = _startScale;
        transform.eulerAngles = _startRotation;
    }
}
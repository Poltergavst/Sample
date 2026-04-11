using DG.Tweening;
using UnityEngine;

public abstract class BaseTweener : MonoBehaviour
{
    [SerializeField] protected float Duration;
    [SerializeField] protected Ease Ease;

    protected virtual void Start()
    {
        if (Ease == Ease.Unset)
        {
            Ease = Ease.Linear;
        }

        MakeTween().SetEase(Ease);
    }

    protected abstract Tween MakeTween();
}

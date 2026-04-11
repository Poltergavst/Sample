using UnityEngine;
using DG.Tweening;

[RequireComponent(typeof(Renderer))]
public class ColorTweener : BaseTweener
{
    [SerializeField] private Color _color;
    
    private Material _material;

    protected override void Start()
    {
        _material = GetComponent<Renderer>().material;
        base.Start();
    }

    protected override void MakeTween()
    {
        _material.DOColor(_color, Duration).SetEase(Ease).SetLoops(-1, LoopType.Yoyo);
    }
}

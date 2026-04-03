using UnityEngine;
using DG.Tweening;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _duration;
    [SerializeField] private float _distance;
     
    private void Start()
    {
        transform
            .DOMoveZ(_distance, _duration)
            .SetRelative()
            .SetEase(Ease.Linear)
            .SetLoops(-1, LoopType.Yoyo);
    }
}

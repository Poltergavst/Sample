using UnityEngine;
using DG.Tweening;

public class Rotator : MonoBehaviour
{
    [SerializeField] private float _duration;
    [SerializeField] private float _distance;

    private void Start()
    {
        transform.DORotate(new Vector3(0, _distance, 0), _duration)
            .SetRelative()
            .SetEase(Ease.Linear)
            .SetLoops(-1, LoopType.Incremental);
    }
}

using UnityEngine;
using DG.Tweening;

public class Scaler : MonoBehaviour
{
    [SerializeField] private float _duration;
    [SerializeField] private float _distance;

    private void Start()
    {
        transform.DOScale(new Vector3(_distance, _distance, _distance), _duration)
            .SetRelative()
            .SetEase(Ease.Linear)
            .SetLoops(-1, LoopType.Yoyo);
    }
}

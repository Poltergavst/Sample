using UnityEngine;

public abstract class BaseTweener : MonoBehaviour
{
    [SerializeField] protected float Duration;

    protected virtual void Start()
    {
        MakeTween();
    }

    protected abstract void MakeTween();
}

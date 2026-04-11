using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent (typeof(Text))]

public class TextTweener : BaseTweener
{
    private Text _text;

    protected override void Start()
    {
        _text = GetComponent<Text>();

        base.Start();
    }

    protected override void MakeTween()
    {
        Sequence sequence = DOTween.Sequence();

        sequence.Append(_text.DOText("Dovahkiin, Dovahkiin\n", Duration).SetEase(Ease));
        sequence.Append(_text.DOText("Naal ok zin los vahriin", Duration).SetRelative().SetEase(Ease));
        sequence.Append(_text.DOText("Wah dein vokul mahfaeraak ahst vaal!", Duration, true, ScrambleMode.All).SetEase(Ease));
        sequence.Join(_text.DOColor(Color.teal, Duration * 0.5f).SetEase(Ease));
        sequence.Join(_text.DOFade(0, Duration));

        sequence.SetLoops(-1, LoopType.Restart);
    }
}

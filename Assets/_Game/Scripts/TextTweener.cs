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

    protected override Tween MakeTween()
    {
        Sequence sequence = DOTween.Sequence();

        sequence.Append(_text.DOText("Dovahkiin, Dovahkiin\n", Duration));
        sequence.Append(_text.DOText("Naal ok zin los vahriin", Duration).SetRelative());
        sequence.Append(_text.DOText("Wah dein vokul mahfaeraak ahst vaal!", Duration, true, ScrambleMode.All));
        sequence.Join(_text.DOColor(Color.teal, Duration * 0.5f));
        sequence.Join(_text.DOFade(0, Duration));

        sequence.SetLoops(-1, LoopType.Restart);

        return sequence;
    }
}

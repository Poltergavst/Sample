// Editor/TransformerEditorPreview.cs
#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;
using DG.Tweening;
using DG.DOTweenEditor;

[CustomEditor(typeof(Transformer))]
public class TransformerEditorPreview : Editor
{
    private Tween _t1, _t2, _t3;
    private bool _isPlaying;

    private void StartPreview(Transformer t)
    {
        (_t1, _t2, _t3) = t.CreateTweens();
        DOTweenEditorPreview.PrepareTweenForPreview(_t1);
        DOTweenEditorPreview.PrepareTweenForPreview(_t2);
        DOTweenEditorPreview.PrepareTweenForPreview(_t3);
        DOTweenEditorPreview.Start();
        _isPlaying = true;
    }

    private void RestartPreviewInPlace(Transformer t)
    {
        DOTweenEditorPreview.Stop(true); // false = не перематывать в начало
        _t1?.Kill();
        _t2?.Kill();
        _t3?.Kill();

        (_t1, _t2, _t3) = t.CreateTweensFromCurrent();
        DOTweenEditorPreview.PrepareTweenForPreview(_t1);
        DOTweenEditorPreview.PrepareTweenForPreview(_t2);
        DOTweenEditorPreview.PrepareTweenForPreview(_t3);
        DOTweenEditorPreview.Start();
        _isPlaying = true;
    }

    public override void OnInspectorGUI()
    {
        Transformer t = (Transformer)target;

        EditorGUI.BeginChangeCheck();
        DrawDefaultInspector();

        if (EditorGUI.EndChangeCheck() && _isPlaying)
            RestartPreviewInPlace(t);

        EditorGUILayout.Space();

        if (GUILayout.Button(_isPlaying ? "■ Stop" : "▶ Preview"))
        {
            if (_isPlaying) StopPreview(t);
            else StartPreview(t);
        }
    }

    private void StopPreview(Transformer t)
    {
        DOTweenEditorPreview.Stop(true);
        _t1?.Kill();
        _t2?.Kill();
        _t3?.Kill();

        t.ResetToStart();

        _isPlaying = false;
    }

    private void OnDisable()
    {
        StopPreview((Transformer)target);
    }
}
#endif
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ChangeColor : MonoBehaviour
{
    private SpriteRenderer _spriteRenderer;

    void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _spriteRenderer.DOColor(Color.red, 2).SetLoops(-1, LoopType.Yoyo);
        _spriteRenderer.DOFade(0, 0.5f).SetLoops(-1, LoopType.Yoyo);
    }
}
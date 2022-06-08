using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteController : MonoBehaviour
{
    private SpriteRenderer _spriteRenderer;
    private AddMovementInputController _addMovementInputController;

    private void Awake()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _addMovementInputController = GetComponent<AddMovementInputController>();
    }

    public bool FlipSpriteX =>  _addMovementInputController.Direction.x < 0f ? true : _addMovementInputController.Direction.x > 0f ? false : _spriteRenderer.flipX;
}

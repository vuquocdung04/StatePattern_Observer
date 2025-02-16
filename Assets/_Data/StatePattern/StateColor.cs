using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateColor : StateBase
{
    [SerializeField] protected Color color;
    [SerializeField] protected SpriteRenderer _spriteRenderer;
    public override void _Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        Debug.LogError("State Color");
        _spriteRenderer.color = Color.white;
        this.transform.localScale = Vector3.one;


    }

    public override void _Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            _spriteRenderer.color = Color.red;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            _spriteRenderer.color = Color.green;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            _spriteRenderer.color = Color.blue;
        }
    }
}

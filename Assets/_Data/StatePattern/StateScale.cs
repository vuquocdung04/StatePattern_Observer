using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateScale : StateBase
{
    [SerializeField] protected SpriteRenderer _spriteRenderer;

    public override void _Start()
    {
        Debug.LogError("State Scale");
        this.transform.localScale = Vector3.one;
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _spriteRenderer.color = Color.white;


    }

    public override void _Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            this.transform.localScale = new Vector3(2, 2, 2);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            this.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            this.transform.localScale = new Vector3(1, 3, 1);
        }
    }
}

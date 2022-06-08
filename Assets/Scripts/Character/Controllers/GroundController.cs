using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundController : MonoBehaviour
{
    private Rigidbody2D rigidbody2D;
    [SerializeField]
    private ContactFilter2D _groundFilter;
    Collider2D _col2D;
    private bool _isGrounding;

    private void Awake()
    {
        _col2D = GetComponent<Collider2D>();
    }

    private void FixedUpdate()
    {
        
    }

    public bool isGrounding => _isGrounding;

    private bool Contact => Physics2D.IsTouching(_col2D, _groundFilter);

}

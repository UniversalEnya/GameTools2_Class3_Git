using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class character : MonoBehaviour
{
    private Animator m_animator;
    
    void Start()
    {
        m_animator = GetComponent<Animator>();
    }

    public void Move(float turn, float forward)
    {
        m_animator.SetFloat("Turn", turn);
        m_animator.SetFloat("Forward", forward);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserControl : MonoBehaviour
{

    private float m_turn;
    private float m_forward;
    private bool m_jump;

    private character m_character;

    private void Start()
    {
        m_character = GetComponent<character>();
    }
    // Update is called once per frame
    void Update()
    {
        m_turn = Input.GetAxis("Horizontal");
        m_forward = Input.GetAxis("Vertical");
        m_jump = Input.GetButtonDown("Jump");
        m_character.Move(m_turn, m_forward, m_jump);
    }
}

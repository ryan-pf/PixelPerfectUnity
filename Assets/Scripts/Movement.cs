using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Camera m_Camera = null;
    Vector3 m_StartPosition = Vector3.zero;
    float m_StartZoom = 0.0f;

    [SerializeField] float m_ZoomScaling = 0.05f;
    [SerializeField] float m_MoveSpeed = 1.0f;
    [SerializeField] float m_MoveScale = 0.3f;
    [SerializeField] bool m_DoZoom = true;
    [SerializeField] bool m_DoMovement = true;

    // Start is called before the first frame update
    void Start()
    {
        m_Camera = GetComponent<Camera>();
        m_StartPosition = transform.position;
        m_StartZoom = m_Camera.orthographicSize;
    }

    // Update is called once per frame
    void Update()
    {
        if (m_DoZoom)
            m_Camera.orthographicSize = m_StartZoom + Mathf.Sin(Time.time) * m_ZoomScaling;

        if (m_DoMovement)
            transform.position = m_StartPosition + Mathf.Sin(Time.time * m_MoveSpeed) * Vector3.right * m_MoveScale + Mathf.Cos(Time.time * m_MoveSpeed) * Vector3.up * m_MoveScale;
    }
}

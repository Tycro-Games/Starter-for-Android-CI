using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task : MonoBehaviour
{
    private Card task;
    private Rigidbody2D rb;
    private bool touchOnIt = false;
    private Vector2 posOfTouch;

    public Card Task1
    {
        get => task;
    }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    public void SetName(string name)
    {
        task.name = name;
    }
    public void SetPriority(string points)
    {
        task.points = Convert.ToInt32(points);
    }
    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            Vector2 touchPos = Input.GetTouch(0).position;
            posOfTouch = Camera.main.ScreenToWorldPoint(new Vector3(touchPos.x, touchPos.y, 0.0f));
            touchOnIt = rb.OverlapPoint(posOfTouch);

        }
    }

    void FixedUpdate()
    {
        if (Input.touchCount > 0 && touchOnIt)
        {
            Vector2 touchPos = Input.GetTouch(0).position;
            posOfTouch = Camera.main.ScreenToWorldPoint(new Vector3(touchPos.x, touchPos.y, 0.0f));
            rb.MovePosition(posOfTouch);

        }
    }


}

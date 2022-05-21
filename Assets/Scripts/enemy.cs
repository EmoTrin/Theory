using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    private int points = 10;

    protected int speed = 2;

    // ENCAPSULATION
    public int Points
    {
        get => points;
        set => points = value;
    }

    // Start is called before the first frame update
    void Start()
    {
        SetPoints(10);
    }

    protected void SetPoints(int points)
    {
        Points = points;
    }

    private void FixedUpdate()
    {
        Move();
    }

    protected virtual void Move()
    {
        transform.Translate(Vector3.forward * speed * Time.fixedDeltaTime);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            FindObjectOfType<Score>().ChangeScore(Points);
            Destroy(gameObject);
        }
    }
}


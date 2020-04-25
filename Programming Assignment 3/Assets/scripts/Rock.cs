using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : MonoBehaviour {

    Vector3 p1;
    Vector3 p2;

    // Use this for initialization
    void Start()
    {
        // apply impulse force to get game object moving
        const float MinImpulseForce = 1f;
        const float MaxImpulseForce = 2f;
        float angle = Random.Range(0, 2 * Mathf.PI);
        Vector2 direction = new Vector2(
            Mathf.Cos(angle), Mathf.Sin(angle));
        float magnitude = Random.Range(MinImpulseForce, MaxImpulseForce);
        GetComponent<Rigidbody2D>().AddForce(
            direction * magnitude,
            ForceMode2D.Impulse);
        // find points of camera
        p1 = Camera.main.ScreenToWorldPoint(new Vector3(0, Camera.main.pixelHeight, 0));
        p2 = Camera.main.ScreenToWorldPoint(new Vector3(Camera.main.pixelWidth, 0, 0));
    }

    void Update()
    {
        // destroy objects if it moves out of screen 
        if (gameObject.transform.position.y < p2.y ||
            gameObject.transform.position.y > p1.y ||
            gameObject.transform.position.x > p2.x ||
            gameObject.transform.position.x < p1.x)
            Destroy(gameObject);
    }
}

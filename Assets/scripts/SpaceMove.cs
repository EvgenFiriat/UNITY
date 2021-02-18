using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceMove : MonoBehaviour
{
    public float speed = 4f;
    public GameObject space;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);

        if (transform.position.y < -8.12f)
        {
            Instantiate(space, new Vector2(0, 10.5f), Quaternion.identity);
            Destroy(gameObject);
        }
    }
}

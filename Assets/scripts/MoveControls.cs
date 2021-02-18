using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveControls : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Stationary)
            {
                if (touch.position.x < Screen.width / 2 && transform.position.x > -1.75f)
                    transform.position = new Vector2(transform.position.x - 0.1f, transform.position.y);

                if (touch.position.x > Screen.width / 2 && transform.position.x < 1.75f)
                    transform.position = new Vector2(transform.position.x + 0.1f, transform.position.y);
            }
        }
    }
}

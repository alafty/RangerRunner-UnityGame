using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaneSwitch : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {

        if ((Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.RightArrow)) && gameObject.transform.position.x <= 0)
        {
            gameObject.transform.position += new Vector3(3.33f, 0, 0);
        }
        if((Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.LeftArrow)) && gameObject.transform.position.x >= 0)
        {
            gameObject.transform.position -= new Vector3(3.33f, 0, 0);

        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForwardForce : MonoBehaviour
{
    public static int movingSpeed;
    // Start is called before the first frame update
    void Start()
    {
        movingSpeed = SetMovingSpeed();
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, movingSpeed * Time.deltaTime);

    }

    public static int SetMovingSpeed()
    {
        int speed = SceneSwitch.difficulty == Difficulty.easy ? 1200 :
            SceneSwitch.difficulty == Difficulty.medium ? 3000 :
            SceneSwitch.difficulty == Difficulty.hard ? 4500 : movingSpeed = 0;
        return speed;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goalControl : MonoBehaviour
{   
    public float GOAL_MIN = 5.0f;
    public float GOAL_MAX = 10.0f;

    private bool isCollided = false;
    // Start is called before the first frame update
    void Start()
    {
        float rnd = Random.Range(GOAL_MIN, GOAL_MAX);
        this.transform.position = new Vector3(rnd, -1.0f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //다른 오브젝트와 충돌하는 동안 계속 호출
    void onCollisionStay(Collision other) {
        this.isCollided = true;
    }

    private void OnGUI() {
        if(isCollided) {
            GUI.Label(new Rect(Screen.width /2, 80, 100, 20), "성공");
        }
    }
}

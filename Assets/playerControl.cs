using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerControl : MonoBehaviour
{
    private float power;
    public float POWERPLUS = 100.0f;

    private Rigidbody myRigid;
    // Start is called before the first frame update
    void Start()
    {
        myRigid = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetMouseButton(0)) {               //왼쪽 버튼이 눌린 동안
            power += POWERPLUS * Time.deltaTime;    //힘을 모은다
        }

        if(Input.GetMouseButtonUp(0)) {
            //축적된 힘을 x와 y에 반영하여 오른쪽 위로 점프
            myRigid.AddForce(new Vector3(power, power, 0));
            power = 0.0f;
        }

        if(this.transform.position.y < -5.0f) {
            SceneManager.LoadScene("GameScene");
        }
    }
}

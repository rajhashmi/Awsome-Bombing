using UnityEngine;

public class PlayerScript: MonoBehaviour
{
    public float speed = 10f;
    void Start(){

    }

    void Update(){;
        MovePlayer();
    }
    void MovePlayer(){
        float h = Input.GetAxis("Horizontal");
        Vector2 temp = transform.position;

        if(h > 0){
            temp.x += speed * Time.deltaTime;
        }else if(h < 0){
             temp.x -= speed * Time.deltaTime;
        }
    }
}

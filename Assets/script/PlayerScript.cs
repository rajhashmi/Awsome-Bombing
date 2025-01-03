using UnityEngine;

public class PlayerScript: MonoBehaviour
{
    public float speed = 10f;
    private float minX = -2.55f;
    private float maxX = 2.55f;
    void Start(){

    }

    void Update(){;
        MovePlayer();
    }
    void MovePlayer(){
        float h = Input.GetAxis("Horizontal");
        Vector2 temp = transform.position;

        if(h > 0 && temp.x < maxX){
            temp.x += speed * Time.deltaTime;
        }else if(h < 0 && temp.x > minX){
             temp.x -= speed * Time.deltaTime;
        }
        transform.position = temp;
    }
    void OnTriggerEnter2D(Collider2D target){
        if(target.tag == "Bomb"){
            Time.timeScale = 0f;
        }
    }   
}

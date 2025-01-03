using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TMPro;
public class CollectorScript : MonoBehaviour
{
    public TMP_Text scoreText;
    private int score;

    void IncreaseScore(){
        score++;
        scoreText.text = "Score: " + score;
    }
     void OnTriggerEnter2D(Collider2D target){
        if(target.tag == "Bomb"){
            IncreaseScore();
            target.gameObject.SetActive(false);
        }
     }
}

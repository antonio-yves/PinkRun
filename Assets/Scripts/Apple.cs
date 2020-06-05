using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{
    private SpriteRenderer spriter;
    private CircleCollider2D circle;
    public GameObject collected;
    public int score;
    // Start is called before the first frame update
    void Start()
    {
        spriter = GetComponent<SpriteRenderer>();
        circle = GetComponent<CircleCollider2D>();
    }

    void OnTriggerEnter2D(Collider2D collider){
        if (collider.gameObject.tag == "Player"){
            spriter.enabled = false;
            circle.enabled = false;
            collected.SetActive(true);
            GameController.instance.totalScore += score;
            GameController.instance.UpdateScoreUI();
            Destroy(gameObject, 0.5f);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Obstacle : MonoBehaviour
{
    [SerializeField]
    private float ObstacleSpeed = 3f;
    Vector3 direction;
    public Vector3 Direction { set { direction = value; } }
    
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, transform.position + direction, ObstacleSpeed * Time.deltaTime);

        Destroy(gameObject, 5f);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Bullet")
        {
            Destroy(gameObject);

            Score score = FindObjectOfType<Score>();
            score.ScoreValue();
        }
        if (collision.tag == "Player")
        {
            SceneManager.LoadScene(0, LoadSceneMode.Single);
        }
    }
}

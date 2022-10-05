using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectPoints : MonoBehaviour
{
    private Rigidbody rb;
    private int playerScore = 0;
    public Text ScoreValue;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        ScoreValue.text = playerScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (this.CompareTag("Player") && collision.collider.CompareTag("Coin"))
        {
            Destroy(collision.gameObject);
            playerScore += 10;
            ScoreValue.text = playerScore.ToString();
        }
    }
}

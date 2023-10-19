using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour
{
    [SerializeField] private Candy _candy;
    public int _playerScore;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision");
        if (collision.transform.tag == "Player")
        {
           
            Destroy(gameObject);
            _playerScore = _playerScore + _candy._candyValue[_candy._candyRNG];
        }
        
    }


}

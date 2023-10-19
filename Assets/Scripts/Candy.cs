using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Candy : MonoBehaviour
{
    [SerializeField] GameObject[] _candy;
    [SerializeField] public int[] _candyValue;
    private GameObject _candyToSpawn;
    int _waitTime;
    float _timer = 0.0f;
    public int _candyRNG;
    int _candyPosRNG;
    int i;

    // Start is called before the first frame update
    void Start()
    {
        _waitTime = Random.Range(1, 4);
    }

    // Update is called once per frame
    void Update()
    {
        if ( i != 15)
        { 
            //timer
            _timer += Time.deltaTime;

            if (_timer > _waitTime)
            {
                _timer = _timer - _waitTime;
                _candyToSpawn = _candy[CandyRNG()];
                SpawnCandy();
                _waitTime = Random.Range(1, 4);
                i = i + 1;
            }

        }
        else
        {
            //end game
        }

    }

    int CandyRNG()
    {
        _candyRNG = Random.Range(0, 5);
        return _candyRNG;
    }

    int CandyPosRNG()
    {
        _candyPosRNG = Random.Range(-7, 7);
        return _candyPosRNG;
    }

    void SpawnCandy()
    {
        CandyPosRNG();
        GameObject _spawnedCandy = Instantiate(_candyToSpawn);
        _spawnedCandy.transform.SetPositionAndRotation(new Vector3(_candyPosRNG, 5, 0), new Quaternion(0, 0, 0, 0));
    }
}

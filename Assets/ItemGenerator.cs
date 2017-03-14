using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour
{
    //
    public GameObject carPrefab;
    //
    public GameObject coinPrefab;
    //
    public GameObject conePrefab;
    //
    private int startPos = -160;
    //
    private int goalPos = 120;
    //
    private float posRange = 3.4f;

    // Use this for initialization
    void Start()
    {
        
        }
    




    /// <summary>
    /// 
    /// </summary>
    private float _timeConter = 0;
    /// <summary>
    /// 
    /// </summary>
    private float _intervalTime = 2f;
    // Update is called once per frame
    void Update()
    {
        //60フレームでゲームが動いていた場合は 1/60秒が加算される
        _timeConter += Time.deltaTime;

        //３秒たったら
        if (_timeConter >= _intervalTime)
        {
            ItemCreate();
            _timeConter = 0;
        }
    }
    void ItemCreate()
    {
        int num = Random.Range(0, 10);
        if (num <= 1)
        {
            //
            for (float j = -1; j <= 1; j += 0.4f)
            {
                GameObject cone = Instantiate(conePrefab) as GameObject;
                cone.transform.position = new Vector3(4 * j, cone.transform.position.y, transform.position.z);
            }
        }
        else
        {

            //
            for (int j = -1; j < 2; j++)
            {
                //
                int item = Random.Range(1, 11);
                //
                int offsetZ = Random.Range(-5, 6);
                //
                if (j <= item && item <= 6)
                {
                    //
                    GameObject coin = Instantiate(coinPrefab) as GameObject;
                    coin.transform.position = new Vector3(posRange * j, coin.transform.position.y, transform.position.z +offsetZ );
                }
                else if (7 <= item && item <= 9)
                {
                    //
                    GameObject car = Instantiate(carPrefab) as GameObject;
                    car.transform.position = new Vector3(posRange * j, car.transform.position.y, transform.position.z + offsetZ);
                }
            }
        }
    }
}


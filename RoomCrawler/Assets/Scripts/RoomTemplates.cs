using System.Collections;
using System.Collections.Generic;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomTemplates : MonoBehaviour
{

    public GameObject[] bottomRooms;
    public GameObject[] topRooms;
    public GameObject[] leftRooms;
    public GameObject[] rightRooms;

    public GameObject closedRoom;

    public List<GameObject> rooms;

    public float waitTime;
    private bool spawnedBoss;
    private bool spawnedTreasure;
    public GameObject treasure;
    public GameObject boss;

    void Update()
    {

        if (waitTime <= 0 && spawnedBoss == false)
        {
            for (int i = 0; i < rooms.Count; i++)
            {
                if (i == rooms.Count - 1)
                {
                    Instantiate(boss, rooms[i].transform.position, Quaternion.identity);
                    spawnedBoss = true;
                }
            }
        }
        else
        {
            waitTime -= Time.deltaTime;
        }


        if (waitTime <= 0 && spawnedTreasure == false)
        {
            for (int i = 0;i < rooms.Count;i++)
            {
                if (i == rooms.Count - 2)
                {
                    Instantiate(treasure, rooms[i].transform.position, Quaternion.identity);
                    spawnedTreasure = true;
                }
            }
        } else
        {
            waitTime -= Time.deltaTime;
        }
    }
}


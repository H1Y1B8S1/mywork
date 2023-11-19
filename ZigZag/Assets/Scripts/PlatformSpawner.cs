using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    public GameObject platform;
    public GameObject diamond;
    Vector3 lastPos;
    float size;
    public bool gameOver;


    void Start()
    {
        lastPos = platform.transform.position;
        size = platform.transform.localScale.x;

        for (int i = 0; i < 20; i++)
        {
            SpawnPlatform();
        }

    }

    void Update()
    {
        if(GameManager.instance.gameOver == true)
        {
            CancelInvoke("SpawnPlatform");
        }
    }


    void SpawnPlatform()
    {
        int rand = Random.Range(0, 6);
        
        if (rand < 3)
        {
            SpawnX();
        }
        else if (rand > 3)
        {
            SpawnZ();
        }
        else
        {
            SpawnX();
            SpawnZ();
        }
    }

    /*void SpawnPlatform()
    {
        for(int i = 0;i < 20;i++)
        {
            SpawnX();

        }

        for (int i = 0;i<20 ;i++) {
            SpawnZ();

        }for(int i = 0;i < 20;i++)
        {
            SpawnXm();

        }

        for (int i = 0;i<20 ;i++) {
            SpawnZm();

        }
    }*/




    void SpawnX()
    {
        Vector3 pos = lastPos;
        pos.x += size;
        Instantiate(platform,pos,Quaternion.identity);
        
        lastPos = pos;

        int rand = Random.Range(0, 4);
        
        if (rand < 1) { 
            Instantiate(diamond,new Vector3(pos.x,pos.y+1f,pos.z), diamond.transform.rotation);
        }

    }

    void SpawnZ()
    {
        Vector3 pos = lastPos;
        pos.z += size;
        Instantiate(platform, pos, Quaternion.identity);

        lastPos = pos;

        int rand = Random.Range(0, 4);
        
        if (rand < 1)
        {
            Instantiate(diamond, new Vector3(pos.x, pos.y + 1f, pos.z), diamond.transform.rotation);
        }
    }void SpawnXm()
    {
        Vector3 pos = lastPos;
        pos.x -= size;
        Instantiate(platform,pos,Quaternion.identity);
        
        lastPos = pos;

        int rand = Random.Range(0, 4);
        
        if (rand < 1) { 
            Instantiate(diamond,new Vector3(pos.x,pos.y+1f,pos.z), diamond.transform.rotation);
        }

    }

    void SpawnZm()
    {
        Vector3 pos = lastPos;
        pos.z -= size;
        Instantiate(platform, pos, Quaternion.identity);

        lastPos = pos;

        int rand = Random.Range(0, 4);
        
        if (rand < 1)
        {
            Instantiate(diamond, new Vector3(pos.x, pos.y + 1f, pos.z), diamond.transform.rotation);
        }
    }


   

    public void StartSpawningPlatforms()
    {
        InvokeRepeating("SpawnPlatform", 1f, 0.3f);

    }
}

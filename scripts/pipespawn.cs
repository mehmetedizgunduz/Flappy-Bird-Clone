using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipespawn : MonoBehaviour
{
    public float spawntime = 2;
    private float timer = 0;
    public GameObject pipe;
    public float height;
    void Start()
    {
        GameObject newpipe =  Instantiate(pipe);
        newpipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height),0);
    }
    void Update()
    {
        if(timer > spawntime)
        {
            GameObject newpipe = Instantiate(pipe);
            newpipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(newpipe, 8);
            timer = 0;
        }
        timer += Time.deltaTime;
    }
}

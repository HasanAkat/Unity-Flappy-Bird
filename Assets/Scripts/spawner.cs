using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public bird bird;
    public GameObject pipes;

    void Start()
    {
        StartCoroutine(Spawn());
    }
    public IEnumerator Spawn()
    {
        while(!bird.isdead)
        {
            Instantiate(pipes, new Vector3(1, Random.Range(-0.25f,0.7f), 0) , Quaternion.identity);
            yield return new WaitForSeconds(2f);
        }
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CouritineScript : MonoBehaviour
{
    void Start()
    {
        StartCoroutine("Coroutine_");
    }  

    IEnumerator Coroutine_()
    {
        for (int i = 0; i < 10; i++)
        {
            Debug.Log("Ik start nu de coroutine");
            yield return new WaitForSeconds(0.5f);
            Debug.Log("Coroutine update");
            yield return new WaitForSeconds(0.5f);
            Debug.Log("Coroutine einde");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CouritineScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Coroutine_");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     IEnumerator Coroutine_()
    {
        Debug.Log("Ik start nu de coroutine");
        yield return new WaitForSeconds(0.5f);
        Debug.Log("Coroutine update");
        yield return new WaitForSeconds(0.5f);
        Debug.Log("Coroutine einde");
    }
}

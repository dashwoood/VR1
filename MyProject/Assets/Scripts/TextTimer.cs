using UnityEngine;
using System.Collections;

public class TextTimer : MonoBehaviour
{
    public float time = 3; 

    IEnumerator Start()
    {
        yield return new WaitForSeconds(time);
        Destroy(gameObject);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextTimerLong : MonoBehaviour
{
    public float time = 15;

    IEnumerator Start()
    {
        yield return new WaitForSeconds(time);
        Destroy(gameObject);
    }
}

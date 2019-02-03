using UnityEngine;
using System.Collections;

public class DestroyByTime : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        //if (other.tag == "boundary")
        //{
        //    return;
        //}

        Destroy(this.gameObject);
    }
}
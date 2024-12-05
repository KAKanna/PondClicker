using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 public class CoinManager : MonoBehaviour
{
    private float speed = 700f;
    //abstract public void Move();
    public virtual void OnClick()
    {
        
    }
    private void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);
    }
}

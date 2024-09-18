using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision
{
  void OnCollisionEnter2D(Collision2D collision)
  {
    Debug.Log("I hit the thing!");
  }
  void OnTriggerEnter2D(Collider2D other)
  {
    Debug.Log("I hit or passed something!");
  }
}
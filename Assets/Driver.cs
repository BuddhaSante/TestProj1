using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    // [SerializeField] float RoteVal = 0.2f;
    // [SerializeField] float TransVal = 0.01f;
    [SerializeField] float factor=0.5f;
    void Start()
    {
      Debug.Log("This is first script in my Unity project");
      // transform.Rotate(0,0,45);  
    }

    // Update is called once per frame
    void Update()
    {
      float RoteVal = Input.GetAxis("Horizontal")* factor;
      transform.Rotate(0,0,RoteVal);
      // I need to add translations to my object
      float TransVal = 0.01f;
      transform.Translate(0,TransVal,0);

    }
}

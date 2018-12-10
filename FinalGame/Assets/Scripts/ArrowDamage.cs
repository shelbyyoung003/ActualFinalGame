using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowDamage : MonoBehaviour
{
   private void OnTriggerEnter(Collider other)
   {
      if (other.gameObject.tag == "Collision")
      {
         Destroy(other.gameObject);
      }
   }
}

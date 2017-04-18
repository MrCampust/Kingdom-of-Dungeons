using UnityEngine;
using System.Collections;

public class MeleeSystem : MonoBehaviour
{
    public int TheDamage = 50;
    public float Distance;
    public float MaxDistance = 1.5f;
    public Transform Mace;

    void Update()
    {

        if (Input.GetButtonDown("Fire1"))
        {//default fire button
            Mace.gameObject.GetComponent<Animation>().Play("MaceAnimation");

            //animation.Play ("Mace1");
            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit))
            {
                Distance = hit.distance;
                if (Distance < MaxDistance)
                {
                    hit.transform.SendMessage("ApplyDamage", TheDamage, SendMessageOptions.DontRequireReceiver);
                }
            }
        }
    }
}
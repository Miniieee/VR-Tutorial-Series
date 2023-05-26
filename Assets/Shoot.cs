using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Shoot : MonoBehaviour
{
    [SerializeField] GameObject bullet;
    [SerializeField] Transform spawnPoint;
    [SerializeField] float bulletSpeed;

   /* private void Start() {
        
        XRGrabInteractable grabable = GetComponent<XRGrabInteractable>();
        grabable.activated.AddListener(Fire);
    }*/

    public void Fire(/*ActivateEventArgs args*/)
    {
        GameObject instantiatedBullet = Instantiate(bullet, spawnPoint.transform.position, spawnPoint.transform.rotation);
        instantiatedBullet.GetComponent<Rigidbody>().velocity = spawnPoint.forward * bulletSpeed;
        
    }
}

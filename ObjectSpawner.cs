using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject objectPrefab;
    public float bulletForce;
   
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown (0)) {
          
            GameObject Bulletclone= Instantiate(objectPrefab, transform.position, transform.rotation);
  Rigidbody bulletRigidBody = Bulletclone.GetComponent<Rigidbody>();
            bulletRigidBody.velocity = transform.forward *  bulletForce;
            Destroy(Bulletclone, 2f);
        }

}
}
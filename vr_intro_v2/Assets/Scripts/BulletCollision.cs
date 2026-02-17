using UnityEngine;

public class BulletCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        ContactPoint contactPoint = collision.contacts[0];
        Target target = collision.gameObject.GetComponent<Target>();
        if(target != null)
        {
            target.BulletHit(contactPoint.point, contactPoint.normal);
        }


    }
    //public CapsuleCollider capsuleCollider;
    //public GameObject targets;
    //public GameObject obstacles;
    //public int points = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    //void Start()
    //{
    //    capsuleCollider = GetComponent<CapsuleCollider>();
    //    BoxCollider targetCollider = targets.GetComponent<BoxCollider>();

    //}

    //public void OnCollisionEnter(Collision collision)
    //{
    //    BoxCollider targetCollider = targets.GetComponent<BoxCollider>();
    //    ContactPoint contactPoint = collision.GetContact(targetCollider);

    //    if (collision.contacts(targetCollider))
    //    {
    //        points++;


    //    }
    //    else if (points >= 0)
    //    {
    //        points--;
    //    }

    //}

    // Update is called once per frame
    //void Update()
    //{

    //}
}

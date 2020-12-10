using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowBehaviour : MonoBehaviour
{

    [Header("Arrow Data")]
    public int movementSpeed = 10;
    public int attackDamage = 100;

    [Header("Component References")]
    public Rigidbody arrowRigidbody;

    //Movement
    private bool nowMoving = false;

    [Header("Collision Settings")]
    public Transform collisionRayStartTransform;
    public float collisionDistanceRange;
    private Vector3 forwardDirection;

    public void BeginMoving()
    {
        nowMoving = true;
        forwardDirection = collisionRayStartTransform.TransformDirection(Vector3.forward);

    }

    void FixedUpdate()
    {
        if(nowMoving)
        {   
            MoveArrowEveryFrame();
            CastRayCollisionCheck();
        }
    }

    void MoveArrowEveryFrame()
    {
        arrowRigidbody.MovePosition(transform.position + transform.forward * (Time.deltaTime * movementSpeed));
    }

    void CastRayCollisionCheck()
    {

        RaycastHit collisionRayHit;

        if(Physics.Raycast(collisionRayStartTransform.position, forwardDirection, out collisionRayHit, 100))
        {
            float distanceToCollision = collisionRayHit.distance;

            Debug.DrawRay(collisionRayStartTransform.position, forwardDirection * distanceToCollision, Color.red);

            if(distanceToCollision <= collisionDistanceRange)
            {
                ArrowHitObject(collisionRayHit);
            }
        }
        

    }

    void ArrowHitObject(RaycastHit collisionData)
    {

        nowMoving = false;

        //ParticlesManager.Instance.SpawnParticlesArrowImpact(collisionData.point);



        //EnemyManager.Instance.EnemyHitByProjectile(collisionData.collider.gameObject, attackDamage);

        RemoveArrow();

    }

    void RemoveArrow()
    {
        gameObject.SetActive(false);
    }

}

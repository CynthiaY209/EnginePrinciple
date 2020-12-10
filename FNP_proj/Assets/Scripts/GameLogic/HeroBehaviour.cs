using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class HeroBehaviour : MonoBehaviour
{
    
    //States
    private bool isCurrentlyMoving;
    private bool isCurrentlyAttacking;

    [Header("Attacking")]
    public float pivotSpeed = 1f;
    private GameObject currentTargetEnemy;
    public Transform projectileSpawnTransform;
    private WaitForSeconds delayTimeBeforeSpawningProjectile = new WaitForSeconds(0.5f);

    [Header("Animation")]
    public Animator heroAnimator;
    private int isMovingHash;
    private int nowAttackHash;
    private bool attackAnimationActive;

    public float moveSpeed = 4.0f;//键盘速度
    private float horMovement;
    private float verMovement;
    //private float groundedRaycastDistance = 0.1f;

    [Header("Navigation")]
    public NavMeshAgent heroAgent;
    private Vector3 currentTarget;
    public float targetDestinationReachedThreshold = 1.5f;

    //Health
    private int currentHealth;

    //SETUP -----

    void Start()
    {
       SetupHero(); 
    }

    void SetupHero()
    {
        SetupAnimatorStringHashes();

        isCurrentlyMoving = false;
        heroAgent.isStopped = true;

        isCurrentlyAttacking = false;
        attackAnimationActive = false;
        
    }

    void SetupAnimatorStringHashes()
    {
        isMovingHash = Animator.StringToHash("isMoving");
        nowAttackHash = Animator.StringToHash("nowAttack");
    }

    void SetTotalHealth(int newTotalHealth)
    {
        currentHealth = newTotalHealth;
    }



    // UPDATE LOOP -----

    void Update()
    {
        
        if(isCurrentlyMoving)
        {
            float distanceToTarget = Vector3.Distance(transform.position, currentTarget);

            Debug.DrawLine(transform.position, currentTarget, Color.red);
        
            if(distanceToTarget < targetDestinationReachedThreshold)
            {
                StopMoving();
            }
        }

        if(isCurrentlyAttacking)
        {
            RotateToFaceTarget();
        }
    }



    // MOVEMENT -----

    public void MoveToTargetPosition(Vector3 targetPosition)
    {
        isCurrentlyAttacking = false;
        attackAnimationActive = false;

        currentTarget = SampleAgainstNavMesh(targetPosition);
        heroAgent.destination = currentTarget;
        heroAgent.isStopped = false;

        isCurrentlyMoving = true;

        UpdateMovingAnimationState();
    }


    void StopMoving()
    {
        isCurrentlyMoving = false;
        heroAgent.isStopped = true;
        UpdateMovingAnimationState();
    }
    

    void UpdateMovingAnimationState()
    {
        heroAnimator.SetBool(isMovingHash, isCurrentlyMoving);
    }


    Vector3 SampleAgainstNavMesh(Vector3 targetDestination)
    {
        NavMeshHit hit;
        if(NavMesh.SamplePosition(targetDestination, out hit, 30.0f, NavMesh.AllAreas))
        {
            return hit.position;
        } else {
            return targetDestination;
        }
    }



    // ATTACK -----

    public void StartAttackingTargetEnemy(GameObject targetEnemy)
    {
        StopMoving();
        currentTargetEnemy = targetEnemy;
        attackAnimationActive = false;
        isCurrentlyAttacking = true;
        
    }


    void RotateToFaceTarget()
    {
        Vector3 lookPos = currentTargetEnemy.transform.position - transform.position;
        lookPos.y = 0;
        Quaternion rotation = Quaternion.LookRotation(lookPos);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * pivotSpeed);

        if (Vector3.Angle(lookPos, transform.forward) < 0.1f)
        {
            AttackEnemyWithProjectile();
        }
    }


    void AttackEnemyWithProjectile(){
        if(attackAnimationActive == false)
        {
            attackAnimationActive = true;
            StartCoroutine(DelayBeforeFiringProjectile());
            StartAttackAnimation();
        }
    }

    IEnumerator DelayBeforeFiringProjectile()
    {
        yield return delayTimeBeforeSpawningProjectile;
        FireProjectile();
    }

    void FireProjectile()
    {
        ArrowManager.Instance.SpawnArrow();
    }

    void StartAttackAnimation()
    {
        heroAnimator.SetTrigger(nowAttackHash);
    }



    // HEALTH -----

    public void SetNewTotalHealth(int newTotalHealth)
    {
        currentHealth = newTotalHealth;
    }

}

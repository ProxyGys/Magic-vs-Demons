using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour
{
    [Range(0f, 5f)]
    float currentSpeed = 1f;
    GameObject curretTarget;
    //[SerializeField] float walkSpeed = 1f; one speed fo all


    private void Awake()
    {
        FindObjectOfType<LevelController>().AttackerSpawned();
    }

    private void OnDestroy()
    {
        LevelController levelController = FindObjectOfType<LevelController>();
        if (levelController != null)
        {
            levelController.AttackerKilled();
        }
    }

    void Update()
    {
        transform.Translate(Vector2.left *currentSpeed* Time.deltaTime);
        UpdateAnimationState();
    }

    private void UpdateAnimationState()
    {
        if (!curretTarget)
        {
            GetComponent<Animator>().SetBool("isAttacking", false);
        }
    }

    public void SetMovementSpeed (float speed)
    {
        currentSpeed = speed;
    }


    public void Attack(GameObject target)
    {
        GetComponent<Animator>().SetBool("isAttacking", true);
        curretTarget = target;
    }

    public void StrikeCurrentTarget(float damage) 
    { 
        if(!curretTarget) { return;  }
        Health health = curretTarget.GetComponent<Health>();
        if (health)
        {
            health.DealDamage(damage);
        }
    }

}


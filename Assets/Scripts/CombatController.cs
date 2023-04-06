using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatController : MonoBehaviour
{
    public int playerNumber = 0;

    public float moveSpeed = 10;
    public float rotationSpeed = 90;
    public Vector3 moveDirection = Vector3.zero;

    public Vector2 input = Vector2.zero;

    public bool fire1IsEnabled = true;
    public bool fire2IsEnabled = true;
    public float rayMaxDistance = 50f;
    public int scorePoint = 1;

    public GameObject barrelEnd;
    public GameObject projectilePrefab;

    public AudioClip bap;
    public AudioClip pow;
    public AudioSource audioSource;

    public Vector3 startingLocation;
    public Quaternion startingRotation;
    InputData inputData;

    Rigidbody rb;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        startingLocation = gameObject.transform.position;
        startingRotation = gameObject.transform.rotation;
    }

    private void Update()
    {
        DrawDebugRay();

        inputData = InputPoller.reference.GetInput(playerNumber);
        RotatePlayer(inputData.rightStick.x);
        MovePlayer(inputData.leftStick.y);
        if (inputData.buttonNorth && fire1IsEnabled)
        {
            Fire1();
        }
        if (inputData.buttonSouth && fire2IsEnabled)
        {
            Fire2();
        }
    }

    void Fire1()
    {
        Debug.Log("fire1");
        audioSource.PlayOneShot(pow);
        ProjectileFire();
    }

    void Fire2()
    {
        Debug.Log("fire2");
        audioSource.PlayOneShot(bap);
        RaycastFire();
    }

    public void ProjectileFire()
    {
        Debug.Log("projectile fire");
        GameObject go = Instantiate(projectilePrefab, barrelEnd.transform.position, barrelEnd.transform.rotation);
        SimpleProjectile bp = go.GetComponent<SimpleProjectile>();
        bp.owner = this;
    }

    void RaycastFire()
    {
        RaycastHit hit;
        bool hasHit = Physics.Raycast(barrelEnd.transform.position, barrelEnd.transform.forward, out hit, rayMaxDistance);
        if(hasHit)
        {
            Debug.Log("Raycast hit: " + hit.collider.gameObject.name);
            CombatController cc = hit.collider.GetComponentInParent<CombatController>();
            if(cc)
            {
                //idk y but sometimes the score goes up but 2-3 pts instead of 1. the other time i referenced CombatManager.cs is in SimpleProjectile.cs.
                CombatManager.instance.AddDeath(scorePoint);
                cc.Reset();
                Reset();
            }
        }
    }

    public void DrawDebugRay()
    {
        float drawLength = 25.0f;
        Vector3 origin = gameObject.transform.position;
        Vector3 direction = origin + (gameObject.transform.forward * drawLength); ;
        Color drawColor = Color.magenta;

        Debug.DrawRay(origin, direction, drawColor);
    }

    public void Reset()
    {
        rb.velocity = Vector3.zero;
        gameObject.transform.position = startingLocation;
        gameObject.transform.rotation = startingRotation;
    }

    //to move forwards and backwards
    void MovePlayer(float value)
    {
        rb.velocity = gameObject.transform.forward * moveSpeed * value;
    }

    void RotatePlayer(float value)
    {
        gameObject.transform.Rotate(value * rotationSpeed * Time.fixedDeltaTime * Vector3.up);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arm : MonoBehaviour
{
    public GameObject[] Pots; // Array to hold different types of projectiles
    public float launchForce;
    public Transform shotPoint;
    private int currentPotIndex = 0; // Index to track the current projectile type
    
    void Update()
    {
        Vector2 armPosition = transform.position;
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 direction = mousePosition - armPosition;
        transform.right = direction;

        if (Input.GetMouseButtonDown(0))
        {
            CycleProjectile(); // Change the projectile type on left-click
        }
        
        if (Input.GetMouseButtonDown(1))
        {
            Shoot(); // Shoot the current projectile on right-click
        }
    }

    void CycleProjectile()
    {
        currentPotIndex = (currentPotIndex + 1) % Pots.Length; // Cycle through the projectile array
    }

    void Shoot() 
    {
        GameObject newPot = Instantiate(Pots[currentPotIndex], shotPoint.position, shotPoint.rotation);
        newPot.GetComponent<Rigidbody2D>().velocity = transform.right * launchForce;
    }
}
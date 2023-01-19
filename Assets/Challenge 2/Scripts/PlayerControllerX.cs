using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    [SerializeField]
    private float coolDown = 1;

    private float dogTimer = 0;

    // Update is called once per frame
    void Update()
    {
        if (dogTimer > 0)
        {
            dogTimer -= Time.deltaTime;
        }

        if (dogTimer <= 0)
        {
            dogTimer = 0;
        }

        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && dogTimer == 0)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            dogTimer = coolDown;
        }
    }
}

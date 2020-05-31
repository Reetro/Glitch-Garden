using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] GameObject projectile, gunPostion = null;
    public void Fire()
    {
        Instantiate(projectile, gunPostion.transform.position, gunPostion.transform.rotation);
    }
}

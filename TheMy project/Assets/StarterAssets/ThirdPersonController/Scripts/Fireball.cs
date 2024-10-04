using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    public GameObject fireballPrefab;  // Prefab del sistema de part�culas de la bola de fuego
    public float lifeTime = 5f;  // Tiempo antes de que la bola de fuego desaparezca
    public Vector3 fireballSize = new Vector3(1f, 1f, 1f);  // Tama�o de la bola de fuego en 3D

    private GameObject fireballInstance;

    void Start()
    {
        CreateFireball();  // Crear la bola de fuego
        Destroy(gameObject, lifeTime);  // Destruir la bola de fuego despu�s de un tiempo
    }

    void CreateFireball()
    {
        // Instancia la bola de fuego en su posici�n actual sin movimiento
        fireballInstance = Instantiate(fireballPrefab, transform.position, Quaternion.identity);

        // Escala la bola de fuego al tama�o deseado en 3D
        SetFireballSize(fireballSize);

        fireballInstance.transform.SetParent(transform);  // Mant�n el sistema de part�culas como hijo para que se mueva con este objeto (si es necesario)
    }

    void SetFireballSize(Vector3 size)
    {
        // Cambia la escala del objeto que contiene el sistema de part�culas en 3D
        fireballInstance.transform.localScale = size;
    }

    void OnDestroy()
    {
        // Opcional: Aqu� puedes a�adir alg�n efecto de explosi�n o sonido cuando la bola de fuego desaparece
    }
}

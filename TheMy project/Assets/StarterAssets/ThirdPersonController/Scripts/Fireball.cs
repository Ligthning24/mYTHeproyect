using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    public GameObject fireballPrefab;  // Prefab del sistema de partículas de la bola de fuego
    public float lifeTime = 5f;  // Tiempo antes de que la bola de fuego desaparezca
    public Vector3 fireballSize = new Vector3(1f, 1f, 1f);  // Tamaño de la bola de fuego en 3D

    private GameObject fireballInstance;

    void Start()
    {
        CreateFireball();  // Crear la bola de fuego
        Destroy(gameObject, lifeTime);  // Destruir la bola de fuego después de un tiempo
    }

    void CreateFireball()
    {
        // Instancia la bola de fuego en su posición actual sin movimiento
        fireballInstance = Instantiate(fireballPrefab, transform.position, Quaternion.identity);

        // Escala la bola de fuego al tamaño deseado en 3D
        SetFireballSize(fireballSize);

        fireballInstance.transform.SetParent(transform);  // Mantén el sistema de partículas como hijo para que se mueva con este objeto (si es necesario)
    }

    void SetFireballSize(Vector3 size)
    {
        // Cambia la escala del objeto que contiene el sistema de partículas en 3D
        fireballInstance.transform.localScale = size;
    }

    void OnDestroy()
    {
        // Opcional: Aquí puedes añadir algún efecto de explosión o sonido cuando la bola de fuego desaparece
    }
}

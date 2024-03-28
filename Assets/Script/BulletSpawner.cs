using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public GameObject[] prefabsToSpawn; // Prefabs das balas para cada n�vel

    public Transform spawnTransform; // O transform onde os objetos ser�o instanciados
    public float spawnDistance = 0f; // Dist�ncia na frente do transform para spawnar os objetos
    public float spawnInterval = 1f; // Intervalo de tempo entre cada spawn
    public float tempoDeVida;
    public static int level; // N�vel atual

    private IEnumerator StartSpawnRoutine()
    {
        while (true)
        {
            // Calcula a posi��o de spawn na frente do transform
            Vector3 spawnPosition = spawnTransform.position + spawnTransform.forward * spawnDistance;

            // Seleciona o prefab com base no n�vel
            int index = Mathf.Clamp(level, 0, prefabsToSpawn.Length - 1);
            GameObject prefabToSpawn = prefabsToSpawn[index];

            // Instancia o objeto na posi��o calculada
            GameObject newObject = Instantiate(prefabToSpawn, spawnPosition, Quaternion.identity);

            // Destruir o objeto ap�s um pequeno atraso
            Destroy(newObject, tempoDeVida);

            // Aguarda o intervalo de spawn
            yield return new WaitForSeconds(spawnInterval);
        }
    }

    void Start()
    {
        // Verifica se o spawnTransform est� atribu�do
        if (spawnTransform == null)
        {
            Debug.LogError("Transform n�o atribu�do ao Prefab Spawner.");
            return;
        }

        // Inicia a rotina de spawn
        StartCoroutine(StartSpawnRoutine());
    }
}

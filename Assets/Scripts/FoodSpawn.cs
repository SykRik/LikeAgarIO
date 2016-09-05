using UnityEngine;
using System.Collections;

public class FoodSpawn : MonoBehaviour
{
	public GameObject _foodPrefab;

	private void Start()
	{
		InvokeRepeating("MyFoodSpawn", 5f, 0.5f);
	}

	private void MyFoodSpawn()
	{
		GameObject FoodClone = Instantiate(_foodPrefab, transform.position, transform.rotation) as GameObject;
	}
}

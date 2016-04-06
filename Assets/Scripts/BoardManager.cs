using UnityEngine;
using System;
using System.Collections.Generic;
using Random = UnityEngine.Random;

public class BoardManager : MonoBehaviour {

	[Serializable]
	public class Count {
		public int maximum;
		public int minimum;

		public Count(int minimum, int maximum){
			this.minimum = minimum;
			this.maximum = maximum;
		}
	}

	public int columns = 8;
	public int rows = 8;
	public Count maxWallCount = new Count(5, 9);
	public Count maxFoodCount = new Count(1, 5);
	public GameObject exit;
	public GameObject[] floorTiles;
	public GameObject[] foodTiles;
	public GameObject[] wallTiles;
	public GameObject[] enemyTiles;
	public GameObject[] outerWallTiles;

	private Transform boardHolder;
	private List<Vector3> gridPositions = new List<Vector3>();

	void InitializeList() {
		gridPositions.Clear();

		for (int x = 1; x < columns - 1; x++) {
			for (int y = 1; y < rows - 1; y++
		}

	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridBehaviour : MonoBehaviour
{ 
	public int Rows;
	public int Columns;
	public int Scale;
	public GameObject GridPrefab;
	public Vector3 LeftBottomLocation = new Vector3(0, 0, 0);

	private void Awake()
	{
		if (GridPrefab)
			GenerateGrid();
		else
			print("Missing GridPrefab, please assign.");
	}
	// Update is called once per frame
	void Update()
	{
		
	}
	void GenerateGrid()
	{
		for (int i = 0; i < Columns; i++)
		{
			for (int j = 0; j < Rows; j++)
			{
				GameObject obj = Instantiate(GridPrefab, new Vector3(LeftBottomLocation.x + Scale * i, LeftBottomLocation.y + Scale * j, LeftBottomLocation.z), Quaternion.identity);
				obj.transform.SetParent(gameObject.transform);
				obj.GetComponent<GridStat>().x = i;
				obj.GetComponent<GridStat>().y = j;
			}
		}
	}
}

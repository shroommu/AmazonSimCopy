﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class DroneManager : MonoBehaviour {

	public static DroneManager instance;

	public GameObject currentDrone;
	public Transform currentDestination;
	public SO_Package currentPackage;
	public SO_Destination currentsO_Destination;
	public float currentDistance;

	public List<Transform> destinations;
	public List<GameObject> drones;
	public List<Transform> warehousePads;
	public List<Transform> droneDummiesAir;
	public List<Transform> droneDummiesGround;

	public int droneCounter = 1;
	
	void Awake()
	{
		if(instance == null)
		{
			instance = this;
		}
		else if(instance != this)
		{
			Destroy(this);
		}
	}


	public void Dispatch()
	{
		currentDrone.GetComponent<DroneHorizMovement>().MoveNavMesh(currentDestination);
	}

}

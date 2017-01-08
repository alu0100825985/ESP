﻿using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	NavMeshAgent agent;

	GameObject target;

	void Awake(){

		agent = GetComponent<NavMeshAgent>();

		target = GameObject.FindGameObjectWithTag("Player");

		agent.SetDestination(target.transform.position);

	}

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
}
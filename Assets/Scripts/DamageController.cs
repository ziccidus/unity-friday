﻿using UnityEngine;
using System.Collections;

public class DamageController : MonoBehaviour {

	public float MaxHitPoints = 100;
	private float _hitpoints;

	void Start () {
		_hitpoints = MaxHitPoints;
	}

	public void takeDamage(float damagePoints) {
		_hitpoints -= damagePoints;
		
		Debug.Log ("Ouch! Luckily, I have " + _hitpoints + " left!");

	}
}

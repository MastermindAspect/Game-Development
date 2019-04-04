﻿
using UnityEngine;

public class UnitStats : MonoBehaviour
{
	public int currentHeath { get; private set; }

	public float attackDelay = .6f;

	public ParticleSystem animation;

	public float attackspeed;
	public Stat heath;
	public Stat damage;
	public Stat energy;
	public Stat armor;

	private void Awake()
	{
		currentHeath = heath.getValue();
	}

	public void takeDamage(int damage)
	{
		damage -= armor.getValue();
		damage = Mathf.Clamp(damage, 0, int.MaxValue);

		currentHeath -= damage;
		Debug.Log(transform.name + " Takes: "+ damage +"damage");

		if (currentHeath <= 0)
		{
			Die();
		}
	}

	public virtual void Die()
	{
		//Animation
		//animation.transform.TransformPoint(gameObject.transform.position);
		//animation.Play(true);
		Destroy(gameObject);
	}
}




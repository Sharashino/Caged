using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CastSpell : MonoBehaviour
{
    public Transform magicSpawn;
    Spell spell;
    public List<Spell> spellList = new List<Spell>();
    public float attackSpeed = 0.25f;
    public float nextAttack;
    public int mana = 10;

    private void Start()
    {
        spell = (Spell)Resources.Load("Spells/" + gameObject.name, typeof(Spell));
        List<Spell> spellDatabase = GameObject.Find("SpellManager").GetComponent<SpellManager>().spellList;

        for(int i=0; i < spellDatabase.Count; i++)
        {
            spellList.Add(spellDatabase[i]);
        }
    }
    private void FixedUpdate()
    {
        if (Input.GetMouseButtonDown(0) && Time.time > nextAttack)
        {
            nextAttack = Time.time + attackSpeed;
            CastMagic(spellList[0]);
            if (spell != null)
                CastMagic(spell);   
        }
    }
    void CastMagic(Spell spell)
    {
        if(spell.spellPrefab == null)
        {
            Debug.LogWarning("No spell prefab!");
            return;
        }
        else
        {
            GameObject spellObject = Instantiate(spell.spellPrefab, magicSpawn.position, Camera.main.GetComponent<Transform>().rotation);
            spellObject.AddComponent<Rigidbody>();
            spellObject.GetComponent<Rigidbody>().useGravity = false;
            spellObject.GetComponent<Rigidbody>().velocity = spellObject.transform.forward * spell.projectileSpeed;
            spellObject.name = spell.spellName;
            spellObject.transform.parent = GameObject.Find("SpellManager").transform;

            Destroy(spellObject, 2);

            //Destroy(spell.spellPrefab, 1);
        }
    }
}

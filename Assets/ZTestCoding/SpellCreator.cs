using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class SpellCreator : EditorWindow
{
    [MenuItem("Spell Maker/Spell Wizard")]
    public static void Inint()
    {
        SpellCreator spellWindow = (SpellCreator)CreateInstance(typeof(SpellCreator));
        spellWindow.Show();
    }
    Spell tempSpell = null;
    SpellManager spellManager = null;

    private void OnGUI()
    {
        if (spellManager = null)
        {
            spellManager = GameObject.Find("SpellManager").GetComponent<SpellManager>();
        }
        if (tempSpell)
        {
            tempSpell.spellName = EditorGUILayout.TextField("Spell Name", tempSpell.spellName);
            tempSpell.spellPrefab = (GameObject)EditorGUILayout.ObjectField("Spell Prefab", tempSpell.spellPrefab, typeof(GameObject), false);
            tempSpell.spellIcon = (Sprite)EditorGUILayout.ObjectField("Spell Icon", tempSpell.spellIcon, typeof(Sprite), false);
            tempSpell.spellManaCost = EditorGUILayout.IntField("Mana Cost", tempSpell.spellManaCost);
            tempSpell.spellMaxDamage = EditorGUILayout.IntField("Maximum Damage", tempSpell.spellMaxDamage);
            tempSpell.spellMinDamage = EditorGUILayout.IntField("Minimum Damage", tempSpell.spellMinDamage);
            tempSpell.projectileSpeed = EditorGUILayout.FloatField("Projectile Speed", tempSpell.projectileSpeed);
        }

        EditorGUILayout.Space();

        if(tempSpell == null )
        {
            if(GUILayout.Button("Create Spell"))
            {
                tempSpell = CreateInstance<Spell>();
            }
        }
        else
        {
            if(GUILayout.Button("Create Scriptable Object"))
            {
                AssetDatabase.CreateAsset(tempSpell, "Assets/GameObjects/Spells/" + tempSpell.spellName + ".asset");
                AssetDatabase.SaveAssets();
                spellManager.spellList.Add(tempSpell);
                Selection.activeObject = tempSpell;

                tempSpell = null;
            }
            if(GUILayout.Button("Reset"))
            {
                Reset();
            }
        }
    }
    void Reset()
    {
        if (tempSpell)
        {
            tempSpell.spellName = "";
            tempSpell.spellIcon = null;
            tempSpell.spellPrefab = null;
            tempSpell.spellManaCost = 0;
            tempSpell.spellMaxDamage = 0;
            tempSpell.spellMinDamage = 0;
            
        }
    }
}

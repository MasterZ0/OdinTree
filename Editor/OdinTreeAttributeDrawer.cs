using ParadoxNotion.Design;
using Sirenix.OdinInspector.Editor;
using System;
using UnityEngine;

/// <summary>
/// Draw an object using the Property Tree of Odin
/// </summary>
public class OdinTreeAttributeDrawer : AttributeDrawer<OdinTreeAttribute> {
        
    private PropertyTree propertyTree;
    private object obj;
            
    public override object OnGUI(GUIContent content, object instance) {

        // Create a instance if is null
        if (instance == null) {
            instance = Activator.CreateInstance(info.field.FieldType);
        }

        // Update the object
        if (propertyTree == null || obj != instance) {
            obj = instance;
            propertyTree = PropertyTree.Create(instance);
        }

        propertyTree.Draw(false);
        return instance;
    }
}
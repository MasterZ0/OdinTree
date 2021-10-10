# OdinTree

This attribute will make it easier when you need to create custom fields and windows within the NodeCanvas, as this attribute will draws objects using the [Property Tree](https://odininspector.com/tutorials/how-to-create-custom-drawers-using-odin/how-to-use-the-propertytree) in conjunction with the [Custom Object Drawer](https://nodecanvas.paradoxnotion.com/documentation/?section=creating-custom-object-drawers).

Requires [Odin Inspector](https://odininspector.com/) and [NodeCanvas](https://nodecanvas.paradoxnotion.com/).

# Installation
Simply put the OdinTreeAttributeDrawer.cs file inside an Editor folder and the OdinTreeAttribute.cs in a shared folder, and start using the attribute as shown in the example.

# Example
 
First you create a serialized class using the attribute [System.Serializeble]. Within this class you can use any attribute, including other assets such as [FMODUnity.EventRef].

```
[System.Serializable]
public class DialogueConfig {

    [TextArea]
    public string text = "This is a dialogue text";

    [ColorPalette("ActirsColors")]
    public Color color;

    public PlayableAsset playable;
    
    [FMODUnity.EventRef]
    public string sound;
}
```
And then just declare your class using the [OdinTree] attribute inside a NodeCanvas class, for example using the ActionTask.

```
public class Speak : ActionTask {
    [OdinTree] public DialogueConfig dialogueConfig;
}
```

Preview:
![image](https://user-images.githubusercontent.com/64444068/136711700-e0d11d84-f9fb-45ff-99a2-4b8106eda5f9.png)

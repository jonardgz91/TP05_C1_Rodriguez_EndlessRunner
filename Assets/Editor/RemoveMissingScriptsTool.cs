using UnityEditor;
using UnityEngine;

public class RemoveMissingScriptsTool
{
    [MenuItem("Tools/Eliminar scripts rotos en selección")]
    static void RemoveMissingScripts()
    {
        if (Selection.gameObjects.Length == 0)
        {
            Debug.LogWarning("No seleccionaste ningún objeto. Seleccioná el prefab o el GameObject en la escena e intentá de nuevo.");
            return;
        }

        foreach (GameObject go in Selection.gameObjects)
        {
            int count = GameObjectUtility.RemoveMonoBehavioursWithMissingScript(go);
            Debug.Log($"'{go.name}': se eliminaron {count} script(s) roto(s).");
            EditorUtility.SetDirty(go);
        }

        AssetDatabase.SaveAssets();
    }
}

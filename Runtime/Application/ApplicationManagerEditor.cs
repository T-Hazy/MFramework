using System;
using UnityEditor;
using UnityEngine;
using Object = UnityEngine.Object;
using MFramework.UnityApplication;

public static class ApplicationManagerEditor
{
    [MenuItem("GameObject/Application/ApplicationManager", false, 0)]
    public static void CreateApplicationManager()
    {
        var manager = Object.FindObjectOfType<ApplicationManager>();
        if (manager)
        {
            Debug.Log($"【{DateTime.Now}】 【ApplicationManager】已存在!");
            Selection.activeObject = manager;
            return;
        }

        var obj = new GameObject
        {
            name = "ApplicationManager"
        };
        obj.transform.SetParent(Selection.activeTransform);
        obj.transform.localPosition = Vector3.zero;
        obj.AddComponent<ApplicationManager>();
        Selection.SetActiveObjectWithContext(obj, obj);
    }
}
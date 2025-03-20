/*using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(MonoBehaviour), true)] // Replace MonoBehaviour with your specific class if needed
public class HighlightEmptyFieldsEditor : Editor
{
    public override void OnInspectorGUI()
    {
        serializedObject.Update();

        // Iterate through each property in the inspector
        SerializedProperty property = serializedObject.GetIterator();
        bool enterChildren = true;

        while (property.NextVisible(enterChildren))
        {
            enterChildren = false;

            // Check if the property is null or empty
            if (property.propertyType == SerializedPropertyType.ObjectReference && property.objectReferenceValue == null)
            {
                // Change the background color for empty properties
                GUI.backgroundColor = Color.red;
            }
            else
            {
                // Reset the background color to default
                GUI.backgroundColor = Color.white;
            }

            // Draw the property
            EditorGUILayout.PropertyField(property);

            // Reset background color after drawing the property
            GUI.backgroundColor = Color.white;
        }

        serializedObject.ApplyModifiedProperties();
    }
}
*/
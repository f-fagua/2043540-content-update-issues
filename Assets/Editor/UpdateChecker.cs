using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.AddressableAssets;
using UnityEditor.AddressableAssets.Build;
using UnityEngine;

public class UpdateChecker : MonoBehaviour
{
    private const string k_CachePath = "Assets/AddressableAssetsData/OSX/addressables_content_state.bin";
        
    [MenuItem("Unity Support/Check Entries")]
    public static void CheckForUpdates()
    {
        var entries = ContentUpdateScript.GatherModifiedEntries(AddressableAssetSettingsDefaultObject.Settings, k_CachePath);
        if (entries.Count > 0)
        {
            foreach (var entry in entries)
            {
                Debug.Log($"Entry {entry.address} at {entry.AssetPath}");
            }
        }
        else
        {
            Debug.LogWarning("No updates found");
        }
    }
}

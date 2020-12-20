using System.Runtime.InteropServices;
using UnityEngine;

public class Test : MonoBehaviour
{
    [DllImport("bsdiff.dll")]
    private static extern int Diff(string oldFile, string newFile, string patchFile);

    [DllImport("bsdiff.dll")]
    private static extern int Patch(string oldFile, string newFile, string patchFile);

    void Start()
    {
        var basePath = Application.dataPath + "/Res/";

        var ret = Diff(basePath + "old.ab", basePath + "new.ab", basePath + "patch");
        Debug.LogWarning($"bsdiff return value: {ret}");
        ret = Patch(basePath + "old.ab", basePath + "new_patched.ab", basePath + "patch");
        Debug.LogWarning($"bspatch return value: {ret}");

        var ab = AssetBundle.LoadFromFile(basePath + "new_patched.ab");
        var t2ds = ab.LoadAllAssets<Texture2D>();

        Debug.Log($"Load {t2ds.Length} Texture");

        GetComponent<Renderer>().material.mainTexture = t2ds[0];
    }
}
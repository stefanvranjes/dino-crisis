using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public static class LevelEditor
{
    private static string previousPath = "";

    [MenuItem("CONTEXT/GameManager/Import Level Data")]
    public static void ImportLevelContainer(MenuCommand menuCommand)
    {
        GameManager gameManager = menuCommand.context as GameManager;
        string path = EditorUtility.OpenFilePanel("Open file to import level data", previousPath, "");
        previousPath = Path.GetDirectoryName(path);

        using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
        {
            const uint DIFF = 0x80017800;
            long scriptPosition = 0x8009e0a0 - DIFF;

            for (int i = 0; i < 10; i++)
            {
                reader.BaseStream.Seek(scriptPosition + i * 0x18, SeekOrigin.Begin);
                reader.ReadInt16();
                LoadScriptContainer scriptContainer = new LoadScriptContainer();
                scriptContainer.DAT_02 = reader.ReadUInt16();
                reader.ReadInt32();
                uint address1 = reader.ReadUInt32() - DIFF;
                uint address2 = reader.ReadUInt32() - DIFF;
                reader.BaseStream.Seek(0x14, SeekOrigin.Current);
                uint address3 = reader.ReadUInt32() - DIFF;
                reader.BaseStream.Seek(address1, SeekOrigin.Begin);
                scriptContainer.scriptName = new string(reader.ReadChars(3));
                reader.BaseStream.Seek(address2, SeekOrigin.Begin);
                scriptContainer.scenes = new List<LoadSceneContainer>();
                int length = (int)(address3 - address2) / 0x18;
                
                if (i == 9)
                    length = (int)(scriptPosition - address2) / 0x18;

                for (int j = 0; j < length; j++)
                {
                    LoadSceneContainer container = new LoadSceneContainer();
                    container.nameIndex = reader.ReadUInt16();
                    container.DAT_02 = reader.ReadUInt16();
                    reader.ReadInt32();
                    container.DAT_08 = reader.ReadByte();
                    reader.BaseStream.Seek(0xb, SeekOrigin.Current);
                    uint address5 = reader.ReadUInt32() - DIFF;
                    long previousPosition = reader.BaseStream.Position;
                    reader.BaseStream.Seek(address5, SeekOrigin.Begin);
                    container.sceneName = new string(reader.ReadChars(5));
                    reader.BaseStream.Seek(previousPosition, SeekOrigin.Begin);
                    scriptContainer.scenes.Add(container);
                }

                gameManager.DAT_9E0A0.Add(scriptContainer);
            }

            EditorUtility.SetDirty(gameManager);
        }
    }

    [MenuItem("CONTEXT/SceneManager/Create Objects")]
    public static void CreateSceneObjects(MenuCommand menuCommand)
    {
        SceneManager sceneManager = menuCommand.context as SceneManager;
        sceneManager.skinnedObjects = new CriSkinned[11];
        sceneManager.boneObjects = new CriBone[100];
        sceneManager.particleObjects = new CriParticle[60];
        sceneManager.staticObjects = new CriStatic[40];

        for (int i = 0; i < 100; i++)
        {
            GameObject obj = new GameObject();
            obj.name = "CriBone (Instance)";
            sceneManager.boneObjects[i] = obj.AddComponent<CriBone>();
        }

        for (int i = 0; i < 60; i++)
        {
            GameObject obj = new GameObject();
            obj.name = "CriParticle (Instance)";
            sceneManager.particleObjects[i] = obj.AddComponent<CriParticle>();
        }

        for (int i = 0; i < 40; i++)
        {
            GameObject obj = new GameObject();
            obj.name = "CriStatic (Instance)";
            sceneManager.staticObjects[i] = obj.AddComponent<CriStatic>();
        }

        for (int i = 0; i < 10; i++)
        {
            GameObject obj = new GameObject();
            obj.name = "CriSkinned (Instance)";
            sceneManager.skinnedObjects[i] = obj.AddComponent<CriPlayer>();
        }

        GameObject obj2 = new GameObject();
        obj2.name = "CriPlayer (Instance)";
        sceneManager.skinnedObjects[10] = obj2.AddComponent<CriPlayer>();
        EditorUtility.SetDirty(sceneManager);
    }
}

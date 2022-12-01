using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEditor;
using UnityEditor.Events;

public static class CoroutineEditor
{
    private static string previousPath = "";

    [MenuItem("CONTEXT/GameManager/Import Coroutines")]
    public static void ImportCoroutines(MenuCommand menuCommand)
    {
        GameManager gameManager = menuCommand.context as GameManager;
        string path = EditorUtility.OpenFilePanel("Open file to import courutine data", previousPath, "");
        previousPath = Path.GetDirectoryName(path);

        using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
        {
            int length = (int)(reader.BaseStream.Length / 0x28);
            
            for (int i = 0; i < length; i++) 
            {
                LoadDoorContainer cont;

                if (gameManager.DAT_A89A0.Count > i)
                    cont = gameManager.DAT_A89A0[i];
                else
                {
                    cont = new LoadDoorContainer();
                    gameManager.DAT_A89A0.Add(cont);
                }

                reader.BaseStream.Seek(8, SeekOrigin.Current);
                cont.DAT_08 = new UnityEvent();

                switch (reader.ReadUInt32())
                {
                    case 0x8007ab80:
                        UnityEventTools.AddPersistentListener(cont.DAT_08, gameManager.FUN_7AB80);
                        break;
                    case 0x8007ad80:
                        UnityEventTools.AddPersistentListener(cont.DAT_08, gameManager.FUN_7AD80);
                        break;
                    case 0x8007b1d4:
                        UnityEventTools.AddPersistentListener(cont.DAT_08, gameManager.FUN_7B1D4);
                        break;
                    case 0x8007b1fc:
                        UnityEventTools.AddPersistentListener(cont.DAT_08, gameManager.FUN_7B1FC);
                        break;
                    case 0x8007b224:
                        UnityEventTools.AddPersistentListener(cont.DAT_08, gameManager.FUN_7B224);
                        break;
                    case 0x8007b634:
                        UnityEventTools.AddPersistentListener(cont.DAT_08, gameManager.FUN_7B634);
                        break;
                    case 0x8007bab0:
                        UnityEventTools.AddPersistentListener(cont.DAT_08, gameManager.FUN_7BAB0);
                        break;
                    case 0x8007bf78:
                        UnityEventTools.AddPersistentListener(cont.DAT_08, gameManager.FUN_7BF78);
                        break;
                    case 0x8007c4a4:
                        UnityEventTools.AddPersistentListener(cont.DAT_08, gameManager.FUN_7C4A4);
                        break;
                    case 0x8007c4c8:
                        UnityEventTools.AddPersistentListener(cont.DAT_08, gameManager.FUN_7C4C8);
                        break;
                    case 0x8007c4ec:
                        UnityEventTools.AddPersistentListener(cont.DAT_08, gameManager.FUN_7C4EC);
                        break;
                    case 0x8007c510:
                        UnityEventTools.AddPersistentListener(cont.DAT_08, gameManager.FUN_7C510);
                        break;
                    case 0x8007c940:
                        UnityEventTools.AddPersistentListener(cont.DAT_08, gameManager.FUN_7C940);
                        break;
                    case 0x8007cb50:
                        UnityEventTools.AddPersistentListener(cont.DAT_08, gameManager.FUN_7CB50);
                        break;
                    case 0x8007d008:
                        UnityEventTools.AddPersistentListener(cont.DAT_08, gameManager.FUN_7D008);
                        break;
                    case 0x8007d030:
                        UnityEventTools.AddPersistentListener(cont.DAT_08, gameManager.FUN_7D030);
                        break;
                    case 0x8007d058:
                        UnityEventTools.AddPersistentListener(cont.DAT_08, gameManager.FUN_7D058);
                        break;
                    case 0x8007d080:
                        UnityEventTools.AddPersistentListener(cont.DAT_08, gameManager.FUN_7D080);
                        break;
                    case 0x8007d894:
                        UnityEventTools.AddPersistentListener(cont.DAT_08, gameManager.FUN_7D894);
                        break;
                    case 0x8007d8bc:
                        UnityEventTools.AddPersistentListener(cont.DAT_08, gameManager.FUN_7D8BC);
                        break;
                    case 0x8007d8e4:
                        UnityEventTools.AddPersistentListener(cont.DAT_08, gameManager.FUN_7D8E4);
                        break;
                    case 0x8007d90c:
                        UnityEventTools.AddPersistentListener(cont.DAT_08, gameManager.FUN_7D90C);
                        break;
                    case 0x8007dd0c:
                        UnityEventTools.AddPersistentListener(cont.DAT_08, gameManager.FUN_7DD0C);
                        break;
                    case 0x8007df78:
                        UnityEventTools.AddPersistentListener(cont.DAT_08, gameManager.FUN_7DF78);
                        break;
                    case 0x8007e380:
                        UnityEventTools.AddPersistentListener(cont.DAT_08, gameManager.FUN_7E380);
                        break;
                    case 0x8007e3a4:
                        UnityEventTools.AddPersistentListener(cont.DAT_08, gameManager.FUN_7E3A4);
                        break;
                    case 0x8007e674:
                        UnityEventTools.AddPersistentListener(cont.DAT_08, gameManager.FUN_7E674);
                        break;
                    case 0x8007e69c:
                        UnityEventTools.AddPersistentListener(cont.DAT_08, gameManager.FUN_7E69C);
                        break;
                    case 0x8007e6c4:
                        UnityEventTools.AddPersistentListener(cont.DAT_08, gameManager.FUN_7E6C4);
                        break;
                    case 0x8007e8d4:
                        UnityEventTools.AddPersistentListener(cont.DAT_08, gameManager.FUN_7E8D4);
                        break;
                    case 0x8007eb44:
                        UnityEventTools.AddPersistentListener(cont.DAT_08, gameManager.FUN_7EB44);
                        break;
                    case 0x8007eeb0:
                        UnityEventTools.AddPersistentListener(cont.DAT_08, gameManager.FUN_7EEB0);
                        break;
                }

                cont.DAT_0C = reader.ReadInt16();
                cont.DAT_0E = new Vector3Int(reader.ReadInt16(), reader.ReadInt16(), reader.ReadInt16());
                cont.DAT_14 = new Vector3Int(reader.ReadInt16(), reader.ReadInt16(), reader.ReadInt16());
                cont.DAT_1A = new Vector3Int(reader.ReadInt16(), reader.ReadInt16(), reader.ReadInt16());
                cont.DAT_20 = new string(reader.ReadChars(8));
            }

            EditorUtility.SetDirty(gameManager);
        }
    }
}

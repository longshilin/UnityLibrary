using Longshilin.Common;
using UnityEngine;

public class DirectoryOperatorTest
{
    private string dataPath = Application.dataPath;

    public void CreateDirTest()
    {
        DirectoryOperator.CreateDir(dataPath + "/Temp");
        Debug.Log("create dir!");
    }
    
    public void DeleteDirTest()
    {
        DirectoryOperator.DeleteDir(dataPath + "/Temp");
        Debug.Log("delete dir!");
    }
}
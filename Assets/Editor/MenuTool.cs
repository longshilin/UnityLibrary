using UnityEditor;

public class MenuTool
{
    [MenuItem("Test Tool/DirectoryOperator Tool")]
    public static void DirectoryOperatorTool()
    {
        var directoryOperatorTest = new DirectoryOperatorTest();
        directoryOperatorTest.CreateDirTest();
        directoryOperatorTest.DeleteDirTest();
    }
}

using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class GetSizeTests
{
    [TestMethod]
    public void GetSize_MultipleFoldersWithFiles()
    {
        var foldersInCurrentDir = Directory.GetParent(@"..\..\..\03.FileAndFolderClasses");

        Folder rootDirectory = new Folder(foldersInCurrentDir.ToString());

        Folder copiedFolder = FolderUtils.CopyFileSystem(ref rootDirectory);

        decimal actualSize = copiedFolder.GetSize().ToMegabytes();

        //You can check the size of the folder 03.FileAndFolderClasses to assert its really between these two values
        Assert.IsTrue(actualSize > 0.46M && actualSize < 0.47M);
    }

    [TestMethod]
    public void GetSize_OneFolderWithFiles()
    {
        var foldersInCurrentDir = Directory.GetParent(@".\");

        Folder rootDirectory = new Folder(foldersInCurrentDir.ToString());

        Folder copiedFolder = FolderUtils.CopyFileSystem(ref rootDirectory);

        decimal actualSize = copiedFolder.GetSize().ToMegabytes();

        //You can check the size of the folder 03.FileAndFolderClassesTraversalTests\bin\debug to assert its really between these two values
        Assert.IsTrue(0.053M < actualSize && actualSize < 0.054M);
    }

}

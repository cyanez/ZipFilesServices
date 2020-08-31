/* Empiria Extensions ****************************************************************************************
*                                                                                                            *
*  Module   : File Integration services                  Component : Service provider                        *
*  Assembly : Empiria.Cognition.dll                      Pattern   : Provider                                *
*  Type     : Files Zip Compresor                        License   : Please read LICENSE.txt file            *
*                                                                                                            *
*  Summary  : Zip Files Compresor.                                                                           *
*                                                                                                            *
************************* Copyright(c) La Vía Óntica SC, Ontica LLC and contributors. All rights reserved. **/
using System;
using System.IO;
using System.IO.Compression;


namespace ZipServices {

  /// <summary>Zip files Compresor services.</summary>

  public class Zip {

    #region Public Methods

    static public void FromDirectory(string path, string zipPath) {
      if (!Directory.Exists(path)) {
        throw new Exception("Directory not exist: " + path);
      }
      if (File.Exists(zipPath)) {
        File.Delete(zipPath);
      }

      ZipFile.CreateFromDirectory(path, zipPath);
    }

    static public void ExtractToDirectory(string zipPath, string extractPath) {
      if (!File.Exists(zipPath)) {
        throw new Exception("Zip file not exist: " + zipPath);
      }
      if (!Directory.Exists(extractPath)) {
        throw new Exception("Directory not exist: " + extractPath);
      }

      ZipFile.ExtractToDirectory(zipPath, extractPath);
    }


    #endregion

  }
}


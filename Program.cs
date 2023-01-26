using System;
using System.IO;
using System.Collections;

namespace DuplicateFiles{

    class File {
        private string file;
        public File(string _file){
            file = _file;
        }

        public int GetFileID(){
            string fileID = file.Trim().Split(" ")[1];
            return Convert.ToInt32(fileID);
        }

        public String GetFileName(){
            return file.Trim().Split(" ")[0];
        }


    }
    class Program{

        static int getOldestID(string fileName, int fileId, string[] fileNames, int[] fileIDs, int noOfFiles){
            int oldestID = fileId;
            for (int index = 0 ; index < noOfFiles ; index++){
                int currentID = fileIDs[index];
                string currentFileName = fileNames[index];

                if (fileName == currentFileName && currentID <= oldestID){
                    oldestID = currentID;
                }
            }

            return oldestID;
        }

        static void Main(string[] args){
            string fileName = "files.in";
            StreamReader file = new StreamReader(fileName);

            int noOfFolders = Convert.ToInt32(file.ReadLine());

            for (int folderIndex = 0; folderIndex < noOfFolders; folderIndex++){
                int noOfFiles = Convert.ToInt32(file.ReadLine());

                string[] fileNames =  new string[noOfFiles];
                int[] fileIDs = new int[noOfFiles]; 
                ArrayList uniqueNames = new ArrayList();
                ArrayList uniqueIDS = new ArrayList();
                int uniqueIndex = 0;

                for (int i = 0; i < noOfFiles; i++){
                    // string[] nameId = file.ReadLine().Trim().Split(" ");
                    File currentFile = new File(file.ReadLine());
                    fileNames[i] = currentFile.GetFileName();
                    fileIDs[i] = currentFile.GetFileID();
                }

                for (int fileIndex = noOfFiles - 1; fileIndex >= 0; fileIndex--){
                    string currentFileName = fileNames[fileIndex];
                    int currentFileId = fileIDs[fileIndex];

                    int oldestId = getOldestID(currentFileName, currentFileId, fileNames, fileIDs, noOfFiles);

                    if(!uniqueNames.Contains(currentFileName)){
                        uniqueNames.Add(currentFileName);
                        uniqueIDS.Add(currentFileId);
                        uniqueIndex++;
                    }
                }

                foreach(int id in uniqueIDS){
                    Console.Write("{0} ", id);
                }
                
                Console.WriteLine();
            }

        }
    }
}
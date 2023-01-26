// using System;
// using System.IO;
// using System.Collections;

// namespace DuplicateFiles2{

//     class FileGroup{
//         ArrayList fileNames = new ArrayList();
//         ArrayList fileIDs = new ArrayList();

//         public FileGroup(ArrayList _fileNames, ArrayList _fileIDs){
//             fileNames = (ArrayList)_fileNames.Clone();
//             fileNames = (ArrayList)_fileIDs.Clone();
//             // fileIDs.AddRange(_fileIDS);
//         }

//         public ArrayList getFileNames(){
//             return fileNames;
//         }

//         public ArrayList getFileIDS(){
//             return fileIDs;
//         }

//         //  public int getOldestID(string fileName, int fileId){
//         //  int noOfFiles = fileNames.Count;
//         //  Console.WriteLine("WE are hrer");
//         //     int oldestID = fileId;
//         //     for (int index = 0 ; index < noOfFiles ; index++){
//         //         int currentID = Convert.ToInt32(fileIDs[index].ToString());
//         //         string currentFileName = fileNames[index].ToString();

//         //         if (fileName == currentFileName && currentID <= oldestID){
//         //             oldestID = currentID;
//         //         }
//         //     }

//         //     return oldestID;
//         // }




    
//     }


//     class Program2{

//         // static int getOldestID(string fileName, int fileId, string[] fileNames, int[] fileIDs, int noOfFiles){
//         //     int oldestID = fileId;
//         //     for (int index = 0 ; index < noOfFiles ; index++){
//         //         int currentID = fileIDs[index];
//         //         string currentFileName = fileNames[index];

//         //         if (fileName == currentFileName && currentID <= oldestID){
//         //             oldestID = currentID;
//         //         }
//         //     }

//         //     return oldestID;
//         // }

//         static void Main(string[] args){
//             string fileName = "files.in";
//             StreamReader file = new StreamReader(fileName);

//             int noOfFolders = Convert.ToInt32(file.ReadLine());
//             FileGroup[] fileGroups = new FileGroup[noOfFolders]; 

//             ArrayList uniqueNames = new ArrayList();
//                 ArrayList uniqueIDS = new ArrayList();
//                 int uniqueIndex = 0;


//             for (int folderIndex = 0; folderIndex < noOfFolders; folderIndex++){
//                 int noOfFiles = Convert.ToInt32(file.ReadLine());

//                 // string[] fileNames =  new string[noOfFiles];
//                 // int[] fileIDs = new int[noOfFiles]; 

//                 ArrayList fileNames = new ArrayList();
//                 ArrayList fileIDs = new ArrayList();

//                 for (int i = 0; i < noOfFiles; i++){
//                     string[] nameId = file.ReadLine().Trim().Split(" ");
//                     fileNames.Add(nameId[0]);
//                     fileIDs.Add(Convert.ToInt32(nameId[1]));
//                 }

//                 fileGroups[folderIndex] = new FileGroup(fileNames, fileIDs);

//          Console.WriteLine("WE are hrer {0}", fileGroups[folderIndex]);

//             }
            
//             foreach(FileGroup fileGroup in fileGroups){
//                 ArrayList fileNames = fileGroup.getFileNames();
//                 ArrayList fileIDs = fileGroup.getFileIDS();

//                 for (int fileIndex = fileNames.Count - 1; fileIndex >= 0; fileIndex--){
//                     string currentFileName = fileNames[fileIndex].ToString();
//                     int currentFileId = Convert.ToInt32(fileIDs[fileIndex].ToString());

//                     // int oldestId = fileGroup.getOldestID(currentFileName, currentFileId);

//                     // if(!uniqueNames.Contains(currentFileName)){
//                     //     uniqueNames.Add(currentFileName);
//                     //     uniqueIDS.Add(currentFileId);
//                     //     uniqueIndex++;
//                     // }
//                 }

//                 foreach(int id in uniqueIDS){
//                     Console.Write("{0} ", id);
//                 }
                
//                 Console.WriteLine();
//             }
             

//         }
//     }
// }
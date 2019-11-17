## chapter 8

* try catch finally 說明。
  * 說明可以多個 catch
  * Exception 是最上層
  * 說明 finally 一定要執行

教怎麼看 Exception 訊息

* 題目:
  * 新增資料的 Exception
    * 請輸入 信箱 abc@abc.com
    * 命名 Ken
    * 主修選擇 資訊工程
    * 按
    * 嘗試修好 Exception

* 使用 [NLog](https://nlog-project.org/) 紀錄 Exception 訊息
  * 安裝 [NLog.Config](https://www.nuget.org/packages/NLog.Config/)
  * 使用說明 API 文件 https://github.com/nlog/nlog/wiki/Tutorial
  * 安裝說明 Info 跟 Debug 的階層用法，調整
  * 使用

* 使用 [System.IO.File](https://docs.microsoft.com/zh-tw/dotnet/csharp/programming-guide/file-system/how-to-write-to-a-text-file) 取代 [System.IO.FileInfo](https://docs.microsoft.com/en-us/dotnet/api/system.io.fileinfo?redirectedfrom=MSDN&view=netframework-4.8)  
  * 使用 File 讀取檔案
  * 讀取 csv 檔案，將 csv 的資料存到物件
  * 用 windows form 選擇檔案

參考
[System.IO.File 與 System.IO.FileInfo 比較說明](https://stackoverflow.com/questions/4003233/what-is-the-difference-between-system-io-file-and-system-io-fileinfo)
[Directory vs DirectoryInfo](https://stackoverflow.com/questions/3146586/directory-vs-directoryinfo)

* NPOI 建立 Excel [Getting Started with NPOI](https://github.com/tonyqus/npoi/wiki/Getting-Started-with-NPOI)
  * 

sample code
``` C#
/*----------Result----------
    ---------------------
    |ID	|Name	|Course |
    |1	|Miles1	|Math1  |
    |2	|Miles2	|Math2  |
    ---------------------
---------------------------*/

// Create Workbook and Specify Excel Version
// [.xlsx => Excel 2007+ (new XSSFWorkbook)], [.xls => Excel 97-2003 (new HSSFWorkbook)]
IWorkbook workbook = new XSSFWorkbook();

// Use workbook to Create Sheet
ISheet sheet = workbook.CreateSheet("sheetname");

// Use sheet to Create Row
sheet.CreateRow(0);

// Use sheet to Create Cell and Set Cell Value at top row of created
sheet.GetRow(0).CreateCell(0).SetCellValue("ID");
sheet.GetRow(0).CreateCell(1).SetCellValue("Name");
sheet.GetRow(0).CreateCell(2).SetCellValue("Course");

// Use sheet to Create New Row and Set Cell Value at each row of created
for (int i = 1; i < 3; i++)
{
    sheet.CreateRow(i);
    sheet.GetRow(i).CreateCell(0).SetCellValue(i);
    sheet.GetRow(i).CreateCell(1).SetCellValue("Miles" + i);
    sheet.GetRow(i).CreateCell(2).SetCellValue("Math" + i);
}

// Call MemoryStream to Write it
MemoryStream ms = new MemoryStream();

// note : Inside workbook.Write() had called ms.close(), so you can't read it from MemoryStream
//        if you want to output file, you should make MemoryStream's content Convert to Array
workbook.Write(ms);

//You have to rewind the MemoryStream before copying
//ms.Seek(0, SeekOrigin.Begin);

using (FileStream fs = new FileStream("test.xlsx", FileMode.OpenOrCreate))
{
    fs.Write(ms.ToArray(), 0, ms.ToArray().Length);
    fs.Flush();
}

```

* 如果要組合路徑強烈建議用 path.combine (考慮可以說)。
  * 因為跨平台
  * 會檢查非法字元  

[Path](https://docs.microsoft.com/zh-tw/dotnet/api/system.io.path.combine?view=netframework-4.8)

* File vs Directory vs Path
  * File 負責處理檔案
  * Directory 負責處理資料夾
  * Path 提供補助方法，處理路徑與檔案名稱取得的 API


製作 Excel


讀寫 Excel
CSV 

課表有講 
DirectoryInfo
FileInfo
Path 類別

檔案寫入
FileInfo f - new FileInfo("D:myDir\\test.txt")
StreamWrite sw = f.CreateText();
sw.Write("abc"); // 寫入緩衝
sw.Flush(); // 將存在 Buffer 緩衝區內的資料寫入指定的檔案內
sw.Close(); // 關閉目前的資料流

讀出檔案
FileInfo f - new FileInfo("D:myDir\\test.txt")
StreamWrite sw = f.OpenText();
Console.ReadLine(sr,ReadToEnd());
sw.Close();

// 一次讀一行
while(sr.Peek() >= 0){
    Console.WriteLine(sr.ReadLine());
}

// 刪除檔案
FileInfo f - new FileInfo("D:myDir\\test.txt")
if(f.Exists){f.Delete();}

將資料加入在檔案後面
FileInfo f - new FileInfo("D:myDir\\test.txt")
StreamWrite sw = f.AppendText();
sw.Write("abc");
sw.Flush();
sw.Close();


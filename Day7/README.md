## chapter 8

## try catch 用法
* 多個 catch
* 使用 [when](https://docs.microsoft.com/zh-tw/dotnet/csharp/language-reference/keywords/try-catch) 設定條件
* finally 用法

### 參考
* [例外狀況和例外處理 (C# 程式設計手冊)](https://docs.microsoft.com/zh-tw/dotnet/csharp/programming-guide/exceptions/)

## 練習如何看 Exception 訊息
``` LOG
Unhandled Exception: System.FormatException: Input string was not in a correct format.
   at System.Number.ParseSingle(String value, NumberStyles options, NumberFormatInfo numfmt)
   at System.Single.Parse(String s)
   at int_try.Program.Main(String[] args) in D:\Course_Labs\DORTS\Day7\int_try\int_try\Program.cs:line 13
```
### 練習如何修復 Exception
* 可以使用 `MessageBox.Show("提示訊息");` 顯示提示訊息

## 使用 [NLog](https://nlog-project.org/) 套件，紀錄 LOG 訊息
  * 安裝 [NLog.Config](https://www.nuget.org/packages/NLog.Config/)
  * 使用 [NLog API](https://github.com/nlog/nlog/wiki/Tutorial#writing-log-messages) 寫 LOG
  * 說明 [Log Level](https://github.com/nlog/nlog/wiki/Configuration-file#log-levels)

### NLog 參考文件
* [NLog Tutorial](https://github.com/nlog/nlog/wiki/Tutorial)
* [如何使用 NLog 設定 EMAIL 發送](https://github.com/NLog/NLog/wiki/Mail-target)


## 使用 [System.IO.File](https://docs.microsoft.com/zh-tw/dotnet/api/system.io.file?view=netframework-4.8) 取代 [System.IO.FileInfo](https://docs.microsoft.com/en-us/dotnet/api/system.io.fileinfo?redirectedfrom=MSDN&view=netframework-4.8)  
  * 使用 File API 讀取檔案  

### 參考
* [System.IO.File 與 System.IO.FileInfo 比較說明](https://stackoverflow.com/questions/4003233/what-is-the-difference-between-system-io-file-and-system-io-fileinfo)
* [Directory vs DirectoryInfo](https://stackoverflow.com/questions/3146586/directory-vs-directoryinfo)

## 建立 Excel
* 使用 NPOI 建立 Excel

### NPOI 範例程式碼
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

using (FileStream fs = new FileStream("test.xlsx", FileMode.OpenOrCreate))
{
    // Save file
    fs.Write(ms.ToArray(), 0, ms.ToArray().Length);
    fs.Flush();
}

```
### NPOI 讀取現有 Excel 範例程式碼
``` C#
FileStream fileStream = new FileStream("sample.xlsx", FileMode.Open, FileAccess.Read);

IWorkbook workbook = new XSSFWorkbook(fileStream);

ISheet sheet = workbook.GetSheetAt(0);

.
.
.

```


### 參考
[Getting Started with NPOI](https://github.com/tonyqus/npoi/wiki/Getting-Started-with-NPOI)


## 使用 [Path](https://docs.microsoft.com/zh-tw/dotnet/api/system.io.path.combine?view=netframework-4.8) API 組合路徑
如果有組合路徑需求，一定要用 Path.Combine()。
* 因為 Path.Combine() 會根據不同的系統，產生相對應的路徑
* Path.Combine() 會檢查路徑是否包含非法字元
* 勿使用字串相加組合路徑 ~~string path = @"d:\archives" + "2001" + "media"~~;


``` C#
/* 使用 Path.Combine 組合路徑 */
string[] paths = {@"d:\archives", "2001", "media", "images"};
string fullPath = Path.Combine(paths);
Console.WriteLine(fullPath);            
// The example displays the following output if run on a Windows system:
//    d:\archives\2001\media\images
// The example displays the following output if run on a Unix-based system:
//    d:\archives/2001/media/images   
```

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
  * 安裝
  * 使用

* 讀取 csv 檔案，將 csv 的資料存到物件
  * 用 windows form 選擇檔案


* NPOI 建立 Excel 
  * 

製作 Excel


教怎麼看程式碼可能會發生的 Exception


程式設計的 UI 介面本來就該避免 Exception 的發生



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


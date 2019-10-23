## chapter 2 複習
* do while, while do 差別

## chapter 3
* 3-8. for vs foreach
  * https://docs.microsoft.com/zh-tw/dotnet/csharp/language-reference/keywords/foreach-in

* 3-10. Array.Foreach 用法

* 3-33 方法的傳值 (`ref, out`)
  * Call by value
  * Call by reference

* 擴充方法 (Extension method)
  * https://docs.microsoft.com/zh-tw/dotnet/csharp/programming-guide/classes-and-structs/extension-methods

* 方法傳入 `params object[] arg` 的用法
* 介紹 `tuple` 與 `C# 7.0 value tuple`
  * 需從 NuGet 安裝 `System.ValueTuple`
  * https://docs.microsoft.com/zh-tw/dotnet/csharp/tuples  

## 練習題目
#### 1. 寫出 2 個字串轉的擴充方法
* a. 將字串轉成數字的擴充方法
``` C#
string a = "123";
int b = a.ToInt();
```
* b. 判斷是字串是否回空白或是空字串
``` C#
string a = "";
bool isAEmptyString = a.IsEmpty();
```

#### 2. 建立一個 Add 方法，傳入 params int[]，並把傳入的數字做相加
``` C#
int sum = Add(1,2,3,4);
// sum = 10
```
#### 3. 練習 Array.Foreach(ary, action) 用法

## 進階練習題

#### 1. 請實作一個方法來判斷字串的傳入的字元是否獨特
  * 假設字串最多是 128 字元
  * Ex: 
    * 輸入 "abcdefg" 回傳 true
    * 輸入 "abdeaa" 回傳 false 因為 a 重複了

**提示:** 字串(string)本身是一個 char 陣列


#### 2. 假設使用者只能輸入字串 [a-z]， 請實作字串壓縮的方法，該方法會回傳原本的字串與壓縮後的字串。
  * 輸入 "aaabbccddddef" 會壓縮成 "a3b2c2d4e1f1"
  * 輸入 "a3b2c2d4e1f1" 會解壓縮成 "aaabbccddddef"
  
#### 3. 請製作一個方法，印出輸入的數字 n 包含哪些值數
  * 輸入 10 印出 2、3、5、7
  * 輸入 100 印出 2、3、5、7、11、13、17、19、23、29、31、37、41、43、47、53、59、61、67、71、73、79、83、89、97

**提示**
  * 只要找該 n 是否能被 n 的平方跟以下的數字整除，若都沒有，表示該 n 為質數
    * 用程式碼求餘數的方法，5 % 2 = 1; 
  * 取得平方跟得 API `Math.Sqrt(1000)`

#### 4. 現在有 10 階的樓梯，而你能夠一次爬 1 階 或 2 階 或 3 階，請問你有多少種爬上去的方式?
 * EX: 假設階梯有 5 階，可爬上去的組合有 13 種，組合如下
   1. 3,2
   2. 3,1,1
   3. 2,3
   4. 2,2,1
   5. 2,1,2
   6. 2,1,1,1
   7. 1,3,1
   8. 1,2,2
   9. 1,2,1,1
   10. 1,1,3
   11. 1,1,2,1
   12. 1,1,1,2
   13. 1,1,1,1,1

**提示:** 使用遞迴
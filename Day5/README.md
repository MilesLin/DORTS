chapter 6:
## 繼承
https://dotblogs.com.tw/mileslin/2015/12/22/010452
https://docs.microsoft.com/zh-tw/dotnet/csharp/tutorials/inheritance
https://docs.microsoft.com/zh-tw/dotnet/csharp/programming-guide/classes-and-structs/knowing-when-to-use-override-and-new-keywords

* static - 無法被實例化，應用程式Run起來，就會存在
  * static class MyClass { }
* abstract - 無法被實例化，是一個未完成的class
  * abstract class MyClass { }
* sealed - 無法被繼承的類別
  * sealed class MyClass { }
* 物件實體化
  * 當一個類別被new起來的時候，建構式會被執行，而父類別建構式，會先執行，以下範例
* 介面(interface)
  * 介面裡面會有定義的方法，類別需要實作介面定義的方法，而一個類別可實作多個介面。

* 製作繼承的題目
* protected
* public
* 說明 api 專案常會用
* virtual 

## 抽象類別
* 使用讀取資料來源(txt vs csv)
* SendGrid
  * dortstest
  * azure_8258621a24d8d371e620e65abd0cd103@azure.com
  * I9IRxMbDEP

## sealed 修飾詞
https://docs.microsoft.com/zh-tw/dotnet/csharp/language-reference/keywords/sealed

## 介面
* 如何定義介面
* 食物外送的運費計算器
 * 物品名稱、單價、送貨距離
   * uber eat
   * food panda
   * honestbee
* fixture 自定義介面擴充的方法
  * 先請大家練習 fixture 怎麼使用

* 回家功課
  * 請思考一下，如果在 mail sender 裡面傳入資料，並產生內容。
chapter 6:

## 繼承
* virtual
* override
* new

### 練習 Web API 的繼承使用情境
* api 網址: http://localhost:15606/api/employee
* api 網址: http://localhost:15606/api/account

#### 參考
* [C# 和 .NET 中的繼承](https://docs.microsoft.com/zh-tw/dotnet/csharp/tutorials/inheritance)
* [了解使用 Override 和 New 關鍵字的時機](https://docs.microsoft.com/zh-tw/dotnet/csharp/programming-guide/classes-and-structs/knowing-when-to-use-override-and-new-keywords)

## 抽象類別
* abstract class
* abstract method
* 如何使用抽象類別設計 Email 的發送程式
  * SendGrid
    * SmtpAccount: `azure_8258621a24d8d371e620e65abd0cd103@azure.com`
    * SmtpPassword: `I9IRxMbDEP`

#### 參考
* [抽象和密封類別以及類別成員](https://docs.microsoft.com/zh-tw/dotnet/csharp/programming-guide/classes-and-structs/abstract-and-sealed-classes-and-class-members)

## sealed 修飾詞
* 建立一個無法被繼承的類別

#### 參考
* [sealed ](https://docs.microsoft.com/zh-tw/dotnet/csharp/language-reference/keywords/sealed)
* [When and why would you seal a class?](https://stackoverflow.com/questions/7777611/when-and-why-would-you-seal-a-class)


## 介面(Interface)
* 定義介面
* 製作食物外送的運費計算器，根據 **單價**、**送貨距離** 計算費用